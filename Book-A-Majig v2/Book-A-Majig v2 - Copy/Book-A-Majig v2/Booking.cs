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
    
    public partial class Booking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Booking()
        {
            this.BookingNotes = new HashSet<BookingNotes>();
        }
    
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string ContactNumber { get; set; }
        public int BookingClasificationId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> ArrivedDate { get; set; }
        public Nullable<System.DateTime> DateInactive { get; set; }
        public int RestaurantId { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int BookingClasificationId1 { get; set; }
        public int RestaurantId1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingNotes> BookingNotes { get; set; }
        public virtual BookingConfirmation BookingConfirmation { get; set; }
        public virtual BookingClasification BookingClasification { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
