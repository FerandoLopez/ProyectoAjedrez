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
    public class ManejadorHotel
    {
        Conexion c = new Conexion("localhost", "ajedrez", "ajedrez", "ajedrez");

        public string Guardar(Hotel hotel)
        {
            return c.Comando(string.Format("call p_insertarhotel('{0}','{1}','{2}')", hotel._Nombre,hotel._Direccion,hotel._Telefono));
        }

        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = c.Mostrar(string.Format("call p_mostrarhotel('{0}')", dato), "hotel").Tables["hotel"];
            tabla.AutoResizeColumns();
        }

        public string Modificar(Hotel hotel)
        {
            return c.Comando(string.Format("call p_modificarhotel('{0}','{1}','{2}')", hotel._Nombre,hotel._Direccion,hotel._Telefono));
        }

        public string Eliminar(Hotel hotel)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro de eliminar " + hotel._Nombre, "Atencion!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = c.Comando(string.Format("call p_eliminarhotel('{0}')", hotel._Nombre));
            }
            return r;
        }
    }
}
