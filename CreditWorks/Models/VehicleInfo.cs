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
    
    public partial class VehicleInfo
    {
        public int Id { get; set; }
        public string OwnerName { get; set; }
        public int ManufacturerId { get; set; }
        public int YearOfManufacture { get; set; }
        public decimal WeightOfVehicle { get; set; }
        public int CategoryId { get; set; }
    
        public virtual Vehicle_Category Vehicle_Category { get; set; }
        public virtual Vehicle_Manufacturer Vehicle_Manufacturer { get; set; }
    }
}
