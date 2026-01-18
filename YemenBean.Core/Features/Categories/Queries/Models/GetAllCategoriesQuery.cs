using MediatR;
using YemenBean.Core.Features.Categories.Queries.Results;

namespace YemenBean.Core.Features.Categories.Queries.Models
{
    public class GetAllCategoriesQuery:IRequest<List<CategoryResult>>
    {
    }
}
