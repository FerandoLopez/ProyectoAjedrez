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
    public partial class FrmAddMovimiento : Form
    {
        ManejadorMovimiento mv;
        public FrmAddMovimiento()
        {
            InitializeComponent();
            mv = new ManejadorMovimiento();
            if (FrmMovimiento.m._IdMov!=0)
            {
                cbPartida.Text = FrmMovimiento.m._IdMov.ToString();
                txtJugada.Text = FrmMovimiento.m._Jugada;
                txtMovimiento.Text = FrmMovimiento.m._Movimiento.ToString();
                txtComentario.Text = FrmMovimiento.m._Comentario;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmMovimiento.m._IdMov == 0)
            {
                MessageBox.Show(mv.Guardar(new Movimiento(FrmMovimiento.m._IdMov,int.Parse(cbPartida.SelectedValue.ToString()),txtJugada.Text,int.Parse(txtMovimiento.Text),txtComentario.Text)));
                Close();
            }
            else
            {
                MessageBox.Show(mv.Modificar(new Movimiento(FrmMovimiento.m._IdMov, int.Parse(cbPartida.SelectedValue.ToString()), txtJugada.Text, int.Parse(txtMovimiento.Text), txtComentario.Text)));
            }
            Close();
        }

        private void FrmAddMovimiento_Load(object sender, EventArgs e)
        {
            var listap = mv.LlenarPartida();
            cbPartida.DataSource = listap;
            cbPartida.ValueMember = "_idpartida";
            cbPartida.DisplayMember = "id_partida";
        }
    }
}
