using MediatR;
using YemenBean.Core.Features.OrderItems.Queries.Results;

namespace YemenBean.Core.Features.OrderItems.Queries.Models
{
    public class GetAllOrderItemsQuery : IRequest<List<OrderItemResult>>
    {
    }
}
