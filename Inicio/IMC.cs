using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    public partial class Tela : Form
    {
        public Tela()
        {
            InitializeComponent();
        }

        private void Tela_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPeso.Text = " ";
            txtAltura.Text = " ";
            lblResultado.Text = " ";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt01_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCalcular_Click(object sender, EventArgs e)
        {
            Double num01, num02, Resultado1, Resultado2;
            num01 = Convert.ToDouble(txtAltura.Text);
            num02 = Convert.ToDouble(txtPeso.Text);
            Resultado1 = num01 * num01;
            Resultado2 = num02 / Resultado1;
            if (Resultado2 < 16)
            lblResultado.Text = "Magreza grave.";
            if (Resultado2 > 16 && Resultado2 < 17)
            lblResultado.Text = "Magreza moderada.";
            if (Resultado2 > 17 && Resultado2 < 19)
                lblResultado.Text = "Magreza leve.";
            if (Resultado2 > 19 && Resultado2 < 25)
                lblResultado.Text = "Saudável";
            if (Resultado2 > 25 && Resultado2 < 30)
                lblResultado.Text = "Sobrepeso";
            if (Resultado2 > 30 && Resultado2 < 35)
                lblResultado.Text = "Obesidade grau 1";
            if (Resultado2 > 35 && Resultado2 < 40)
                lblResultado.Text = "Obesidade grau 2";
            if (Resultado2 > 40)
                lblResultado.Text = "Obesidade grau 3";
        }
    }
}
