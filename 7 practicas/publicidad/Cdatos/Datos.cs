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
    public class Datos
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conector"].ConnectionString);


        public List<Entidades> SelectEmisoras(int buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("mostrarEmisoras", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@emisorasId", buscar);
            LeerFilas = cmd.ExecuteReader();

            List<Entidades> leer = new List<Entidades>();

            while (LeerFilas.Read())
            {
                leer.Add(new Entidades
                {
                    Id_emisora = LeerFilas.GetInt32(0),
                    NIF = LeerFilas.GetString(1),
                    Nombre = LeerFilas.GetString(2),
                    Direccion_postal = LeerFilas.GetInt32(3),
                    Director = LeerFilas.GetString(4),
                    Banda_hertziana = LeerFilas.GetString(5),
                });
            }
            conexion.Close();
            LeerFilas.Close();
            return leer;
        }

       
    }
}

