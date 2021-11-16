using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {

        public string _IdJugador { get; set; }
        public int _FkIdParticipante { get; set; }
        public int _Nivel { get; set; }

        public Jugador()
        {

        }

        public Jugador(string idJugador, int fkIdParticipante, int nivel)
        {
            _IdJugador = idJugador;
            _FkIdParticipante = fkIdParticipante;
            _Nivel = nivel;
        }
    }
}
