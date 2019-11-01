namespace SalesOrder.Entities
{
    class OrderItem
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem() { }

        public OrderItem(int id, Product product, double quantity, double price)
        {
            Id = id;
            Product = product;
            Quantity = quantity;
            Price = price;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
