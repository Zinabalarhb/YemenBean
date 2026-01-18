using MediatR;

namespace YemenBean.Core.Features.Admin.Commands.Models
{
    public class UpdateAdminCommandModel : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
