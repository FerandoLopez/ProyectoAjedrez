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
    public partial class FrmAddJugador : Form
    {
        ManejadorJugador mj;
        public FrmAddJugador()
        {
            InitializeComponent();
            mj = new ManejadorJugador();
            if (!(FrmJugador.j._IdJugador.Equals("")))
            {
                txtJugador.Text = FrmJugador.j._IdJugador;
                cbParticipante.Text = FrmJugador.j._FkIdParticipante.ToString();
                txtNivel.Text = FrmJugador.j._Nivel.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmJugador.j._IdJugador.Equals(""))
            {
                MessageBox.Show(mj.Guardar(new Jugador(txtJugador.Text,int.Parse(cbParticipante.SelectedValue.ToString()),int.Parse(txtNivel.Text))));
                Close();
            }
            else
            {
                MessageBox.Show(mj.Modificar(new Jugador(txtJugador.Text, int.Parse(cbParticipante.SelectedValue.ToString()), int.Parse(txtNivel.Text))));
            }
            Close();
        }

        private void FrmAddJugador_Load(object sender, EventArgs e)
        {
            var lista = mj.LlenarParticipante();
            cbParticipante.DataSource = lista;
            cbParticipante.ValueMember = "_idparticipante";
            cbParticipante.DisplayMember = "_nombre";
        }
    }
}
