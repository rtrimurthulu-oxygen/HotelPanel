//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookingDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class ImgUrl
    {
        public long ImgUrlId { get; set; }
        public long HotelId { get; set; }
        public string Path { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
        public string LocalPath { get; set; }
        public Nullable<long> nRow { get; set; }
        public string FileName { get; set; }
        public Nullable<long> AccommodationlID { get; set; }
        public string PathWeb { get; set; }
        public string Link { get; set; }
    }
}
