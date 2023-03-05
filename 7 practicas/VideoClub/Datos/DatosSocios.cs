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
    public class DatosSocios
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());

        public DataTable mostrarSocios(string nombre)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_mostrarSocio", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nombre", nombre);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            connection.Close();

            return dt;
        }

        public void insertarSocios(string nombre, string telefono, string direccion, string actores, string generos, string directores)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_insertarSocio", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nombre", nombre);
            cmd.Parameters.AddWithValue("direccion", direccion);
            cmd.Parameters.AddWithValue("telefono", telefono);
            cmd.Parameters.AddWithValue("directoresFavoritos", directores);
            cmd.Parameters.AddWithValue("generosFavoritos", generos);
            cmd.Parameters.AddWithValue("actoresFavoritos", actores);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable mostrarNombreSocio(string nombre)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_mostrarNombreSocio", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nombre", nombre);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            connection.Close();

            return dt;
        }

        public int idSocio(string nombre)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select idSocio from socio where nombreSocio = @nombre", connection);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return int.Parse(reader[0].ToString());
            }
            connection.Close();

            return 1;

        }
    }
}
