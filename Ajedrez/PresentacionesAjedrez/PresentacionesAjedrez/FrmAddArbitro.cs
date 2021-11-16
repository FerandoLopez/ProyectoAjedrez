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
    public partial class FrmAddArbitro : Form
    {
        ManejadorArbitro ma;
        public FrmAddArbitro()
        {
            InitializeComponent();
            ma = new ManejadorArbitro();
            if (!(FrmArbitro.a._IdArbitro.Equals("")))
            {
                txtIdArbitro.Text = FrmArbitro.a._IdArbitro;
                cbArbitro.Text = FrmArbitro.a._FkIdParticipante.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmArbitro.a._IdArbitro.Equals(""))
            {
                MessageBox.Show(ma.Guardar(new Arbitro(txtIdArbitro.Text,int.Parse(cbArbitro.SelectedValue.ToString()))));
                Close();
            }
            else
            {
                MessageBox.Show(ma.Modificar(new Arbitro(txtIdArbitro.Text, int.Parse(cbArbitro.SelectedValue.ToString()))));
            }
            Close();
        }

        private void FrmAddArbitro_Load(object sender, EventArgs e)
        {
            var lista = ma.LlenarParticipante();
            cbArbitro.DataSource = lista;
            cbArbitro.ValueMember = "_idparticipante";
            cbArbitro.DisplayMember = "_nombre";
        }
    }
}
