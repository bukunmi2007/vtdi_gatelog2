﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vtdi_gatelog2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class vtdi_gatelog2_dbEntities : DbContext
    {
        public vtdi_gatelog2_dbEntities()
            : base("name=vtdi_gatelog2_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Gate_In_Out> Gate_In_Outs { get; set; }
        public virtual DbSet<Item_To_Declare> Item_To_Declares { get; set; }
        public virtual DbSet<Purpose_of_Visit> Purpose_of_Visits { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vehicle_Type> Vehicle_Types { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
    }
}
