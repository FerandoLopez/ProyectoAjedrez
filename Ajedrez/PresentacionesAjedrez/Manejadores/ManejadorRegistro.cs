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
    public class ManejadorRegistro
    {
        Conexion c = new Conexion("localhost", "ajedrez", "ajedrez", "ajedrez");

        public string Guardar(Registro registro)
        {
            return c.Comando(string.Format("call p_insertarregistro(null,'{0}','{1}','{2}','{3}')", registro._FechaEntrada,registro._FechaSalida,registro._FkIdParticipante,registro._FkIdHotel));
        }

        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = c.Mostrar(string.Format("call p_mostrarregistro('{0}')", dato), "registro").Tables["registro"];
            tabla.AutoResizeColumns();
        }

        public string Modificar(Registro registro)
        {
            return c.Comando(string.Format("call p_modificarregistro('{0}','{1}','{2}','{3}','{4}')", registro._IdRegistro,registro._FechaEntrada,registro._FechaSalida,registro._FkIdParticipante,registro._FkIdHotel));
        }

        public string Eliminar(Registro registro)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro de eliminar " + registro._FechaEntrada, "Atencion!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = c.Comando(string.Format("call p_eliminarregistro('{0}')", registro._IdRegistro));
            }
            return r;
        }

        public List<ComboParticipante> LlenarParticipante()
        {
            return c.LlenarParticipante("select idparticipante, nombre from participante");
        }

        public List<ComboHotel> LlenarHotel()
        {
            return c.LlenarHotel("select idhotel,nombre from hotel");
        }
    }
}
