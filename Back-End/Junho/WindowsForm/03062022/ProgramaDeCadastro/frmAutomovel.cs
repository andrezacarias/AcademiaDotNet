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
    public partial class frmAutomovel : Form
    {
        static List<Carro> carros = new List<Carro>();
        public frmAutomovel()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbFabricante.Clear();
            tbModeloCarro.Clear();
            foreach (int checados in lbOpcionais.CheckedIndices)
            {
                lbOpcionais.SetItemChecked(checados, false);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool ac = false, dh = false, abs = false, ve = false, ab = false;
            int portas;
            foreach (string opc in lbOpcionais.CheckedItems)
            {
                if (opc == "Ar condicionado")
                {
                    ac = true;
                }
                if (opc == "Direção hidráulica")
                {
                    dh = true;
                }
                if (opc == "Freios ABS")
                {
                    abs = true;
                }
                if (opc == "Vidros elétricos")
                {
                    ve = true;
                }
                if (opc == "Air bag")
                {
                    ab = true;
                }
            }
            portas = 0;
            if (cbQtdPortas.Text == "2 portas") portas = 2;
            else if (cbQtdPortas.Text == "3 portas") portas = 3;
            else if (cbQtdPortas.Text == "4 portas") portas = 4;
            else if (cbQtdPortas.Text == "5 portas") portas = 5;
            Carro c = new Carro(tbModeloCarro.Text, tbFabricante.Text, ac, dh, abs, ab, ve, portas);
            //c.MostrarDadosCarro();
            carros.Add(c);
            //mostraListadeCarros();
            dgAutomoveis.Rows.Add(tbModeloCarro.Text, tbFabricante.Text, ac, dh, abs, ab, ve, portas);
        }
        static void mostraListadeCarros() 
        {
            foreach(Carro c in carros)
            {
                MessageBox.Show("Carro " + c.modelo + 
                    "\nFabricante " + c.fabricante + 
                    "\nDH " + c.dh + 
                    "\nAr " + c.ar + 
                    "\nABS " + c.abs + 
                    "\nAir bag " + c.airbag + 
                    "\nVidros eletrico " + c.ve + 
                    "\nPortas " + c.portas);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbOpcionais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

