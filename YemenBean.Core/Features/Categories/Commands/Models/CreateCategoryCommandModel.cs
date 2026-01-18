using MediatR;

namespace YemenBean.Core.Features.Categories.Commands.Models
{
    public class CreateCategoryCommandModel : IRequest<int>
    {
        public string Name { get; set; } = null!;
    }
}
