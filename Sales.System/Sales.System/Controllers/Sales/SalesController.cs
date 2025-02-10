using Microsoft.AspNetCore.Mvc;

namespace Sales.System.Controllers.Sales
{
    [Route("api/sales")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        [HttpGet()] //endpoint para retornar as vendas feitas?
        public string Get()
        {
            return "oi";
        }
    }
}
