using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace capaNegocio
{
    public class NegocioOrden
    {
        DatosOrden orden = new DatosOrden();
        public int numeroOrden()
        {
            return orden.numeroOrden();
        }

        public void insertarOrden(int numOrden, string vehiculo, int idVehiculo, int idCliente, int idEmpleado,
            string fecha, string fechaEntrega, string metodoPago, int dias)
        {
            orden.insertarOrden(numOrden, vehiculo, idVehiculo, idCliente, idEmpleado, fecha, fechaEntrega, metodoPago, dias);
        }

        public int idVehiculo(string vehiculo)
        {
            return orden.idVehiculo(vehiculo);
        }

        public int idEmpleado(string empleado)
        {
            return orden.idEmpleado(empleado);
        }

        public DataTable buscarOrden(string numero)
        {
            return orden.mostrarOrden(numero);
        }
    }
}
