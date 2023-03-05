using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public  class E_Aviones
    {
        private int _ID_AVIONES;
        private string _MODELO;
        private string _COD_AVIONES;
        private string _BASE_OSPEDAJE;
        private string _ANO_CREACION;

        public int ID_AVIONES { get => _ID_AVIONES; set => _ID_AVIONES = value; }
        public string MODELO { get => _MODELO; set => _MODELO = value; }
        public string COD_AVIONES { get => _COD_AVIONES; set => _COD_AVIONES = value; }
        public string BASE_OSPEDAJE { get => _BASE_OSPEDAJE; set => _BASE_OSPEDAJE = value; }
        public string ANO_CREACION { get => _ANO_CREACION; set => _ANO_CREACION = value; }
    }
}
