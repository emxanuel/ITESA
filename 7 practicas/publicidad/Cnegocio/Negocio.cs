using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centidades;
using Cdatos;

namespace Cnegocio
{
    public class Negocio
    {
        Datos objDato = new Datos();

        public List<Entidades> Semisora(int buscar)
        {
            return objDato.SelectEmisoras(buscar);
        }
    }
}
