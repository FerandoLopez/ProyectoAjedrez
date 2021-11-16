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
    public partial class FrmPartida : Form
    {
        ManejadorPartida mp;
        int i = 0;
        public static Partida p;
        public FrmPartida()
        {
            InitializeComponent();
            mp = new ManejadorPartida();
            p = new Partida();
        }

        void Actualizar()
        {
            mp.Mostrar(dtgPartidas, txtBuscarPartidas.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            p._IdPartida = 0;
            p._Fecha = "";
            p._Jugador1 = "";
            p._ColorJugador1 = "";
            p._Jugador2 = "";
            p._ColorJugador2 = "";
            p._Arbitro = "";
            p._IdSala = 0;
            p._Entradas = 0;
            FrmAddPartida fap = new FrmAddPartida();
            fap.Dock = DockStyle.Fill;
            fap.ShowDialog();
            Actualizar();
        }

        private void dtgPartidas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            p._IdPartida = int.Parse(dtgPartidas.Rows[i].Cells[0].Value.ToString());
            p._Fecha = dtgPartidas.Rows[i].Cells[1].Value.ToString();
            p._Jugador1 = dtgPartidas.Rows[i].Cells[2].Value.ToString();
            p._ColorJugador1 = dtgPartidas.Rows[i].Cells[3].Value.ToString();
            p._Jugador2 = dtgPartidas.Rows[i].Cells[4].Value.ToString();
            p._ColorJugador2 = dtgPartidas.Rows[i].Cells[5].Value.ToString();
            p._Arbitro = dtgPartidas.Rows[i].Cells[6].Value.ToString();
            p._IdSala = int.Parse(dtgPartidas.Rows[i].Cells[7].Value.ToString());
            p._Entradas = int.Parse(dtgPartidas.Rows[i].Cells[8].Value.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgPartidas.RowCount > 0)
            {
                string r = mp.Eliminar(p);
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

        private void dtgPartidas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAddPartida ap = new FrmAddPartida();
            ap.ShowDialog();
            Actualizar();
        }

        private void txtBuscarPartidas_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void FrmPartida_Load(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
