using MediatR;
using YemenBean.Core.Features.Categories.Commands.Models;
using YemenBean.Infrastructure.Context;

namespace YemenBean.Core.Features.Categories.Commands.Handlers
{
    public class UpdateCategoryHandler : IRequestHandler<UpdateCategoryCommandModel,int>
    {
        private readonly ApplicationDbContext _context;

        public UpdateCategoryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdateCategoryCommandModel request, CancellationToken cancellationToken)
        {
            var category = await _context.Categories.FindAsync(request.Id);
            if (category == null) throw new Exception("Category not found");

            category.Name = request.Name;
           return  await _context.SaveChangesAsync();

            
        }
    }
}

