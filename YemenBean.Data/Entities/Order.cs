using System;
using System.Collections.Generic;
using System.Text;

namespace YemenBean.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public string CustomerName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string City { get; set; } = null!;

        public decimal Total { get; set; }

        public string Status { get; set; } = "جديد";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // مهم جداً: تهيئة المجموعة لتجنب NullReference
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
