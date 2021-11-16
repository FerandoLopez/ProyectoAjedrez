using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionesAjedrez
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnPais_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnPais_Click_1(object sender, EventArgs e)
        {
            FrmPais p = new FrmPais();
            p.MdiParent = this;
            p.Dock = DockStyle.Fill;
            p.Show();
        }

        private void btnParticipante_Click(object sender, EventArgs e)
        {
            FrmParticipante p = new FrmParticipante();
            p.MdiParent = this;
            p.Dock = DockStyle.Fill;
            p.Show();
        }

        private void btnHotel_Click(object sender, EventArgs e)
        {
            FrmHotel h = new FrmHotel();
            h.MdiParent = this;
            h.Dock = DockStyle.Fill;
            h.Show();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            FrmAlojamiento r = new FrmAlojamiento();
            r.MdiParent = this;
            r.Dock = DockStyle.Fill;
            r.Show();
        }

        private void btnSalas_Click(object sender, EventArgs e)
        {
            FrmSala s = new FrmSala();
            s.MdiParent = this;
            s.Dock = DockStyle.Fill;
            s.Show();
        }

        private void btnPartidas_Click(object sender, EventArgs e)
        {
           FrmPartida pr = new FrmPartida();
           pr.MdiParent = this;
           pr.Dock = DockStyle.Fill;
           pr.Show();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            FrmRepresenta c = new FrmRepresenta();
            c.MdiParent = this;
            c.Dock = DockStyle.Fill;
            c.Show();
        }

        private void btnMovimiento_Click(object sender, EventArgs e)
        {
            FrmMovimiento m = new FrmMovimiento();
            m.MdiParent = this;
            m.Dock = DockStyle.Fill;
            m.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnJugador_Click(object sender, EventArgs e)
        {
            FrmJugador j = new FrmJugador();
            j.MdiParent = this;
            j.Dock = DockStyle.Fill;
            j.Show();
        }

        private void btnArbitro_Click(object sender, EventArgs e)
        {
            FrmArbitro a = new FrmArbitro();
            a.MdiParent = this;
            a.Dock = DockStyle.Fill;
            a.Show();
        }
    }
}
