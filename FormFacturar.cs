using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;

namespace Capas
{
    public partial class FormFacturar : MaterialSkin.Controls.MaterialForm
    {
        NegocioOrden orden = new NegocioOrden();
        NegocioFactura factura = new NegocioFactura();

        public FormFacturar()
        {
            InitializeComponent();
            dataGridView1.DataSource = orden.buscarOrden(tbBuscarOrden.Text);
        }

        private void tbBuscarOrden_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = orden.buscarOrden(tbBuscarOrden.Text);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["Facturado"].Value.ToString() == "No")
            {
                factura.insertarFactura(int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()),
                    DateTime.Now.ToString("yyyy-MM-dd"), dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                MessageBox.Show("Factura procesada");
                factura.facturar(int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()));
                dataGridView1.DataSource = orden.buscarOrden(tbBuscarOrden.Text);
            }
            else
            {
                MessageBox.Show("Orden facturada anteriormente");
            }
        }
    }
}
