//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MENSSAloonShopping.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BarbersShopEntities : DbContext
    {
        public BarbersShopEntities()
            : base("name=BarbersShopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Audit> Audits { get; set; }
        public virtual DbSet<Facial> Facials { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Style> Styles { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
