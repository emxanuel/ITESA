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
    public partial class ClientesBalances : Form
    {
        public ClientesBalances()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                getIdRuta();
            }
        }

        void getIdRuta()
        {
            int idRuta;
            int.TryParse(textBox1.Text, out idRuta);
            var f = new Form2();
            f.IdRuta = idRuta;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getIdRuta();
        }
    }
}
