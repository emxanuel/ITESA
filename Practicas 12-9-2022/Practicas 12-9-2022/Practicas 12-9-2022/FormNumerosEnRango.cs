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
    public partial class FormNumerosEnRango : Form
    {
        public FormNumerosEnRango()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int inicio, fin, cuenta = 0;
            int.TryParse(tbInicio.Text, out inicio);
            int.TryParse(tbFin.Text, out fin);
            for (int i = inicio + 1; i < fin; i++)
            {
                cuenta++;
            }
            textBox1.Text = cuenta.ToString();
            label3.Text = "Numeros entre " + inicio + " y " + fin + "";
        }
    }
}
