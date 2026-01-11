
using MediatR;
using YemenBean.Core.Features.Products.Queries.Result;

namespace YemenBean.Core.Features.Products.Queries
{
    public class GetProductByIdQuery : IRequest<ProductResult>
    {
        public int Id { get; set; }
        public GetProductByIdQuery(int id) => Id = id;
    }
}
