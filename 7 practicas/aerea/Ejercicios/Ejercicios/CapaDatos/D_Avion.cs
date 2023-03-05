using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidades;
using System.Data;
namespace CapaDatos
{
    public  class D_Avion
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Aviones> ListarAviones(string MODELO)
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_buscaraviones", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@modelo", MODELO);
            leer = cmd.ExecuteReader();
            List<E_Aviones> Listar = new List<E_Aviones>();
            while (leer.Read())
            {
                Listar.Add(new E_Aviones
                {
                    ID_AVIONES = leer.GetInt32(0),
                    MODELO = leer.GetString(1),
                    COD_AVIONES = leer.GetString(2),
                    BASE_OSPEDAJE = leer.GetString(3),
                    ANO_CREACION = leer.GetString(4),
                   
                });

            }
            conexion.Close();
            leer.Close();
            return Listar;
        }


    }
}
