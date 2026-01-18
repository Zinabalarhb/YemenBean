using MediatR;

namespace YemenBean.Core.Features.OrderItem.Commands.Models
{
    public class DeleteOrderItemCommandModel : IRequest<int>
    {
        public int Id { get; set; }
    }
}
