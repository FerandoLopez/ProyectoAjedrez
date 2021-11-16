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
    public partial class FrmAlojamiento : Form
    {
        ManejadorAlojamiento mr;
        int i = 0;
        public static Alojamiento re;
        public FrmAlojamiento()
        {
            InitializeComponent();
            mr = new ManejadorAlojamiento();
            re = new Alojamiento();
        }
        
        void Actualizar()
        {
            mr.Mostrar(dtgAlojamientos, txtBuscarRegistro.Text);
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            re._IdAlojamiento = 0;
            re._FechaEntrada = "";
            re._FechaSalida = "";
            re._FkIdPartiicpante = 0;
            re._Hotel = "";
            FrmAddAlojamiento far = new FrmAddAlojamiento();
            far.Dock = DockStyle.Fill;
            far.ShowDialog();
            Actualizar();
        }

        private void dtgRegistros_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            re._IdAlojamiento = int.Parse(dtgAlojamientos.Rows[i].Cells[0].Value.ToString());
            re._FkIdPartiicpante = int.Parse(dtgAlojamientos.Rows[i].Cells[1].Value.ToString());
            re._Hotel = dtgAlojamientos.Rows[i].Cells[2].Value.ToString();
            re._FechaEntrada = dtgAlojamientos.Rows[i].Cells[3].Value.ToString();
            re._FechaSalida = dtgAlojamientos.Rows[i].Cells[4].Value.ToString();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgAlojamientos.RowCount>0)
            {
                string r = mr.Eliminar(re);
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

        private void dtgRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAddAlojamiento ar = new FrmAddAlojamiento();
            ar.ShowDialog();
            Actualizar();
        }

        private void txtBuscarRegistro_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
