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
    
    public partial class Accommodation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Accommodation()
        {
            this.AccommodationCommissions = new HashSet<AccommodationCommission>();
            this.AccommodationAttributes = new HashSet<AccommodationAttribute>();
            this.AccommodationCommission1 = new HashSet<AccommodationCommission1>();
            this.AccommodationDescriptions = new HashSet<AccommodationDescription>();
            this.AccommodationReviews = new HashSet<AccommodationReview>();
            this.AccomodationImages = new HashSet<AccomodationImage>();
            this.AccomodationRoomImages = new HashSet<AccomodationRoomImage>();
            this.AccomodationSuppliers = new HashSet<AccomodationSupplier>();
            this.Discounts = new HashSet<Discount>();
            this.Pages = new HashSet<Page>();
            this.Facilities = new HashSet<Facility>();
            this.Locations = new HashSet<Location>();
        }
    
        public long AccommodationlID { get; set; }
        public Nullable<long> ChainID { get; set; }
        public string AirportCode { get; set; }
        public Nullable<byte> Type { get; set; }
        public string Name { get; set; }
        public string Rating { get; set; }
        public string Address { get; set; }
        public string PostCodeZip { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Description { get; set; }
        public string Near { get; set; }
        public Nullable<System.DateTime> lastUpdate { get; set; }
        public string CountryCode { get; set; }
        public string CityName { get; set; }
        public Nullable<long> CityId { get; set; }
        public string Resort { get; set; }
        public string Region { get; set; }
        public string DestinationId { get; set; }
        public string Destination { get; set; }
        public string Country { get; set; }
        public string HotelArea { get; set; }
        public string HotelImages { get; set; }
        public string HotelLocation { get; set; }
        public string HotelInfo { get; set; }
        public string PAmenities { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<long> UserID { get; set; }
        public Nullable<System.DateTime> DateVerified { get; set; }
        public Nullable<bool> IsVerified { get; set; }
        public Nullable<bool> IsError { get; set; }
        public string BookingUrl { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccommodationCommission> AccommodationCommissions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccommodationAttribute> AccommodationAttributes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccommodationCommission1> AccommodationCommission1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccommodationDescription> AccommodationDescriptions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccommodationReview> AccommodationReviews { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccomodationImage> AccomodationImages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccomodationRoomImage> AccomodationRoomImages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccomodationSupplier> AccomodationSuppliers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Discount> Discounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Page> Pages { get; set; }
        public virtual AccommodationSortedByCountry AccommodationSortedByCountry { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facility> Facilities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Location> Locations { get; set; }
    }
}
