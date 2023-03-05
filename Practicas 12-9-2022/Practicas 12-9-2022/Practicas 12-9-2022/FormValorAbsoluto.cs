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
    public partial class FormValorAbsoluto : Form
    {
        public FormValorAbsoluto()
        {
            InitializeComponent();
        }

        private void tbInicio_TextChanged(object sender, EventArgs e)
        {
            double n;
            double.TryParse(tbNumero.Text, out n);
            tbValorAbsoluto.Text = Math.Abs(n).ToString();
        }
    }
}
