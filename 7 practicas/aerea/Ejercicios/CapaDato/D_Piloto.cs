using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidades;
using System.Data;

namespace CapaDato
{
    public class D_Piloto
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Piloto> ListarTodosLosPilotos(string PILOTOS)
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_buscarpilotos", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@pilotos", PILOTOS);
            leer = cmd.ExecuteReader();
            List<E_Piloto> Listar = new List<E_Piloto>();
            while (leer.Read())
            {
                Listar.Add(new E_Piloto
                {
                    ID_PILOTOS = leer.GetInt32(0),
                    PILOTOS = leer.GetString(1),
                    COD_PILOTOS = leer.GetString(2),
                    HORAS_EJERCIDAS = leer.GetString(3),
                  

                });

            }
            conexion.Close();
            leer.Close();
            return Listar;
        }
    }

}