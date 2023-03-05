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
    public class D_Miembros
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Miembro> ListarTodosLosMiembros(string MIEMBRO)
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_buscarmiembros", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@miembro", MIEMBRO);
            leer = cmd.ExecuteReader();
            List<E_Miembro> Listar = new List<E_Miembro>();
            while (leer.Read())
            {
                Listar.Add(new E_Miembro
                {
                    ID_MIEMBROS = leer.GetInt32(0),
                    MIEMBRO = leer.GetString(1),
                    COD_MIEMBROS = leer.GetString(2),
                    PUESTO = leer.GetString(3),
                    BASE_DE_JORNADA = leer.GetString(3),
                    HORAS_EJERCIDAS = leer.GetString(3),





                });

            }
            conexion.Close();
            leer.Close();
            return Listar;
        }
    }
}
