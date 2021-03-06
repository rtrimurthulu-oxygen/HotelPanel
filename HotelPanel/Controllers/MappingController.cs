﻿using Logic.BusinessObjects;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HotelPanel.Controllers
{
    [SessionState(System.Web.SessionState.SessionStateBehavior.ReadOnly)]
    public class MappingController : Controller
    {
        private readonly GeocodingBusiness geocodingBusiness;
        private readonly IATACodeBusiness iATACodeBusiness;
        private readonly BookingBusiness bookingBusiness;
        private readonly DOTWBusiness dotwBusiness;
        public MappingController()
        {
            geocodingBusiness = new GeocodingBusiness();
            iATACodeBusiness = new IATACodeBusiness();
            bookingBusiness = new BookingBusiness();
            dotwBusiness = new DOTWBusiness();
        }

        // GET: Geocode
        public ActionResult Geocode() => View();

        // GET: Get Geocodes All
        public JsonResult GetAllGeocodes()
        {
            try
            {
                return Json(new { success = false, data = geocodingBusiness.MapGeocodeAll() }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        // GET: Get Geocodes Range
        public JsonResult GetGeocodes(long from, long to)
        {
            try
            {
                return Json(new { success = false, data = geocodingBusiness.MapGeocodeRange(from, to) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        // GET: Iata Code
        public ActionResult Iata() => View();

        // GET: Map Iata Codes
        public JsonResult MapIataCode(string code, byte searchBy = (byte)Common.IATASearchBy.ByLocationCode)
        {
            try
            {
                var result = iATACodeBusiness.MapIata(code, (Common.IATASearchBy)searchBy);
                return Json(new { success = result.success, message = result.message, data = result.data }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult MapAllIataCodes()
        {
            try
            {
                var result = iATACodeBusiness.GetAndMapIATAData();
                return Json(new { success = result.success, message = result.message, data = result.data }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        // GET: Hotel Info
        public ActionResult HotelInfo() => View();

        public async Task<JsonResult> MapBookingDataAsync(long from, long to)
        {
            try
            {
                return Json(new { success = true, data = (await bookingBusiness.MapBookingInfoAsync(from, to)).OrderBy(x => x.HotelID) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }


    }
}