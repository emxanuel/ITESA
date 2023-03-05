using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tabla_Multiplicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(textBox1.Text, out n))
            {
                listBox1.Items.Clear();
                for (int i = 1; i <= 12; i++)
                {
                    listBox1.Items.Add(n + " x " + i + " = " + n * i);
                }
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                int n;
                if (int.TryParse(textBox1.Text, out n))
                {
                    listBox1.Items.Clear();
                    for (int i = 1; i <= 12; i++)
                    {
                        listBox1.Items.Add(n + " x " + i + " = " + n * i);
                    }
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
        }
    }
}
