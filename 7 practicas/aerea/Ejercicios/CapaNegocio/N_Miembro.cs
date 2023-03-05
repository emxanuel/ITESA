using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDato;
namespace CapaNegocio
{
    public class N_Miembro
    {

       D_Miembros  objData = new D_Miembros();
        public List<E_Miembro> ListandoAviones()
        {
            return null;

        }
        public List<E_Miembro> ListarTodosLosMiembros(string MIEMBRO)
        {
            return objData.ListarTodosLosMiembros(MIEMBRO);
        }
    }
}
