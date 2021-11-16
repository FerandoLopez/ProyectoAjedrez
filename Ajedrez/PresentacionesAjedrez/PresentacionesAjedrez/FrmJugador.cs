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
    public partial class FrmJugador : Form
    {
        ManejadorJugador mj;
        int i = 0;
        public static Jugador j;
        public FrmJugador()
        {
            InitializeComponent();
            mj = new ManejadorJugador();
            j = new Jugador();
        }

        void Actualizar()
        {
            mj.Mostrar(dtgJugadores, txtBuscarJugadores.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            j._IdJugador = "";
            j._FkIdParticipante = 0;
            j._Nivel = 0;
            FrmAddJugador aj = new FrmAddJugador();
            aj.Dock = DockStyle.Fill;
            aj.ShowDialog();
            Actualizar();
        }

        private void dtgJugadores_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            j._IdJugador = dtgJugadores.Rows[i].Cells[0].Value.ToString();
            j._FkIdParticipante = int.Parse(dtgJugadores.Rows[i].Cells[1].Value.ToString());
            j._Nivel = int.Parse(dtgJugadores.Rows[i].Cells[2].Value.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgJugadores.RowCount > 0)
            {
                string r = mj.Eliminar(j);
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

        private void dtgJugadores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAddJugador aj = new FrmAddJugador();
            aj.ShowDialog();
            Actualizar();
        }

        private void txtBuscarJugadores_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void FrmJugador_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
