﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Context2 : DbContext
    {
        public Context2()
            : base("name=Context2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Acc_Airport> Acc_Airport { get; set; }
        public virtual DbSet<AccommodationLocationTmp> AccommodationLocationTmps { get; set; }
        public virtual DbSet<AccommodationTmp> AccommodationTmps { get; set; }
        public virtual DbSet<AccomodationSupplier2Tmp> AccomodationSupplier2Tmp { get; set; }
        public virtual DbSet<AccomodationSupplierTmp> AccomodationSupplierTmps { get; set; }
        public virtual DbSet<LocationTmp> LocationTmps { get; set; }
        public virtual DbSet<AccomodationSupplier> AccomodationSuppliers { get; set; }
        public virtual DbSet<AccommodationAlternativeName> AccommodationAlternativeNames { get; set; }
        public virtual DbSet<DeActiveAccommodation> DeActiveAccommodations { get; set; }
    }
}
