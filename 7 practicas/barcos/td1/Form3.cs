using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace td1
{
    public partial class Form3 : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection conexion = new SqlConnection("server=MYNOR; database=diori ; integrated security = true");
        public Form3()
        {
            InitializeComponent();
            dataGridView1.DataSource = llamada();
            dataGridView2.DataSource = llamada1();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        public DataTable llamada()

        {
            conexion.Open();
            string klk = "select nombre,apellido,cedula,fecha_de_nacimiento,A.direccion,telefono,nombre_barco,numero_amarre,cuota from propietario A inner join barcos B on A.id_propietario = B.id_propietario";
            SqlCommand cmd = new SqlCommand(klk, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);
            conexion.Close();
            return dataTable;
        }
        public DataTable llamada1()

        {
            conexion.Open();
            string klk = "select nombre,apellido,cedula,fecha_de_nacimiento,telefono,nombre_barco,hora_salida,fecha_salida,B.direccion from patron A inner join barcos B on A.id_patron = B.id_patron";
            SqlCommand cmd = new SqlCommand(klk, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);
            conexion.Close();
            return dataTable;
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
