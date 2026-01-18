using MediatR;
using YemenBean.Core.Features.OrderItems.Queries.Models;
using YemenBean.Core.Features.OrderItems.Queries.Results;
using YemenBean.Infrastructure.Context;

namespace YemenBean.Core.Features.OrderItems.Queries.Handlers
{
    public class GetOrderItemByIdHandler : IRequestHandler<GetOrderItemByIdQuery, OrderItemResult>
    {
        private readonly ApplicationDbContext _context;

        public GetOrderItemByIdHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<OrderItemResult> Handle(GetOrderItemByIdQuery request, CancellationToken cancellationToken)
        {
            var item = await _context.OrderItems.FindAsync(request.Id);
            if (item == null) throw new Exception("OrderItem not found");

            return new OrderItemResult
            {
                Id = item.Id,
                OrderId = item.OrderId,
                ProductId = item.ProductId,
                ProductName = item.ProductName,
                Quantity = item.Quantity,
                Price = item.Price
            };
        }
    }
}
