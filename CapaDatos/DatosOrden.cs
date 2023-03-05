using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CapaDatos
{
    public class DatosOrden
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ToString());

        public int numeroOrden()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from orden", connection);
            int numero = 0;
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                numero = int.Parse(reader[0].ToString());
            }
            connection.Close();

            return numero;
        }

        public void insertarOrden(int numOrden, string vehiculo, int idVehiculo, int idCliente, int idEmpleado,
            string fecha, string fechaEntrega, string metodoPago, int dias)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_insertarOrden", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("numOrden", numOrden);
            cmd.Parameters.AddWithValue("vehiculo", vehiculo);
            cmd.Parameters.AddWithValue("idVehiculo", idVehiculo);
            cmd.Parameters.AddWithValue("idCliente", idCliente);
            cmd.Parameters.AddWithValue("idEmpleado", idEmpleado);
            cmd.Parameters.AddWithValue("fecha", fecha);
            cmd.Parameters.AddWithValue("fechaEntrega", fechaEntrega);
            cmd.Parameters.AddWithValue("metodoPago", metodoPago);
            cmd.Parameters.AddWithValue("dias", dias);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public int idVehiculo(string carro)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select idAutomovil from vehiculos where marca + ' ' + modelo + ' ' + año = '" + carro + "'", connection);
            int numero = 0;
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                numero = int.Parse(reader[0].ToString());
            }
            connection.Close();

            return numero;
        }

        public int idEmpleado(string empleado)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select idEmpleado from empleados where nombre + ' ' + apellido = '" + empleado + "'", connection);
            int numero = 0;
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                numero = int.Parse(reader[0].ToString());
            }
            connection.Close();

            return numero;
        }

        public DataTable mostrarOrden(string numero)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_buscarOrden", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("numero", numero);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            connection.Close();

            return dt;
        }
    }
}
