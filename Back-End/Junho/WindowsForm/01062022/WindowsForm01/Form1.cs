namespace WindowsForm01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTOk_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Cliquei no bot�o OK!");
            MessageBox.Show("O nome do usu�rio digitado � " + tbNome.Text + "\n" +
                "  o e-mail do usu�rio digitado � " + tbEmail.Text + "\n" +
                "  o endere�o do usu�rio digitado � " + tbEndereco.Text + "\n" +
                "  o telefone do usu�rio digitado � " + tbTelefone.Text + "\n" +
                "  o bairro do usu�rio digitado � " + tbBairro.Text + "\n" +
                "  a cidade do usu�rio digitado � " + tbCidade.Text + "\n" +
                "  o sexo do usu�rio digitado � " + tbSexo.Text);
            MessageBox.Show("Cadastro efetuado com sucesso");
        }

        private void BTCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no bot�o Cancelar!");
        }

   
    }
}