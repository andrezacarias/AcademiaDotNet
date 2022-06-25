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
    public partial class Tela01 : Form
    {
        private Form frmAtivo;
        public Tela01()
        {
            InitializeComponent();
        }

        /// <summary>
        /// método que faz passar de um formulário para o outro
        /// </summary>
        /// <param name="frm"></param>
        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
        /// <summary>
        /// método para quando clicar em uma formulário fechar o outro
        /// </summary>
        private void ActiveFormClose()
        {
            if (frmAtivo != null)
            {
                frmAtivo.Close();
            }
        }
        /// <summary>
        /// método para mudar de cor a parte do menu selecionada
        /// </summary>
        /// <param name="frmAtivo"></param>
        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                ctrl.ForeColor = Color.Black;
            }

        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RHINO STORE AGRADECE SUA CONFIANÇA!! \n VOLTE SEMPRE!");
            Application.Exit();
        }
        private void Tela01_Load(object sender, EventArgs e)
        {

        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            ActiveButton(btnVendas);
            FormShow(new FormCadastroClientes());
        }
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            ActiveButton(btnProdutos);
            FormShow(new FormCadastroProdutos());
        }
        private void btnVendas_Click_1(object sender, EventArgs e)
        {
            ActiveButton(btnVendas);
            FormShow(new FormCadastroVendas());
        }
        private void btnSair_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("RHINO STORE AGRADECE SUA CONFIANÇA!! \n VOLTE SEMPRE!");
            Application.Exit();
        }
               
    }
}
