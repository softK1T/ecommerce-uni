using ecommerce_uni.Models;
using Microsoft.EntityFrameworkCore;

namespace ecommerce_uni.Data
{
    public class ShopDbContext: DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasConversion<decimal>();

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Asus ROG Strix G15", Description = "High-performance gaming laptop with AMD Ryzen 9 processor and NVIDIA GeForce RTX 3070 graphics.", Price = 1499.99m },
                new Product { Id = 2, Name = "Dell XPS 13", Description = "Sleek and powerful ultrabook with Intel Core i7 processor and stunning 4K display.", Price = 1299.99m },
                new Product { Id = 3, Name = "Apple MacBook Air", Description = "Lightweight and portable laptop with Apple M1 chip and long battery life.", Price = 999.99m },
                new Product { Id = 4, Name = "HP Spectre x360", Description = "Versatile 2-in-1 laptop with Intel Core i7 processor and vibrant touchscreen display.", Price = 1199.99m },
                new Product { Id = 5, Name = "Iphone 13 Pro", Description = "Latest Apple smartphone with A15 Bionic chip, ProMotion display, and advanced camera system.", Price = 999.99m },
                new Product { Id = 6, Name = "Samsung Galaxy S21", Description = "Flagship Android smartphone with powerful performance, stunning display, and versatile camera features.", Price = 799.99m },
                new Product { Id = 7, Name = "Google Pixel 6", Description = "Google's latest smartphone with Tensor chip, exceptional camera capabilities, and clean Android experience.", Price = 699.99m }
                );
        }

    }
}
