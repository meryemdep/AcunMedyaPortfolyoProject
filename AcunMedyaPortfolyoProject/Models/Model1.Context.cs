﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AcunMedyaPortfolyoProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBacunmedyaproject1Entities : DbContext
    {
        public DBacunmedyaproject1Entities()
            : base("name=DBacunmedyaproject1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<About> About { get; set; }
        public virtual DbSet<CategoryTbl> CategoryTbl { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<Education> Education { get; set; }
        public virtual DbSet<Experience> Experience { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<Projectpart> Projectpart { get; set; }
        public virtual DbSet<References> References { get; set; }
        public virtual DbSet<ServicesPart> ServicesPart { get; set; }
        public virtual DbSet<Skills> Skills { get; set; }
        public virtual DbSet<Slider1> Slider1 { get; set; }
    }
}
