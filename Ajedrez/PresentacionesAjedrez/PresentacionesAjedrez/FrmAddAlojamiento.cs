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
    public partial class FrmAddAlojamiento : Form
    {
        ManejadorAlojamiento mr;
        public FrmAddAlojamiento()
        {
            InitializeComponent();
            mr = new ManejadorAlojamiento();
            if (FrmAlojamiento.re._IdAlojamiento!=0)
            {
                txtFechaEntrada.Text = FrmAlojamiento.re._FechaEntrada;
                txtFechaSalida.Text = FrmAlojamiento.re._FechaSalida;
                cbParticipante.Text = FrmAlojamiento.re._FkIdPartiicpante.ToString();
                cbHotel.Text = FrmAlojamiento.re._Hotel.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmAlojamiento.re._IdAlojamiento == 0)
            {
                MessageBox.Show(mr.Guardar(new Alojamiento(FrmAlojamiento.re._IdAlojamiento, int.Parse(cbParticipante.SelectedValue.ToString()), cbHotel.SelectedValue.ToString(), txtFechaEntrada.Text, txtFechaSalida.Text)));
                Close();
            }
            else
            {
                MessageBox.Show(mr.Modificar(new Alojamiento(FrmAlojamiento.re._IdAlojamiento, int.Parse(cbParticipante.SelectedValue.ToString()), cbHotel.SelectedValue.ToString(), txtFechaEntrada.Text, txtFechaSalida.Text)));
            }
            Close();
        }

        private void FrmAddRegistro_Load(object sender, EventArgs e)
        {
            var listap = mr.LlenarParticipante();
            cbParticipante.DataSource = listap;
            cbParticipante.ValueMember = "_idparticipante";
            cbParticipante.DisplayMember = "_nombre";

            var listah = mr.LlenarHotel();
            cbHotel.DataSource = listah;
            cbHotel.ValueMember = "_nombre";
            cbHotel.DisplayMember = "_nombre";
        }
    }
}
