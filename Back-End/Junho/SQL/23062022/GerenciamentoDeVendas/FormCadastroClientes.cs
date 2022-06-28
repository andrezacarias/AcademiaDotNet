using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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

        private void btnApagarCliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quero apagar");
            //Cliente a = new Cliente(tbNome.Text, tbTelefone.Text, tbEmail.Text);
            //apagarCliente(tbNome.Text, tbTelefone.Text, tbEmail.Text);
        }

        //private void apagarCliente(string text1, string text2, string text3)
        //{
            
        //}

        //private void apagarCliente(object sender, EventArgs e)
        //{
        //    //lembre que o remover está relacionado com ListView e a região
        //    //selecionada


        //    try
        //    {
        //        //MessageBox.Show(listView_medidasGlicemias.SelectedItems[0].Text);
                

        //        //gerar sentenças SQL
        //        string sqlTexto = "DELETE FROM clientes WHERE idCliente = @idCliente";

        //        SqlCommand comando = new SqlCommand(sqlTexto);
        //        comando.Parameters.AddWithValue("@idCliente", idClienteDataGridViewTextBoxColumn);

        //        //executar sentença SQL
        //        comando.ExecuteNonQuery();
        //    }
        //    catch (Exception error)
        //    {
        //        MessageBox.Show(error.Message);
        //    }

        //    this.clientesTableAdapter.Fill(this.rhinoStore_DBDataSet15.Clientes);

        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

