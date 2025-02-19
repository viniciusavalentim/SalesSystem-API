using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Sales.System.Queries.Products.Get
{
    public class GetProductsQueryRequest : IRequest<GetProductsQueryResponse>
    {
    }
}
