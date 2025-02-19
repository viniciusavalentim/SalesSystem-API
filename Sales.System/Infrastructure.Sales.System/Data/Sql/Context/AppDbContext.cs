using Microsoft.EntityFrameworkCore;
using Domain.Sales.System.Entities.Products;

namespace Infrastructure.Sales.System.Data.Sql.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ProductEntitie> ProductsTable { get; set; }
    }
}
