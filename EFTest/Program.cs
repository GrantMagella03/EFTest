using EFTest;
using System.Threading.Channels;

namespace EFTest {
    internal class Program {
        static void Main(string[] args) {
            var _dbContext = new AppDbContext();
            var orders = _dbContext.Orders.ToList();
            orders.ForEach(o => Console.WriteLine(o));
            var custOrders = from c in _dbContext.Customers
                             join o in _dbContext.Orders
                                on c.ID equals o.CustomerID
                             join ol in _dbContext.OrderLines
                                on o.ID equals ol.OrdersID
                             where c.ID == 1
                             select new {
                                 OrderDate = o.Date,
                                 o.Description,
                                 Customer = c.Name,
                                 ol.Product,
                                 ol.Quantity,
                                 ol.Price,
                                 LineTotal = ol.Quantity * ol.Price
                             };
            custOrders.ToList().ForEach(c => Console.WriteLine($"{c.OrderDate} | {c.Description} | {c.Customer} | {c.Product} | {c.Quantity}"));



            /*
            //var customers = from c in _dbContext.Customers.ToList() select c;
            //get all customers
            foreach( var c in _dbContext.Customers.ToList()) {
                Console.WriteLine(c);
            }
            //get by id
            Console.WriteLine(_dbContext.Customers.Find(1));
            //insert customer
            var NC = new Customer() {
                ID = 0, Code = "MAXTT", Name = "Max", City = "Mason", State = "OH", Active = true
            };
            //_dbContext.Customers.Add( NC );
            //_dbContext.SaveChanges();

            //update customer
            var UC =  _dbContext.Customers.Find(41);
            if(UC is null ) { return; }
            //UC.Code = "MXTEC";
            //_dbContext.Entry(UC).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dbContext.SaveChanges();
            //delete
            int id = 41;
            var DC = _dbContext.Customers.Find(id);
            if( DC is null ) { return; }
            _dbContext.Remove(DC);
            _dbContext.SaveChanges();
            */
        }
    }
}