﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeninTravel_API.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LeninTravelDBEntities : DbContext
    {
        public LeninTravelDBEntities()
            : base("name=LeninTravelDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tm_des_destinos> tm_des_destinos { get; set; }
        public virtual DbSet<tm_vi2_viajes> tm_vi2_viajes { get; set; }
        public virtual DbSet<tm_via_viajeros> tm_via_viajeros { get; set; }
    }
}