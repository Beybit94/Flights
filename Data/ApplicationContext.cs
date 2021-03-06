﻿using Data.Configuration;
using Data.Entity;
using Data.Entity.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Data
{
    public class ApplicationContext : IdentityDbContext<User,Role,string>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //builder.ApplyConfiguration(new AdminRoleConfig());
            //builder.ApplyConfiguration(new ManagerRoleConfig());
            //builder.ApplyConfiguration(new AdminUserConfig());
            //builder.ApplyConfiguration(new ManagerUserConfig());
            //builder.ApplyConfiguration(new UsersWithRolesConfig());
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Flight> Flights { get; set; }
    }
}
