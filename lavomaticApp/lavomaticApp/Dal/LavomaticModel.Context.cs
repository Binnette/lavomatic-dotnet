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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class lavomaticDbEntities : DbContext
    {
        public lavomaticDbEntities()
            : base("name=lavomaticDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Laundry> Laundries { get; set; }
        public virtual DbSet<LaundryExt> LaundryExts { get; set; }
        public virtual DbSet<Dryer> Dryers { get; set; }
        public virtual DbSet<Washer> Washers { get; set; }
    }
}
