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
    public partial class FormSeleccionarClientes : MaterialSkin.Controls.MaterialForm
    {
        FormOrden parent = new FormOrden();
        NegocioClientes negocio = new NegocioClientes();
        public FormSeleccionarClientes(FormOrden f)
        {
            parent = f;
            InitializeComponent();
        }

        private void FormSeleccionarClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = negocio.buscarCLiente(tbBuscarCliente.Text);
        }

        private void tbBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = negocio.buscarCLiente(tbBuscarCliente.Text);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int i, id;
            string nombre;
            i = dataGridView1.SelectedRows.Count;
            if (i == 1)
            {
                i = dataGridView1.CurrentRow.Index;
                nombre = dataGridView1.Rows[i].Cells[3].Value.ToString() + " " + 
                    dataGridView1.Rows[i].Cells[1].Value.ToString() + " " + 
                    dataGridView1.Rows[i].Cells[2].Value.ToString();
                id = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                parent.tbCliente.Text = nombre;
                parent.idCliente = id;
            }
            this.Close();
        }
    }
}
