using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Representa
    {
        public Representa(int idRepresenta, int paisRepresentante, int paisRepresentado)
        {
            _IdRepresenta = idRepresenta;
            _PaisRepresentante = paisRepresentante;
            _PaisRepresentado = paisRepresentado;
        }

        public int _IdRepresenta { get; set; }
        public int _PaisRepresentante { get; set; }
        public int _PaisRepresentado { get; set; }

        public Representa()
        {

        }
    }
}
