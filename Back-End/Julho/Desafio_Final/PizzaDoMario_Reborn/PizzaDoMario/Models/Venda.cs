using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaDoMario.Models
{
    public class Venda 

    {
        [Key]
        public int IdVenda { get; set; }
        [ForeignKey("CadastroCliente")]
        [Display(Name = "Telefone")]
        public int ClienteId { get; set; }
        public CadastroCliente CadastroCliente { get; set; }
        public decimal valorTotal { get; set; }
        public DateTime dataCompra { get; set; }
        public StatusPedido StatusPedido { get; set; }
    
    }
    public enum StatusPedido
    {
        EmAndamento = 1,
        Finalizado

    }
}
