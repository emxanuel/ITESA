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
    public partial class Form3 : Form
    {
        public int IdCliente { get; set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.facturaTableAdapter.Fill(reporteDataSet.Factura, IdCliente);
            this.reportViewer1.RefreshReport();
        }
    }
}
