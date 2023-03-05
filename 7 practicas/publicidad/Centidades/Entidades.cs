using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centidades
{
    public class Entidades
    {
        private int _id_emisora;
        private string _NIF;
        private string _nombre;
        private int _Direccion_postal;
        private string _director;
        private string _Banda_hertziana;

        public int Id_emisora { get => _id_emisora; set => _id_emisora = value; }
        public string NIF { get => _NIF; set => _NIF = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Direccion_postal { get => _Direccion_postal; set => _Direccion_postal = value; }
        public string Director { get => _director; set => _director = value; }
        public string Banda_hertziana { get => _Banda_hertziana; set => _Banda_hertziana = value; }
    }
}
