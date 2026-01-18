using MediatR;
using YemenBean.Core.Features.Users.Queries.Results;

namespace YemenBean.Core.Features.Users.Queries.Models
{
    public class GetUserByIdQuery : IRequest<UserResult>
    {
        public int Id { get; set; }
    }
}
