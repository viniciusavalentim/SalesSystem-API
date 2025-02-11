namespace Domain.Models.Products
{
    public class Product
    {
        public Product(string name, int code, bool available, double price)
        {
            Name = name;
            Code = code;
            Available = available;
            Price = price;
        }

        public string Name { get; set; }
        public int Code { get; set; }
        public bool Available { get; set; }
        public double Price { get; set; }
 
    }
}
