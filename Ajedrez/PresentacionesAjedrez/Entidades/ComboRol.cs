using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ComboRol
    {
        public ComboRol(string rol)
        {
            _Rol = rol;
        }

        public string _Rol { get; set; }

        public ComboRol()
        {

        }
    }
}
