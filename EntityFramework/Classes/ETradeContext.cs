using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Classes
{
    public class ETradeContext : DbContext
    {
        public DbSet<Product> products { get; set; }
    }
}
