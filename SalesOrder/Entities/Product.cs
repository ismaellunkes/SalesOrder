using System.Globalization;

namespace SalesOrder.Entities
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name + "  R$ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
