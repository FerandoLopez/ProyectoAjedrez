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
    public partial class FrmAddPartida : Form
    {
        ManejadorPartida mp;
        public FrmAddPartida()
        {
            InitializeComponent();
            mp = new ManejadorPartida();
            if (FrmPartida.p._IdPartida!=0)
            {
                txtFecha.Text = FrmPartida.p._Fecha;
                cbJugador1.Text = FrmPartida.p._Jugador1;
                txtColor.Text = FrmPartida.p._ColorJugador1;
                cbJugador2.Text = FrmPartida.p._ColorJugador2;
                txtColor2.Text = FrmPartida.p._ColorJugador2;
                cbArbitro.Text = FrmPartida.p._Arbitro;
                txtSala.Text = FrmPartida.p._IdSala.ToString();
                txtEntradas.Text = FrmPartida.p._Entradas.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAddPartida_Load(object sender, EventArgs e)
        {
            var listaj = mp.LlenarJugador();
            cbJugador1.DataSource = listaj;
            cbJugador1.ValueMember = "_idjugador";
            cbJugador1.DisplayMember = "_idjugador";

            var listaj2 = mp.LlenarJugador();
            cbJugador2.DataSource = listaj2;
            cbJugador2.ValueMember = "_idjugador";
            cbJugador2.DisplayMember = "_idjugador";

            var listaa = mp.LlenarArbitro();
            cbArbitro.DataSource = listaa;
            cbArbitro.ValueMember = "_idarbitro";
            cbArbitro.DisplayMember = "_idarbitro";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmPartida.p._IdPartida == 0)
            {
                MessageBox.Show(mp.Guardar(new Partida(FrmPartida.p._IdPartida,txtFecha.Text,cbJugador1.SelectedValue.ToString(),txtColor.Text,
                    cbJugador2.SelectedValue.ToString(),txtColor2.Text,cbArbitro.SelectedValue.ToString(),int.Parse(txtSala.Text),
                    int.Parse(txtEntradas.Text.ToString()))));
                Close();
            }
            else
            {
                MessageBox.Show(mp.Modificar(new Partida(FrmPartida.p._IdPartida, txtFecha.Text, cbJugador1.SelectedValue.ToString(), txtColor.Text,
                    cbJugador2.SelectedValue.ToString(), txtColor2.Text, cbArbitro.SelectedValue.ToString(), int.Parse(txtSala.Text),
                    int.Parse(txtEntradas.Text.ToString()))));
                Close();
            }
        }
    }
}
