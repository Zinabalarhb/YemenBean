namespace YemenBean.Core.Features.Products.Queries.Result
{
    public class ProductResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string DisplayName => $"{Name} - ${Price}";
    }
}
