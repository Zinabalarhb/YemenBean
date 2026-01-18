using MediatR;
using YemenBean.Core.Features.Users.Queries.Results;

namespace YemenBean.Core.Features.Users.Queries.Models
{
    public class GetAllUsersQuery : IRequest<List<UserResult>>
    {
    }
}
