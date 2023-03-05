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
    public partial class Form1 : Form
    {
        NegocioPeliculas Peliculas = new NegocioPeliculas();
        NegocioSocios Socios = new NegocioSocios();
        NegocioFicha Ficha = new NegocioFicha();
        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = Peliculas.mostrarNombrePeliculas(tbBuscarPelicula.Text);
            comboBox1.DisplayMember = "NombrePelicula";
            comboBox1.ValueMember = "NombrePelicula";

            comboBox2.DataSource = Socios.mostrarNombreSocio(tbBuscarSocio.Text);
            comboBox2.DisplayMember = "Nombre";
            comboBox2.ValueMember = "NombreSocio";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Ficha.insertarFicha(Socios.idSocio(comboBox2.Text), comboBox2.Text, comboBox1.Text,
                DateTime.Now.ToString("yyyy-MM-dd"));
                MessageBox.Show("Ficha creada con exito");
            }
            catch
            {
                MessageBox.Show("Pelicula no disponible, se le llamara cuando lo esté");
            }
            
        }

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSocios form = new FormSocios();
            form.Show();
        }

        private void peliculasADevolverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devueltas form = new Devueltas();
            form.Show();
        }
    }
}
