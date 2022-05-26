using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_AnimalDeEstimacao
{
    public class BichoDeEstimacao
    {
        //atributos
        private String nome;
        private String especie;
        public int contadorGato;
        public int contadorCachorro;
        public int contadorPeixe;

        //construtor
        public BichoDeEstimacao(string nome, string especie, int contadorGato, int contadorCachorro, int contadorPeixe)
        {
            this.nome = nome;
            this.especie = especie;
            this.contadorGato = contadorGato;
            this.contadorCachorro = contadorCachorro;
            this.contadorPeixe = contadorPeixe;
        }

        //metodos
        public void mostraAnimalDeEstimacao()
        {
            Console.WriteLine($"Eu tenho {contadorGato} gatos ,{contadorCachorro} cachorros e {contadorPeixe} peixes.");
        }

    }
}
