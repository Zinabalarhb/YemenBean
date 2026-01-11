
using Microsoft.EntityFrameworkCore;
using YemenBean.Data.Entities;

namespace YemenBean.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products => Set<Product>();
    }
}
