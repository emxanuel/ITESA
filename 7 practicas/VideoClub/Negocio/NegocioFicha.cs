using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocio
{
    public class NegocioFicha
    {
        DatosFicha datos = new DatosFicha();

        public void insertarFicha(int idSocio, string nombreSocio, string nombrePelicula, string fecha)
        {
            datos.insertarFicha(idSocio, nombreSocio, nombrePelicula, fecha);
        }

        public void devolver(string nombre)
        {
            datos.devolver(nombre);
        }

        public DataTable mostrarFichas()
        {
            return datos.mostrarFichas();
        }
    }
}
