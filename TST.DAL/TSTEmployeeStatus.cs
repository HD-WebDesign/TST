//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TST.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TSTEmployeeStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSTEmployeeStatus()
        {
            this.TSTEmployees = new HashSet<TSTEmployee>();
        }
    
        public int EmployeeStatusID { get; set; }
        public string EmployeeStatusName { get; set; }
        public string EmployeeStatusDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSTEmployee> TSTEmployees { get; set; }
    }
}
