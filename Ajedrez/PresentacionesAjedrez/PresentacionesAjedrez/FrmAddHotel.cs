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
    public partial class FrmAddHotel : Form
    {
        ManejadorHotel mh;
        public FrmAddHotel()
        {
            InitializeComponent();
            mh = new ManejadorHotel();
            if (!(FrmHotel.h._Nombre.Equals("")))
            {
                txtNombre.Text = FrmHotel.h._Nombre;
                txtDireccion.Text = FrmHotel.h._Direccion;
                txtTelefono.Text = FrmHotel.h._Telefono;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmHotel.h._Nombre.Equals(""))
            {
                MessageBox.Show(mh.Guardar(new Hotel( txtNombre.Text, txtDireccion.Text,txtTelefono.Text)));
                Close();
            }
            else
            {
                MessageBox.Show(mh.Modificar(new Hotel(txtNombre.Text, txtDireccion.Text, txtTelefono.Text)));
            }
            Close();
        }
    }
}
