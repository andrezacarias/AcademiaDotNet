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
    public partial class Form1 : Form
    {
        public Form1()
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
            c.MostrarDadosCarro();
        }
    }
}

