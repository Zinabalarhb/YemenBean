using MediatR;
using YemenBean.Core.Features.Users.Queries.Models;
using YemenBean.Core.Features.Users.Queries.Results;
using YemenBean.Infrastructure.Context;

namespace YemenBean.Core.Features.Users.Queries.Handlers
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, UserResult>
    {
        private readonly ApplicationDbContext _context;

        public GetUserByIdHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<UserResult> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _context.Users.FindAsync(request.Id);
            if (user == null) throw new Exception("User not found");

            return new UserResult
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Phone = user.Phone,
                CreatedAt = user.CreatedAt
            };
        }
    }
}
