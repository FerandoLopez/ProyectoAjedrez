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
    public class ManejadorPaises
    {
        Conexion c = new Conexion("localhost", "ajedrez", "ajedrez", "ajedrez");
        public string Guardar(Paises pais)
        {
            return c.Comando(string.Format("call p_insertarpais(null,'{0}','{1}',null)",pais._Nombre,pais._NoClubes,pais._FkIdPais));
        }

        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = c.Mostrar(string.Format("call p_mostrarpais('{0}')", dato), "pais").Tables["pais"];
            tabla.AutoResizeColumns();
        }

        public string Modificar(Paises pais)
        {
           return c.Comando(string.Format("call p_modificarpais('{0}','{1}','{2}',null)", pais._IdPais, pais._Nombre, pais._NoClubes, pais._FkIdPais));
        }

        public string Eliminar(Paises pais)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro de eliminar " + pais._Nombre, "Atencion!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = c.Comando(string.Format("call p_eliminarpais('{0}')", pais._IdPais));
            }
            return r;
        }
    }
}
