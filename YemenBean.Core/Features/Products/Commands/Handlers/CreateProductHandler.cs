
using MediatR;
using YemenBean.Core.Features.Products.Commands.Models;
using YemenBean.Data.Entities;
using YemenBean.Infrastructure.Context;

namespace YemenBean.Core.Features.Products.Commands.Handlers
{
    public class CreateProductHandler : IRequestHandler<ProductCommandModelCreate, int>
    {
        private readonly ApplicationDbContext _dbContext;

        public CreateProductHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(ProductCommandModelCreate request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Name = request.Name,
                Price = request.Price,
                ImageUrl = request.ImageUrl
            };

            _dbContext.Products.Add(product);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return product.Id;
        }
    }
}
