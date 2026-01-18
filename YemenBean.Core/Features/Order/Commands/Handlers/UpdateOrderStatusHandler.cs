using MediatR;
using YemenBean.Core.Features.Orders.Commands.Models;
using YemenBean.Infrastructure.Context;

namespace YemenBean.Core.Features.Orders.Commands.Handlers
{
    public class UpdateOrderStatusHandler : IRequestHandler<UpdateOrderStatusCommandModel,int>
    {
        private readonly ApplicationDbContext _context;

        public UpdateOrderStatusHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdateOrderStatusCommandModel request, CancellationToken cancellationToken)
        {
            var order = await _context.Orders.FindAsync(request.Id);
            if (order == null) throw new Exception("Order not found");

            order.Status = request.Status;
            return await _context.SaveChangesAsync();

           
        }
    }
}
