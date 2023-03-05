using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using capaNegocio;

namespace capaNegocio
{
    public class NegocioVehiculo
    {
        DatosVehiculo vehiculo = new DatosVehiculo();
        public DataTable mostrarVehiculos(string modelo)
        {
            return vehiculo.mostrarVehiculos(modelo);
        }

        public void insertarVehiculo(string marca, string modelo, string tipo, string año, float kilometraje,
            int capacidad, string combustible, float tarifa, int cantidad)
        {
            vehiculo.insertarVehiculos(marca, modelo, tipo, año, kilometraje, capacidad, combustible, tarifa, cantidad);
        }

        public void actualizarVehiculo(string marca, string modelo, string tipo, string año, float kilometraje,
            int capacidad, string combustible, float tarifa, int id, int cantidad)
        {
            vehiculo.actualizarVehiculo(marca, modelo, tipo, año, kilometraje, capacidad, combustible, tarifa, id, cantidad);
        }

        public void eliminarVehiculo(int id)
        {
            vehiculo.eliminarVehiculo(id);
        }

        public DataTable listarVehiculos(string modelo)
        {
            return vehiculo.listarVehiculos(modelo);
        }

        public float montoVehiculo(string automovil)
        {
            return vehiculo.montoVehiculo(automovil);
        }
    }
}
