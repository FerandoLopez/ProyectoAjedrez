using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Manejadores;
using Entidades;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorAlojamiento
    {
        Conexion c = new Conexion("localhost", "ajedrez", "ajedrez", "ajedrez");

        public string Guardar(Alojamiento alojamiento)
        {
            return c.Comando(string.Format("call p_insertarregistro(null,'{0}','{1}','{2}','{3}')", alojamiento._FkIdPartiicpante,alojamiento._Hotel,
                alojamiento._FechaEntrada,alojamiento._FechaSalida));
        }

        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = c.Mostrar(string.Format("call p_mostrarregistro('{0}')", dato), "aloja").Tables["aloja"];
            tabla.AutoResizeColumns();
        }

        public string Modificar(Alojamiento alojamiento)
        {
            return c.Comando(string.Format("call p_modificarregistro('{0}','{1}','{2}','{3}','{4}')", alojamiento._IdAlojamiento,alojamiento._FkIdPartiicpante,
                alojamiento._Hotel,alojamiento._FechaEntrada,alojamiento._FechaSalida));
        }

        public string Eliminar(Alojamiento alojamiento)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro de eliminar el alojamiento con fecha " + alojamiento._FechaEntrada, "Atencion!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = c.Comando(string.Format("call p_eliminarregistro('{0}')", alojamiento._IdAlojamiento));
            }
            return r;
        }

        public List<ComboParticipante> LlenarParticipante()
        {
            return c.LlenarParticipante("select idparticipante, nombre from participante");
        }

        public List<ComboHotel> LlenarHotel()
        {
            return c.LlenarHotel("select nombre from hotel");
        }
    }
}
