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
    public partial class FrmArbitro : Form
    {
        ManejadorArbitro ma;
        int i = 0;
        public static Arbitro a;
        public FrmArbitro()
        {
            InitializeComponent();
            ma = new ManejadorArbitro();
            a = new Arbitro();
        }

        void Actualizar()
        {
            ma.Mostrar(dtgArbitros, txtBuscarParticipantes.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            a._IdArbitro = "";
            a._FkIdParticipante = 0;
            FrmAddArbitro aa = new FrmAddArbitro();
            aa.Dock = DockStyle.Fill;
            aa.ShowDialog();
            Actualizar();
        }

        private void dtgArbitros_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            a._IdArbitro = dtgArbitros.Rows[i].Cells[0].Value.ToString();
            a._FkIdParticipante = int.Parse(dtgArbitros.Rows[i].Cells[1].Value.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgArbitros.RowCount > 0)
            {
                string r = ma.Eliminar(a);
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

        private void dtgArbitros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAddArbitro aa = new FrmAddArbitro();
            aa.ShowDialog();
            Actualizar();
        }

        private void FrmArbitro_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
