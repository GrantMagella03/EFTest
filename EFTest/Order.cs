using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest {
    public class Order { // needs to be public
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public int CustomerID { get; set; }
        public override string ToString() {
            return $"{ID}|{Date}|{CustomerID}|{Description}";
        }
    }
}
