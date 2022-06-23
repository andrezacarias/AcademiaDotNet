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
        public int valorCobrado;
        public int precoHora;
        public int limiteCarros;
        public string dataDia;
        public string horaEntrada;
        public string horaSaida;
        public string vetorDados { get; internal set; }
        public object DtpHoraEntrada { get; }
        public string dataEntrada;
        public bool jacadastrado = false;


        //Construtor
        public Veiculo(TextBox tbPlaca,  ComboBox cbOperacao, MaskedTextBox mtbData,
                       int tempoDePermanencia, int valorCobrado, int precoHora,
                        int limiteCarros, string dataDia, string horaEntrada,
                        string horaSaida, string dataEntrada)
        {
            this.tbPlaca = tbPlaca;
            this.cbOperacao = cbOperacao;
            this.mtbData = mtbData;
            this.valorCobrado = valorCobrado;
            this.precoHora = precoHora;
            this.limiteCarros = limiteCarros;
            this.dataDia = dataDia;
            this.horaEntrada = horaEntrada;
            this.horaSaida = horaSaida;
            this.dataEntrada = dataEntrada;
            
        }

        public Veiculo(TextBox tbPlaca,  ComboBox cbOperacao, string dataDia,
                        int tempoDePermanencia, string dataEntrada, int valorCobrado)
        {
            dataDia = Convert.ToString(DateTime.Now);
            string[] vetorDados = dataDia.Split(' ');
        }

        public Veiculo(TextBox tbPlaca,  string[] vetorDados, ComboBox cbOperacao,
                        ComboBox cbEntradaSaida, MaskedTextBox mtbData, int valorCobrado)
        {
            this.tbPlaca = tbPlaca;
            this.mtbData = mtbData;
            this.cbOperacao = cbOperacao;

        }

        public Veiculo(TextBox tbPlaca,  ComboBox cbEntradaSaida, 
                ComboBox cbOperacao, object dtpHoraEntrada, int valorCobrado)
        {
            this.tbPlaca = tbPlaca;
            this.cbOperacao = cbOperacao;
            this.DtpHoraEntrada = dtpHoraEntrada;
        }

        public Veiculo(TextBox tbPlaca, DataGrid dgEstacionados, 
               MaskedTextBox mtbData, int valorCobrado)
        {
            this.tbPlaca = tbPlaca;
            this.mtbData = mtbData;
        }

        public Veiculo(TextBox tbPlaca, DataGrid dgEstacionados, 
            MaskedTextBox mtbData)
        {
            this.tbPlaca = tbPlaca;
            this.mtbData = mtbData;
        }

        public Veiculo(int valorCobrado)
        {
        }

        public Veiculo(TextBox tbPlaca, MaskedTextBox mtbData)
        {
            this.tbPlaca = tbPlaca;
            this.mtbData = mtbData;
        }
        public Veiculo(TextBox tbPlaca, string dataDia, MaskedTextBox mtbData)
        {
            this.tbPlaca = tbPlaca;
            this.dataDia = dataDia;
            this.mtbData = mtbData;
            
        }
        public static void gravarArquivoEntrada(Veiculo c)
        {
            try
            {
                
                string dataEntrada = DateTime.Now.ToShortDateString();
                StreamWriter escritor = new StreamWriter("arquivoEntradaVeiculos.dat", true);
                escritor.WriteLine(c.tbPlaca.Text + ";" + dataEntrada + ";" + c.mtbData.Text);
                escritor.Flush();
                escritor.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Arquivo de cadastro com problemas" + e.Message);
            }


        }

        public void gravarArquivoSaida(Veiculo c)
        {
            try
            {
                DateTime dataTemporaria;
                dataTemporaria = Convert.ToDateTime(mtbData.Text);
                TimeSpan tempoDePermanencia = DateTime.Now.Subtract(dataTemporaria);
                //calculaValorCobrado();
                //
                //Inicio
                //Calculando o valor Cobrado!
                string[] contaTempo = tempoDePermanencia.ToString().Split(':');

                int tempoHora = Convert.ToInt16(contaTempo[0]);
                int tempoMinuto = Convert.ToInt16(contaTempo[1]);

                if (tempoMinuto > 0)
                {
                    tempoHora++;
                }

                valorCobrado = tempoHora * 5;
                //Fim
                //
                MessageBox.Show("Tempo de permanência : " + tempoDePermanencia + "\nValor da estadia : R$"  + valorCobrado + ",00");
                StreamWriter escritor = new StreamWriter("arquivoSaidaVeiculos.dat", true);
                escritor.WriteLine(c.tbPlaca.Text + ";" +  c.mtbData.Text + ";" + tempoDePermanencia + ";" + valorCobrado);
                escritor.Flush();
                escritor.Close();
               

            }
            catch (Exception e)
            {
                MessageBox.Show("Arquivo de cadastro com problemas" + e.Message);
            }
        }
        
        //private void calculaValorCobrado()
        //{

        //}

        //public void calculaValorCobrado(Veiculo c)
        //{
        //    string[] contaTempo = c.tempoDePermanencia.ToString().Split(':');

        //    int tempoHora = Convert.ToInt16(contaTempo[0]);
        //    int tempoMinuto = Convert.ToInt16(contaTempo[1]);

        //    if (tempoMinuto > 0)
        //    {
        //        tempoHora++;
        //    }

        //   valorCobrado = tempoHora * 12;
        //}

    }
}
