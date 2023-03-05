using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace capaNegocio
{
    public class NegocioEmpleados
    {
        DatosEmpleados empleados = new DatosEmpleados();

        public DataTable mostrarEmpleados(string nombre)
        {
            return empleados.mostarEmpleados(nombre);
        }

        public void insertarEmpleados(string nombre, string apellido, string cedula,
            float sueldo, string fechaNac, string fechaCon, string telefono, int departamento)
        {
            empleados.insertarEmpleado(nombre, apellido, cedula, sueldo, fechaNac, fechaCon, telefono, departamento);
        }

        public void actualizarEmpleados(string nombre, string apellido, string cedula,
            float sueldo, string fechaNac, string fechaCon, string telefono, int departamento,
            int id)
        {
            empleados.actualizarEmpleado(nombre, apellido, cedula, sueldo, fechaNac, fechaCon, telefono, departamento, id);
        }

        public void eliminarEmpleado(int id)
        {
            empleados.eliminarEmpleado(id);
        }

        public int loginEmpleados(string usuario, string contrasena)
        {
            return empleados.login(contrasena, usuario);
        }
    }
}
