//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProjectMapQtyRange
    {
        public int ProjectMapQtyRangeID { get; set; }
        public int CompanyID { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public string DisplayText { get; set; }
        public System.DateTime MsModificationDate { get; set; }
    
        public virtual Company Company { get; set; }
    }
}
