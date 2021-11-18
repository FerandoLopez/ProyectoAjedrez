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
    public partial class FrmAddPais : Form
    {
        ManejadorPaises mp;
        public FrmAddPais()
        {
            InitializeComponent();
            mp = new ManejadorPaises();
            if (FrmPais.p._IdPais != 0)
            {
                txtNombre.Text = FrmPais.p._Nombre;
                txtClubes.Text = FrmPais.p._NoClubes.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmPais.p._IdPais == 0)
            {
                MessageBox.Show(mp.Guardar(new Paises(FrmPais.p._IdPais, txtNombre.Text, int.Parse(txtClubes.Text),int.Parse(txtNoPais.Text))));
                Close();
            }
            else
            {
                MessageBox.Show(mp.Modificar(new Paises(FrmPais.p._IdPais, txtNombre.Text, int.Parse(txtClubes.Text),int.Parse(txtNoPais.Text))));
            }
            Close();
        }
    }
}
