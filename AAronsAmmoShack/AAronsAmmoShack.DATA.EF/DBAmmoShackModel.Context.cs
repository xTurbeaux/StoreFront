﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AAronsAmmoShack.DATA.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBAmmoShackEntities : DbContext
    {
        public DBAmmoShackEntities()
            : base("name=DBAmmoShackEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ammos> Ammos { get; set; }
        public virtual DbSet<Calibers> Calibers1 { get; set; }
        public virtual DbSet<Damages> Damages1 { get; set; }
        public virtual DbSet<Manufacturers> Manufacturers1 { get; set; }
        public virtual DbSet<RelatedFirearms> RelatedFirearms1 { get; set; }
    }
}
