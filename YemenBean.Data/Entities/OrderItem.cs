using System;
using System.Collections.Generic;
using System.Text;

namespace YemenBean.Data.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;

        public int ProductId { get; set; }

        public string ProductName { get; set; } = null!;

        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}