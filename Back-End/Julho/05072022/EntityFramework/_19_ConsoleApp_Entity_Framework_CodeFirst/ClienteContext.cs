using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ConsoleApp_Entity_Framework_CodeFirst
{
    public class ClienteContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
    }
}
