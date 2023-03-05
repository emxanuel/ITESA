using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace Ejercicios
{
    public partial class Form4 : Form
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public Form4()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void CargarAviones()
        {
      
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     
        private void Form4_Load(object sender, EventArgs e)
        {

            string consulta = "Select * from aviones";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dtgtablas.DataSource = dt;
            CargarAviones();
        }

        private void avionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string consulta = "Select * from aviones";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dtgtablas.DataSource = dt;
        }

        private void pilotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string consulta = "Select * from pilotos";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dtgtablas.DataSource = dt;
        }

        private void miembrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string consulta = "Select * from miembros";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dtgtablas.DataSource = dt;
        }
    }
}
