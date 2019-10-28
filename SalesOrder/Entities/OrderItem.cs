using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrder.Entities
{
    class OrderItem
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
        public double Quantity { get; set; }
        public double Total { get; set; }
    }
}
