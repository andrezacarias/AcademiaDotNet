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

namespace WindowsFormsDesafio_OO_Garagem
{
    public partial class LblHoraDeEntrada : Form
    {
        public LblHoraDeEntrada()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            Veiculo c = new Veiculo(tbPlaca, cbEntradaSaida, dtpHoraEntrada);
            MessageBox.Show(tbPlaca.Text + "\n" + cbEntradaSaida.Text + "\n" + dtpHoraEntrada.Text);
            Veiculo.gravarArquivoEntrada(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Veiculo c = new Veiculo(tbPlaca, cbEntradaSaida,  dtpHoraEntrada);
            String horaTemporaria = Convert.ToString(dtpHoraEntrada);
            String[] VetorDados = horaTemporaria.Split(' ');
            MessageBox.Show(tbPlaca.Text + "\n" + cbEntradaSaida.Text + "\n" + VetorDados[3]);// dtpHoraEntrada.Text);
            Veiculo.gravarArquivoSaida(c);
        }
    }
}
