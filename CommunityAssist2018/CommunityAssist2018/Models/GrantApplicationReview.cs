//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CommunityAssist2018.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GrantApplicationReview
    {
        public int GrantApplicationReviewKey { get; set; }
        public Nullable<int> GrantApplicationKey { get; set; }
        public Nullable<int> EmployeeKey { get; set; }
        public Nullable<System.DateTime> GrantApplicationReviewDate { get; set; }
        public string GrantApplicationReviewNotes { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual GrantApplication GrantApplication { get; set; }
    }
}
