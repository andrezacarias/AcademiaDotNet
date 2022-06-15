using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Desafio01_Garagem
{
    internal class Persistencia
    {
        //Atributos
        
        public int tempoDePermanencia;
        public int valorCobrado;
        public int precoHora;
        public int limiteCarros;
        public string dataDia;
        public string horaEntrada;
        public string horaSaida;

        public Persistencia(TextBox tbPlaca, string[] vetorDados, MaskedTextBox mtbData)
        {
        }

        public Persistencia(int tempoDePermanencia, int valorCobrado, int precoHora, int limiteCarros, string dataDia, string horaEntrada, string horaSaida)
        {
            this.tempoDePermanencia = tempoDePermanencia;
            this.valorCobrado = valorCobrado;
            this.precoHora = precoHora;
            this.limiteCarros = limiteCarros;
            this.dataDia = dataDia;
            this.horaEntrada = horaEntrada;
            this.horaSaida = horaSaida;
        }


        

        
    }
}
