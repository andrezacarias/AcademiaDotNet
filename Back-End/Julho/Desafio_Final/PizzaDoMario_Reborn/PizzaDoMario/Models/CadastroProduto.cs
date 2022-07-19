using System.ComponentModel.DataAnnotations;

namespace PizzaDoMario.Models
{
    public class CadastroProduto
    {
        [Key]
        public int IdProduto { get; set; }
        [Required]
        [Display(Name = "Nome do Produto")]
        public string nomeProduto { get; set; }
        [Required]
        [Display(Name = "Preço")]
        public decimal preco { get; set; }
        [Required]
        [Display(Name = "Descrição")]
        public string descricao { get; set; }


    }
}
