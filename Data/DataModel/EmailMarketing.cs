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
    
    public partial class EmailMarketing
    {
        public long EmailMarketingID { get; set; }
        public Nullable<int> TypeIndex { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string TitleImage1 { get; set; }
        public string TitleImage2 { get; set; }
        public string TitleImage3 { get; set; }
        public string DescriptionImage1 { get; set; }
        public string DescriptionImage2 { get; set; }
        public string DescriptionImage3 { get; set; }
        public string LinkImage1 { get; set; }
        public string LinkImage2 { get; set; }
        public string LinkImage3 { get; set; }
        public Nullable<long> LanguageID { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string CreateDateTime { get; set; }
        public Nullable<long> CreateUserID { get; set; }
    
        public virtual Language Language { get; set; }
        public virtual User1 User1 { get; set; }
    }
}
