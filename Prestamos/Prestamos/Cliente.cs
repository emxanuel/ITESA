using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Prestamos
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        int idCliente;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                getIdClient();
            }
        }

        void getIdClient()
        {
            int.TryParse(textBox1.Text, out idCliente);
            var f = new Form3();
            this.Hide();
            f.IdCliente = idCliente;
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getIdClient();
        }
    }
}
