using MediatR;
using YemenBean.Core.Features.Orders.Queries.Models;
using YemenBean.Core.Features.Orders.Queries.Results;
using YemenBean.Infrastructure.Context;

namespace YemenBean.Core.Features.Orders.Queries.Handlers
{
    public class GetOrderByIdHandler : IRequestHandler<GetOrderByIdQuery, OrderResult>
    {
        private readonly ApplicationDbContext _context;

        public GetOrderByIdHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<OrderResult> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            var order = await _context.Orders.FindAsync(request.Id);
            if (order == null) throw new Exception("Order not found");

            return new OrderResult
            {
                Id = order.Id,
                CustomerName = order.CustomerName,
                Phone = order.Phone,
                City = order.City,
                Total = order.Total,
                Status = order.Status,
                CreatedAt = order.CreatedAt
            };
        }
    }
}
