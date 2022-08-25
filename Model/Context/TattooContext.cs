using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Model.BussinessRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Context
{
    public class TattooContext : DbContext
    {
      
        // entity
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        //Config to connected database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Database=TattooProject;Integrated Security=True;");
        }

        // Config Model
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                        .HasOne<Customer>(c => c.Customer)
                        .WithMany(c => c.Orders)
                        .HasForeignKey(c => c.CustomerId)
                        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Product>()
                        .HasOne<Category>(c => c.Category)
                        .WithMany(c => c.Products)
                        .HasForeignKey(p => p.ProductId)
                        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderDetail>()
                         .HasKey(od => new { od.ProductId, od.OrderId });

            modelBuilder.Entity<OrderDetail>()
                        .HasOne<Product>(p => p.Product)
                        .WithMany(od => od.OrderDetails)
                        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderDetail>()
                        .HasOne<Order>(o => o.Order)
                        .WithMany(od => od.OrderDetails)
                        .OnDelete(DeleteBehavior.Cascade);
        }
        // data Default when instanse




    }
}
