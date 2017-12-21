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
    
    public partial class Order
    {
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int OrderID { get; set; }
        public int CompanyID { get; set; }
        public Nullable<int> ProjectID { get; set; }
        public Nullable<int> year { get; set; }
        public Nullable<int> month { get; set; }
        public Nullable<decimal> YardsActual { get; set; }
        public Nullable<decimal> MaterialCost { get; set; }
        public Nullable<decimal> DollarsActual { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
        public Nullable<decimal> YardsTicketed { get; set; }
        public Nullable<System.DateTime> OnJobTime { get; set; }
        public Nullable<int> LocationID { get; set; }
        public Nullable<int> ProspectID { get; set; }
        public Nullable<int> DispatchOrderID { get; set; }
        public string DispatchOrderNumber { get; set; }
        public string SalesmanCode { get; set; }
        public Nullable<System.DateTime> Inserted { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public System.DateTime MsModificationDate { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual Plant Plant { get; set; }
        public virtual Project Project { get; set; }
        public virtual Prospect Prospect { get; set; }
    }
}