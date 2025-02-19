using Domain.Sales.System.Enums.Products;
using MediatR;
using Newtonsoft.Json;

namespace Domain.Sales.System.Command.Create.Product
{
    public class CreateProductCommand : IRequest<string>
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public ProductCategoryEnum Category { get; set; }

        [JsonProperty("isAvailable")]
        public bool IsAvailable { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }
    }
}
