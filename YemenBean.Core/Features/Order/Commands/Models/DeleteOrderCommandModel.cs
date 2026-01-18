using MediatR;

namespace YemenBean.Core.Features.Orders.Commands.Models
{
    public class DeleteOrderCommandModel : IRequest<int>
    {
        public int Id { get; set; }
    }
}
