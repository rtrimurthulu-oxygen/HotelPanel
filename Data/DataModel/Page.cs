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
    
    public partial class Page
    {
        public long PageId { get; set; }
        public string PageUrl { get; set; }
        public Nullable<long> AccommodationID { get; set; }
        public bool IsEnabled { get; set; }
        public Nullable<long> UserID { get; set; }
        public Nullable<long> ModifyUserID { get; set; }
        public Nullable<System.DateTime> CreationTime { get; set; }
        public Nullable<System.DateTime> ModificationTime { get; set; }
        public byte LayoutType { get; set; }
        public string Content { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public Nullable<float> Priority { get; set; }
        public string PageTitle { get; set; }
        public string ChangeFreq { get; set; }
    
        public virtual User1 User1 { get; set; }
        public virtual User1 User11 { get; set; }
        public virtual Accommodation Accommodation { get; set; }
    }
}
