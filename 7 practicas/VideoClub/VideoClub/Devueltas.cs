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
    public partial class Devueltas : Form
    {
        NegocioFicha negocio = new NegocioFicha();
        public Devueltas()
        {
            InitializeComponent();
        }

        private void Devueltas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = negocio.mostrarFichas();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            negocio.devolver(dataGridView1.CurrentRow.Cells["NombrePelicula"].Value.ToString());
            MessageBox.Show("Pelicula devuelta");
        }
    }
}
