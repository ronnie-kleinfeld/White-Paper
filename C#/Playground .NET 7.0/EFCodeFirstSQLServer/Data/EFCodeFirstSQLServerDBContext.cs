﻿using EFCodeFirstSQLServer.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCodeFirstSQLServer.Data
{
    public class EFCodeFirstSQLServerDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Connection String Here");
        }
    }
}