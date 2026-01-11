using MediatR;
using YemenBean.Core.Features.Products.Queries.Result;
using System.Collections.Generic;

namespace YemenBean.Core.Features.Products.Queries
{
    public class GetAllProductsQuery : IRequest<List<ProductResult>> { }
}
