using System;

namespace SalesOrder.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(int id, string name, double price, DateTime manufactureDate)
            : base(id, name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return base.PriceTag().Replace("  R$ ", " (used)  R$ ") + " (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
