using MediatR;
using YemenBean.Core.Features.Orders.Queries.Results;

namespace YemenBean.Core.Features.Orders.Queries.Models
{
    public class GetOrderByIdQuery : IRequest<OrderResult>
    {
        public int Id { get; set; }
    }
}
