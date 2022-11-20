using Microsoft.EntityFrameworkCore;
using OnionArchiture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchiture.Persistence.Context
{
    public class AppDbContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Pen",
                Value = 10,
                Quantity = 100
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Boook",
                Value = 10,
                Quantity = 100
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Pencil",
                Value = 10,
                Quantity = 100
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
