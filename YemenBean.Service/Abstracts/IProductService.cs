using YemenBean.Data.Entities;

namespace YemenBean.Service.Abstracts
{
    public interface IProductService
    {
        Task<List<Product>> GetAllAsync();
    }
}
