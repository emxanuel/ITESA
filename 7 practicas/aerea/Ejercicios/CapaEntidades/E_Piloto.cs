using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Piloto
    {
        private int _ID_PILOTOS;
        private string _PILOTOS;
        private string _COD_PILOTOS;
        private string _HORAS_EJERCIDAS;

        public int ID_PILOTOS { get => _ID_PILOTOS; set => _ID_PILOTOS = value; }
        public string PILOTOS { get => _PILOTOS; set => _PILOTOS = value; }
        public string COD_PILOTOS { get => _COD_PILOTOS; set => _COD_PILOTOS = value; }
        public string HORAS_EJERCIDAS { get => _HORAS_EJERCIDAS; set => _HORAS_EJERCIDAS = value; }
    }
}
