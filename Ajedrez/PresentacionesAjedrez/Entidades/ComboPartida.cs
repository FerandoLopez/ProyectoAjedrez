using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ComboPartida
    {
        public ComboPartida(int idPartida)
        {
            _IdPartida = idPartida;
        }

        public int _IdPartida { get; set; }

        public ComboPartida()
        {

        }
    }
}
