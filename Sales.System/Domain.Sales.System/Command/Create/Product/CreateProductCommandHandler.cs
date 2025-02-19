using Domain.Sales.System.Interfaces.Services.Queries.Product;
using Domain.Sales.System.Enums.Products;
using Domain.Sales.System.Entities.Products;
using MediatR;

namespace Domain.Sales.System.Command.Create.Product
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, string>
    {
        private readonly IProductQueriesService _productQueriesService;
        public CreateProductCommandHandler(IProductQueriesService productQueriesService)
        {
            _productQueriesService = productQueriesService;
        }

        public async Task<string> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
                _productQueriesService.CreateProduct(
                    new ProductEntitie(
                        "teste",
                        ProductCategoryEnum.Beleza,
                        true,
                        20
                    )
                );

                return await Task.FromResult("sucesso");
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw;
            }
            
        }
    }
}
