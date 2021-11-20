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
    public partial class FrmParticipante : Form
    {
        ManejadorParticipantes mp;
        int i = 0;
        public static Participantes p;
        public FrmParticipante()
        {
            InitializeComponent();
            mp = new ManejadorParticipantes();
            p = new Participantes();
        }
        void Actualizar()
        {
            mp.Mostrar(dtgParticipantes, txtBuscarParticipantes.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            p._IdParticipante = 0;
            p._Nombre = "";
            p._Direccion = "";
            p._Campeonato = "";
            p._Telefono = "";
            p._Rol = "";
            p._FkIdPais = 0;
            FrmAddParticipante ape = new FrmAddParticipante();
            ape.Dock = DockStyle.Fill;
            ape.ShowDialog();
            Actualizar();
        }

        private void dtgParticipantes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            p._IdParticipante = int.Parse(dtgParticipantes.Rows[i].Cells[0].Value.ToString());
            p._Nombre = dtgParticipantes.Rows[i].Cells[1].Value.ToString();
            p._Direccion = dtgParticipantes.Rows[i].Cells[2].Value.ToString();
            p._Campeonato = dtgParticipantes.Rows[i].Cells[3].Value.ToString();
            p._Telefono = dtgParticipantes.Rows[i].Cells[4].Value.ToString();
            p._Rol = dtgParticipantes.Rows[i].Cells[5].Value.ToString();
            p._FkIdPais = int.Parse(dtgParticipantes.Rows[i].Cells[6].Value.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgParticipantes.RowCount>0)
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
                MessageBox.Show("Debe de elegir un registro");
            }
            Actualizar();
        }

        private void dtgParticipantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAddParticipante ap = new FrmAddParticipante();
            ap.ShowDialog();
            Actualizar();
        }

        private void txtBuscarParticipantes_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void FrmParticipante_Load(object sender, EventArgs e)
        {
            Actualizar();
            //this.dtgParticipantes.Columns["IdParticipante"].Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
