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
    internal class Cliente
    {
        public string nome;
        public string email;
        public string telefone;

        public Cliente(string nome, string email, string telefone)
        {
            this.nome = nome;
            this.email = email;
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
            command.CommandText = "insert into Clientes values (@nome, @telefone, @email);";
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@email", SqlDbType.VarChar);
            command.Parameters.Add("@telefone", SqlDbType.VarChar);
            command.Parameters[0].Value = this.nome;
            command.Parameters[1].Value = this.email;
            command.Parameters[2].Value = this.telefone;
         

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
                MessageBox.Show("Cadastro efetuado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

