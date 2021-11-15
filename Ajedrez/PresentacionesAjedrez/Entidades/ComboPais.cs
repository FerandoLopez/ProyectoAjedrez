using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ComboPais
    {
        public ComboPais(int idPais, string nombre)
        {
            _IdPais = idPais;
            _Nombre = nombre;
        }

        public int _IdPais { get; set; }
        public string _Nombre { get; set; }

        public ComboPais()
        {

        }
    }
}
