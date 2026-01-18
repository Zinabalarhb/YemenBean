using MediatR;
using YemenBean.Core.Features.OrderItem.Commands.Models;
using YemenBean.Infrastructure.Context;

namespace YemenBean.Core.Features.OrderItem.Commands.Handlers
{
    public class DeleteOrderItemHandler : IRequestHandler<DeleteOrderItemCommandModel,int>
    {
        private readonly ApplicationDbContext _context;

        public DeleteOrderItemHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeleteOrderItemCommandModel request, CancellationToken cancellationToken)
        {
            var item = await _context.OrderItems.FindAsync(request.Id);
            if (item == null) throw new Exception("OrderItem not found");

            _context.OrderItems.Remove(item);
            return await _context.SaveChangesAsync();
            
        }
    }
}
