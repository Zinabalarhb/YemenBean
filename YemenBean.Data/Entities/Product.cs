using System;
using YemenBean.Data.Entities;

namespace YemenBean.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public string ImageUrl { get; set; } = null!;

        public string? Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // ===== Category Relation =====
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}