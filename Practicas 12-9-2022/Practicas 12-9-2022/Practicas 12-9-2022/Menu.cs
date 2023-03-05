using Calculadora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tabla_Multiplicar;

namespace Practicas_12_9_2022
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCalcIf_Click(object sender, EventArgs e)
        {
            var form = new FormCalculadoraIf();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnCalcSwitch_Click(object sender, EventArgs e)
        {
            var form = new FormCalculadoraSwitch();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnConversionTemperatura_Click(object sender, EventArgs e)
        {
            var form = new FormConversionTemperatura();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnDibujarCuadrado_Click(object sender, EventArgs e)
        {
            var form = new FormCuadrado();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnDimensionesEsfera_Click(object sender, EventArgs e)
        {
            var form = new FormEsfera();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            var form = new FormExcel();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnFichero_Click(object sender, EventArgs e)
        {
            var form = new FormFichero();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnNumerosEnRango_Click(object sender, EventArgs e)
        {
            var form = new FormNumerosEnRango();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            var form = new FormRandom();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnTablaMultiplicar_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnValorAbsoluto_Click(object sender, EventArgs e)
        {
            var form = new FormValorAbsoluto();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            var form = new FormCalculadora();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
