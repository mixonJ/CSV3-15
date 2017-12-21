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
    
    public partial class Terms_Discount
    {
        public Terms_Discount()
        {
            this.Quotes = new HashSet<Quote>();
        }
    
        public int Terms_Discount_ID { get; set; }
        public int CompanyID { get; set; }
        public Nullable<int> Discount_Days { get; set; }
        public decimal Discount_Amount { get; set; }
        public Nullable<int> Net_Days { get; set; }
        public string Description { get; set; }
        public bool Discount_Taxes { get; set; }
        public bool Percent_Flag { get; set; }
        public System.DateTime MsModificationDate { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual ICollection<Quote> Quotes { get; set; }
    }
}
