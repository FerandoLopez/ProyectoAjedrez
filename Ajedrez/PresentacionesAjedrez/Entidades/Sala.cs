using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sala
    {
        public Sala(int idSala, string medios, int capacidad, string hotel)
        {
            _IdSala = idSala;
            _Medios = medios;
            _Capacidad = capacidad;
            _Hotel = hotel;
        }

        public int _IdSala { get; set; }
        public string _Medios { get; set; }
        public int _Capacidad { get; set; }
        public string _Hotel { get; set; }

        public Sala()
        {

        }
    }
}
