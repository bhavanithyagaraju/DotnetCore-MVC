using DotnetCore_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DotnetCore_MVC.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Order>().ToTable("OrderDetail");
            

            // Map Order → Customer Relationship
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)        // Order has one Customer
                .WithMany(c => c.Orders)        // Customer has many Orders
                .HasForeignKey(o => o.CustomerId) // FK column in Orders table
                .OnDelete(DeleteBehavior.Restrict); // Optional

            base.OnModelCreating(modelBuilder);
        }
    }
}
