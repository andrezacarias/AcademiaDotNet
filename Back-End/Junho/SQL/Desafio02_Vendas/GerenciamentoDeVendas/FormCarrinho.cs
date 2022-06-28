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
    public partial class FormCarrinho : Form
    {
        public FormCarrinho()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormCarrinho_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rhinoStore_DBDataSet16.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.rhinoStore_DBDataSet16.Clientes);
            // TODO: esta linha de código carrega dados na tabela 'rhinoStore_DBDataSet6.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.rhinoStore_DBDataSet6.produtos);
            

        }
    }
}
