using Microsoft.AspNetCore.Mvc;

namespace Sales.System.Controllers.Products
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet("available")] //endpoint para trazer produtos disponiveis
        public void getAvailableProducts()
        {
            //buscar produtos cadastrados no banco que tenham o status como available (um enum?)
        }
    }
}
