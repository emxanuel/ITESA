using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NegocioPeliculas
    {
        DatosPeliculas datos = new DatosPeliculas();

        public DataTable mostrarNombrePeliculas(string nombre)
        {
            return datos.mostrarNombrePeliculas(nombre);
        }
    }
}
