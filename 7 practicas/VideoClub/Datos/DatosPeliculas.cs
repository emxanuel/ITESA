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
    public class DatosPeliculas
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());

        public DataTable mostrarNombrePeliculas(string nombre)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_mostrarNombrePelicula", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nombre", nombre);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            connection.Close();

            return dt;
        }
        
    }
}
