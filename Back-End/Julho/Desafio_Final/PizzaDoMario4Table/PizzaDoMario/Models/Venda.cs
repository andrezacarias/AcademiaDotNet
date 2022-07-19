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
        [Display(Name = "Nome do Cliente")]
        public  CadastroCliente CadastroCliente { get; set; }
        //public CadastroProduto CadastroProduto { get; set; }
        [Display(Name = "Valor total")]
        public decimal valorTotal  { get; set; }


    }

}
