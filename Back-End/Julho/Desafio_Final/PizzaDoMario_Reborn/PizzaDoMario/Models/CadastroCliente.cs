using System.ComponentModel.DataAnnotations;

namespace PizzaDoMario.Models
{
    public class CadastroCliente
    {
        [Key]
        [Required]
        public int IdCliente { get; set; }
        [Required]
        public string nome { get; set; }
        [Required]
        public string telefone { get; set; }
        [Required]
        public string endereco { get; set; }
        [Required]
        public string complemento { get; set; }
        [Required]
        public string bairro { get; set; }
        [Required]
        public string CEP { get; set; }

    }
}
