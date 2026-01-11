
using Microsoft.EntityFrameworkCore;
using YemenBean.Infrastructure.Context;
using YemenBean.Core.Features.Products.Queries.Result;
using MediatR;

namespace YemenBean.Core.Features.Products.Queries.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, ProductResult>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetProductByIdHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ProductResult> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Products
                .Where(p => p.Id == request.Id)
                .Select(p => new ProductResult
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    ImageUrl = p.ImageUrl
                })
                .FirstOrDefaultAsync(cancellationToken);
        }
    }
}
