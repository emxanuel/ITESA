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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int IdRuta { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.balancesTableAdapter.Fill(reporteDataSet.Balances, IdRuta);
            this.reportViewer1.RefreshReport();
        }
    }
}
