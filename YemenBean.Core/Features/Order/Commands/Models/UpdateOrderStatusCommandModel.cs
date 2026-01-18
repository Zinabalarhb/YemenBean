using MediatR;

namespace YemenBean.Core.Features.Orders.Commands.Models
{
    public class UpdateOrderStatusCommandModel : IRequest<int>
    {
        public int Id { get; set; }
        public string Status { get; set; } = null!;
    }
}
