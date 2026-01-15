using ecommerce_uni.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace ecommerce_uni.Data
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasConversion<decimal>();

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "MacBook Pro 16 M4 Pro",
                    Description = "Ultimate professional laptop with Apple M4 Pro chip, 18GB unified memory, and Liquid Retina XDR display.",
                    Price = 2499.00m,
                    Category = 1,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 2,
                    Name = "Dell XPS 15 2025",
                    Description = "Premium Windows ultrabook featuring Intel Core Ultra 9, OLED InfinityEdge display, and NVIDIA RTX 4060.",
                    Price = 1899.99m,
                    Category = 1,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 3,
                    Name = "ASUS ROG Zephyrus G16",
                    Description = "Slim gaming powerhouse with AI-ready AMD Ryzen 9 processor and RTX 4080 graphics.",
                    Price = 2299.00m,
                    Category = 1,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 4,
                    Name = "Lenovo ThinkPad X1 Carbon Gen 13",
                    Description = "The gold standard for business laptops. Ultra-light carbon fiber chassis with all-day battery life.",
                    Price = 1649.50m,
                    Category = 1,
                    IsAvailable = false
                },
                new Product
                {
                    Id = 5,
                    Name = "HP Spectre x360 16",
                    Description = "Versatile 2-in-1 convertible with 3K+ OLED touchscreen and AI-enhanced webcam for professionals.",
                    Price = 1399.99m,
                    Category = 1,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 6,
                    Name = "Samsung Galaxy S25 Ultra",
                    Description = "Top-tier Android flagship with Snapdragon 8 Elite, 200MP camera, and built-in S Pen.",
                    Price = 1299.99m,
                    Category = 2,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 7,
                    Name = "iPhone 16 Pro Max",
                    Description = "Apple's most powerful iPhone with A18 Pro chip, titanium design, and advanced 5x telephoto camera.",
                    Price = 1199.00m,
                    Category = 2,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 8,
                    Name = "Google Pixel 10 Pro",
                    Description = "The smartest smartphone with next-gen Gemini AI, Tensor G5 chip, and best-in-class computational photography.",
                    Price = 999.00m,
                    Category = 2,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 9,
                    Name = "OnePlus 13",
                    Description = "Flagship killer performance with Snapdragon 8 Gen 4, 100W SuperVOOC charging, and Hasselblad camera system.",
                    Price = 799.99m,
                    Category = 2,
                    IsAvailable = false
                },
                new Product
                {
                    Id = 10,
                    Name = "Xiaomi 15 Ultra",
                    Description = "Photography monster with Leica optics, 1-inch main sensor, and premium ceramic back.",
                    Price = 1099.00m,
                    Category = 2,
                    IsAvailable = true
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Laptops"
                },
                new Category
                {
                    Id = 2,
                    Name = "Smartphones"
                }
            );
        }
    }
}
