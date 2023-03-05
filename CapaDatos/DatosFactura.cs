using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CapaDatos
{
    public class DatosFactura
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ToString());

        public void insertarFactura(int numOrden, string fecha, string fechaDevolucion)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_insertarFactura", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("numOrden", numOrden);
            cmd.Parameters.AddWithValue("fecha", fecha);
            cmd.Parameters.AddWithValue("fechaDevolucion", fechaDevolucion);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void facturar(int numOrden)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("update orden set facturado = 'Si' where numOrden = " + numOrden + "", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
