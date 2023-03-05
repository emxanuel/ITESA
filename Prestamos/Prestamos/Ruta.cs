using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestamos
{
    public partial class Ruta : Form
    {
        int idRuta;
        public Ruta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getIdRuta();
        }

        void getIdRuta()
        {
            int.TryParse(textBox1.Text, out idRuta);
            var f = new Form1();
            this.Hide();
            f.IdRuta = idRuta;
            f.ShowDialog();
            this.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                getIdRuta();
            }
        }
    }
}
