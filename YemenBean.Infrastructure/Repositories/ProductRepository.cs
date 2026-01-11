using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using YemenBean.Data.Entities;
using YemenBean.Infrastructure.Context;

namespace YemenBean.Infrastructure.Repositories
{
    public class ProductRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _dbContext.Products.ToListAsync();
        }
    }
}
