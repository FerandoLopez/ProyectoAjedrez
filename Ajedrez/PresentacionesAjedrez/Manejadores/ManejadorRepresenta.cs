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
    public class ManejadorRepresenta
    {
        Conexion c = new Conexion("localhost", "ajedrez", "ajedrez", "ajedrez");
        public string Guardar(Representa rep)
        {
            return c.Comando(string.Format("call p_insertarepresenta(null,'{0}','{1}')", rep._PaisRepresentante,rep._PaisRepresentado));
        }

        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = c.Mostrar(string.Format("select * from representa", dato), "representa").Tables["representa"];
            tabla.AutoResizeColumns();
        }

        public string Modificar(Representa rep)
        {
            return c.Comando(string.Format("call p_modificarepresenta('{0}','{1}','{2}')", rep._IdRepresenta,rep._PaisRepresentante,rep._PaisRepresentado));
        }

        public string Eliminar(Representa rep)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro de eliminar " + rep._PaisRepresentante, "Atencion!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = c.Comando(string.Format("call p_eliminarpais('{0}')", rep._IdRepresenta));
            }
            return r;
        }

        public List<ComboPais> LlenarPais()
        {
            return c.LlenarPais("select idpais, nombre from pais");
        }
    }
}
