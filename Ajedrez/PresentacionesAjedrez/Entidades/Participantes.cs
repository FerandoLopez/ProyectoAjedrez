using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Participantes
    {
        public int _IdParticipante { get; set; }
        public string _Nombre { get; set; }
        public string _Direccion { get; set; }
        public string _Campeonato { get; set; }
        public string _Telefono { get; set; }
        public string _Rol { get; set; }
        public int _FkIdPais { get; set; }
        public Participantes()
        {

        }

        public Participantes(int idParticipante, string nombre, string direccion, string campeonato, string telefono, string rol, int fkIdPais)
        {
            _IdParticipante = idParticipante;
            _Nombre = nombre;
            _Direccion = direccion;
            _Campeonato = campeonato;
            _Telefono = telefono;
            _Rol = rol;
            _FkIdPais = fkIdPais;
        }
    }
}
