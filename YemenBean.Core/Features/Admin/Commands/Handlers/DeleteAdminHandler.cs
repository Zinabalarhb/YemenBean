using MediatR;
using YemenBean.Core.Features.Admin.Commands.Models;
using YemenBean.Infrastructure.Context;

namespace YemenBean.Core.Features.Admin.Commands.Handlers
{
    public class DeleteAdminHandler : IRequestHandler<DeleteAdminCommandModel,int>
    {
        private readonly ApplicationDbContext _context;

        public DeleteAdminHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        async Task<int> IRequestHandler<DeleteAdminCommandModel, int>.Handle(DeleteAdminCommandModel request, CancellationToken cancellationToken)
        {
            var admin = await _context.Admins.FindAsync(request.Id);
            if (admin == null) throw new Exception("Admin not found");

            _context.Admins.Remove(admin);
            return await _context.SaveChangesAsync();
        }
    }
}
