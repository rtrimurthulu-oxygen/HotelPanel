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
    
    public partial class BookingAirport
    {
        public int ID { get; set; }
        public string airport_name { get; set; }
        public string iata { get; set; }
        public Nullable<double> number_of_hotels { get; set; }
        public string country_code { get; set; }
        public string deeplink { get; set; }
    }
}
