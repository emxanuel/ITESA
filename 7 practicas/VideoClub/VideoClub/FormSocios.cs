using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace VideoClub
{
    public partial class FormSocios : Form
    {
        NegocioSocios negocio = new NegocioSocios();
        public FormSocios()
        {
            InitializeComponent();
        }

        private void Socios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = negocio.mostrarSocios(tbBuscar.Text);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            negocio.insertarSocio(tbNombre.Text, tbTelefono.Text, tbDireccion.Text, tbActores.Text, tbGeneros.Text, tbDirectores.Text);
            dataGridView1.DataSource = negocio.mostrarSocios(tbBuscar.Text);
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = negocio.mostrarSocios(tbBuscar.Text);
        }
    }
}
