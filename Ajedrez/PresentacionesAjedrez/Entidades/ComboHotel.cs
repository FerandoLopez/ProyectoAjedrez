using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ComboHotel
    {
        public ComboHotel(int idHotel, string nombre)
        {
            _IdHotel = idHotel;
            _Nombre = nombre;
        }

        public int _IdHotel { get; set; }
        public string _Nombre { get; set; }

        public ComboHotel()
        {

        }
    }
}
