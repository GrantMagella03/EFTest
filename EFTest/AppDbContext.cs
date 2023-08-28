using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest {
    public class AppDbContext : DbContext {
        public DbSet<Customer> Customers {get; set;}
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public AppDbContext() {

        } // only needed for console app
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { } // needed for any entity framework
        protected override void OnConfiguring(DbContextOptionsBuilder Obldr) {
            var connStr = "server=localhost\\sqlexpress;" +
                          "database=SalesDb;" +
                          "trusted_connection=true;" +
                          "trustServerCertificate=true;";
            Obldr.UseSqlServer(connStr);
        }
    }
}
