//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TESTVS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Accountant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Accountant()
        {
            this.Imports = new HashSet<Import>();
        }
    
        public string AccountantId { get; set; }
        public string AccountantName { get; set; }
        public string AccountantPassword { get; set; }
        public Nullable<int> AccountantAge { get; set; }
        public string AccountantAddress { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Import> Imports { get; set; }
    }
}
