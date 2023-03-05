using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capas
{
    public partial class FormOrden : MaterialSkin.Controls.MaterialForm
    {
        NegocioVehiculo negocio = new NegocioVehiculo();
        NegocioOrden orden = new NegocioOrden();
        NegocioVehiculo vehiculo = new NegocioVehiculo();
        public int idCliente;
        public FormOrden()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormEmpleados();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormVehiculos();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "Vehiculo";
            comboBox1.ValueMember = "Vehiculo";
            comboBox1.DataSource = negocio.listarVehiculos(comboBox1.Text);
            TbNumeroOrden.Text = (orden.numeroOrden() + 1).ToString();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbBuscarVehiculo_TextChanged(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "Vehiculo";
            comboBox1.ValueMember = "Vehiculo";
            comboBox1.DataSource = negocio.listarVehiculos(tbBuscarVehiculo.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e) 
        {
            dataGridView1.Rows.Add(comboBox1.Text, tbCliente.Text, "Juana Severino", 
                dateTimePicker1.Value.ToString("yyyy-MM-dd"), comboBox2.Text, tbDias.Text, vehiculo.montoVehiculo(comboBox1.Text));
            btnAgregarBD.Enabled = true;
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormClientes();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void seleccionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormSeleccionarClientes(this);
            form.Show();
        }

        private void btnAgregarBD_Click(object sender, EventArgs e)
        {
            int numero;
            numero = int.Parse(TbNumeroOrden.Text);
            float monto = 0;
            string fecha, fechaEntrega, metodoPago, nombre;
            nombre = tbCliente.Text;
            fecha = DateTime.Now.ToString("yyyy-MM-dd");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                try 
                { 
                    monto += float.Parse(dataGridView1.Rows[i].Cells["Monto"].Value.ToString()); 
                }
                catch { }
            }
            if (MessageBox.Show("Esta a punto de agregarle una orden a el/la cliente " + nombre + " por un monto de " + monto + " por "+tbDias.Text+" dias", ", ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    fechaEntrega = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    metodoPago = comboBox2.Text;
                    try
                    {

                        orden.insertarOrden(numero, dataGridView1.Rows[i].Cells["Vehiculo"].Value.ToString(),
                        orden.idVehiculo(dataGridView1.Rows[i].Cells["Vehiculo"].Value.ToString()),
                        idCliente, orden.idEmpleado(dataGridView1.Rows[i].Cells[2].Value.ToString()),
                        fecha, fechaEntrega, metodoPago, int.Parse(tbDias.Text));
                        TbNumeroOrden.Text = (orden.numeroOrden() + 1).ToString();
                    }
                    catch
                    {

                    }
                }
                dataGridView1.Rows.Clear();
                btnAgregarBD.Enabled = false;
                MessageBox.Show("Orden procesada");
            }
            else
            {
                dataGridView1.Rows.Clear();
                MessageBox.Show("Orden no procesada");
            }
            
            
        }

        private void tbDias_TextChanged(object sender, EventArgs e)
        {
            bool convertir;
            int n;
            convertir = int.TryParse(tbDias.Text, out n);
            if (tbDias.Text != "")
            {
                if (convertir == false)
                {
                    btnAgregar.Enabled = false;
                    MessageBox.Show("Inserte un numero");
                }
                else
                {
                    btnAgregar.Enabled = true;
                }
            }
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormFacturar();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
