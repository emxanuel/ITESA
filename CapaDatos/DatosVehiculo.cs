using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaDatos
{
    public class DatosVehiculo
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ToString());
        public DataTable mostrarVehiculos(string modelo)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_mostrarVehiculos", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("modelo", modelo);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            connection.Close();

            return dt;
        }

        public void insertarVehiculos(string marca, string modelo, string tipo, string año, float kilometraje, 
            int capacidad, string combustible, float tarifa, int cantidad)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_insertarVehiculo", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("marca", marca);
            cmd.Parameters.AddWithValue("modelo", modelo);
            cmd.Parameters.AddWithValue("tipo", tipo);
            cmd.Parameters.AddWithValue("año", año);
            cmd.Parameters.AddWithValue("kilometraje", kilometraje);
            cmd.Parameters.AddWithValue("capacidad", capacidad);
            cmd.Parameters.AddWithValue("combustible", combustible);
            cmd.Parameters.AddWithValue("tarifa", tarifa);
            cmd.Parameters.AddWithValue("cantidad", cantidad);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void actualizarVehiculo(string marca, string modelo, string tipo, string año, float kilometraje, 
            int capacidad, string combustible, float tarifa, int id, int cantidad)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_actualizarVehiculo", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("marca", marca);
            cmd.Parameters.AddWithValue("modelo", modelo);
            cmd.Parameters.AddWithValue("tipo", tipo);
            cmd.Parameters.AddWithValue("año", año);
            cmd.Parameters.AddWithValue("kilometraje", kilometraje);
            cmd.Parameters.AddWithValue("capacidad", capacidad);
            cmd.Parameters.AddWithValue("combustible", combustible);
            cmd.Parameters.AddWithValue("tarifa", tarifa);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("cantidad", cantidad);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void eliminarVehiculo(int id)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_eliminarVehiculos", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable listarVehiculos(string modelo)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_listarVehiculos", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("modelo", modelo);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            connection.Close();

            return dt;
        }

        public float montoVehiculo(string vehiculo)
        {
            float monto = 0;
            connection.Open();
            SqlCommand cmd = new SqlCommand("select tarifa from vehiculos where marca + ' ' + modelo + ' ' + año = '" + vehiculo + "'", connection);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                monto = float.Parse(reader["tarifa"].ToString());
            }
            connection.Close();

            return monto;
        }
    }
}
