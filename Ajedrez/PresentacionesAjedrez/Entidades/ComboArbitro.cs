using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ComboArbitro
    {
        public ComboArbitro(string idArbitro)
        {
            _IdArbitro = idArbitro;
        }

        public string _IdArbitro { get; set; }

        public ComboArbitro()
        {

        }
    }
}
