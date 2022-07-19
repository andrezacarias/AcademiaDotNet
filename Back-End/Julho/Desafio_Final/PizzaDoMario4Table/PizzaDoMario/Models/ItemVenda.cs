using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaDoMario.Models
{
    public class ItemVenda
    {
        [Key]
        public int IdItemVenda { get; set; }
        [ForeignKey("CadastroCliente")]
        public int IdCliente { get; set; }
        [ForeignKey("Venda")]
        public int IdVenda { get; set; }
        [ForeignKey("CadastroProduto")]
        [Display(Name = " Produto")]
        public int IdProduto { get; set; }
        [Display(Name = "Preço")]
        public decimal preco { get; set; }
        public decimal subTotal {get; set; }
        [Display(Name = "Quantidade")]
        public int quantidade { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data da Compra")]
        public DateTime dataCompra { get; set; }
        public CadastroCliente CadastroCliente { get; set; }
        public CadastroProduto CadastroProduto { get; set; }
    }
}
