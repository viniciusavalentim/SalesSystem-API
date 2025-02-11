using MediatR;
using Newtonsoft.Json;

namespace Domain.Command.Create.Product
{
    public class CreateProductCommand : IRequest<string>
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("isAvailable")]
        public bool IsAvailable { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }
    }
}
