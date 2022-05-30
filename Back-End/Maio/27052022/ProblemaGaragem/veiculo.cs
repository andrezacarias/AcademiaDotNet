using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaGaragem
{
    class Veiculo
    {   //atributos
        string placa;
        DateTime dataHoraEntrada;

        //Construtor
       
               
        //construtor usado para popular a lista a partir do arquivo (banco)
        public Veiculo(string placa, DateTime dataHoraEntrada)
        {
            this.placa = placa;
            this.dataHoraEntrada = dataHoraEntrada;
           
        }
        public string Placa { get => placa; set => placa = value; }

        public DateTime DataHoraEntrada { get => dataHoraEntrada; set => dataHoraEntrada = value; }

        public Veiculo()
        {
            

        }

        
    }
}