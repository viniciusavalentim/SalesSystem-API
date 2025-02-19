using Domain.Sales.System.Entities.Products;

namespace Domain.Sales.System.Interfaces.Services.Queries.Product
{
    public interface IProductQueriesService
    {
        Task<IEnumerable<ProductEntitie>> GetAllProductsAsync();
        public bool CreateProduct(ProductEntitie request);
    }
}
