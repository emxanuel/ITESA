using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDato;
namespace CapaNegocio
{
    public   class N_Avion
    {

        D_Avion objData = new D_Avion();
        public List<E_Aviones> ListandoAviones()
        {
            return null;

        }
        public List<E_Aviones> ListarTodosLosAviones(string MODELO)
        {
            return objData.ListarTodosLosAviones(MODELO);
        }

    }
}
