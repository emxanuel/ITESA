using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Miembro
    {

        private int _ID_MIEMBROS;
        private string _MIEMBRO;
        private string _COD_MIEMBROS;
        private string _PUESTO;
        private string _BASE_DE_JORNADA;
        private string _HORAS_EJERCIDAS;

        public int ID_MIEMBROS { get => _ID_MIEMBROS; set => _ID_MIEMBROS = value; }
        public string MIEMBRO { get => _MIEMBRO; set => _MIEMBRO = value; }
        public string COD_MIEMBROS { get => _COD_MIEMBROS; set => _COD_MIEMBROS = value; }
        public string PUESTO { get => _PUESTO; set => _PUESTO = value; }
        public string BASE_DE_JORNADA { get => _BASE_DE_JORNADA; set => _BASE_DE_JORNADA = value; }
        public string HORAS_EJERCIDAS { get => _HORAS_EJERCIDAS; set => _HORAS_EJERCIDAS = value; }
    }
}
