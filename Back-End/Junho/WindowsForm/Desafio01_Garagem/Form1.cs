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
using System.Collections.Generic;


namespace Desafio01_Garagem
{
    public partial class TelaPrincipalGaragem : Form
    {
        private string dataEntrada;
        public string jacadastrado;
        public TelaPrincipalGaragem()
        {
            InitializeComponent();
            
           lerArquivoEntrada();
           lerArquivoSaida();
          
        }

        //lista com os objetos veículo estacionados na garagem,
        //esta lista recebe um objeto quando o funcionário
        //registra uma entrada, e o objeto é removido quando o
        //usuário registra uma saída.
                
        private void TelaPrincipalGaragem_Load(object sender, EventArgs e)
        {

        }

        public void lerArquivoEntrada()
        {
            try {    

            dgEstacionados.Rows.Clear();

            
                //Lê o arquivo de registro de entrada e retorna os valores registrados lá
                //referentes aos veículos que deram entrada na garagem no dia de expediente
                StreamReader leitor = new StreamReader("arquivoEntradaVeiculos.dat");
                string linha;//placa;dataEntrada,dataHora
                string[] dados; //FNO4273;13/06/2022;17:30
                do
                {
                    
                    linha = leitor.ReadLine();
                    dados = linha.Split(';');
                    dgEstacionados.Rows.Add(dados[0], dados[1], dados[2]);
                    jacadastrado = dados[0];
                    //MessageBox.Show("tbPlaca= " + tbPlaca.Text + "\n dados[0]= " + dados[0]+ " "+ jacadastrado);
                    if (tbPlaca.Text.Equals(dados[0]))
                    {
                       MessageBox.Show("Veículo já estacionado, digite placa diferente!");
                       break;

                    }
                    

                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Arquivo de cadastro com problemas" + e.Message);
            }
}

        public void lerArquivoSaida()
        {
            try
            {
                dgSaida.Rows.Clear();
            
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
            catch (Exception e)
            {
                MessageBox.Show("Arquivo de cadastro com problemas" + e.Message);
            }


        }
              
            private void btnExecutar_Click(object sender, EventArgs e)
        {
            //Recebe a data do sistema e a coloca em um vetor, splita por espaço
            string dataDia = Convert.ToString(DateTime.Now);
            string[] vetorDados = dataDia.Split(' ');
            //Converte os caracteres para letras maiúsculas
            tbPlaca.Text=tbPlaca.Text.ToUpper();
            //Constrói um objeto c(veículo)
            Veiculo c = new Veiculo(tbPlaca, mtbData);
            //Seleciona Entrada ou Saída do veículo
            int i;
            if (cbOperacao.SelectedIndex == 0)
            {
                if (mtbData == null)
                {
                    MessageBox.Show("Digite a hora de Entrada HH:MM");
                    
                }
                lerArquivoEntrada();
                if (jacadastrado != tbPlaca.Text)
                {
                    Veiculo.gravarArquivoEntrada(c);
                    tbPlaca.Clear();
                    mtbData.Clear();
                }
                //Veiculo.gravarArquivoEntrada(c);
                //lerArquivoEntrada();
                MessageBox.Show("Temos " + (50 - dgEstacionados.RowCount) + " vagas disponíveis.");
                lerArquivoEntrada();
            }
            else
            {
                File.Delete("arquivoEntradaVeiculos.dat");
                Veiculo v;
                dgEstacionados.Rows.RemoveAt(dgEstacionados.CurrentRow.Index);
                for(i=0;  i<dgEstacionados.Rows.Count-1; i++)
                {
                    gambiarra.Text=dgEstacionados.Rows[i].Cells[0].Value.ToString();
                    gambiarra2.Text=dgEstacionados.Rows[i].Cells[2].Value.ToString();
                    v = new Veiculo(gambiarra, 
                                   dgEstacionados.Rows[i].Cells[1].Value.ToString(),
                                   gambiarra2);
                    Veiculo.gravarArquivoEntrada(v);
                }
                c.gravarArquivoSaida(c);
                tbPlaca.Clear();
                mtbData.Clear();
                lerArquivoSaida();
                MessageBox.Show("Temos " + (51 - dgEstacionados.RowCount) + " vagas disponíveis.");
                lerArquivoEntrada();
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
            //MessageBox.Show("Valor " + tempoDePermanencia);
        }

        private void btnFinalDia_Click(object sender, EventArgs e)
        {   
           //TimeSpan habilita = 20:00;
           // if(DateTime.Now < habilita)
           // {
                btnFinalDia.Enabled = false;
           // }
            File.Delete("arquivoEntradaVeiculos.dat");
            File.Delete("arquivoSaidaVeiculos.dat");
            dgEstacionados.Rows.Clear();
            dgSaida.Rows.Clear();
        }
    }
}
