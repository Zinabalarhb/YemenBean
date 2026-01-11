
using MediatR;

namespace YemenBean.Core.Features.Products.Commands.Models
{
    public class ProductCommandModelDelete : IRequest<bool>
    {
        public int Id { get; set; }

    }
}
