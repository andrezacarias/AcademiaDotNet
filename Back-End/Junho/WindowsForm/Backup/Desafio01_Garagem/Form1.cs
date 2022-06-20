using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Desafio01_Garagem
{
    public partial class TelaPrincipalGaragem : Form
    {
        private string dataEntrada;

        public TelaPrincipalGaragem()
        {
            InitializeComponent();
            
           lerArquivoEntrada();
           lerArquivoSaida();

        }

        private void TelaPrincipalGaragem_Load(object sender, EventArgs e)
        {

        }

        public void lerArquivoEntrada()
        {
            dgEstacionados.Rows.Clear();
            try
            {
                //Lê o arquivo de registro de entrada e retorna os valores registrados lá
                //referentes aos veículos que deram entrada na garagem no dia de expediente
                StreamReader leitor = new StreamReader("arquivoEntradaVeiculos.dat");
                string linha;
                string[] dados;
                do
                {
                    linha = leitor.ReadLine();
                    dados = linha.Split(';');
                    dgEstacionados.Rows.Add(dados[0], dados[1], dados[2]);


                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (IOException e)
            {
                MessageBox.Show("Erro ao ler o arquivo: " + e.Message);
            }
        }

        public void lerArquivoSaida()
        {
            dgSaida.Rows.Clear();
            try
            {
                //Lê o arquivo de registro de entrada e retorna os valores registrados lá
                //referentes aos veículos que deram entrada na garagem no dia de expediente
                StreamReader leitor = new StreamReader("arquivoSaidaVeiculos.dat");
                string linha;
                string[] dados;
                

                do
                {
                    linha = leitor.ReadLine();
                    dados = linha.Split(';');
                    dgSaida.Rows.Add(dados[0], dados[1], dados[2], dados[3]);


                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (IOException e)
            {
                MessageBox.Show("Erro ao ler o arquivo: " + e.Message);
            }


        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //Recebe a data do sistema e a coloca em um vetor, splita por espaço
            string dataDia = Convert.ToString(DateTime.Now);
            string[] vetorDados = dataDia.Split(' ');
            //Pop up dos dados de entrada
            MessageBox.Show(tbPlaca.Text + "\n" + vetorDados[0] + "\n" + mtbData.Text + "\n" + cbOperacao.Text);
            Veiculo c = new Veiculo(tbPlaca, mtbData);
            //Seleciona Entrada ou Saída do veículo
            if (cbOperacao.SelectedIndex == 0)
            {

                Veiculo.gravarArquivoEntrada(c);
                lerArquivoEntrada();
            }
            else
            {
                c.gravarArquivoSaida(c);
                lerArquivoSaida();
               
            }
        }

        private void dgEstacionados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DateTime dataTemporaria;
            //lerArquivoEntrada();
            tbPlaca.Text = dgEstacionados.CurrentRow.Cells[0].Value.ToString();
            dataEntrada= dgEstacionados.CurrentRow.Cells[1].Value.ToString();   
            mtbData.Text = dgEstacionados.CurrentRow.Cells[2].Value.ToString();
            dataTemporaria = Convert.ToDateTime(mtbData.Text);
            TimeSpan tempoDePermanencia = DateTime.Now.Subtract(dataTemporaria);
            MessageBox.Show("Valor " + tempoDePermanencia);
        }
    }
}
