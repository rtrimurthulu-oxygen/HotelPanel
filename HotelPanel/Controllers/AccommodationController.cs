﻿using Common;
using Constants;
using Data.ViewModel;
using Logic.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Data.ViewModel.AccommodationModels;

namespace HotelPanel.Controllers
{
    public class AccommodationController : BaseController
    {

        AccommodationBusiness _AccommodationBusiness = new AccommodationBusiness();

        [HttpGet]
        public JsonResult GetCountries(string query)
        {
            try
            {
                return Json(new { success = true, data = _AccommodationBusiness.GetCountries(query) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpGet]
        public JsonResult GetCities(string query)
        {
            try
            {
                return Json(new { success = true, data = _AccommodationBusiness.GetCities(query) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                return Json(new { success = false, message = ex.Message });
            }
        }

        // GET: Accommodation
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            IEnumerable<AccommodationModels.ListNameAccommodation> Result = null;
            return View(Result);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult List(AccommodationModels.SearchAccommodation Model)
        {
            if (ModelState.IsValid)
            {
                IEnumerable<AccommodationModels.ListNameAccommodation> Result = _AccommodationBusiness.GetNames(Model);
                return View(Result);
            }
            return View(new List<Data.ViewModel.AccommodationModels.ListNameAccommodation>());
        }
        public ActionResult Images(long AccommodationID)
        {
            var Images = _AccommodationBusiness.GetImages(AccommodationID);
            AccommodationModels.FilterImagesView Model = new AccommodationModels.FilterImagesView
            {
                AccommodationID = AccommodationID,
                AccomodationImages = Images
            };
            return View(Model);
        }
        public ActionResult RoomImages(long id)
        {
            try
            {
                return View(_AccommodationBusiness.GetRoomImageByAccId(id));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ActionResult Weather(string AccommodationID)
        {
            long Entry = AccommodationID.IsNormalized() ? long.Parse(AccommodationID) : 0;
            var Model = _AccommodationBusiness.GetWeather(Entry);
            return View(Model);
        }
        [HttpPost]
        public JsonResult Filter(FilterImagesView model)
        {
            try
            {
                if (model != null)
                {
                    var result = _AccommodationBusiness.VerifyAccommodationImages(model);
                    if (result)
                    {
                        return Json(new { success = true }, JsonRequestBehavior.AllowGet);
                    }
                    return Json(new { success = false, message = "Verify Accommodation Images failed." }, JsonRequestBehavior.AllowGet);
                }
                return Json(new { success = false, message = "Model is invalid." }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public ActionResult Facility(long AccommodationID)
        {
            AccommodationModels.AccommodationFacility Model = new AccommodationModels.AccommodationFacility();
            var Facility = _AccommodationBusiness.GetFacilities(AccommodationID);
            var Description = _AccommodationBusiness.GetDescription(AccommodationID);
            string Name = _AccommodationBusiness.GetAccommodation(AccommodationID).Name;
            Model.Facilities = new List<Data.DataModel.Facility>(Facility);
            Model.Description = Description;
            Model.AccommodationID = AccommodationID;
            Model.Name = Name;
            return View(Model);
        }
        public ActionResult EditName(long id)
        {
            var accommodation = _AccommodationBusiness.GetAccommodation(id);
            AccommodationModels.EditName Model = new AccommodationModels.EditName
            {
                AccommodationID = accommodation.AccommodationlID,
                Name = accommodation.Name
            };
            return View(Model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditName(AccommodationModels.EditName Model)
        {
            if (ModelState.IsValid)
            {
                var Result = _AccommodationBusiness.EditName(Model);
                iUserStorage.Store(PublicConstants.Session.Message_Success, PublicConstants.Message.Success);
                return View(Model);
            }
            iUserStorage.Store(PublicConstants.Session.Message_Error, PublicConstants.Message.Faild);
            return View(Model);
        }
        public ActionResult EditDescription(long id)
        {
            var accommodation = _AccommodationBusiness.GetAccommodation(id);
            AccommodationModels.EditDescription Model = new AccommodationModels.EditDescription
            {
                AccommodationID = accommodation.AccommodationlID,
                Description = accommodation.Description
            };
            return View(Model);
        }
        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult EditDescription(AccommodationModels.EditDescription Model)
        {
            if (ModelState.IsValid)
            {
                var Result = _AccommodationBusiness.EditDescription(Model);
                iUserStorage.Store(PublicConstants.Session.Message_Success, PublicConstants.Message.Success);
                return View(Model);
            }
            iUserStorage.Store(PublicConstants.Session.Message_Error, PublicConstants.Message.Faild);
            return View(Model);
        }
        public ActionResult ListFacility(long id)
        {
            var Facilities = _AccommodationBusiness.GetFacilities();
            var accommodation = _AccommodationBusiness.GetAccommodation(id);
            AccommodationModels.ListFacilities Model = new AccommodationModels.ListFacilities
            {
                AccommodationID = accommodation.AccommodationlID,
                AccommodationName = accommodation.Name,
                Facilities = Facilities
            };
            return View(Model);
        }
        public ActionResult AddFacility()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddFacility(AccommodationModels.AddFacilities Model)
        {
            if (ModelState.IsValid)
            {
                var Result = _AccommodationBusiness.AddFacilities(Model);
                iUserStorage.Store(PublicConstants.Session.Message_Success, PublicConstants.Message.Success);
                return View();
            }
            iUserStorage.Store(PublicConstants.Session.Message_Error, PublicConstants.Message.Faild);
            return View();
        }
        public ActionResult EditFacility(long id)
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditFacility(AccommodationModels.EditFacilities Model)
        {
            if (ModelState.IsValid)
            {
                var Result = _AccommodationBusiness.EditFacilities(Model);
                iUserStorage.Store(PublicConstants.Session.Message_Success, PublicConstants.Message.Success);
                return View(Result);
            }
            iUserStorage.Store(PublicConstants.Session.Message_Error, PublicConstants.Message.Faild);
            return View();
        }
        public ActionResult ListLanguageDescription(long AccommodationID)
        {
            Data.ViewModel.AccommodationModels.ListLanguageDescription Model = new Data.ViewModel.AccommodationModels.ListLanguageDescription()
            {
                AccommodationID = AccommodationID,
                AccommodationDescriptions = _AccommodationBusiness.ListOtherLanguageDescription(AccommodationID)
            };
            return View(Model);
        }
        public ActionResult AddDescription(long AccommodationID)
        {
            var enumDataType = from Common.Language e in Language.GetValues(typeof(Language)) select new { ID = (int)e, Name = e.ToString() };
            ViewBag.LanguageID = new SelectList(enumDataType, "ID", "Name");
            return View(new Data.ViewModel.AccommodationModels.AddDescriptionViewModel() { AccommodationID = AccommodationID });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult AddDescription(AccommodationModels.AddDescription Model)
        {
            if (ModelState.IsValid)
            {
                var Result = _AccommodationBusiness.AddDescription(Model);
                if (Result)
                {
                    iUserStorage.Store(PublicConstants.Session.Message_Success, PublicConstants.Message.Success);
                    return RedirectToAction("ListLanguageDescription", new { AccommodationID = Model.AccommodationID });
                }
                else
                {
                    iUserStorage.Store(PublicConstants.Session.Message_Error, PublicConstants.Message.Faild);
                    return RedirectToAction("ListLanguageDescription", new { AccommodationID = Model.AccommodationID });
                }
            }
            iUserStorage.Store(PublicConstants.Session.Message_Warning, PublicConstants.Message.ModelState);
            return RedirectToAction("ListLanguageDescription", new { AccommodationID = Model.AccommodationID });
        }
        public ActionResult ChangeDescription(long AccommodationDescriptionID)
        {
            var AccommodationDescription = _AccommodationBusiness.GetAccommodationDescription(AccommodationDescriptionID);
            var enumDataType = from Common.Language e in Language.GetValues(typeof(Language)) select new { ID = (int)e, Name = e.ToString() };
            ViewBag.LanguageID = new SelectList(enumDataType, "ID", "Name", AccommodationDescription.LanguageID);
            Data.ViewModel.AccommodationModels.EditDescriptionViewModel Model = new AccommodationModels.EditDescriptionViewModel()
            {
                AccommodationDescriptionID = AccommodationDescriptionID,
                Description = AccommodationDescription.Description,
                AccommodationID = AccommodationDescription.AccommodationID
            };
            return View(Model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult ChangeDescription(AccommodationModels.ChangeDescription Model)
        {
            if (ModelState.IsValid)
            {
                var Result = _AccommodationBusiness.ChangeDescription(Model);
                if (Result)
                {
                    iUserStorage.Store(PublicConstants.Session.Message_Success, PublicConstants.Message.Success);
                    return RedirectToAction("ListLanguageDescription", new { AccommodationID = Model.AccommodationID });
                }
                else
                {
                    iUserStorage.Store(PublicConstants.Session.Message_Error, PublicConstants.Message.Faild);
                    return RedirectToAction("ListLanguageDescription", new { AccommodationID = Model.AccommodationID });
                }
            }
            iUserStorage.Store(PublicConstants.Session.Message_Warning, PublicConstants.Message.ModelState);
            return RedirectToAction("ListLanguageDescription", new { AccommodationID = Model.AccommodationID });
        }
        public ActionResult SearchReport()
        {
            var Result = _AccommodationBusiness.GetSearchReport();
            return View(Result);
        }

        [HttpPost]
        public JsonResult VerifyRoomImage(RoomImagesViewModel model)
        {
            try
            {
                if (model != null)
                {
                    var result = _AccommodationBusiness.VerifyRoomImages(model);
                    if (result)
                    {
                        return Json(new { success = true }, JsonRequestBehavior.AllowGet);
                    }
                    return Json(new { success = false, message = "Verify Room Images failed." }, JsonRequestBehavior.AllowGet);
                }
                return Json(new { success = false, message = "Model is invalid." }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}