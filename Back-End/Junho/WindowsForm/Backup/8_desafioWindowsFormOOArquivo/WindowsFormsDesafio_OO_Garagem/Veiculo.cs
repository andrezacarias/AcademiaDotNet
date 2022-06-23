using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.IO;

namespace WindowsFormsDesafio_OO_Garagem
{
    public class Veiculo
    {
        public TextBox tbPlaca;
        public ComboBox cbEntradaSaida;
        public DateTimePicker dtpHoraEntrada;
        public TextBox tbLimiteCarros;
        public TextBox tbValorHora;
        public ListBox lbValorEstadia;
        

        public Veiculo(TextBox tbPlaca, ComboBox cbEntradaSaida, DateTimePicker dtpHoraEntrada1)
        {
            this.tbPlaca = tbPlaca;
            this.cbEntradaSaida = cbEntradaSaida;
        }

        public Veiculo(TextBox tbPlaca, ComboBox cbEntradaSaida, DateTimePicker dtpHoraEntrada, DateTimePicker dtpHoraSaida, TextBox tbLimiteCarros, TextBox tbValorHora, ListView lvEstadia)
        {
            this.tbPlaca = tbPlaca;
            this.cbEntradaSaida = cbEntradaSaida;
            this.dtpHoraEntrada = dtpHoraEntrada;
            this.tbLimiteCarros = tbLimiteCarros;
            this.tbValorHora = tbValorHora;
            this.lbValorEstadia = lbValorEstadia;
                        
        }

       
        public static void gravarArquivoEntrada(Veiculo o)
        {
            try
            {
                    StreamWriter escritor = new StreamWriter("arquivoEntradaVeiculos.dat", true);
                    escritor.WriteLine(o.tbPlaca.Text + "/" + o.cbEntradaSaida.Text + "/" + o.dtpHoraEntrada + DateTime.Now);
                    escritor.Flush();
                    escritor.Close();
               
            }
            catch (Exception e)
            {
                Console.WriteLine("Arquivo de cadastro com problemas" + e.Message);
            }
        }

        public static void gravarArquivoSaida(Veiculo o)
        {
            try
            {
              
                StreamWriter escritor = new StreamWriter("arquivoSaidaVeiculos.dat", true);
                string gravaHora = Convert.ToString(DateTime.Now);
                string[] horaEntradaSaida = gravaHora.Split(' ');
                escritor.WriteLine(o.tbPlaca.Text + "/" + o.cbEntradaSaida.Text + "/" + o.dtpHoraEntrada + horaEntradaSaida[1]);
                escritor.Flush();
                escritor.Close();
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Arquivo de cadastro com problemas" + e.Message);
            }
        }
    }


}