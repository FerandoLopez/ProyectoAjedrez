using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alojamiento
    {
        public Alojamiento(int idAlojamiento, int fkIdPartiicpante, string hotel, string fechaEntrada, string fechaSalida)
        {
            _IdAlojamiento = idAlojamiento;
            _FkIdPartiicpante = fkIdPartiicpante;
            _Hotel = hotel;
            _FechaEntrada = fechaEntrada;
            _FechaSalida = fechaSalida;
        }

        public int _IdAlojamiento { get; set; }
        public int _FkIdPartiicpante { get; set; }
        public string _Hotel { get; set; }
        public string _FechaEntrada { get; set; }
        public string _FechaSalida { get; set; }

        public Alojamiento()
        {

        }
    }
}
