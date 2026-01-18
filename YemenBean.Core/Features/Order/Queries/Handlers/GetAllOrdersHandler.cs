using MediatR;
using Microsoft.EntityFrameworkCore;
using YemenBean.Infrastructure.Context;
using YemenBean.Core.Features.Orders.Queries.Results;
using YemenBean.Core.Features.Order.Queries.Models;

namespace YemenBean.Core.Features.Orders.Queries.Handlers
{
    public class GetAllOrdersHandler : IRequestHandler<GetAllOrdersQuery, List<OrderResult>>
    {
        private readonly ApplicationDbContext _context;

        public GetAllOrdersHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<OrderResult>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            return await _context.Orders
                .Select(o => new OrderResult
                {
                    Id = o.Id,
                    CustomerName = o.CustomerName,
                    Phone = o.Phone,
                    City = o.City,
                    Total = o.Total,
                    Status = o.Status,
                    CreatedAt = o.CreatedAt
                })
                .ToListAsync();
        }
    }
}
