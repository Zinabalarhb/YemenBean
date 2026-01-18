using MediatR;
using YemenBean.Core.Features.Admin.Commands.Models;
using YemenBean.Infrastructure.Context;

namespace YemenBean.Core.Features.Admin.Commands.Handlers
{
    public class CreateAdminHandler : IRequestHandler<CreateAdminCommandModel, int>
    {
        private readonly ApplicationDbContext _context;

        public CreateAdminHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateAdminCommandModel request, CancellationToken cancellationToken)
        {
            var admin = new YemenBean.Data.Entities.Admin
            {
                Name = request.Name,
                Email = request.Email,
                //PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password),
                CreatedAt = DateTime.UtcNow
            };

            _context.Admins.Add(admin);
            await _context.SaveChangesAsync();

            return admin.Id;
        }
    }
}
