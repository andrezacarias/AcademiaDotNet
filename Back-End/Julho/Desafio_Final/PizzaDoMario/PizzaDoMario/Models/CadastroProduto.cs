using System.ComponentModel.DataAnnotations;

namespace PizzaDoMario.Models
{
    public class CadastroProduto
    {
        [Key]
        public int IdProduto { get; set; }
        [Required]
        public string nomeProduto { get; set; }
        [Required]
        public float preco { get; set; }
        [Required]
        public string descricao { get; set; }
        //public Venda Venda { get; set; }

    }
}
