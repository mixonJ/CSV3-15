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
    
    public partial class QuoteSurcharge
    {
        public int QuoteSurchargeID { get; set; }
        public int QuoteID { get; set; }
        public int SurchargeID { get; set; }
        public decimal Rate { get; set; }
        public System.DateTime MsModificationDate { get; set; }
    
        public virtual Quote Quote { get; set; }
        public virtual Surcharge Surcharge { get; set; }
    }
}
