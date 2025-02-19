using Domain.Sales.System.Entities.Products;
using Domain.Sales.System.Interfaces.Services.Queries.Product;
using Domain.Sales.System.Models.Base;
using Infrastructure.Sales.System.Data.Sql.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Sales.System.Data.Sql.Queries
{
    public class ProductQueriesService : IProductQueriesService
    {
        private readonly AppDbContext _context;

        public ProductQueriesService(
            AppDbContext context
        )
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductEntitie>> GetAllProductsAsync()
        { 
            var response = new ResponseBase<IEnumerable<ProductEntitie>>();

            try
            {               
                response.Data = await _context.ProductsTable.ToListAsync();

                return response.Data;
            }
            catch (Exception ex)
            {
                response.Messages = ex.Message;
                response.Status = false;
                throw;
            }
        }

        public bool CreateProduct(ProductEntitie request)
        {
            try
            {
                _context.ProductsTable.Add(request);
                _context.SaveChanges();
                return true;
                
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
