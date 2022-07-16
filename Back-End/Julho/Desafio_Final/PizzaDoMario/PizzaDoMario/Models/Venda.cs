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
        public  CadastroCliente CadastroCliente { get; set; }

        [ForeignKey("CadastroProduto")]
        public int IdProduto { get; set; }
        public  CadastroProduto CadastroProduto { get; set; }
        public decimal valorTotal { get; set; }
        [DataType(DataType.Date)]
        public DateTime dataCompra { get; set; }
        public int quantidade { get; set; }
        //public List<CadastroProduto> CadastroProdutoList { get; set; }

    }

}
