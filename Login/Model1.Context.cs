﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Login
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class Entities2 : DbContext
{
    public Entities2()
        : base("name=Entities2")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<month> months { get; set; }

    public virtual DbSet<year> years { get; set; }

}

}

