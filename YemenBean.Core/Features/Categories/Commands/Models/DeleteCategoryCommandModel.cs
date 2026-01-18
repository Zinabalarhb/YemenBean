using MediatR;

namespace YemenBean.Core.Features.Categories.Commands.Models
{
    public class DeleteCategoryCommandModel : IRequest<int>
    {
        public int Id { get; set; }
    }
}
