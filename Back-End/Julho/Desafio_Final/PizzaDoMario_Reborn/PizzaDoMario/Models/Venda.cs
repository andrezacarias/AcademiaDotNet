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

        [ForeignKey("CadastroProduto")]
        [Display(Name =" Produto")]
        public int IdProduto { get; set; }
        public CadastroProduto CadastroProduto { get; set; }
        [Display(Name = "Quantidade")]
        public int quantidade { get; set; }
        [Display(Name = "Preço")]
        public decimal preco { get; set; }
        [Display(Name = "Valor total")]
        public decimal valorTotal { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data da Compra")]
        public DateTime dataCompra { get; set; }
        
        

    }

}
