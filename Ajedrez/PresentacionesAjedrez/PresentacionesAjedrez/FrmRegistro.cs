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
    public partial class FrmRegistro : Form
    {
        ManejadorRegistro mr;
        int i = 0;
        public static Registro re;
        public FrmRegistro()
        {
            InitializeComponent();
            mr = new ManejadorRegistro();
            re = new Registro();
        }
        
        void Actualizar()
        {
            mr.Mostrar(dtgRegistros, txtBuscarRegistro.Text);
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            re._IdRegistro = 0;
            re._FechaEntrada = "";
            re._FechaSalida = "";
            re._FkIdParticipante = 0;
            re._FkIdHotel = 0;
            FrmAddRegistro far = new FrmAddRegistro();
            far.Dock = DockStyle.Fill;
            far.ShowDialog();
            Actualizar();
        }

        private void dtgRegistros_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            re._IdRegistro = int.Parse(dtgRegistros.Rows[i].Cells[0].Value.ToString());
            re._FechaEntrada = dtgRegistros.Rows[i].Cells[1].Value.ToString();
            re._FechaSalida = dtgRegistros.Rows[i].Cells[2].Value.ToString();
            re._FkIdParticipante = int.Parse(dtgRegistros.Rows[i].Cells[3].Value.ToString());
            re._FkIdHotel = int.Parse(dtgRegistros.Rows[i].Cells[4].Value.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgRegistros.RowCount>0)
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
            FrmAddRegistro ar = new FrmAddRegistro();
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
