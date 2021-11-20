using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;

namespace Manejadores
{
    public class ManejadorSala
    {
        Conexion c = new Conexion("localhost", "ajedrez", "ajedrez", "ajedrez");

        public string Guardar(Sala sala)
        {
            return c.Comando(string.Format("call p_insertarsala(null,'{0}','{1}','{2}')", sala._Medios, sala._Capacidad, sala._Hotel));
        }

        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = c.Mostrar(string.Format("call p_mostrarsala('{0}')", dato), "sala").Tables["sala"];
            tabla.AutoResizeColumns();
        }

        public string Modificar(Sala sala)
        {
            return c.Comando(string.Format("call p_modificarsala('{0}','{1}','{2}','{3}')", sala._IdSala, sala._Medios, sala._Capacidad, sala._Hotel));
        }

        public string Eliminar(Sala sala)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro de eliminar la sala " + sala._IdSala, "Atencion!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = c.Comando(string.Format("call p_eliminarsala('{0}')", sala._IdSala));
            }
            return r;
        }

        public List<ComboHotel> LlenarHotel()
        {
            return c.LlenarHotel("select nombre from hotel");
        }

        public List<ComboSala> LlenarSala()

        {
            return c.LlenarSala("select idsala from sala");
        }
    }
}

