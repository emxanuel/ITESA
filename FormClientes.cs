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
    public partial class FormClientes : MaterialSkin.Controls.MaterialForm
    {
        NegocioClientes conexion = new NegocioClientes();
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conexion.mostrarClientes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(tbIdCliente.Text, out id);
            conexion.eliminarCliente(id);

            dataGridView1.DataSource = conexion.mostrarClientes();
        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {
            /*nombre, apellido, trato, docIden, doc, correo,
                telefono, direccion, fechaNac, tipoCliente, tarifa, id*/
            int id, tarifa;
            int.TryParse(tbIdCliente.Text, out id);
            int.TryParse(tbTarifa.Text, out tarifa);
            conexion.actualizarCliente(tbNombre.Text, tbApellido.Text, tbTrato.Text, tbDocIden.Text,
                tbIden.Text, tbCorreo.Text, tbTelefono.Text, tbDireccion.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), tbTipoCliente.Text,
                tarifa, id);
            dataGridView1.DataSource = conexion.mostrarClientes();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            int tarifa;
            int.TryParse(tbTarifa.Text, out tarifa);
            conexion.insertarCliente(tbNombre.Text, tbApellido.Text, tbTrato.Text, tbDocIden.Text,
                tbIden.Text, tbCorreo.Text, tbTelefono.Text, tbDireccion.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), tbTipoCliente.Text,
                tarifa);
            dataGridView1.DataSource = conexion.mostrarClientes();
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            if(tbBuscar.Text != "")
            {
                dataGridView1.DataSource = conexion.buscarCLiente(tbBuscar.Text);
            }
            else
            {
                dataGridView1.DataSource = conexion.mostrarClientes(); 
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
