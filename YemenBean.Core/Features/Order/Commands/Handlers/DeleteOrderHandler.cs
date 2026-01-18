using MediatR;
using YemenBean.Core.Features.Orders.Commands.Models;
using YemenBean.Infrastructure.Context;

namespace YemenBean.Core.Features.Order.Commands.Handlers
{
    public class DeleteOrderHandler : IRequestHandler<DeleteOrderCommandModel,int>
    {
        private readonly ApplicationDbContext _context;

        public DeleteOrderHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeleteOrderCommandModel request, CancellationToken cancellationToken)
        {
            var order = await _context.Orders.FindAsync(request.Id);
            if (order == null) throw new Exception("Order not found");

            _context.Orders.Remove(order);
           return  await _context.SaveChangesAsync();
           
        }
    }
}
