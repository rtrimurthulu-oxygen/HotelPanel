//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class PackagesIndex
    {
        public long PackagesIndexID { get; set; }
        public Nullable<int> TypeIndex { get; set; }
        public string CheckInDate { get; set; }
        public string CheckOutDate { get; set; }
        public string HotelCheckIn { get; set; }
        public string HotelCheckOut { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public string SourceCode { get; set; }
        public string DestinationCode { get; set; }
        public string RoomsInfo { get; set; }
        public string Nationality { get; set; }
        public Nullable<long> currencyID { get; set; }
        public Nullable<decimal> markup { get; set; }
        public string cabinClassCode { get; set; }
        public string airlineCode { get; set; }
        public string departureTime { get; set; }
        public string returnTime { get; set; }
        public string ratePlanCodes { get; set; }
        public Nullable<decimal> hotelRate { get; set; }
        public string facilityCodes { get; set; }
        public Nullable<int> Nights { get; set; }
        public Nullable<bool> nonStop { get; set; }
        public string ModificationDateTime { get; set; }
        public string ModificationUserID { get; set; }
        public string CreateDateTime { get; set; }
        public Nullable<long> CreateUserID { get; set; }
        public string HotelName { get; set; }
        public Nullable<decimal> FromPrice { get; set; }
        public Nullable<decimal> ToPrice { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public Nullable<System.DateTime> PackageFromDate { get; set; }
        public Nullable<System.DateTime> PackageToDate { get; set; }
        public string Title_EN { get; set; }
        public Nullable<long> LanguageID { get; set; }
        public Nullable<System.Guid> TaskId { get; set; }
        public Nullable<System.DateTime> ScheduledToRunOn { get; set; }
        public string TaskActionUrl { get; set; }
        public Nullable<long> CompanyID { get; set; }
    
        public virtual Company1 Company1 { get; set; }
        public virtual Language Language { get; set; }
    }
}
