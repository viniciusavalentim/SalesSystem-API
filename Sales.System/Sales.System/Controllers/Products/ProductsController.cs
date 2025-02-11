using Domain.Command.Create.Product;
using Domain.Models.Products;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Sales.System.Controllers.Products
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("available")] //endpoint para trazer produtos disponiveis
        public IEnumerable<Product> getAvailableProducts()
        {

            var products = new List<Product>
            {
                new ("perfuminho", 1, true, 50),
                new ("batonzinho", 2, true, 10),
                new ("blusinha", 3, true, 30),
                new("sapatinho", 4, true, 80)
            };
            return products;
            //buscar produtos cadastrados no banco que tenham o status como available (um enum?)
        }

        [HttpPost("create")]
        public void CreateProducts([FromBody] CreateProductCommand request)
        {
            _mediator.Send(request);
        }

        [HttpDelete("delete/{id}")]
        public void DeleteProduct(string id)
        {

        }

        [HttpPatch("change-status/{id}")]
        public void ChangeProductStatus(string id)
        {

        }

        [HttpPut("alter/{id}")]
        public void ChangeProductStatus([FromBody] Product request)
        {

        }
    }
}
