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
    
    public partial class CreditStatus
    {
        public int CreditStatusID { get; set; }
        public int CompanyID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string ColorCode { get; set; }
        public System.DateTime MsModificationDate { get; set; }
    
        public virtual Company Company { get; set; }
    }
}
