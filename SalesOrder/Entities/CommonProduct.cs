namespace SalesOrder.Entities
{
    class CommonProduct : Product
    {

        public CommonProduct() { }

        public CommonProduct(int id, string name, double price)
            : base(id, name, price) { }

    }
}
