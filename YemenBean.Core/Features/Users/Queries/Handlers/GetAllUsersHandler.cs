using MediatR;
using Microsoft.EntityFrameworkCore;
using YemenBean.Core.Features.Users.Queries.Models;
using YemenBean.Core.Features.Users.Queries.Results;
using YemenBean.Infrastructure.Context;

namespace YemenBean.Core.Features.Users.Queries.Handlers
{
    public class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, List<UserResult>>
    {
        private readonly ApplicationDbContext _context;

        public GetAllUsersHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<UserResult>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            return await _context.Users
                .Select(u => new UserResult
                {
                    Id = u.Id,
                    Name = u.Name,
                    Email = u.Email,
                    Phone = u.Phone,
                    CreatedAt = u.CreatedAt
                })
                .ToListAsync();
        }
    }
}
