namespace YemenBean.Core.Features.OrderItems.Queries.Results
{
    public class OrderItemResult
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
