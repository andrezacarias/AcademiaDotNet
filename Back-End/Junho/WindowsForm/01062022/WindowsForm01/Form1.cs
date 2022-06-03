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
            // MessageBox.Show("Cliquei no botão OK!");
            MessageBox.Show("O nome do usuário digitado é " + tbNome.Text + "\n" +
                "  o e-mail do usuário digitado é " + tbEmail.Text + "\n" +
                "  o endereço do usuário digitado é " + tbEndereco.Text + "\n" +
                "  o telefone do usuário digitado é " + tbTelefone.Text + "\n" +
                "  o bairro do usuário digitado é " + tbBairro.Text + "\n" +
                "  a cidade do usuário digitado é " + tbCidade.Text + "\n" +
                "  o sexo do usuário digitado é " + tbSexo.Text);
            MessageBox.Show("Cadastro efetuado com sucesso");
        }

        private void BTCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no botão Cancelar!");
        }

   
    }
}