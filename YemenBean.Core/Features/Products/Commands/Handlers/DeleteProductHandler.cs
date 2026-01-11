

using MediatR;
using Microsoft.EntityFrameworkCore;
using YemenBean.Core.Features.Products.Commands.Models;
using YemenBean.Infrastructure.Context;

namespace YemenBean.Core.Features.Products.Commands.Handlers
{
    public class DeleteProductHandler : IRequestHandler<ProductCommandModelDelete, bool>
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteProductHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(ProductCommandModelDelete request, CancellationToken cancellationToken)
        {
            var product = await _dbContext.Products.FirstOrDefaultAsync(p => p.Id == request.Id, cancellationToken);
            if (product == null) return false;

            _dbContext.Products.Remove(product);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
