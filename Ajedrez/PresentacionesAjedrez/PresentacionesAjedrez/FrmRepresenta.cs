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
    public partial class FrmRepresenta : Form
    {
        ManejadorRepresenta mr;
        int i = 0;
        public static Representa rp;
        public FrmRepresenta()
        {
            InitializeComponent();
            mr = new ManejadorRepresenta();
            rp = new Representa();
        }

        void Actualizar()
        {
            mr.Mostrar(dtgRepresenta, txtBuscarColor.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            rp._IdRepresenta = 0;
            rp._PaisRepresentante = 0;
            rp._PaisRepresentado = 0;
            FrmAddRepresenta fac = new FrmAddRepresenta();
            fac.Dock = DockStyle.Fill;
            fac.ShowDialog();
            Actualizar();
        }

        private void dtgRepresenta_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            rp._IdRepresenta = int.Parse(dtgRepresenta.Rows[i].Cells[0].Value.ToString());
            rp._PaisRepresentante = int.Parse(dtgRepresenta.Rows[i].Cells[1].Value.ToString());
            rp._PaisRepresentado = int.Parse(dtgRepresenta.Rows[i].Cells[2].Value.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgRepresenta.RowCount>0)
            {
                string r = mr.Eliminar(rp);
                 if(string.IsNullOrEmpty(r))
                {
                    MessageBox.Show(r);
                    Actualizar();
                }
            }
            else
            {
                MessageBox.Show("Debe de elegir un registro");
            }
        }

        private void dtgRepresenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAddRepresenta ar = new FrmAddRepresenta();
            ar.ShowDialog();
            Actualizar();
        }

        private void txtBuscarColor_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void FrmRepresenta_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
