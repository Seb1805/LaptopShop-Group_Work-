//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERD
{
    using System;
    using System.Collections.Generic;
    
    public partial class CPUs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CPUs()
        {
            this.Products = new HashSet<Products>();
        }
    
        public int CPUId { get; set; }
        public int Generation { get; set; }
        public string ModelNumber { get; set; }
        public double GHz { get; set; }
        public int BrandId { get; set; }
    
        public virtual Brands Brands { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Products> Products { get; set; }
    }
}
