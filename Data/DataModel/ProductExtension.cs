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
    
    public partial class ProductExtension
    {
        public long ProductExtensionId { get; set; }
        public string VersionNumber { get; set; }
        public string Extensions { get; set; }
        public Nullable<long> UserId { get; set; }
        public Nullable<long> ModifyUserId { get; set; }
        public Nullable<System.DateTime> CreationTime { get; set; }
        public Nullable<System.DateTime> ModificationTime { get; set; }
    
        public virtual User1 User1 { get; set; }
        public virtual User1 User11 { get; set; }
    }
}
