using Domain.Sales.System.Interfaces.Services.Queries.Product;
using MediatR;

namespace Domain.Sales.System.Queries.Products.Get
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQueryRequest, GetProductsQueryResponse>
    {
        private readonly IProductQueriesService _productQueriesService;
        public GetProductsQueryHandler(IProductQueriesService productQueriesService)
        {
            _productQueriesService = productQueriesService;
        }
        public async Task<GetProductsQueryResponse> Handle(GetProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var response = new GetProductsQueryResponse();
            response.Products = await _productQueriesService.GetAllProductsAsync();
            return response;
        }
    }
}
