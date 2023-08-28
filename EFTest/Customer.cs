using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest {
    public class Customer { // needs to be public
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public decimal Sales { get; set; }
        public bool Active { get; set; }
        public string? Code { get; set; }
        public override string ToString() {
            return $"{Name}";
        }
    }
}
