using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
