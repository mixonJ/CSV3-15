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
    
    public partial class PlantProductPrice
    {
        public int PlantProductPriceID { get; set; }
        public int PlantID { get; set; }
        public int ProductID { get; set; }
        public decimal ListPrice { get; set; }
        public int PriceListID { get; set; }
        public string Description { get; set; }
        public string PriceExtensionCode { get; set; }
        public System.DateTime MsModificationDate { get; set; }
    
        public virtual Plant Plant { get; set; }
        public virtual Product Product { get; set; }
    }
}
