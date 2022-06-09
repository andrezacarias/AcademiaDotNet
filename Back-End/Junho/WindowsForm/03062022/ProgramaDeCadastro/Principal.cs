using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaDeCadastro
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAutomovel fauto = new frmAutomovel();
            fauto.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void automóvelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutomovel fauto = new frmAutomovel();
            fauto.ShowDialog();
        }
    }
}
