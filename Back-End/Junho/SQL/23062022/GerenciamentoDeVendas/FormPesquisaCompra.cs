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
    public partial class FormPesquisaCompra : Form
    {
        public FormPesquisaCompra()
        {
            InitializeComponent();
        }

        private void FormPesquisaCompra_Load(object sender, EventArgs e)
        {
            
            // TODO: esta linha de código carrega dados na tabela 'rhinoStore_DBDataSet27.vendas'. Você pode movê-la ou removê-la conforme necessário.
            this.vendasTableAdapter.Fill(this.rhinoStore_DBDataSet27.vendas);

        }
    }
}
