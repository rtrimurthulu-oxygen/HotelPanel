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
    
    public partial class AccommodationSortedByCountry
    {
        public long AccommodationId { get; set; }
        public string AccommodationName { get; set; }
        public string CountryName { get; set; }
        public string CityName { get; set; }
        public Nullable<long> Ordered { get; set; }
    
        public virtual Accommodation Accommodation { get; set; }
    }
}
