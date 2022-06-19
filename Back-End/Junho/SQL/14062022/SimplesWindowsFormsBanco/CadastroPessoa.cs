using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SimplesWindowsFormsBanco
{
    public partial class CadastroPessoa : Form
    {
        public CadastroPessoa()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa(tbNome.Text, int.Parse(tbIdade.Text), tbCpf.Text, tbEndereco.Text, tbBairro.Text, tbCep.Text, tbCidade.Text);
            MessageBox.Show("Nome: " + p.nome + "\nCPF: " +p.cpf);
            tbNome.Text = "";
            tbIdade.Text = " ";
            tbCpf.Text = " ";
            tbEndereco.Text = " ";
            tbBairro.Text = " ";
            tbCep.Text = " ";
            tbCidade.Text = " ";
            p.gravarPessoa();

        }
    }
}
