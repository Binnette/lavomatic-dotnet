//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lavomaticApp.Dal
{
    using System;

    public partial class Laundry
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Lat { get; set; }
        public decimal Lon { get; set; }
        public string OpenHours { get; set; }
        public string Phone { get; set; }
        public string HouseNum { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Web { get; set; }
        public Nullable<bool> WheelChair { get; set; }
    
        public virtual Dryer Dryer { get; set; }
        public virtual LaundryExt LaundryExt { get; set; }
        public virtual Washer Washer { get; set; }
    }
}