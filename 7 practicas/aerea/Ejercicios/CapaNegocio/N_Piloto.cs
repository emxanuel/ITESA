using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDato;
namespace CapaNegocio
{
    public  class N_Piloto
    {
        D_Piloto objData = new D_Piloto();
        public List<E_Piloto> ListandoAviones()
        {
            return null;

        }
        public List<E_Piloto> ListarTodosLosPilotos(string PILOTOS)
        {
            return objData.ListarTodosLosPilotos(PILOTOS);
        }
    }
}
