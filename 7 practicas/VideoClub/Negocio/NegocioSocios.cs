using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NegocioSocios
    {
        DatosSocios datos = new DatosSocios();

        public DataTable mostrarSocios(string nombre)
        {
            return datos.mostrarSocios(nombre);
        }

        public void insertarSocio(string nombre, string telefono, string direccion, string actores, string generos, string directores)
        {
            datos.insertarSocios(nombre, telefono, direccion, actores, generos, directores);
        }

        public DataTable mostrarNombreSocio(string nombre)
        {
            return datos.mostrarNombreSocio(nombre);
        }

        public int idSocio(string nombre)
        {
            return datos.idSocio(nombre);
        }
    }
}
