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
    public partial class FrmHotel : Form
    {
        ManejadorHotel mh;
        int i = 0;
        public static Hotel h;
        public FrmHotel()
        {
            InitializeComponent();
            mh = new ManejadorHotel();
            h = new Hotel();
        }
        void Actualizar()
        {
            mh.Mostrar(dtgHoteles, txtBuscarHotel.Text);
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            h._IdHotel = 0;
            h._Nombre = "";
            h._Direccion = "";
            h._Telefono = "";
            FrmAddHotel ah = new FrmAddHotel();
            ah.Dock = DockStyle.Fill;
            ah.ShowDialog();
            Actualizar();
        }

        private void dtgHoteles_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            h._IdHotel = int.Parse(dtgHoteles.Rows[i].Cells[0].Value.ToString());
            h._Nombre = dtgHoteles.Rows[i].Cells[1].Value.ToString();
            h._Direccion = dtgHoteles.Rows[i].Cells[2].Value.ToString();
            h._Telefono = dtgHoteles.Rows[i].Cells[3].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgHoteles.RowCount>0)
            {
                string r = mh.Eliminar(h);
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

        private void dtgHoteles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAddHotel ah = new FrmAddHotel();
            ah.ShowDialog();
            Actualizar();
        }

        private void txtBuscarHotel_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void FrmHotel_Load(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
