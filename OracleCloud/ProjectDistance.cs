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
    
    public partial class ProjectDistance
    {
        public int ProjectDistanceID { get; set; }
        public int ProjectID { get; set; }
        public int PlantID { get; set; }
        public Nullable<decimal> Miles { get; set; }
        public Nullable<decimal> Kilometers { get; set; }
        public System.DateTime MsModificationDate { get; set; }
    
        public virtual Plant Plant { get; set; }
        public virtual Project Project { get; set; }
    }
}
