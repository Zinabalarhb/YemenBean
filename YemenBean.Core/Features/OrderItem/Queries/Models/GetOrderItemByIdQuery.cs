using MediatR;
using YemenBean.Core.Features.OrderItems.Queries.Results;

namespace YemenBean.Core.Features.OrderItems.Queries.Models
{
    public class GetOrderItemByIdQuery : IRequest<OrderItemResult>
    {
        public int Id { get; set; }
    }
}
