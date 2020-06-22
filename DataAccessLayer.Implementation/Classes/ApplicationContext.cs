using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace DataAccessLayer.Implementation.Classes
{
    class ApplicationContext : DbContext
    { 
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
             : base(options)
        {
                
        }
        public DbSet<ClientEntity> Products { get; set; }
        public DbSet<CookEntity> Shops { get; set; }
        public DbSet<DishEntity> ProductsInShops { get; set; }
        public DbSet<OrderEntity> Reservations { get; set; }
    }
}
