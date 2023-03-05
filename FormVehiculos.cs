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
using MaterialSkin.Controls;

namespace Capas
{
    public partial class FormVehiculos : MaterialSkin.Controls.MaterialForm
    {
        NegocioVehiculo negocio = new NegocioVehiculo();
        public FormVehiculos()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            float kilometraje, tarifa;
            float.TryParse(tbKilometraje.Text, out kilometraje);
            float.TryParse(tbTarifa.Text, out tarifa);
            int capacidad;
            int.TryParse(tbCapacidad.Text, out capacidad);
            negocio.insertarVehiculo(tbMarca.Text, tbModelo.Text, tbTipo.Text, tbAño.Text, kilometraje, 
                capacidad, tbCombustible.Text, tarifa, int.Parse(tbCantidad.Text));
            dataGridView1.DataSource = negocio.mostrarVehiculos(tbBuscar.Text);
        }

        private void FormVehiculos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = negocio.mostrarVehiculos(tbBuscar.Text);
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = negocio.mostrarVehiculos(tbBuscar.Text);
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            float kilometraje, tarifa;
            float.TryParse(tbKilometraje.Text, out kilometraje);
            float.TryParse(tbTarifa.Text, out tarifa);
            int capacidad, id;
            int.TryParse(tbCapacidad.Text, out capacidad);
            int.TryParse(tbId.Text, out id);
            negocio.actualizarVehiculo(tbMarca.Text, tbModelo.Text, tbTipo.Text, tbAño.Text, kilometraje,
                capacidad, tbCombustible.Text, tarifa, id, int.Parse(tbCantidad.Text));
            dataGridView1.DataSource = negocio.mostrarVehiculos(tbBuscar.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(tbId.Text, out id);
            negocio.eliminarVehiculo(id);
            dataGridView1.DataSource = negocio.mostrarVehiculos(tbBuscar.Text);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int i;
            i = dataGridView1.SelectedRows.Count;
            if (i == 1)
            {
                i = dataGridView1.CurrentRow.Index;
                tbMarca.Text = dataGridView1.Rows[i].Cells["Marca"].Value.ToString();
                tbModelo.Text = dataGridView1.Rows[i].Cells["Modelo"].Value.ToString();
                tbTipo.Text = dataGridView1.Rows[i].Cells["Tipo auto"].Value.ToString();
                tbAño.Text = dataGridView1.Rows[i].Cells["Año"].Value.ToString();
                tbKilometraje.Text = dataGridView1.Rows[i].Cells["Kilometraje"].Value.ToString();
                tbCapacidad.Text = dataGridView1.Rows[i].Cells["Capacidad"].Value.ToString();
                tbCombustible.Text = dataGridView1.Rows[i].Cells["Tipo combustible"].Value.ToString();
                tbTarifa.Text = dataGridView1.Rows[i].Cells["Tarifa"].Value.ToString();
                tbId.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                tbCantidad.Text = dataGridView1.Rows[i].Cells["cantidad"].Value.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbMarca.Text = "";
            tbModelo.Text = "";
            tbTipo.Text = "";
            tbAño.Text = "";
            tbKilometraje.Text = "";
            tbCapacidad.Text = "";
            tbCombustible.Text = "";
            tbTarifa.Text = "";
            tbId.Text = "";
            tbCantidad.Clear();
        }

        public bool verificarNumero(MaterialSingleLineTextField tb, MaterialRaisedButton btn1, MaterialRaisedButton btn2, 
            MaterialRaisedButton btn3)
        {
            bool convertir;
            int n;
            convertir = int.TryParse(tb.Text, out n);
            if (tbCantidad.Text != "")
            {
                if (convertir == false)
                {
                    btn1.Enabled = false;
                    btn2.Enabled = false;
                    btn3.Enabled = false;
                }
                else
                {
                    btn1.Enabled = true;
                    btn2.Enabled = true;
                    btn3.Enabled = true;
                }
            }
            return convertir;
        }

        private void tbCantidad_TextChanged(object sender, EventArgs e)
        {
            if (tbCantidad.Text != "")
            {
                if (verificarNumero(tbCantidad, btnActualizar, btnInsertar, btnEliminar) == false)
                {
                    MessageBox.Show("Inserte un numero");
                }
            }
            
        }

        private void tbKilometraje_TextChanged(object sender, EventArgs e)
        {
            if (tbKilometraje.Text != "")
            {
                if (verificarNumero(tbKilometraje, btnActualizar, btnInsertar, btnEliminar) == false)
                {
                    MessageBox.Show("Inserte un numero");
                }
            }
            
        }

        private void tbAño_TextChanged(object sender, EventArgs e)
        {
            if(tbAño.Text != "")
            {
                if (verificarNumero(tbAño, btnActualizar, btnInsertar, btnEliminar) == false)
                {
                    MessageBox.Show("Inserte un numero");
                }
            }
            
        }

        private void tbTarifa_TextChanged(object sender, EventArgs e)
        {
            if (tbTarifa.Text != "")
            {
                if (verificarNumero(tbTarifa, btnActualizar, btnInsertar, btnEliminar) == false)
                {
                    MessageBox.Show("Inserte un numero");
                }
            }
            
            
        }
    }
}
