﻿using BookingDB;
using Service.ServiceModel.BookingModels;
using Service.Suppliers;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Logic.BusinessObjects
{
    public class BookingBusiness
    {
        private bool AllowTruncate => ConfigurationManager.AppSettings["AllowTruncateBookingDB"] == "true" ? true : false;
        private void TruncateDB(long hotelId)
        {
            try
            {
                using (var context = new BookingStaticDataEntities())
                {
                    context.Configuration.AutoDetectChangesEnabled = false;

                    // Remove Room Info
                    context.RoomInfoes.RemoveRange(context.RoomInfoes.Where(x => x.HotelId == hotelId));

                    // Remove Lat_Long
                    context.HotelLatLongs.RemoveRange(context.HotelLatLongs.Where(x => x.HotelId == hotelId));

                    // Remove Locations
                    context.Locations.RemoveRange(context.Locations.Where(x => x.HotelId == hotelId));

                    // Remove Images
                    context.ImgUrls.RemoveRange(context.ImgUrls.Where(x => x.HotelId == hotelId));

                    // Remove Facilities
                    context.Facilities.RemoveRange(context.Facilities.Where(x => x.HotelId == hotelId));

                    // Remove GoodToKnow
                    context.GoodToNows.RemoveRange(context.GoodToNows.Where(x => x.HotelId == hotelId));

                    // Remove Locations
                    context.Locations.RemoveRange(context.Locations.Where(x => x.HotelId == hotelId));

                    context.ChangeTracker.DetectChanges();
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private string GetUrlByID(long hotelID)
        {
            try
            {
                using (var context = new BookingStaticDataEntities())
                {
                    var url = context.Hotels.FirstOrDefault(x => x.HotelId == hotelID).hotel_url;
                    return url.Remove(url.LastIndexOf('?'));
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private bool InsertHotelInfo(long hotelID, HotelData data)
        {
            try
            {
                using (var context = new BookingStaticDataEntities())
                {
                    var hotel = context.Hotels.FirstOrDefault(x => x.HotelId == hotelID);
                    hotel.DescriptionSite = data.Description;
                    context.GoodToNows.Add(new GoodToNow
                    {
                        CheckIn = data.GoodToKnow.CheckIn,
                        CheckOut = data.GoodToKnow.CheckOut,
                        HotelId = hotelID,
                        Pets = data.GoodToKnow.Pets,
                    });
                    context.ImgUrls.AddRange(data.HotelImageUrls.Select(x => new ImgUrl
                    {
                        HotelId = hotelID,
                        Path = x,
                        LastUpdate = DateTime.Now,
                    }).ToList());
                    context.Locations.AddRange(data.Locations.Select(x => new BookingDB.Location
                    {
                        Name = x.Name,
                        LocationID = x.LocationID,
                        LastUpdate = DateTime.Now
                    }).ToList());
                    context.HotelLatLongs.Add(new HotelLatLong
                    {
                        HotelId = hotelID,
                        Lat = data.Latitude,
                        Long = data.Longitude,
                    });
                    context.Facilities.AddRange(data.Facilities.Select(x => new BookingDB.Facility
                    {
                        Category = x.Category,
                        HotelId = hotelID,
                        Title = x.Title,
                        LastUpdate = DateTime.Now
                    }).ToList());
                    return context.SaveChanges() > 0 ? true : false;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool InsertRoomInfo(long hotelID, List<RoomData> data)
        {
            try
            {
                var roomsInfo = new ConcurrentBag<RoomInfo>();
                Parallel.ForEach(data, roomData =>
                {
                    roomData.RoomImages.ForEach(image =>
                    {
                        roomsInfo.Add(new RoomInfo
                        {
                            HotelId = hotelID,
                            Radif = image.ID,
                            RoomSize = roomData.RoomSize,
                            RoomTypeIcon = roomData.Sleeps,
                            RoomTypeName = roomData.RoomType,
                            RoomTypeInfo = roomData.RoomTypeInfo,
                            RoomTypeIconInfo = roomData.SleepsInfo,
                            RoomImgUrl = image.Url,
                            RoomFacilities = string.Join("-", roomData.Facilities),
                            RoomDescription = roomData.Description,
                            RoomTypeId = Convert.ToInt64(Regex.Replace(roomData.RoomTypeID, "[A-Za-z ]", "")),
                        });
                    });
                });
                using (var context = new BookingStaticDataEntities())
                {
                    context.Configuration.AutoDetectChangesEnabled = false;
                    context.RoomInfoes.AddRange(roomsInfo);
                    context.ChangeTracker.DetectChanges();
                    return context.SaveChanges() > 0 ? true : false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public (bool success, string message, List<BookingViewModel> data) MapBookingInfo(long from, long to)
        {
            try
            {
                if (from > to) throw new ArgumentOutOfRangeException();
                var result = new ConcurrentBag<BookingViewModel>();
                Parallel.For(from, to + 1, i =>
                 {
                     try
                     {
                         string message = "";
                         bool insertHotelToDB = false, insertRoomsToDB = false, getHotel = false, getRooms = false;
                         if (AllowTruncate) TruncateDB(i);
                         string bookingUrl = GetUrlByID(i);
                         var bookingAccess = new BookingAccess(bookingUrl);
                         var hotelResult = new BookingResponseModel<HotelData>();
                         var roomsResult = new BookingResponseModel<List<RoomData>>();
                         Parallel.Invoke(
                             () =>
                             {
                                 hotelResult = bookingAccess.GetHotelInfo();
                             },
                             () =>
                             {
                                 roomsResult = bookingAccess.GetRooms();
                             });
                         Parallel.Invoke(
                             () =>
                             {
                                 if (hotelResult.Success)
                                 {
                                     getHotel = true;
                                     if (InsertHotelInfo(i, hotelResult.Data)) insertHotelToDB = true;
                                 }
                                 else
                                 {
                                     message += "Get Hotel Info Message: ";
                                     message += string.Join("--", hotelResult.Errors.Select(x => x.Text).ToArray());
                                 }
                             },
                             () =>
                             {
                                 if (roomsResult.Success)
                                 {
                                     getRooms = true;
                                     if (InsertRoomInfo(i, roomsResult.Data)) insertRoomsToDB = true;
                                 }
                                 else
                                 {
                                     message += "Get Hotel Info Message: ";
                                     message += string.Join("--", roomsResult.Errors.Select(x => x.Text).ToArray());
                                 }
                             });
                         result.Add(new BookingViewModel
                         {
                             HotelID = i,
                             GetHotelInfo = getHotel,
                             GetRoomInfo = getRooms,
                             InsertHotelToDB = insertHotelToDB,
                             InsertRoomsToDB = insertRoomsToDB,
                         });
                     }
                     catch (Exception ex)
                     {
                         result.Add(new BookingViewModel
                         {
                             HotelID = i,
                             Message = ex.Message,
                         });
                     }
                 });
                return (true, null, result.ToList());

            }
            catch (Exception ex)
            {
                return (false, ex.Message, null);
            }
        }


    }
}
