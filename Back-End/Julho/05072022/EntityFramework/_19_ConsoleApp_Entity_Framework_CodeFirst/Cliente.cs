using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace _19_ConsoleApp_Entity_Framework_CodeFirst
{
    [Table("Clientes")]
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nome, string email)
        {

            Nome = nome;
            Email = email;
        }
    }
}
