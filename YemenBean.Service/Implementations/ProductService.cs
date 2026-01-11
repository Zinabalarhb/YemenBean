using YemenBean.Data.Entities;

using YemenBean.Service.Abstracts;
using YemenBean.Infrastructure.Repositories;
namespace YemenBean.Service.Implementations
{
    public class ProductService : IProductService
    {
        private readonly ProductRepository _repository;

        public ProductService(ProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }
    }
}
