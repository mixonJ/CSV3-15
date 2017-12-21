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
    
    public partial class Competitor
    {
        public Competitor()
        {
            this.CompetitorPlants = new HashSet<CompetitorPlant>();
        }
    
        public int CompetitorID { get; set; }
        public int CompanyID { get; set; }
        public string CompetitorName { get; set; }
        public System.DateTime Inserted { get; set; }
        public System.DateTime Modified { get; set; }
        public bool Inactive { get; set; }
        public Nullable<int> UserID { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public string Country { get; set; }
        public System.DateTime MsModificationDate { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual ICollection<CompetitorPlant> CompetitorPlants { get; set; }
        public virtual User User { get; set; }
    }
}
