using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MiniEcommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerce.Data.Context
{
    public class PostgreeContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public PostgreeContext( IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = _configuration.GetConnectionString("postgree");
            optionsBuilder.UseNpgsql(connection);
        }


        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerPassword> CustomerPassword { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Product> Product { get; set; }


    }

}
