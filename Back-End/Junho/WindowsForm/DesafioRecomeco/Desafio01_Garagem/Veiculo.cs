using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Desafio01_Garagem
{
    internal class Veiculo
    {
        //Atributos
        public TextBox tbPlaca;
        public ComboBox cbOperacao;
        public MaskedTextBox mtbData;
        public int tempoDePermanencia;
        public int valorCobrado = 5;
        public int precoHora;
        public int limiteCarros;
        public string dataDia;
        public string horaEntrada;
        public string horaSaida;
        public string vetorDados { get; internal set; }
        public object DtpHoraEntrada { get; }


        //Construtor
        public Veiculo(TextBox tbPlaca, ComboBox cbOperacao, MaskedTextBox mtbData, int tempoDePermanencia, int valorCobrado, int precoHora, int limiteCarros, string dataDia, string horaEntrada, string horaSaida)
        {
            this.tbPlaca = tbPlaca;
            this.cbOperacao = cbOperacao;
            this.mtbData = mtbData;
            this.tempoDePermanencia = tempoDePermanencia;
            this.valorCobrado = valorCobrado;
            this.precoHora = precoHora;
            this.limiteCarros = limiteCarros;
            this.dataDia = dataDia;
            this.horaEntrada = horaEntrada;
            this.horaSaida = horaSaida;

        }

        public Veiculo(TextBox tbPlaca, ComboBox cbOperacao, string dataDia, int tempoDePermanencia)
        {
            dataDia = Convert.ToString(DateTime.Now);
            string[] vetorDados = dataDia.Split(' ');
        }

        public Veiculo(TextBox tbPlaca, string[] vetorDados, ComboBox cbEntradaSaida, MaskedTextBox mtbData)
        {
            this.tbPlaca = tbPlaca;
            this.mtbData = mtbData;
            this.cbOperacao = cbOperacao;

        }

        public Veiculo(TextBox tbPlaca, ComboBox cbEntradaSaida, object dtpHoraEntrada)
        {
            this.tbPlaca = tbPlaca;
            this.cbOperacao = cbOperacao;
            DtpHoraEntrada = dtpHoraEntrada;
        }

        public Veiculo(TextBox tbPlaca, MaskedTextBox mtbData, int valorCobrado)
        {
            this.tbPlaca = tbPlaca;
            this.mtbData = mtbData;
        }

        public Veiculo(TextBox tbPlaca, MaskedTextBox mtbData)
        {
            this.tbPlaca = tbPlaca;
            this.mtbData = mtbData;
        }

        public static void gravarArquivoEntrada(Veiculo o)
        {
            try
            {
                string dataEntrada = DateTime.Now.ToShortDateString();
                StreamWriter escritor = new StreamWriter("arquivoEntradaVeiculos.dat", true);
                escritor.WriteLine(o.tbPlaca.Text + ";" + dataEntrada + ";" + o.mtbData.Text);
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
                string dataEntrada = DateTime.Now.ToShortDateString();
                StreamWriter escritor = new StreamWriter("arquivoSaidaVeiculos.dat", true);
                escritor.WriteLine(o.tbPlaca.Text + ";" + dataEntrada + ";" + o.mtbData.Text + ";" + o.valorCobrado);
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
