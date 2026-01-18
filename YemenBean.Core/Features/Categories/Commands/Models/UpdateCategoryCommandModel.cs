using MediatR;

namespace YemenBean.Core.Features.Categories.Commands.Models
{
    public class UpdateCategoryCommandModel : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
