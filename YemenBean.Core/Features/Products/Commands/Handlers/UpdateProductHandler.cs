using MediatR;
using Microsoft.EntityFrameworkCore;
using YemenBean.Infrastructure.Context;
using YemenBean.Data.Entities;
using YemenBean.Core.Features.Products.Commands.Models;

namespace YemenBean.Core.Features.Products.Commands.Handlers
{
    public class UpdateProductHandler : IRequestHandler<ProductCommandModelUpdate, bool>
    {
        private readonly ApplicationDbContext _dbContext;

        public UpdateProductHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(ProductCommandModelUpdate request, CancellationToken cancellationToken)
        {
            var product = await _dbContext.Products.FirstOrDefaultAsync(p => p.Id == request.Id, cancellationToken);
            if (product == null) return false;

            product.Name = request.Name;
            product.Price = request.Price;
            product.ImageUrl = request.ImageUrl;

            await _dbContext.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
