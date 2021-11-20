using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paises
    {
        public int _IdPais { get; set; }
        public string _Nombre { get; set; }
        public int _NoClubes { get; set; }
        public Paises()
        {
                
        }

        public Paises(int idPais, string nombre, int noClubes)
        {
            _IdPais = idPais;
            _Nombre = nombre;
            _NoClubes = noClubes;
        }
    }

}
