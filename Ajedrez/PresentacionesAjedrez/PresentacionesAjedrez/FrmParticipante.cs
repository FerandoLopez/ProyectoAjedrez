using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionesAjedrez
{
    public partial class FrmParticipante : Form
    {
        public FrmParticipante()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAddParticipante ape = new FrmAddParticipante();
            ape.Dock = DockStyle.Fill;
            ape.ShowDialog();
        }
    }
}
