using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaDoMario.Models
{
    [Table("Cadastro Cliente")]
    public class CadastroCliente
    {
        [Key]
        [Required]
        [Display(Name = "Cliente")]
        public int IdCliente { get; set; }
        [Required]
        [Display(Name = "Nome")]
        public string nome { get; set; }
        [Required]
        [Display(Name = "Endereço")]
        public string endereco { get; set; }
        [Required]
        [Display(Name = "Complemento")]
        public string complemento { get; set; }
        [Required]
        [Display(Name = "Bairro")]
        public string bairro { get; set; }
        [Required]
        [Display(Name = "Telefone")]
        public string telefone { get; set; }
        





    }
}
