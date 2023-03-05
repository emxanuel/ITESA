using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosFicha
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());

        public void insertarFicha(int idSocio, string nombreSocio, string nombrePelicula, string fecha)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_insertarFicha", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idSocio", idSocio);
            cmd.Parameters.AddWithValue("nombreSocio", nombreSocio);
            cmd.Parameters.AddWithValue("nombrePelicula", nombrePelicula);
            cmd.Parameters.AddWithValue("fechaFicha", fecha);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void devolver(string nombre)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_PeliculasDevueltas", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nombrePelicula", nombre);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable mostrarFichas()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_mostrarFicha '', '', ''", connection);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            connection.Close();

            return dt;
        }

    }
}
