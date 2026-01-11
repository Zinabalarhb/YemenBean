
using Microsoft.EntityFrameworkCore;
using YemenBean.Infrastructure.Context;
using YemenBean.Core.Features.Products.Queries.Result;
using MediatR;

namespace YemenBean.Core.Features.Products.Queries.Handlers
{
    public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, List<ProductResult>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetAllProductsHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ProductResult>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Products
                .Select(p => new ProductResult
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    ImageUrl = p.ImageUrl
                })
                .ToListAsync(cancellationToken);
        }
    }
}
