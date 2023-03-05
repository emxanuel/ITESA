using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capas
{
    public partial class FormEmpleados : MaterialSkin.Controls.MaterialForm
    {
        NegocioEmpleados negocio = new NegocioEmpleados();
        public FormEmpleados()
        {
            InitializeComponent();
            dtpFechaCon.CustomFormat = "yyyy-MM-dd";
            dtpFechaNac.CustomFormat = "yyyy-MM-dd";
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = negocio.mostrarEmpleados(tbBuscar.Text);
        }

        private void materialSingleLineTextField1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = negocio.mostrarEmpleados(tbBuscar.Text);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            float sueldo;
            float.TryParse(tbSueldo.Text, out sueldo);
            negocio.insertarEmpleados(tbNombre.Text, tbApellido.Text, tbCedula.Text, sueldo, 
                dtpFechaNac.Value.ToString("yyyy-MM-dd"), dtpFechaCon.Value.ToString("yyyy-MM-dd"), 
                tbTelefono.Text.ToString(), int.Parse(comboBoxDepartamento.Text));
            dataGridView1.DataSource = negocio.mostrarEmpleados(tbBuscar.Text);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int i;
            i = dataGridView1.SelectedRows.Count;
            if (i == 1)
            {
                i = dataGridView1.CurrentRow.Index;
                tbNombre.Text = dataGridView1.Rows[i].Cells["Nombre"].Value.ToString();
                tbApellido.Text = dataGridView1.Rows[i].Cells["Apellido"].Value.ToString();
                tbCedula.Text = dataGridView1.Rows[i].Cells["Cedula"].Value.ToString();
                tbSueldo.Text = dataGridView1.Rows[i].Cells["Sueldo"].Value.ToString();
                tbTelefono.Text = dataGridView1.Rows[i].Cells["Telefono"].Value.ToString();
                comboBoxDepartamento.Text = dataGridView1.Rows[i].Cells["Departamento"].Value.ToString();
                dtpFechaCon.Value = DateTime.Parse(dataGridView1.Rows[i].Cells["Fecha Contratacion"].Value.ToString());
                dtpFechaNac.Value = DateTime.Parse(dataGridView1.Rows[i].Cells["Fecha Nacimiento"].Value.ToString());
                tbId.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            float sueldo;
            float.TryParse(tbSueldo.Text, out sueldo);
            int id;
            int.TryParse(tbId.Text, out id);
            negocio.actualizarEmpleados(tbNombre.Text, tbApellido.Text, tbCedula.Text, sueldo,
                dtpFechaNac.Value.ToString("yyyy-MM-dd"), dtpFechaCon.Value.ToString("yyyy-MM-dd"),
                tbTelefono.Text.ToString(), int.Parse(comboBoxDepartamento.Text), id);
            dataGridView1.DataSource = negocio.mostrarEmpleados(tbBuscar.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(tbId.Text, out id);
            negocio.eliminarEmpleado(id);
            dataGridView1.DataSource = negocio.mostrarEmpleados(tbBuscar.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbApellido.Clear();
            tbCedula.Clear();
            tbId.Clear();
            tbNombre.Clear();
            tbSueldo.Clear();
            tbTelefono.Clear();
            comboBoxDepartamento.Text = "1";
            dtpFechaCon.Value = DateTime.Now;
            dtpFechaNac.Value = DateTime.Now;
            tbBuscar.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void tbSueldo_TextChanged(object sender, EventArgs e)
        {
            FormVehiculos f = new FormVehiculos();
            if (tbSueldo.Text != "")
            {
                if (f.verificarNumero(tbSueldo, btnActualizar, btnInsertar, btnEliminar) == false)
                {
                    MessageBox.Show("Inserte un numero");
                }
            }
            
        }
    }
}
