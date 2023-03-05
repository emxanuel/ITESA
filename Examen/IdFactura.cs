using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class IdFactura : Form
    {
        public IdFactura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(textBox1.Text, out id);
            var f = new Form1();
            f.IdFactura = id;
            f.Show();
        }
    }
}
