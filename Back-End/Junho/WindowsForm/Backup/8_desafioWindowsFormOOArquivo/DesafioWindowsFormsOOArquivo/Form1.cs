using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioWindowsFormsOOArquivo
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tbPlaca.Text + "\n" +
                            dtpDataEntrada.Text + "\n" +
                            dtpHoraEntrada.Text + "\n");                            ;
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show(tbPlaca.Text + "\n" +
                                dtpDataEntrada.Text + "\n" +
                                dtpHoraSaida.Text);
            }
        }
    }
}
