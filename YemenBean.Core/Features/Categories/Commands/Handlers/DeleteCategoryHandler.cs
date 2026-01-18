using MediatR;
using YemenBean.Core.Features.Categories.Commands.Models;
using YemenBean.Infrastructure.Context;

namespace YemenBean.Core.Features.Categories.Commands.Handlers
{
    public class DeleteCategoryHandler : IRequestHandler<DeleteCategoryCommandModel,int>
    {
        private readonly ApplicationDbContext _context;

        public DeleteCategoryHandler(ApplicationDbContext context)
        {
            _context = context;
        }



        async Task<int> IRequestHandler<DeleteCategoryCommandModel, int>.Handle(DeleteCategoryCommandModel request, CancellationToken cancellationToken)
        {
            var category = await _context.Categories.FindAsync(request.Id);
            if(category == null) throw new Exception("Category not found");

            _context.Categories.Remove(category);
           return await _context.SaveChangesAsync();

           
        }
    }
}
