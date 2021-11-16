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
    public class ManejadorArbitro
    {
        Conexion c = new Conexion("localhost", "ajedrez", "ajedrez", "ajedrez");
        public string Guardar(Arbitro arbitro)
        {
            return c.Comando(string.Format("call p_insertararbitro('{0}','{1}')",arbitro._IdArbitro, arbitro._FkIdParticipante));
        }

        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = c.Mostrar(string.Format("select * from arbitro", dato), "arbitro").Tables["arbitro"];
            tabla.AutoResizeColumns();
        }

        public string Modificar(Arbitro arbitro)
        {
            return c.Comando(string.Format("call p_modificararbitro('{0}','{1}')", arbitro._IdArbitro,arbitro._FkIdParticipante));
        }

        public string Eliminar(Arbitro arbitro)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro de eliminar el arbitro" +arbitro._IdArbitro, "Atencion!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = c.Comando(string.Format("call p_eliminararbitro('{0}')", arbitro._IdArbitro));
            }
            return r;
        }

        public List<ComboParticipante> LlenarParticipante()
        {
            return c.LlenarParticipante("select idparticipante, nombre from participante");
        }
    }
}
