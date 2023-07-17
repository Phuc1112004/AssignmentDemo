using AssignmentDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDemo.Data
{
    public class DataContext : DbContext
    {
        // Ket noi bao mat
        private string _connectionString = "Server=MSI\\SQLEXPRESS; Database=ShopDB; User Id=sa; Password=12345678; Trusted_Connection=True; TrustServerCertificate=True;MultipleActiveResultSets=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }


        // Tao bang trong database
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
