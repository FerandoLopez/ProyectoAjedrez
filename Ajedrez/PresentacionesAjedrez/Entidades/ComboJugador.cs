using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ComboJugador
    {

        public string _IdJugador { get; set; }

        public ComboJugador()
        {

        }

        public ComboJugador(string idJugador)
        {
            _IdJugador = idJugador;
        }
    }
}
