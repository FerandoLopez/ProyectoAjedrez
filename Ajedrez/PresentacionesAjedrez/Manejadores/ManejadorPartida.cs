using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorPartida
    {
        Conexion c = new Conexion("localhost", "ajedrez", "ajedrez", "ajedrez");
        public string Guardar(Partida partida)
        {
            return c.Comando(string.Format("call p_insertarpartida(null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                partida._Fecha,partida._Jugador1,partida._ColorJugador1,partida._Jugador2,partida._ColorJugador2,partida._Arbitro,
                partida._IdSala,partida._Entradas));
        }

        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = c.Mostrar(string.Format("call p_mostrarpartida('{0}')", dato), "partida").Tables["partida"];
            tabla.AutoResizeColumns();
        }

        public string Modificar(Partida partida)
        {
            return c.Comando(string.Format("call p_modificarpartida('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", 
                partida._IdPartida,partida._Fecha,partida._Jugador1,partida._ColorJugador1,partida._Jugador2,partida._ColorJugador2,
                partida._Arbitro,partida._IdSala,partida._Entradas));
        }

        public string Eliminar(Partida partida)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro de eliminar la partida del " + partida._Fecha, "Atencion!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = c.Comando(string.Format("call p_eliminarpartida('{0}')", partida._IdPartida));
            }
            return r;
        }

        public List<ComboJugador> LlenarJugador()
        {
            return c.LlenarJugador("select idjugador from jugador");
        }

        public List<ComboArbitro> LlenarArbitro()
        {
            return c.LlenarArbitro("select idarbitro from arbitro");
        }

        public List<ComboSala> LlenarSala()
        {
            return c.LlenarSala("select idsala from sala");
        }
    }
}
