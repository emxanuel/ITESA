using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uno
{
    public partial class Form1 : Form
    {
        int index = 0, menor, mayor;
        int[] arreglo = new int[3];

        private void button1_Click(object sender, EventArgs e)
        {
            if (index > 3)
                return;

            arreglo[index] = Convert.ToInt32(numerotxt.Text);

            index++;
        }

        private void calculartxt_Click(object sender, EventArgs e)
        {
            menor = arreglo.Min();
            mayor = arreglo.Max();

            mayortxt.Text = mayor.ToString();
            menortxt.Text = menor.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
