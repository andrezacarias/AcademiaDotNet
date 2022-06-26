using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GerenciamentoDeVendas
{
    internal class Banco
    {
        //String com o caminho do Banco de Dados
        string stringConexao = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=RhinoStore_DB;TrustServerCertificate=True;Integrated Security=True";
        private SqlConnection cn;

        private void conexao()//vincular a string com o cn, bm inicia o CN
        {
            cn = new SqlConnection(stringConexao);
            //cn = new SqlConnection(conexaoString);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                //tentar fazer algo
                conexao();
                cn.Open();

                return cn;
            }
            catch (Exception ex)
            {
                //faz algo se deu erro
                return null;
            }
        }

        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception e)
            {
                return;
            }
        }

       
    }
}
