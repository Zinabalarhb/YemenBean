using MediatR;
using Microsoft.EntityFrameworkCore;
using YemenBean.Core.Features.Admin.Queries.Models;
using YemenBean.Core.Features.Admin.Queries.Results;
using YemenBean.Infrastructure.Context;

namespace YemenBean.Core.Features.Admin.Queries.Handlers
{
    public class GetAllAdminsHandler : IRequestHandler<GetAllAdminsQuery, List<AdminResult>>
    {
        private readonly ApplicationDbContext _context;

        public GetAllAdminsHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<AdminResult>> Handle(GetAllAdminsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Admins
                .Select(a => new AdminResult { Id = a.Id, Name = a.Name, Email = a.Email })
                .ToListAsync();
        }
    }
}
