//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CreditWorks.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vehicle_Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehicle_Category()
        {
            this.VehicleInfo = new HashSet<VehicleInfo>();
        }
    
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int RangeMin { get; set; }
        public int RangeMax { get; set; }
        public string CategoryIcon { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleInfo> VehicleInfo { get; set; }
    }
}
