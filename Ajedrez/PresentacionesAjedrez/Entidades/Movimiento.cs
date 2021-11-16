using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Movimiento
    {
        public Movimiento(int idMov, int idPartida, string jugada, int movimiento, string comentario)
        {
            _IdMov = idMov;
            _IdPartida = idPartida;
            _Jugada = jugada;
            _Movimiento = movimiento;
            _Comentario = comentario;
        }

        public int _IdMov { get; set; }
        public int _IdPartida { get; set; }
        public string _Jugada { get; set; }
        public int _Movimiento { get; set; }
        public string _Comentario { get; set; }

        public Movimiento()
        {
            
        }
    }
}
