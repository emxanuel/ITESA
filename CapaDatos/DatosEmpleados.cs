using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatosEmpleados
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ToString());
        public DataTable mostarEmpleados(string nombre)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_mostrarEmpleados", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nombre", nombre);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            connection.Close();

            return dt;
        }

        public void insertarEmpleado(string nombre, string apellido, string cedula, 
            float sueldo, string fechaNac, string fechaCon, string telefono, int departamento)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_insertarEmpleado", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nombre", nombre);
            cmd.Parameters.AddWithValue("apellido", apellido);
            cmd.Parameters.AddWithValue("cedula", cedula);
            cmd.Parameters.AddWithValue("fechaNac", fechaNac);
            cmd.Parameters.AddWithValue("fechaCon", fechaCon);
            cmd.Parameters.AddWithValue("telefono", telefono);
            cmd.Parameters.AddWithValue("departamento", departamento);
            cmd.Parameters.AddWithValue("sueldo", sueldo);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void actualizarEmpleado(string nombre, string apellido, string cedula,
            float sueldo, string fechaNac, string fechaCon, string telefono, int departamento,
            int id)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_actualizarEmpleado", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nombre", nombre);
            cmd.Parameters.AddWithValue("apellido", apellido);
            cmd.Parameters.AddWithValue("cedula", cedula);
            cmd.Parameters.AddWithValue("fechaNac", fechaNac);
            cmd.Parameters.AddWithValue("fechaCon", fechaCon);
            cmd.Parameters.AddWithValue("telefono", telefono);
            cmd.Parameters.AddWithValue("departamento", departamento);
            cmd.Parameters.AddWithValue("sueldo", sueldo);
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void eliminarEmpleado(int id)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_eliminarEmpleado", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public int login(string contrasena, string usuario)
        {
            int i;
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_login", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("usuario", usuario);
            cmd.Parameters.AddWithValue("contrasena", contrasena);
            i = int.Parse(cmd.ExecuteScalar().ToString());
            connection.Close();

            return i;
        }
    }
}
