namespace ecommerce_uni.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? Category { get; set; } // Для фильтра по категории
        public bool IsAvailable { get; set; } // Для фильтра "в наличии"
    }
}