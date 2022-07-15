using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaDoMario.Models
{
    public class Venda
    {
        [Key]
        public int IdVenda { get; set; }
        [Required]
        [ForeignKey("CadastroCliente")]
        public int IdCliente { get; set; }
        //public CadastroCliente Cliente { get; set; }
        public float valorTotal { get; set; }
        public DateTime dataCompra { get; set; }
       
        



    }
}
