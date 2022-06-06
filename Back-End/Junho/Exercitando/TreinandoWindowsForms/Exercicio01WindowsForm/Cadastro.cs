using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Exercicio01WindowsForm
{
    public class Cadastro
    {
        public TextBox tbNome;
        public MaskedTextBox tbTelefone;
        public MaskedTextBox tbCPF;
        public TextBox tbLogin;
        public TextBox tbSenha;
        public ComboBox cbStatus;
        public ComboBox cbTipo;

        public string nome { get; set; }    
        public string telefone { get; set; }
        public string cpf { get; set; }
        public string Login { get; set; }
        public string senha { get; set; }
        public string status { get; set; }
        public string tipo { get; set; }
        public Cadastro(string nome, string telefone, string cpf, string login, string senha, string status, string tipo)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.cpf = cpf;
            Login = login;
            this.senha = senha;
            this.status = status;
            this.tipo = tipo;
        }

        public Cadastro(TextBox tbNome, MaskedTextBox tbTelefone, MaskedTextBox tbCPF, TextBox tbLogin, TextBox tbSenha, ComboBox cbStatus, ComboBox cbTipo)
        {
            this.tbNome = tbNome;
            this.tbTelefone = tbTelefone;
            this.tbCPF = tbCPF;
            this.tbLogin = tbLogin;
            this.tbSenha = tbSenha;
            this.cbStatus = cbStatus;
            this.cbTipo = cbTipo;
        }
       

        public static void gravarArquivo(Cadastro o)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("cadastro.txt", true);

                escritor.WriteLine(o.tbNome.Text + "," + o.tbTelefone.Text  + "," + o.tbCPF.Text + "," + o.tbLogin.Text + "," + o.tbSenha.Text + "," + o.cbStatus.Text + "," + o.cbTipo.Text);
                escritor.Flush();
                escritor.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Arquivo de cadastro com problemas" + e.Message);
            }
        }


        public void MostrarDadosCadastro()
        {
            MessageBox.Show("Nome: " + tbNome.Text +
          "\nTelefone: " + tbTelefone.Text +
          "\nCPF: " + tbCPF.Text +
          "\nLogin: " + tbLogin.Text +
          "\nSenha: " + tbSenha.Text +
          "\nStatus: " + cbStatus.Text +
          "\nTipo: " + cbTipo.Text);

        }
    }

    
    
}
