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
    
    public partial class EventStatu
    {
        public EventStatu()
        {
            this.CustomerEvents = new HashSet<CustomerEvent>();
        }
    
        public int EventStatusID { get; set; }
        public string EventStatus { get; set; }
        public System.DateTime MsModificationDate { get; set; }
    
        public virtual ICollection<CustomerEvent> CustomerEvents { get; set; }
    }
}