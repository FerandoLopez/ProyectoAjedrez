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
    public partial class FrmPartida : Form
    {
        public FrmPartida()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAddPartida fap = new FrmAddPartida();
            fap.Dock = DockStyle.Fill;
            fap.ShowDialog();
        }
    }
}
