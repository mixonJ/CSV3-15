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
    
    public partial class ProjectProduct
    {
        public ProjectProduct()
        {
            this.PourSchedules = new HashSet<PourSchedule>();
            this.ProjectBidderProducts = new HashSet<ProjectBidderProduct>();
            this.QuoteDetails = new HashSet<QuoteDetail>();
            this.Schedules = new HashSet<Schedule>();
        }
    
        public int ProjectProductID { get; set; }
        public int ProjectID { get; set; }
        public decimal Qty { get; set; }
        public Nullable<int> UOMID { get; set; }
        public System.DateTime Inserted { get; set; }
        public System.DateTime Modified { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> ProductLineID { get; set; }
        public Nullable<int> ProductTypeID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> PsiID { get; set; }
        public Nullable<int> ProductUsageID { get; set; }
        public string Note { get; set; }
        public Nullable<bool> Forecasted { get; set; }
        public Nullable<int> PlantID { get; set; }
        public Nullable<decimal> Freight { get; set; }
        public Nullable<decimal> FreightPay { get; set; }
        public Nullable<decimal> CompetitorPrice { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public Nullable<int> LineOfBusinessID { get; set; }
        public Nullable<int> StatusID { get; set; }
        public System.DateTime MsModificationDate { get; set; }
        public string PriceExtensionCode { get; set; }
        public Nullable<int> LostReasonID { get; set; }
        public Nullable<int> LostToID { get; set; }
        public string LostNote { get; set; }
        public string MIX_MATL_CLASS_ID { get; set; }
        public string BATCH_BOOK_TYPE { get; set; }
        public string CONSISTENCE_CODE { get; set; }
        public Nullable<decimal> WORKABILITY_VALUE { get; set; }
        public string WORKABLITY_BASE_UOM { get; set; }
        public Nullable<decimal> STRGTH_VALUE { get; set; }
        public string STRGTH_CODE { get; set; }
        public Nullable<decimal> USER_MIN_CEM_CONT { get; set; }
        public Nullable<decimal> USER_MAX_WATER_CEM_RATIO { get; set; }
        public string CEM_CLASS_ID { get; set; }
        public Nullable<decimal> REPLACEMENT_PCT { get; set; }
        public Nullable<decimal> AGG_SIZE { get; set; }
        public string COARSE_AGG_CLASS_ID { get; set; }
        public string FINE_AGG_CLASS_ID { get; set; }
        public string ADMIX_CLASS_ID { get; set; }
        public string WATER_CLASS_ID { get; set; }
        public string CHLORIDE_CLASS { get; set; }
        public Nullable<decimal> LIFETIME { get; set; }
        public string ENVIRO_CLASS_CODE { get; set; }
        public string TQS_ITEMCODE { get; set; }
        public string TQS_DESC { get; set; }
        public string TQS_SHORT_DESC { get; set; }
        public int SortOrder { get; set; }
    
        public virtual CompanyBidStatus CompanyBidStatus { get; set; }
        public virtual CompetitorPlant CompetitorPlant { get; set; }
        public virtual LinesOfBusiness LinesOfBusiness { get; set; }
        public virtual Plant Plant { get; set; }
        public virtual ICollection<PourSchedule> PourSchedules { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductLine ProductLine { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual ProductUsage ProductUsage { get; set; }
        public virtual ICollection<ProjectBidderProduct> ProjectBidderProducts { get; set; }
        public virtual Project Project { get; set; }
        public virtual Unit_Of_Measure Unit_Of_Measure { get; set; }
        public virtual ICollection<QuoteDetail> QuoteDetails { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
