using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class ComboParticipante
    {
        public ComboParticipante(int idParticipante, string nombre)
        {
            _IdParticipante = idParticipante;
            _Nombre = nombre;
        }

        public int _IdParticipante { get; set; }
        public string _Nombre { get; set; }

        public ComboParticipante()
        {

        }
    }
}
