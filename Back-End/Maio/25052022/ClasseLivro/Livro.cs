using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    public class Livro
    {
        //atributos
        public String titulo; //{ get => titulo; set => titulo = value; }
        public String autor;
        public int paginas;
        public int ano;
        public int edicao;
        //construtor
        public Livro(String titulo, String autor, int paginas, int ano, int edicao)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.paginas = paginas;
            this.ano = ano;
            this.edicao = edicao;
        }
        //metodos
        public void apresentaInfoLivro()
        {
            Console.WriteLine("O livro com titulo de " + this.titulo + " do autor " + this.autor + " edição " + this.edicao + " lançado no ano de " + this.ano + " com " + this.paginas + " páginas");
        }

    }
}