using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace capaNegocio
{
    public class ConexionSQLN
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ToString());
        ConexionSQL conexion = new ConexionSQL();
        public DataTable mostrarClientes()
        {
            return conexion.mostrarClientes();
        }

        public int insertarCliente(string nombre, string apellido, string trato, string docIden,
            string doc, string correo, string telefono, string direccion, string fechaNac,
            string tipoCliente, int tarifa)
        {
            return conexion.insertarCliente(nombre, apellido, trato, docIden, doc, correo, 
                telefono, direccion, fechaNac, tipoCliente, tarifa);
        }

        public int eliminarCliente(int id)
        {
            return conexion.eliminarCliente(id);
        }

        public int actualizarCliente(string nombre, string apellido, string trato, string docIden,
            string doc, string correo, string telefono, string direccion, string fechaNac,
            string tipoCliente, int tarifa, int id)
        {
            return conexion.actualizarCliente(nombre, apellido, trato, docIden, doc, correo,
                telefono, direccion, fechaNac, tipoCliente, tarifa, id);
        }

        public DataTable buscarCLiente(string nombre)
        {
            return conexion.buscarCliente(nombre);
        }
    }
}
