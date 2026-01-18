using MediatR;
using YemenBean.Core.Features.Categories.Queries.Results;

namespace YemenBean.Core.Features.Categories.Queries.Models
{
    public class GetCategoryByIdQuery : IRequest<CategoryResult>
    {
        public int Id { get; set; }
    }
}
