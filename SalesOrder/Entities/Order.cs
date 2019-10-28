using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesOrder.Entities.Enums;

namespace SalesOrder.Entities
{   
    class Order
    {
        public int id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Customer Costumer { get; set; }        

        public override string ToString()
        {
            return id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }   
}
