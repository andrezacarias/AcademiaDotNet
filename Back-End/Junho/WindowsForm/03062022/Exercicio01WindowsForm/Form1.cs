using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Exercicio01WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbCPF.Clear();
            tbLogin.Clear();
            tbNome.Clear();
            tbSenha.Clear();
            tbTelefone.Clear();
            cbStatus.ResetText();
            cbTipo.ResetText();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro c = new Cadastro(tbNome, tbTelefone, tbCPF, tbLogin, tbSenha, cbStatus, cbTipo );
            c.MostrarDadosCadastro();
        }
    }
}
