//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Book_A_Majig_v2.DatabaseEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class TeamCommendation
    {
        public int Id { get; set; }
        public string Reason { get; set; }
    
        public virtual Shift Shift { get; set; }
        public virtual EmployeeCommendationClassification EmployeeCommendationClassification { get; set; }
    }
}
