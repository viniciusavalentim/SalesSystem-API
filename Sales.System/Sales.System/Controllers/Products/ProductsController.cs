using Domain.Sales.System.Command.Create.Product;
using Domain.Sales.System.Entities.Products;
using Domain.Sales.System.Queries.Products.Get;
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


        [HttpGet("get")] 
        public async Task<GetProductsQueryResponse> GetProducts()
        {
            return await _mediator.Send(new GetProductsQueryRequest());
        }

        [HttpPost("create")]
        public async Task<string> CreateProductsAsync(CreateProductCommand request)
        {
            try
            {
                return await _mediator.Send(request);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw;
            }          
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
        public void ChangeProductStatus([FromBody] ProductEntitie request)
        {

        }
    }
}
