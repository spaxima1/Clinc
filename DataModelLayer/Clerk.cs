//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModelLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clerk
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clerk()
        {
            this.Patients = new HashSet<Patient>();
        }
    
        public int ClerkID { get; set; }
        public string ClerkUserName { get; set; }
        public string ClerkName { get; set; }
        public string ClerkFamily { get; set; }
        public string ClerkPassword { get; set; }
        public Nullable<System.DateTime> ClerkStartDate { get; set; }
        public Nullable<System.DateTime> ClerkEndDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
