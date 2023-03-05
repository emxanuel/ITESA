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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pedidosDataSet.Reporte4' Puede moverla o quitarla según sea necesario.
            this.reporte4TableAdapter.Fill(this.pedidosDataSet.Reporte4);
            // TODO: esta línea de código carga datos en la tabla 'pedidosDataSet.Reporte4' Puede moverla o quitarla según sea necesario.
            this.reporte4TableAdapter.Fill(this.pedidosDataSet.Reporte4);

            this.reportViewer1.RefreshReport();
        }
    }
}
