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
    
    public partial class SalespersonContact
    {
        public int SalesPersonContactID { get; set; }
        public int SalesPersonID { get; set; }
        public int ContactID { get; set; }
        public System.DateTime MsModificationDate { get; set; }
    
        public virtual Contact Contact { get; set; }
        public virtual User User { get; set; }
    }
}