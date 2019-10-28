using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesOrder.Entities;
using SalesOrder.Entities.Enums;

namespace SalesOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                id = 1839,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
            Console.Read();


        }
    }
}

