using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesOrder.Entities.Enums;

namespace SalesOrder.Entities
{
    class Address
    {
        public int Id { get; set; }
        public string LineAdress1 { get; set; }
        public string LineAdress2 { get; set; }
        public Country Country { get; set; }

        public override string ToString()
        {
            return Id
                + LineAdress1
                + ", " + LineAdress2
                + ", " + Country;              
        }
    }
}
