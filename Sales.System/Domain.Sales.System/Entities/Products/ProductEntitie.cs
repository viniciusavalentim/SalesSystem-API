using Domain.Sales.System.Enums.Products;
using Newtonsoft.Json;

namespace Domain.Sales.System.Entities.Products
{
    public class ProductEntitie
    {
        public ProductEntitie(
            string name, 
            ProductCategoryEnum categoryEnum, 
            bool available, 
            double price
        )
        {
            Name = name;
            CategoryEnum = categoryEnum;
            Available = available;
            Price = price;
        }

        [JsonIgnore]
        public int Id { get; set; }
        public string Name { get; set; }
        public ProductCategoryEnum CategoryEnum { get; set; }
        public bool Available { get; set; }
        public double Price { get; set; }
    }
}