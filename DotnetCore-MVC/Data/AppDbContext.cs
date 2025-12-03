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
    }
}
