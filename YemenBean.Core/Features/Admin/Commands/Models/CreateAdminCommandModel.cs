using MediatR;

namespace YemenBean.Core.Features.Admin.Commands.Models
{
    public class CreateAdminCommandModel : IRequest<int>
    {
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
