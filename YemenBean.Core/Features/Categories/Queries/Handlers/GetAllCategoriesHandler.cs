using MediatR;
using Microsoft.EntityFrameworkCore;
using YemenBean.Core.Features.Categories.Queries.Models;
using YemenBean.Core.Features.Categories.Queries.Results;
using YemenBean.Infrastructure.Context;

namespace YemenBean.Core.Features.Categories.Queries.Handlers
{
    public class GetAllCategoriesHandler : IRequestHandler<GetAllCategoriesQuery, List<CategoryResult>>
    {
        private readonly ApplicationDbContext _context;

        public GetAllCategoriesHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryResult>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            return await _context.Categories
                .Select(c => new CategoryResult { Id = c.Id, Name = c.Name }).ToListAsync();
               
        }
    }
}
