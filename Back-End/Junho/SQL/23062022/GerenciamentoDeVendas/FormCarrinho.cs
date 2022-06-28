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
        public int qtd;
        public double precoProduto;
        public double valorT;
        public string nomeProd;
        public string idenProduto;


        public FormCarrinho()
        {
            InitializeComponent();
        }

        public FormCarrinho(int qtd, double precoProduto, double valorT, string nomeProd, string idenProduto)
        {
            this.qtd = qtd;
            this.precoProduto = precoProduto;
            this.valorT = valorT;
            this.nomeProd = nomeProd;
            this.idenProduto = idenProduto;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormCarrinho_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rhinoStore_DBDataSet26.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter2.Fill(this.rhinoStore_DBDataSet26.Clientes);
            // TODO: esta linha de código carrega dados na tabela 'rhinoStore_DBDataSet25.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter5.Fill(this.rhinoStore_DBDataSet25.produtos);
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IdenCliente = int.Parse(comboBox1.SelectedValue.ToString());
            MessageBox.Show("Selected Item Text: " + comboBox1.Text + "\n" +
                           "Index: " + IdenCliente);
            
            
            
        }

        //Seleciona o produto, valor unitário e a identidade no DB clicando 
        private void dgListaProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idenProduto = int.Parse(dgListaProdutos.CurrentRow.Cells[0].Value.ToString());
            string nomeProd = dgListaProdutos.CurrentRow.Cells[1].Value.ToString();
            qtd = int.Parse(tbQuantidade.Text);
            valorT = qtd * precoProduto;
            precoProduto = double.Parse(dgListaProdutos.CurrentRow.Cells[2].Value.ToString());
                        
        }
        //Mostra os dados do produto escolhido já com o valor X quantidade
        private void btnComprar_Click(object sender, EventArgs e)
        {
            string nomeProd = dgListaProdutos.CurrentRow.Cells[1].Value.ToString();
            int idenProduto = int.Parse(dgListaProdutos.CurrentRow.Cells[0].Value.ToString());
            qtd = int.Parse(tbQuantidade.Text);
            valorT = qtd * precoProduto;
            MessageBox.Show("idProduto: " + idenProduto +
                            "\nNome: " + nomeProd +
                            "\nPreço: " + precoProduto + 
                            "\nQuantidade: " + qtd 
                          + "\nValor Total: " + valorT) ;
        }
        //Grava no DataGrid os valores de cada item a quantidade e o valor
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            string nomeProd = dgListaProdutos.CurrentRow.Cells[1].Value.ToString();
            int idenProduto = int.Parse(dgListaProdutos.CurrentRow.Cells[0].Value.ToString());
            // IdProduto = idProdutoDataGridViewTextBoxColumn.ToString();
            dgCarrinho.Rows.Add(idenProduto, nomeProd, precoProduto, qtd, valorT);
            //MessageBox.Show(nomeProduto + "\n" + precoProduto + "\n" + qtd + "\n" + valorT);
            
           
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int IdenCliente = int.Parse(comboBox1.SelectedValue.ToString());
            float totalCompra=0;

            foreach (DataGridViewRow linha in dgCarrinho.Rows)
            {
                
                float valorVendaItem = float.Parse(linha.Cells[4].Value.ToString());
                totalCompra = totalCompra + valorVendaItem;

            }
            MessageBox.Show($" {IdenCliente}");
            tbTotal.Text = Convert.ToDouble(totalCompra).ToString();
        }
    }
}
