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
    public partial class Form1 : Form
    {
        public int IdRuta { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reporteDataSet.EnforceConstraints = false;
            this.cobradoresRutaTableAdapter.Fill(reporteDataSet.CobradoresRuta, IdRuta);
            this.reportViewer1.RefreshReport();
        }
    }
}
