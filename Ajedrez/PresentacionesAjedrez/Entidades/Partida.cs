using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Partida
    {

        public int _IdPartida { get; set; }
        public string _Fecha { get; set; }
        public string _Jugador1 { get; set; }
        public string _ColorJugador1 { get; set; }
        public string _Jugador2 { get; set; }
        public string _ColorJugador2 { get; set; }
        public string _Arbitro { get; set; }
        public int _IdSala { get; set; }
        public int _Entradas { get; set; }
        public Partida()
        {

        }

        public Partida(int idPartida, string fecha, string jugador1, string colorJugador1, string jugador2, string colorJugador2, string arbitro, int idSala, int entradas)
        {
            _IdPartida = idPartida;
            _Fecha = fecha;
            _Jugador1 = jugador1;
            _ColorJugador1 = colorJugador1;
            _Jugador2 = jugador2;
            _ColorJugador2 = colorJugador2;
            _Arbitro = arbitro;
            _IdSala = idSala;
            _Entradas = entradas;
        }
    }
}
