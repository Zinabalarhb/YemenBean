using MediatR;
using YemenBean.Core.Features.Admin.Queries.Results;

namespace YemenBean.Core.Features.Admin.Queries.Models
{
    public class GetAllAdminsQuery : IRequest<List<AdminResult>>
    {
    }
}
