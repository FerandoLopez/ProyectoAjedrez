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
        string color = "";
        string color2 = "";
        public FrmAddPartida()
        {
            InitializeComponent();
            mp = new ManejadorPartida();
            if (FrmPartida.p._IdPartida!=0)
            {
                txtFecha.Text = FrmPartida.p._Fecha;
                cbJugador1.Text = FrmPartida.p._Jugador1;
                color = FrmPartida.p._ColorJugador1;
                cbJugador2.Text = FrmPartida.p._ColorJugador2;
                color2 = FrmPartida.p._ColorJugador2;
                cbArbitro.Text = FrmPartida.p._Arbitro;
                cbSala.Text = FrmPartida.p._IdSala.ToString();
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

            var listas = mp.LlenarSala();
            cbSala.DataSource = listas;
            cbSala.ValueMember = "_idsala";
            cbSala.DisplayMember = "_idsala";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmPartida.p._IdPartida == 0)
            {

                if (rbNegras.Checked)
                {
                    rbNegras2.Visible = false;
                    color = "Negras";

                }

                else if (rbBlancas.Checked)
                {
                    rbBlancas2.Checked = false;
                    color = "Blancas";
                }

                if (rbNegras2.Checked)
                {
                    rbNegras.Checked = false;
                    color2 = "Negras";
                
                }
                else if (rbBlancas2.Checked)
                {
                    rbBlancas.Checked = false;
                    color2 = "Blancas";
                }

                MessageBox.Show(mp.Guardar(new Partida(FrmPartida.p._IdPartida,txtFecha.Text,cbJugador1.SelectedValue.ToString(),color,
                    cbJugador2.SelectedValue.ToString(),color2,cbArbitro.SelectedValue.ToString(),int.Parse(cbSala.SelectedValue.ToString()),
                    int.Parse(txtEntradas.Text.ToString()))));
                Close();
            }
            else
            {
                MessageBox.Show(mp.Modificar(new Partida(FrmPartida.p._IdPartida, txtFecha.Text, cbJugador1.SelectedValue.ToString(), color,
                    cbJugador2.SelectedValue.ToString(), color2, cbArbitro.SelectedValue.ToString(), int.Parse(cbSala.SelectedValue.ToString()),
                    int.Parse(txtEntradas.Text.ToString()))));

            }
            Close();
        }
    }
}
