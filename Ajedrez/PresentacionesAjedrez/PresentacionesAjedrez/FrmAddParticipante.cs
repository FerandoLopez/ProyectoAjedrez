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
                txtTelefono.Text = FrmParticipante.p._Telefono;
                txtCampeonato.Text = FrmParticipante.p._Campeonato;
                cbRol.Text = FrmParticipante.p._Rol;
                cbColor.Text = FrmParticipante.p._Color;
                cbPais.Text = FrmParticipante.p._FkIdPais.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmParticipante.p._IdParticipante == 0)
                {
                    MessageBox.Show(mp.Guardar(new Participantes(FrmParticipante.p._IdParticipante,txtNombre.Text,txtDireccion.Text,txtTelefono.Text,txtCampeonato.Text,cbRol.SelectedValue.ToString(),cbColor.SelectedValue.ToString(), int.Parse(cbPais.SelectedValue.ToString()))));
                    Close();
                }
                else
                {
                    MessageBox.Show(mp.Modificar(new Participantes(FrmParticipante.p._IdParticipante, txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtCampeonato.Text, cbRol.SelectedValue.ToString(), cbColor.SelectedValue.ToString(), int.Parse(cbPais.SelectedValue.ToString()))));
            }
                Close();
            }

        private void FrmAddParticipante_Load(object sender, EventArgs e)
        {
            var lista = mp.LlenarPais();
            cbPais.DataSource = lista;
            cbPais.ValueMember = "_idpais";
            cbPais.DisplayMember = "_nombre";

            var listarol = mp.LlenarRol();
            cbRol.DataSource = listarol;
            cbRol.ValueMember = "_rol";
            cbRol.DisplayMember = "_rol";

            var listacolor = mp.LlenarColor();
            cbColor.DataSource = listacolor;
            cbColor.ValueMember = "_color";
            cbColor.DisplayMember = "_color";
        }
    }
    }
