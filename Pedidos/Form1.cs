using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedidos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pedidosDataSet1.Reporte1' Puede moverla o quitarla según sea necesario.
            this.reporte1TableAdapter1.Fill(this.pedidosDataSet1.Reporte1);
            // TODO: esta línea de código carga datos en la tabla 'pedidosDataSet.Reporte1' Puede moverla o quitarla según sea necesario.
            this.reporte1TableAdapter.Fill(this.pedidosDataSet.Reporte1);
            this.reportViewer1.RefreshReport();
        }
    }
}