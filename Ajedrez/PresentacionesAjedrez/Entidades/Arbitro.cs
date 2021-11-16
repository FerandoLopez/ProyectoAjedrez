using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Arbitro
    {

        public string _IdArbitro { get; set; }
        public int _FkIdParticipante { get; set; }


        public Arbitro()
        {

        }

        public Arbitro(string idArbitro, int fkIdParticipante)
        {
            _IdArbitro = idArbitro;
            _FkIdParticipante = fkIdParticipante;
        }
    }
}
