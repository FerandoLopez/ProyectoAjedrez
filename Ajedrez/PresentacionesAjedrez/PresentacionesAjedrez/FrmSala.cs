using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejadores;

namespace PresentacionesAjedrez
{
    public partial class FrmSala : Form
    {
        ManejadorSala ms;
        int i = 0;
        public static Sala s;
        public FrmSala()
        {
            InitializeComponent();
            ms = new ManejadorSala();
            s = new Sala();
        }

        void Actualizar()
        {
            ms.Mostrar(dtgSalas, txtBuscarSala.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            s._IdSala = 0;
            s._Medios = "";
            s._Capacidad = 0;
            s._Hotel = "";
            FrmAddSala fas = new FrmAddSala();
            fas.Dock = DockStyle.Fill;
            fas.ShowDialog();
            Actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgSalas.RowCount > 0)
            {
                string r = ms.Eliminar(s);
                if (string.IsNullOrEmpty(r))
                {
                    MessageBox.Show(r);
                    Actualizar();
                }
            }
            else
            {
                MessageBox.Show("Debe de elegir un registro");
            }
            Actualizar();
        }

        private void dtgSalas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAddSala sl = new FrmAddSala();
            sl.ShowDialog();
            Actualizar();
        }

        private void txtBuscarSala_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void FrmSala_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtgSalas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            s._IdSala = int.Parse(dtgSalas.Rows[i].Cells[0].Value.ToString());
            s._Medios = dtgSalas.Rows[i].Cells[1].Value.ToString();
            s._Capacidad = int.Parse(dtgSalas.Rows[i].Cells[2].Value.ToString());
            s._Hotel = dtgSalas.Rows[i].Cells[3].Value.ToString();
        }
    }
}
