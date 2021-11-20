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
    public partial class FrmAddParticipante : Form
    {
        ManejadorParticipantes mp;
        public FrmAddParticipante()
        {
            InitializeComponent();
            mp = new ManejadorParticipantes();
            if (FrmParticipante.p._IdParticipante != 0)
            {

                txtNombre.Text = FrmParticipante.p._Nombre;
                txtDireccion.Text = FrmParticipante.p._Direccion;
                txtCampeonato.Text = FrmParticipante.p._Campeonato;
                txtTelefono.Text = FrmParticipante.p._Telefono;
                cbPais.Text = FrmParticipante.p._FkIdPais.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string rol = "";
            if (rbJugador.Checked)
            {
                rol = "Jugador";

            }
            else if (rbArbitro.Checked)
            {
                rol = "Arbitro";
            }

            if (FrmParticipante.p._IdParticipante == 0)
                {
                    MessageBox.Show(mp.Guardar(new Participantes(FrmParticipante.p._IdParticipante,txtNombre.Text,txtDireccion.Text,txtCampeonato.Text,txtTelefono.Text, rol,int.Parse(cbPais.SelectedValue.ToString()))));
                    Close();
                }
                else
                {
                    MessageBox.Show(mp.Modificar(new Participantes(FrmParticipante.p._IdParticipante, txtNombre.Text, txtDireccion.Text, txtCampeonato.Text, txtTelefono.Text,rol, int.Parse(cbPais.SelectedValue.ToString()))));
            }
                Close();
            }

        private void FrmAddParticipante_Load(object sender, EventArgs e)
        {
            var lista = mp.LlenarPais();
            cbPais.DataSource = lista;
            cbPais.ValueMember = "_idpais";
            cbPais.DisplayMember = "_nombre";
        }
    }
   }
