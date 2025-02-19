using Domain.Sales.System.Entities.Products;

namespace Domain.Sales.System.Queries.Products.Get
{
    public class GetProductsQueryResponse
    {
        public IEnumerable<ProductEntitie>? Products { get; set; } 
    }
}
