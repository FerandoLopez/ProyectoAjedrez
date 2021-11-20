using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;
using Entidades;

namespace PresentacionesAjedrez
{
    public partial class FrmMovimiento : Form
    {
        ManejadorMovimiento mv;
        int i = 0;
        public static Movimiento m;
        public FrmMovimiento()
        {
            InitializeComponent();
            mv = new ManejadorMovimiento();
            m = new Movimiento();
        }

        void Actualizar()
        {
            mv.Mostrar(dtgMovimientos, txtBuscarMovimiento.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            m._IdMov = 0;
            m._IdPartida = 0;
            m._Jugada = "";
            m._Movimiento = 0;
            m._Comentario = "";
            FrmAddMovimiento fam = new FrmAddMovimiento();
            fam.Dock = DockStyle.Fill;
            fam.ShowDialog();
            Actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgMovimientos.RowCount > 0)
            {
                string r = mv.Eliminar(m);
                if (string.IsNullOrEmpty(r))
                {
                    MessageBox.Show(r);
                    Actualizar();
                }
            }
            else
            {
                MessageBox.Show("Debe elegir un registro");
            }
            Actualizar();
        }

        private void dtgMovimientos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAddMovimiento am = new FrmAddMovimiento();
            am.ShowDialog();
            Actualizar();
        }

        private void txtBuscarMovimiento_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void FrmMovimiento_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtgMovimientos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            m._IdMov = int.Parse(dtgMovimientos.Rows[i].Cells[0].Value.ToString());
            m._IdPartida = int.Parse(dtgMovimientos.Rows[i].Cells[1].Value.ToString());
            m._Jugada = dtgMovimientos.Rows[i].Cells[2].Value.ToString();
            m._Movimiento = int.Parse(dtgMovimientos.Rows[i].Cells[3].Value.ToString());
            m._Comentario = dtgMovimientos.Rows[i].Cells[4].Value.ToString();
        }
    }
}
