using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Centidades;
using System.Data;

namespace Cdatos
{
    public class Datos2
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conector"].ConnectionString);
        public List<Entidades2> SelectCobro(int buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("mostrarCobros", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@emisorasId", buscar);
            LeerFilas = cmd.ExecuteReader();

            List<Entidades2> leer = new List<Entidades2>();

            while (LeerFilas.Read())
            {
                leer.Add(new Entidades2
                {
                    Id_emisora = LeerFilas.GetInt32(0),
                    Patrocinador = LeerFilas.GetString(1),
                    Precioxsec = LeerFilas.GetString(2),
                    Duracion = LeerFilas.GetString(3),
                    Diasxsemana = LeerFilas.GetInt32(4),
                    Preciototal = LeerFilas.GetString(5),
                });
            }
            conexion.Close();
            LeerFilas.Close();
            return leer;
        }
        public void CreateCobro(Entidades2 Cobro)
        {

            SqlCommand cmd = new SqlCommand("crearCobro", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@id_emisora", Cobro.Id_emisora);
            cmd.Parameters.AddWithValue("@Patrocinador", Cobro.Patrocinador);
            cmd.Parameters.AddWithValue("@Precioxsec", Cobro.Precioxsec);
            cmd.Parameters.AddWithValue("@Duracion_publicidad", Cobro.Duracion);
            cmd.Parameters.AddWithValue("@diasxsema", Cobro.Diasxsemana);
            cmd.Parameters.AddWithValue("@Precio_total", Cobro.Preciototal);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        
        public void DeleteCobro(Entidades2 Cobro)
        {
            SqlCommand cmd = new SqlCommand("borrarCobro", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@emisoraId", Cobro.Id_emisora);


            cmd.ExecuteNonQuery();
            conexion.Close();

        }
    }
}
