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
    
    public partial class CustomerEventType
    {
        public CustomerEventType()
        {
            this.CustomerEvents = new HashSet<CustomerEvent>();
        }
    
        public int EventTypeID { get; set; }
        public int CompanyID { get; set; }
        public string EventType { get; set; }
        public System.DateTime MsModificationDate { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual ICollection<CustomerEvent> CustomerEvents { get; set; }
    }
}
