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
    
    public partial class SkillCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SkillCategory()
        {
            this.EmployeeShifts = new HashSet<EmployeeShift>();
            this.EmployeeCommendationSkillCategories = new HashSet<EmployeeCommendationSkillCategory>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeShift> EmployeeShifts { get; set; }
        public virtual SkillCategory Children { get; set; }
        public virtual SkillCategory Paremt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeCommendationSkillCategory> EmployeeCommendationSkillCategories { get; set; }
    }
}
