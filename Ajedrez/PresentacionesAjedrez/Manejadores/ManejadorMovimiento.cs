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
    public class ManejadorMovimiento
    {
        Conexion c = new Conexion("localhost", "ajedrez", "ajedrez", "ajedrez");

        public string Guardar(Movimiento mov)
        {
            return c.Comando(string.Format("call p_insertarmovimiento(null,'{0}','{1}','{2}','{3}')", mov._IdPartida
                ,mov._Jugada,mov._Movimiento,mov._Comentario));
        }

        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = c.Mostrar(string.Format("select * from movimiento", dato), "movimiento").Tables["movimiento"];
            tabla.AutoResizeColumns();
        }

        public string Modificar(Movimiento mov)
        {
            return c.Comando(string.Format("call p_modificarmovimiento('{0}','{1}','{2}','{3}','{4}')", mov._IdMov,
                mov._IdPartida,mov._Jugada,mov._Movimiento,mov._Comentario));
        }

        public string Eliminar(Movimiento mov)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro de eliminar el movimento " + mov._IdMov, "Atencion!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = c.Comando(string.Format("call p_eliminarmovimiento('{0}')", mov._IdMov));
            }
            return r;
        }
    }
}
