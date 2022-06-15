using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Glicemia_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void limparTextBox()
        {
            textBox_DataMedida.Text = "";
            textBox_idGlicemia.Text = "";
            textBox_idPaciente.Text = "";
            textBox_ValorGlicemia.Text = "";
        }

        private string conexaoString = ConfigurationManager.ConnectionStrings["GlicemiaDBString"].ConnectionString;
        private void carregarListView()
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            string sqlTexto = "SELECT idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente FROM MedidaGlicemia";
            SqlCommand comando = new SqlCommand(sqlTexto, conexao);

            listView_medidasGlicemia.Items.Clear();
            SqlDataReader leitor = comando.ExecuteReader();
            int i = 0;
            while (leitor.Read())
            {
                listView_medidasGlicemia.Items.Add(leitor["idMedidaGlicemia"].ToString());
                listView_medidasGlicemia.Items[i].SubItems.Add(leitor["valorGlicemia"].ToString());
                listView_medidasGlicemia.Items[i].SubItems.Add(leitor["dataMedida"].ToString());
                listView_medidasGlicemia.Items[i].SubItems.Add(leitor["idPaciente"].ToString());
                i++;
            }

            conexao.Close();
        }
        private void button_Conectar_Click(object sender, EventArgs e)
        {
            carregarListView();
            button_Conectar.Enabled = false;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //capturar valores das variáveis
                int idMedidaGlicemia = int.Parse(textBox_idGlicemia.Text);
                int valorGlicemia = int.Parse(textBox_ValorGlicemia.Text);
                string dataMedida = textBox_DataMedida.Text;
                int idPaciente = int.Parse(textBox_idPaciente.Text);

                //gerar sentenças SQL
                string sqlTexto = "INSERT INTO MedidaGlicemia (idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente) VALUES(@idMedidaGlicemia, @valorGlicemia, @dataMedida, @idPaciente)";
                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);
                comando.Parameters.AddWithValue("@valorGlicemia", valorGlicemia);
                comando.Parameters.AddWithValue("@dataMedida", dataMedida);
                comando.Parameters.AddWithValue("@idPaciente", idPaciente);

                //executar sentença SQL
                comando.ExecuteNonQuery();
            }
            catch (Exception error)
            {
            }

            conexao.Close();

            //recarregar ListView
            carregarListView();
            limparTextBox();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //lembre que o remover está relacionado com ListView e a região
            //selecionada

            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //MessageBox.Show(listView_medidasGlicemias.SelectedItems[0].Text);
                int idMedidaGlicemia = int.Parse(listView_medidasGlicemia.SelectedItems[0].Text);

                //gerar sentenças SQL
                string sqlTexto = "DELETE FROM MedidaGlicemia WHERE idMedidaGlicemia = @idMedidaGlicemia";

                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);

                //executar sentença SQL
                comando.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


            conexao.Close();

            //recarregar ListView
            carregarListView();
        }
    }


}
