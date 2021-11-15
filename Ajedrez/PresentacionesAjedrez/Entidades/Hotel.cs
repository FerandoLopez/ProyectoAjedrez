using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Hotel
    {
        public Hotel(int idHotel, string nombre, string direccion, string telefono)
        {
            _IdHotel = idHotel;
            _Nombre = nombre;
            _Direccion = direccion;
            _Telefono = telefono;
        }

        public int _IdHotel { get; set; }
        public string _Nombre { get; set; }
        public string _Direccion { get; set; }
        public string _Telefono { get; set; }

        public Hotel()
        {

        }
    }
}
