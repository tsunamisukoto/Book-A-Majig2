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
    
    public partial class EmployeeShiftPresets
    {
        public int Id { get; set; }
        public int DayOfWeek { get; set; }
        public System.DateTime StartTime { get; set; }
        public Nullable<System.DateTime> FinishTime { get; set; }
    
        public virtual EmployeeLevelCategory EmployeeShiftCategory { get; set; }
        public virtual ShiftCategory ShiftCategory { get; set; }
    }
}
