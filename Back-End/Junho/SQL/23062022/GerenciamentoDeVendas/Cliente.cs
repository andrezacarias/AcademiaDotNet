using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace GerenciamentoDeVendas
{
    internal class Cliente
    {
        public string nome;
        public string email;
        public string cpf;
        public string telefone;

        public Cliente(string nome, string email, string cpf, string telefone)
        {
            this.nome = nome;
            this.email = email;
            this.cpf = cpf;
            this.telefone = telefone;
        }

        public bool gravarCliente()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into Cliente values (@nomeCompleto, @email, @cpf, @celular);";
            command.Parameters.Add("@nomeCompleto", SqlDbType.VarChar);
            command.Parameters.Add("@email", SqlDbType.VarChar);
            command.Parameters.Add("@cpf", SqlDbType.VarChar);
            command.Parameters.Add("@celular", SqlDbType.VarChar);
            command.Parameters[0].Value = this.nome;
            command.Parameters[1].Value = this.email;
            command.Parameters[2].Value = this.cpf;
            command.Parameters[3].Value = this.telefone;

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

