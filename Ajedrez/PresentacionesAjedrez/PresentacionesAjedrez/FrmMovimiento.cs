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
    public partial class FrmMovimiento : Form
    {
        public FrmMovimiento()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAddMovimiento fam = new FrmAddMovimiento();
            fam.Dock = DockStyle.Fill;
            fam.ShowDialog();
        }
    }
}
