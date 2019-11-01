using System.Globalization;

namespace SalesOrder.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(int id, string name, double price, double customsFee)
            : base(id, name, price)
        {
            this.CustomsFee = customsFee;
        }

        /* Implementar um acréscimo do valor alfandegário + 10% */
        public double TotalPrice()
        {
            return Price + (1.1 * CustomsFee);
        }

        public override string PriceTag()
        {
            return Name + " " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Customs fee: R$ " + CustomsFee + ")";
        }
    }
}
