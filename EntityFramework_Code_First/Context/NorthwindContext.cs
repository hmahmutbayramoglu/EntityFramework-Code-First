using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; //...
using EntityFramework_Code_First.Entities; //...

namespace EntityFramework_Code_First.Context
{
    public class NorthwindContext : DbContext
    {

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Order> Order { get; set; }




    }
}
