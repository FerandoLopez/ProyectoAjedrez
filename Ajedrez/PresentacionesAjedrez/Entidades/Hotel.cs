using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Hotel
    {

        public string _Nombre { get; set; }
        public string _Direccion { get; set; }
        public string _Telefono { get; set; }

        public Hotel()
        {

        }

        public Hotel(string nombre, string direccion, string telefono)
        {
            _Nombre = nombre;
            _Direccion = direccion;
            _Telefono = telefono;
        }
    }
}
