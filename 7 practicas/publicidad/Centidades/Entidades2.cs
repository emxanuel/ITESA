using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centidades
{
    public class Entidades2
    {
        private int _id_emisora;
        private string _patrocinador;
        private string _precioxsec;
        private string _duracion;
        private int _diasxsemana;
        private string _preciototal;

        public int Id_emisora { get => _id_emisora; set => _id_emisora = value; }
        public string Patrocinador { get => _patrocinador; set => _patrocinador = value; }
        public string Precioxsec { get => _precioxsec; set => _precioxsec = value; }
        public string Duracion { get => _duracion; set => _duracion = value; }
        public int Diasxsemana { get => _diasxsemana; set => _diasxsemana = value; }
        public string Preciototal { get => _preciototal; set => _preciototal = value; }
    }
}
