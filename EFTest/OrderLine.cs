﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest {
    internal class OrderLine {
        public int Id { get; set; }
        public string Product { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int OrdersID { get; set; }
    }
}
