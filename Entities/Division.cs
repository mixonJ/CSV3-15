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
    
    public partial class Division
    {
        public Division()
        {
            this.AdditionalProducts = new HashSet<AdditionalProduct>();
            this.CompetitorPlants = new HashSet<CompetitorPlant>();
            this.Plants = new HashSet<Plant>();
        }
    
        public int DivisionID { get; set; }
        public string DivisionName { get; set; }
        public int CompanyID { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string ST { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public System.DateTime MsModificationDate { get; set; }
    
        public virtual ICollection<AdditionalProduct> AdditionalProducts { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<CompetitorPlant> CompetitorPlants { get; set; }
        public virtual ICollection<Plant> Plants { get; set; }
    }
}