using MediatR;
using YemenBean.Core.Features.Admin.Commands.Models;
using YemenBean.Infrastructure.Context;

namespace YemenBean.Core.Features.Admin.Commands.Handlers
{
    public class UpdateAdminHandler : IRequestHandler<UpdateAdminCommandModel,int>
    {
        private readonly ApplicationDbContext _context;

        public UpdateAdminHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdateAdminCommandModel request, CancellationToken cancellationToken)
        {
            var admin = await _context.Admins.FindAsync(request.Id);
            if (admin == null) throw new Exception("Admin not found");

            admin.Name = request.Name;
            admin.Email = request.Email;

             return await _context.SaveChangesAsync();
           
           
        }

     
    }
}
