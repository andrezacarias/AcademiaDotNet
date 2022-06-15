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
        

        public TelaPrincipalGaragem()
        {
            InitializeComponent();

            
        }



        private void btnExecutar_Click(object sender, EventArgs e)
        {   
            //Recebe a data do sistem e a coloca em um vetor, splita por espaço
            string dataDia = Convert.ToString(DateTime.Now);
            string[] vetorDados = dataDia.Split(' ');
            //Pop up dos dados de entrada
            MessageBox.Show(tbPlaca.Text + "\n" + vetorDados[0] + "\n" + mtbData.Text + "\n" + cbOperacao.Text);
            ////Método para gravar os dados de entrada no arquivo.
            //StreamWriter escritor = new StreamWriter("arquivoEntradaVeiculos.dat", true);
            //escritor.WriteLine(tbPlaca.Text + "|" + vetorDados[0] + "|" + mtbData.Text);
            //escritor.Flush();
            //escritor.Close();
            Veiculo c = new Veiculo(tbPlaca, mtbData);
            //Teste
            if (cbOperacao.SelectedIndex == 0)
            {
                Veiculo.gravarArquivoEntrada(c);
            }
            else
            {
                Veiculo.gravarArquivoSaida(c);
            }
        }

        private void TelaPrincipalGaragem_Load(object sender, EventArgs e)
        {

        }
    }
}
