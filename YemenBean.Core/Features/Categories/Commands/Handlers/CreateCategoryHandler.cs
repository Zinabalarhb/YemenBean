using MediatR;
using YemenBean.Core.Features.Categories.Commands.Models;
using YemenBean.Data.Entities;
using YemenBean.Infrastructure.Context;

namespace YemenBean.Core.Features.Categories.Commands.Handlers
{
    public class CreateCategoryHandler : IRequestHandler<CreateCategoryCommandModel, int>
    {
        private readonly ApplicationDbContext _context;

        public CreateCategoryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateCategoryCommandModel request, CancellationToken cancellationToken)
        {
            var category = new Category { Name = request.Name };
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return category.Id;
        }
    }
}
