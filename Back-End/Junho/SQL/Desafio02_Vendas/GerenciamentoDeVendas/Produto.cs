using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GerenciamentoDeVendas
{
    internal class Produto
    {
        public string nomeProduto;
        public double preco;
        public int estoque;
        public int codEan;

        public Produto(string nomeProduto, double preco, int estoque, int codEan)
        {
            this.nomeProduto = nomeProduto;
            this.preco = preco;
            this.estoque = estoque;
            this.codEan = codEan;
        }

        
        public bool gravarProduto()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into produtos values (@nome, @preco, @estoque, @codEAN);";
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@preco", SqlDbType.Float);
            command.Parameters.Add("@estoque", SqlDbType.Int);
            command.Parameters.Add("@codEAN", SqlDbType.Int);
            command.Parameters[0].Value = nomeProduto;
            command.Parameters[1].Value = preco;
            command.Parameters[2].Value = estoque;
            command.Parameters[3].Value = codEan;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                tran.Rollback();
                return false;
            }
            finally
            {
                banco.fecharConexao();
            }
        }
    }
}
