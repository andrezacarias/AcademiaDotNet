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
            // TODO: esta linha de código carrega dados na tabela 'rhinoStore_DBDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.rhinoStore_DBDataSet.Cliente);

        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            
            Cliente c = new Cliente(tbNomeCliente.Text, tbEmail.Text, tbCPF.Text, tbTelefone.Text);
            bool ok = c.gravarCliente();
            if(ok) {
                MessageBox.Show("Cadastrado com sucesso!!!");
                this.clienteTableAdapter.Fill(this.rhinoStore_DBDataSet.Cliente);
            }
           

        }

        private void dgCadastroCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
