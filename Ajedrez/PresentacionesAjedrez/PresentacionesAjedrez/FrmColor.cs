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
    public partial class FrmColor : Form
    {
        public FrmColor()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAddColor fac = new FrmAddColor();
            fac.Dock = DockStyle.Fill;
            fac.ShowDialog();
        }
    }
}
