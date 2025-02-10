using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfCorePostgresDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCorePostgresDemo.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ConsoleEntity;Username=postgres;Password=0000");
        }
        public DbSet<User> Users {get; set;}
        public DbSet<Card> Cards {get; set;}
        public DbSet<CardItem> CardItems {get;set;}
        public DbSet<Category> Categories {get;set;}
        public DbSet<Customer> Customers {get;set;}
        public DbSet<CustomerAddress> CustomerAddresses {get; set;}
        public DbSet<Product> Products {get;set;}
    }
}