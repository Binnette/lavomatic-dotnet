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

    public partial class LaundryExt
    {
        public long IdLaundry { get; set; }
        public Nullable<bool> Detergent { get; set; }
        public Nullable<decimal> DetergentPrice { get; set; }
        public string DetergentComment { get; set; }
        public Nullable<bool> Softener { get; set; }
        public Nullable<decimal> SoftenerPrice { get; set; }
        public Nullable<int> Desk { get; set; }
        public Nullable<int> Seat { get; set; }
    
        public virtual Laundry Laundry { get; set; }
    }
}