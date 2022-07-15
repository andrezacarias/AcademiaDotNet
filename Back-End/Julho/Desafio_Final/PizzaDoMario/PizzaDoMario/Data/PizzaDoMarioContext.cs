using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PizzaDoMario.Models;

namespace PizzaDoMario.Data
{
    public class PizzaDoMarioContext : DbContext
    {
        public PizzaDoMarioContext (DbContextOptions<PizzaDoMarioContext> options)
            : base(options)
        {
        }

        public DbSet<PizzaDoMario.Models.CadastroCliente> CadastroCliente { get; set; } = default!;

        public DbSet<PizzaDoMario.Models.CadastroProduto>? CadastroProduto { get; set; }

        public DbSet<PizzaDoMario.Models.Venda>? Venda { get; set; }
    }
}
