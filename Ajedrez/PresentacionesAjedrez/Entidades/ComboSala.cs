using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ComboSala
    {
        public ComboSala(int idSala)
        {
            _IdSala = idSala;
        }

        public int _IdSala { get; set; }
        public ComboSala()
        {

        }
    }
}
