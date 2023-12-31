﻿using Core.Entities;
using Core.Entities.OrderAggregate;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Core.Identity;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class StoreContext : IdentityDbContext<AppUser>
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }

        public virtual DbSet<Product> Products { get; set; }
        public  virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<DeliveryMethod> DeliveryMethods { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());  
        }
    }
}
