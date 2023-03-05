using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centidades;
using Cdatos;

namespace Cnegocio
{
    public class Negocio2
    {
        Datos2 objDato = new Datos2();
        public List<Entidades2> Scobro(int buscar)
        {
            return objDato.SelectCobro(buscar);
        }

        public void Ccobro(Entidades2 Cobro)
        {
            objDato.CreateCobro(Cobro);
        }
        public void Dcobro(Entidades2 Cobro)
        {
            objDato.DeleteCobro(Cobro);
        }
    }
}
