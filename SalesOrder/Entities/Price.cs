using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrder.Entities
{
    class Price
    {
        public int Id { get; set; }
        public double ProductPrice { get; set; }
        public double MaximumDiscount { get; set; }
        public Product Product { get; set; }
        public DateTime StartValidity { get; set; }
        public DateTime FinishValidity { get; set; }
    }
}
