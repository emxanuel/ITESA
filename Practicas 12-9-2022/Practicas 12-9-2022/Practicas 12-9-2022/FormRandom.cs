using OpenXmlPowerTools;
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
    public partial class FormRandom : Form
    {
        int[] n = new int[5];
        int i = 0;
        public FormRandom()
        {
            InitializeComponent();
            label1.Text = "Numero " + (i + 1).ToString();
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int x = 0;
            listBox1.Items.Clear();
            while (x < 5)
            {
                listBox1.Items.Add(n[random.Next(5)]);
                x++;
            }
            x = 0;
            button1.Enabled = false;
            textBox1.Enabled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (i < 5)
            {
                if (e.KeyChar == (int)Keys.Enter)
                {
                    if (i < 5)
                    {
                        int.TryParse(textBox1.Text, out n[i]);
                        textBox1.Focus();
                        i++;
                        textBox1.Clear();
                        label1.Text = "Numero " + (i + 1).ToString();
                    }
                    if (i == 5)
                    {
                        label1.Text = "Numero 1";
                        button1.Enabled = true;
                        textBox1.Enabled = false;
                        
                    }
                }
            }
            else
            {
                Random random = new Random();
                i = 0;
                textBox1.Focus();
                textBox1.Clear();
            }

        }
    }
}
