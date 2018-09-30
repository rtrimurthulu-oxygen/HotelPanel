﻿using Service.ServiceModel.PublicModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ServiceModel.BookingModels
{
    public class BookingResponseModel<T>
    {
        public bool Success { get; set; }
        public List<Error> Errors { get; set; }
        public T Data { get; set; }
    }
    public class HotelData
    {
        public string Description { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public List<string> HotelImageUrls { get; set; }
        public List<Facility> Facilities { get; set; }
        public GoodToKnow GoodToKnow { get; set; }
        public List<Location> Locations { get; set; }
    }
    public class RoomData
    {
        public string Sleeps { get; set; }
        public string RoomType { get; set; }
        public List<RoomImage> RoomImages { get; set; }
        public string RoomSize { get; set; }
        public List<string> Facilities { get; set; }
        public string SleepsInfo { get; set; }
        public string RoomTypeInfo { get; set; }
        public string Description { get; set; }
        public string RoomTypeID { get; set; }
    }
    public class RoomImage
    {
        public int ID { get; set; }
        public string Url { get; set; }
    }

    public class GoodToKnow
    {
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public string Pets { get; set; }
        public string Groups { get; set; }
    }

    public class Facility
    {
        public string Title { get; set; }
        public string Category { get; set; }
    }
    public class Location
    {
        public int LocationID { get; set; }
        public string Name { get; set; }
    }

    public class BookingViewModel
    {
        public long HotelID { get; set; }
        public string Message { get; set; }
        public bool GetRoomInfo { get; set; }
        public bool GetHotelInfo { get; set; }
        public bool InsertHotelToDB { get; set; }
        public bool InsertRoomsToDB { get; set; }
    }
}
