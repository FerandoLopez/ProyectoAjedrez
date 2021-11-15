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
    public partial class FrmAddRegistro : Form
    {
        ManejadorRegistro mr;
        public FrmAddRegistro()
        {
            InitializeComponent();
            mr = new ManejadorRegistro();
            if (FrmRegistro.re._IdRegistro!=0)
            {
                txtFechaEntrada.Text = FrmRegistro.re._FechaEntrada;
                txtFechaSalida.Text = FrmRegistro.re._FechaSalida;
                cbParticipante.Text = FrmRegistro.re._FkIdParticipante.ToString();
                cbHotel.Text = FrmRegistro.re._FkIdHotel.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmRegistro.re._IdRegistro == 0)
            {
                MessageBox.Show(mr.Guardar(new Registro(FrmRegistro.re._IdRegistro, txtFechaEntrada.Text,txtFechaSalida.Text,int.Parse(cbParticipante.SelectedValue.ToString()),int.Parse(cbHotel.SelectedValue.ToString()))));
                Close();
            }
            else
            {
                MessageBox.Show(mr.Modificar(new Registro(FrmRegistro.re._IdRegistro, txtFechaEntrada.Text, txtFechaSalida.Text, int.Parse(cbParticipante.SelectedValue.ToString()), int.Parse(cbHotel.SelectedValue.ToString()))));
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
            cbHotel.ValueMember = "_idHotel";
            cbHotel.DisplayMember = "_nombre";
        }
    }
}
