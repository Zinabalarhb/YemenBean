namespace YemenBean.Core.Features.Orders.Queries.Results
{
    public class OrderResult
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string City { get; set; } = null!;
        public decimal Total { get; set; }
        public string Status { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
    }
}
