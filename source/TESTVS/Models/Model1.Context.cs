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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WEBMVCEntities1 : DbContext
    {
        public WEBMVCEntities1()
            : base("name=WEBMVCEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Accountant> Accountants { get; set; }
        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<Good> Goods { get; set; }
        public virtual DbSet<Import> Imports { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<warehouse> warehouses { get; set; }
    }
}
