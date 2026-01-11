
using MediatR;

namespace YemenBean.Core.Features.Products.Commands.Models
{
    public class ProductCommandModelCreate: IRequest<int>
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
