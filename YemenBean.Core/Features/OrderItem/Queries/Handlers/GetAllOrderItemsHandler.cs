using MediatR;
using Microsoft.EntityFrameworkCore;
using YemenBean.Core.Features.OrderItems.Queries.Models;
using YemenBean.Core.Features.OrderItems.Queries.Results;
using YemenBean.Infrastructure.Context;

namespace YemenBean.Core.Features.OrderItems.Queries.Handlers
{
    public class GetAllOrderItemsHandler : IRequestHandler<GetAllOrderItemsQuery, List<OrderItemResult>>
    {
        private readonly ApplicationDbContext _context;

        public GetAllOrderItemsHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<OrderItemResult>> Handle(GetAllOrderItemsQuery request, CancellationToken cancellationToken)
        {
            return await _context.OrderItems
                .Select(i => new OrderItemResult
                {
                    Id = i.Id,
                    OrderId = i.OrderId,
                    ProductId = i.ProductId,
                    ProductName = i.ProductName,
                    Quantity = i.Quantity,
                    Price = i.Price
                })
                .ToListAsync();
        }
    }
}
