//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Book_A_Majig_v2
{
    using System;
    using System.Collections.Generic;
    
    public partial class LockOutTime
    {
        public int Id { get; set; }
        public string StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
    
        public virtual LockOutDate LockOutDate { get; set; }
    }
}
