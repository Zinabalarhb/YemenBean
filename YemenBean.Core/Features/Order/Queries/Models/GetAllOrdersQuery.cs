using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using YemenBean.Core.Features.Orders.Queries.Results;

namespace YemenBean.Core.Features.Order.Queries.Models
{
    public class GetAllOrdersQuery:IRequest<List<OrderResult>>
    {
    }
}
