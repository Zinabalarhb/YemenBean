
using MediatR;

namespace YemenBean.Core.Features.Products.Commands.Models
{
    public class ProductCommandModelUpdate : IRequest<bool>
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
