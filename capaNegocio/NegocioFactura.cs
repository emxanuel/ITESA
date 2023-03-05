using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace capaNegocio
{
    public class NegocioFactura
    {
        DatosFactura factura = new DatosFactura();

        public void insertarFactura(int numOrden, string fecha, string fechaDevolucion)
        {
            factura.insertarFactura(numOrden, fecha, fechaDevolucion);
        }

        public void facturar(int numOrden)
        {
            factura.facturar(numOrden);
        }
    }
}
