using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaDoMario.Models
{
    [Table("Cadastro Cliente")]
    public class CadastroCliente
    {
        [Key]
        [Required]
        public int IdCliente { get; set; }
        [Required]
        public string nome { get; set; }
        [Required]
        public string endereco { get; set; }
        [Required]
        public string complemento { get; set; }
        [Required]
        public string bairro { get; set; }
        [Required]
        public string telefone { get; set; }
        //[Required]
        //public string CEP { get; set; }





    }
}
