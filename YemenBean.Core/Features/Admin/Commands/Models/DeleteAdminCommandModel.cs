using MediatR;

namespace YemenBean.Core.Features.Admin.Commands.Models
{
    public class DeleteAdminCommandModel : IRequest<int>
    {
        public int Id { get; set; }
    }
}
