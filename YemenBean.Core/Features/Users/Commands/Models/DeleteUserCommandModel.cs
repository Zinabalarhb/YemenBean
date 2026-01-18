using MediatR;

namespace YemenBean.Core.Features.Users.Commands.Models
{
    public class DeleteUserCommandModel : IRequest<int>
    {
        public int Id { get; set; }
    }
}
