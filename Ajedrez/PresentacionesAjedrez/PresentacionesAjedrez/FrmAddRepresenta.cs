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
    public partial class FrmAddRepresenta : Form
    {
        ManejadorRepresenta mr;
        public FrmAddRepresenta()
        {
            InitializeComponent();
            mr = new ManejadorRepresenta();
            if (FrmRepresenta.rp._IdRepresenta!=0)
            {
                cbRepresentante.Text = FrmRepresenta.rp._PaisRepresentante.ToString();
                cbRepresentado.Text = FrmRepresenta.rp._PaisRepresentado.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmRepresenta.rp._IdRepresenta == 0)
            {
                MessageBox.Show(mr.Guardar(new Representa(FrmRepresenta.rp._IdRepresenta,int.Parse(cbRepresentante.SelectedValue.ToString()),int.Parse(cbRepresentado.SelectedValue.ToString()))));
                Close();
            }
            else
            {
                MessageBox.Show(mr.Modificar(new Representa(FrmRepresenta.rp._IdRepresenta, int.Parse(cbRepresentante.SelectedValue.ToString()), int.Parse(cbRepresentado.SelectedValue.ToString()))));
            }
            Close();
        }

        private void FrmAddRepresenta_Load(object sender, EventArgs e)
        {
            var lista1 = mr.LlenarPais();
            cbRepresentante.DataSource = lista1;
            cbRepresentante.ValueMember = "_idpais";
            cbRepresentante.DisplayMember = "_nombre";

            var lista2 = mr.LlenarPais();
            cbRepresentado.DataSource = lista2;
            cbRepresentado.ValueMember = "_idpais";
            cbRepresentado.DisplayMember = "_nombre";
        }
    }
}
