using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GerenciamentoDeVendas
{
    internal class Vendas
    {
        public int idVendas;
        public int codigoCliente;
        public float valorTotal;

        public Vendas(int idVendas, int codigoCliente, float valorTotal)
        {
            this.idVendas = idVendas;
            this.codigoCliente = codigoCliente;
            this.valorTotal = valorTotal;
        }
        public bool gravarVendas()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into Cliente values (@codigoCliente, @valorTotal);";
            command.Parameters.Add("@codigoCliente", SqlDbType.Int);
            command.Parameters.Add("@valorTotal", SqlDbType.Float);
            command.Parameters[0].Value = this.codigoCliente;
            command.Parameters[1].Value = this.valorTotal;
        ;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
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
