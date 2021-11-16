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
    public partial class FrmPais : Form
    {
        ManejadorPaises mp;
        int i = 0;
        public static Paises p;
        public FrmPais()
        {
            InitializeComponent();
            mp = new ManejadorPaises();
            p = new Paises();
        }

        void Actualizar()
        {
            mp.Mostrar(dtgPaises, txtBuscarPaises.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            p._IdPais = 0;
            p._Nombre = "";
            p._NoClubes = 0;
            FrmAddPais ap = new FrmAddPais();
           // ap.Dock = DockStyle.Fill;
            ap.ShowDialog();
            Actualizar();
        }

        private void dtgPaises_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            p._IdPais = int.Parse(dtgPaises.Rows[i].Cells[0].Value.ToString());
            p._Nombre = dtgPaises.Rows[i].Cells[1].Value.ToString();
            p._NoClubes = int.Parse(dtgPaises.Rows[i].Cells[2].Value.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgPaises.RowCount > 0)
            {
                string r = mp.Eliminar(p);
                if (string.IsNullOrEmpty(r))
                {
                    MessageBox.Show(r);
                    Actualizar();
                }
            }
            else
            {
                MessageBox.Show("Debe elegir un registro");
            }
            Actualizar();
        }

        private void dtgPaises_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAddPais ap = new FrmAddPais();
            ap.ShowDialog();
            Actualizar();
        }

        private void txtBuscarPaises_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void FrmPais_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
