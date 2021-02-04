﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Code_First.Entities
{
    public class Order
    {
        public int OrderID { get; set; }

        public string CustomerID { get; set; }

        public string ShipCity { get; set; }

        public string ShipCountry { get; set; }

        public DateTime OrderDate { get; set; }

        public Customer Customer { get; set; }
    }
}
