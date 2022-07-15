using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaDoMario.Models
{
    public class ItemVenda : Venda
    {
        [Key]
        [Required]
        public int IdItemVenda { get; set; }
        [Required]
        public float valorUnitario { get; set; }
        [Required]
        public int quantidade { get; set; }
        [ForeignKey("Venda")]
        public int IdVenda { get; set; }
        [ForeignKey("CadastroProduto")]
        public int IdProduto { get; set; }





    }
}
