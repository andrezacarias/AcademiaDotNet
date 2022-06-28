using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeVendas
{
    public partial class FormCadastroClientes : Form
    {
        public FormCadastroClientes()
        {
            InitializeComponent();
        }

        private void FormCadastroClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rhinoStore_DBDataSet15.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.rhinoStore_DBDataSet15.Clientes);

        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente(tbNome.Text, tbTelefone.Text, tbEmail.Text);
            MessageBox.Show(tbNome.Text + tbTelefone.Text + tbEmail.Text) ;
            c.gravarCliente();
            this.clientesTableAdapter.Fill(this.rhinoStore_DBDataSet15.Clientes);
        }
    }
}
