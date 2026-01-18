using MediatR;
using YemenBean.Core.Features.Users.Commands.Models;
using YemenBean.Infrastructure.Context;

namespace YemenBean.Core.Features.Users.Commands.Handlers
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommandModel,int>
    {
        private readonly ApplicationDbContext _context;

        public DeleteUserHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeleteUserCommandModel request, CancellationToken cancellationToken)
        {
            var user = await _context.Users.FindAsync(request.Id);
            if (user == null) throw new Exception("User not found");

            _context.Users.Remove(user);
           return await _context.SaveChangesAsync();
        }
    }
}
