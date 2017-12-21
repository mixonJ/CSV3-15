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
    
    public partial class Project
    {
        public Project()
        {
            this.CustomerEvents = new HashSet<CustomerEvent>();
            this.Orders = new HashSet<Order>();
            this.PourSchedules = new HashSet<PourSchedule>();
            this.ProjectBidders = new HashSet<ProjectBidder>();
            this.ProjectDistances = new HashSet<ProjectDistance>();
            this.ProjectNotes = new HashSet<ProjectNote>();
            this.ProjectProducts = new HashSet<ProjectProduct>();
        }
    
        public int ProjectID { get; set; }
        public Nullable<bool> Private { get; set; }
        public Nullable<int> OwnerID { get; set; }
        public int CompanyID { get; set; }
        public string ProjectName { get; set; }
        public int ProjectTypeID { get; set; }
        public int StatusID { get; set; }
        public System.DateTime StatusChangeDate { get; set; }
        public int SourceID { get; set; }
        public bool Active { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public Nullable<int> PlantID { get; set; }
        public int SalespersonID { get; set; }
        public Nullable<System.DateTime> BidDate { get; set; }
        public Nullable<int> LostReasonID { get; set; }
        public Nullable<int> LostToID { get; set; }
        public string LostNote { get; set; }
        public System.DateTime Inserted { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public int PrevStatus { get; set; }
        public Nullable<bool> Exported { get; set; }
        public Nullable<int> WinningProjectBidderID { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> TotalYards { get; set; }
        public string ConnectionCode { get; set; }
        public string CustCode { get; set; }
        public string ProjectCode { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<int> GeofenceID { get; set; }
        public string Country { get; set; }
        public string ProjectDescription { get; set; }
        public Nullable<int> ZoneCodeID { get; set; }
        public System.DateTime MsModificationDate { get; set; }
        public Nullable<System.DateTime> DateLastExported { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual CompanyBidStatus CompanyBidStatus { get; set; }
        public virtual CompetitorPlant CompetitorPlant { get; set; }
        public virtual ICollection<CustomerEvent> CustomerEvents { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual Plant Plant { get; set; }
        public virtual ICollection<PourSchedule> PourSchedules { get; set; }
        public virtual ICollection<ProjectBidder> ProjectBidders { get; set; }
        public virtual ICollection<ProjectDistance> ProjectDistances { get; set; }
        public virtual ICollection<ProjectNote> ProjectNotes { get; set; }
        public virtual ICollection<ProjectProduct> ProjectProducts { get; set; }
        public virtual ProjectType ProjectType { get; set; }
        public virtual Source Source { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ZoneCode ZoneCode { get; set; }
    }
}
