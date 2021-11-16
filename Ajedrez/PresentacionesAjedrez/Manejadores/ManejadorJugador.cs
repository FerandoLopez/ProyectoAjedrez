using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manejadores;
using AccesoDatos;
using Entidades;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorJugador
    {
        Conexion c = new Conexion("localhost", "ajedrez", "ajedrez", "ajedrez");
        public string Guardar(Jugador jugador)
        {
            return c.Comando(string.Format("call p_insertarjugador('{0}','{1}','{2}')", jugador._IdJugador, jugador._FkIdParticipante,jugador._Nivel));
        }

        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = c.Mostrar(string.Format("select * from jugador", dato), "jugador").Tables["jugador"];
            tabla.AutoResizeColumns();
        }

        public string Modificar(Jugador jugador)
        {
            return c.Comando(string.Format("call p_modificarjugador('{0}','{1}','{2}')", jugador._IdJugador,jugador._FkIdParticipante,jugador._Nivel));
        }

        public string Eliminar(Jugador jugador)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro de eliminar " + jugador._IdJugador, "Atencion!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = c.Comando(string.Format("call p_eliminarjugador('{0}')", jugador._IdJugador));
            }
            return r;
        }

        public List<ComboParticipante> LlenarParticipante()
        {
            return c.LlenarParticipante("select idparticipante, nombre from participante");
        }
    }
}
