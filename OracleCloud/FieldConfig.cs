//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OracleCloud
{
    using System;
    using System.Collections.Generic;
    
    public partial class FieldConfig
    {
        public int FieldConfigID { get; set; }
        public int CompanyID { get; set; }
        public string FieldID { get; set; }
        public bool Required { get; set; }
        public bool Hidden { get; set; }
        public string FormID { get; set; }
        public System.DateTime MsModificationDate { get; set; }
    
        public virtual Company Company { get; set; }
    }
}