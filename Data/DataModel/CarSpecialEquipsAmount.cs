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
    
    public partial class CarSpecialEquipsAmount
    {
        public long CarSpecialEquipsAmountid { get; set; }
        public Nullable<decimal> EquipsAmount { get; set; }
        public long CarTotalFareid { get; set; }
    
        public virtual CarTotalFare CarTotalFare { get; set; }
    }
}
