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
    public partial class FrmAddSala : Form
    {
        ManejadorSala ms;
        public FrmAddSala()
        {
            InitializeComponent();
            ms = new ManejadorSala();
            if (FrmSala.s._IdSala!=0)
            {
                txtMedios.Text = FrmSala.s._Medios;
                txtCapacidad.Text = FrmSala.s._Capacidad.ToString();
                cbHotel.Text = FrmSala.s._Hotel;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmSala.s._IdSala == 0)
            {
                MessageBox.Show(ms.Guardar(new Sala(FrmSala.s._IdSala, txtMedios.Text, int.Parse(txtCapacidad.Text), cbHotel.SelectedValue.ToString())));
                Close();
            }
            else
            {
                MessageBox.Show(ms.Modificar(new Sala(FrmSala.s._IdSala, txtMedios.Text, int.Parse(txtCapacidad.Text), cbHotel.SelectedValue.ToString())));
            }
            Close();
            
        }

        private void FrmAddSala_Load(object sender, EventArgs e)
        {
            var listah = ms.LlenarHotel();
            cbHotel.DataSource = listah;
            cbHotel.ValueMember = "_nombre";
            cbHotel.DisplayMember = "_nombre";
        }
    }
}
