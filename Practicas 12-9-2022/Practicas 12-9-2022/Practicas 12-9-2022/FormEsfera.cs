using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas_12_9_2022
{
    public partial class FormEsfera : Form
    {
        public FormEsfera()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radio, diametro, circunferencia, volumen;
            double.TryParse(tbRadio.Text, out radio);
            diametro = radio * 2;
            circunferencia = Math.Round(2 * Math.PI * radio, 2);
            volumen = Math.Round(Math.Pow(radio, 3) * 4 / 3, 2);
            tbCircunferencia.Text = circunferencia.ToString();
            tbDiametro.Text = diametro.ToString();
            tbVolumen.Text = volumen.ToString();
        }
    }
}
