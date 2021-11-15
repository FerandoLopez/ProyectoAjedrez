using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Registro
    {
        public Registro(int idRegistro, string fechaEntrada, string fechaSalida, int fkIdParticipante, int fkIdHotel)
        {
            _IdRegistro = idRegistro;
            _FechaEntrada = fechaEntrada;
            _FechaSalida = fechaSalida;
            _FkIdParticipante = fkIdParticipante;
            _FkIdHotel = fkIdHotel;
        }

        public int _IdRegistro { get; set; }
        public string _FechaEntrada { get; set; }
        public string _FechaSalida { get; set; }
        public int _FkIdParticipante { get; set; }
        public int _FkIdHotel { get; set; }

        public Registro()
        {

        }
    }
}
