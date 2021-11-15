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
    public class ManejadorParticipantes
    {
        Conexion c = new Conexion("localhost", "ajedrez", "ajedrez", "ajedrez");
        public string Guardar(Participantes participante)
        {
            return c.Comando(string.Format("call p_insertarparticipante(null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}')", 
                participante._Nombre,participante._Direccion,participante._Telefono,participante._Campeonato,participante._Rol,participante._Color,participante._FkIdPais));
        }

        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = c.Mostrar(string.Format("call p_mostrarparticipante('{0}')", dato), "participante").Tables["participante"];
            tabla.AutoResizeColumns();
        }

        public string Modificar(Participantes participante)
        {
            return c.Comando(string.Format("call p_modificarparticipante('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                participante._IdParticipante,participante._Nombre, participante._Direccion, participante._Telefono, participante._Campeonato, participante._Rol, participante._Color, participante._FkIdPais));
        }

        public string Eliminar(Participantes participante)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro de eliminar " + participante._Nombre, "Atencion!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = c.Comando(string.Format("call p_eliminarparticipante('{0}')", participante._IdParticipante));
            }
            return r;
        }

        public List<ComboPais> LlenarPais()
        {
            return c.LlenarPais("select idpais, nombre from pais");
        }

        public List<ComboRol> LlenarRol()
        {
            return c.LlenarRol("select rol from rol");
        }

        public List<ComboColor> LlenarColor()
        {
            return c.LlenarColor("select color from color");
        }
    }
}

