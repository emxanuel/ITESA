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
    public partial class FormCuadrado : Form
    {
        public FormCuadrado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = 0;
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(pictureBox1.BackColor);
            Pen pen = new Pen(Color.Blue, 3);
            int.TryParse(textBox1.Text, out size);
            graphics.DrawRectangle(pen, 0, 0, size, size);
        }

    }
}
