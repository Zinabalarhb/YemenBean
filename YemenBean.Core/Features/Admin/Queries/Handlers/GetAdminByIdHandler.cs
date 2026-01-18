using MediatR;
using YemenBean.Core.Features.Admin.Queries.Models;
using YemenBean.Core.Features.Admin.Queries.Results;
using YemenBean.Infrastructure.Context;

namespace YemenBean.Core.Features.Admin.Queries.Handlers
{
    public class GetAdminByIdHandler : IRequestHandler<GetAdminByIdQuery, AdminResult>
    {
        private readonly ApplicationDbContext _context;

        public GetAdminByIdHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<AdminResult> Handle(GetAdminByIdQuery request, CancellationToken cancellationToken)
        {
            var admin = await _context.Admins.FindAsync(request.Id);
            if (admin == null) throw new Exception("Admin not found");

            return new AdminResult { Id = admin.Id, Name = admin.Name, Email = admin.Email };
        }
    }
}
