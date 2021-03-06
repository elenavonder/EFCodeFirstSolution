﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCodeFirstProject
{
    public class AppDbContext : DbContext 
    {
        //must do DbSet to migrate tables to SQL
        public virtual DbSet<OrderLine> OrderLines { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }

        //constructor needs to be made to connect to SQL Database HAVE TO CALL
        //DbContextOptions is the type
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        //default constructor; don't have to call base, but good practice
        public AppDbContext() : base () { }

        //If you have a Start-Up CLASS file you do not need the configuring
        //used for not making web application, used for console apps
        //protected is used when inheritting OVERRIDE is used with polymorphism
        //there is a METHOD in DbContext named OnConfiguring and we want it to be called at run time, not compile time
        protected override void OnConfiguring (DbContextOptionsBuilder options)
        {
            //if we have not configured once, configure
            if (!options.IsConfigured)
            {
                options.UseSqlServer("server=localhost\\sqlexpress;database=CustOrdDb;trusted_connection=true");
                             //this is the connection string^^
            }
        }
        //table with no foreign key should be done first
        protected override void OnModelCreating (ModelBuilder builder)
        {//fluent api goes in this METHOD
            //parameter name must go first. 
            //if you have 5 tables, need 5 statement blocks
            builder.Entity<Customer>(e =>
            {//e represents the table / class
                //put whatever you need to do in table in brackets
                e.HasIndex(x => x.Code).IsUnique();
                //x = column
                //stating we want ^^ SQL to put an index on Code column/ can be duplicated
                //putting .IsUnique, keeps it from being duplicated
            });
            //using fluent-api to make description not null
            //pro of fluent-api is that you can do anything you need to for entity framework
            builder.Entity<Order>(e =>
            {
                e.Property(o => o.Description).IsRequired().HasMaxLength(50);
            });
        }
    }
}
