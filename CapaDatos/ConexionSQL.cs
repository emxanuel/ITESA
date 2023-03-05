using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security;

namespace CapaDatos
{
    public class ConexionSQL
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ToString());

        public DataTable mostrarClientes()
        {
            connection.Open();
            string query = "exec sp_mostrarCliente";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            connection.Close();

            return dt;
        }

        public int insertarCliente(string nombre, string apellido, string trato, string docIden,
            string doc, string correo, string telefono, string direccion, string fechaNac,
            string tipoCliente, int tarifa)
        {
            int verificar;
            connection.Open();
            string query = "exec sp_insertarCliente '" + nombre + "', '" + apellido + "', '" + trato + 
                "', '" + docIden + "', '" + doc + "', '" + correo + "', '" + telefono + "', '" + direccion + 
                "', '" + fechaNac + "', '" + tipoCliente + "', " + tarifa + "";
            SqlCommand cmd = new SqlCommand(query, connection);
            verificar = cmd.ExecuteNonQuery();
            connection.Close();

            return verificar;
        }

        public int eliminarCliente(int id)
        {
            int verificar;
            connection.Open();
            string query = "exec sp_eliminarCliente "+id+"";
            SqlCommand cmd = new SqlCommand(query, connection);
            verificar = cmd.ExecuteNonQuery();
            connection.Close();

            return verificar;
        }

        public int actualizarCliente(string nombre, string apellido, string trato, string docIden,
            string doc, string correo, string telefono, string direccion, string fechaNac,
            string tipoCliente, int tarifa, int id)
        {
            int verificar;
            connection.Open();
            string query = "exec sp_actualizarCliente '" + nombre + "', '" + apellido + "', '" + trato + 
                "', '" + docIden + "', '" + doc + "', '" + correo + "', '" + telefono + "', '" + direccion + 
                "', '" + fechaNac + "', '" + tipoCliente + "', " + tarifa + ", " + id + "";
            SqlCommand cmd = new SqlCommand(query, connection);
            verificar = cmd.ExecuteNonQuery();
            connection.Close();

            return verificar;
        }

        public DataTable buscarCliente(string nombre)
        {
            connection.Open();
            string query = "exec sp_buscarCliente '" + nombre + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            connection.Close();

            return dt;
        }
    }
}
