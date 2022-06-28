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
    public partial class FormCadastroProdutos : Form
    {
        public FormCadastroProdutos()
        {
            InitializeComponent();
        }

        private void FormCadastroProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rhinoStore_DBDataSet12.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter4.Fill(this.rhinoStore_DBDataSet12.produtos);
           
            
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            Produto p = new Produto(tbNomeProduto.Text, double.Parse(tbPreco.Text), int.Parse(tbEstoque.Text), int.Parse(tbCodEAN.Text)  );
            //MessageBox.Show(tbNomeProduto.Text, tbPreco.Text, tbEstoque.Text, tbCodEAN.Text) ;
             p.gravarProduto();
            //if (ok)
            //{
             MessageBox.Show("Cadastrado com sucesso!!!");
            this.produtosTableAdapter4.Fill(this.rhinoStore_DBDataSet12.produtos);
            //}
        }
    }
}
