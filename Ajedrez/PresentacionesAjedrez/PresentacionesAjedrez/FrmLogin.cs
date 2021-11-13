﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;

namespace PresentacionesAjedrez
{
    public partial class FrmLogin : Form
    {
        ManejadorLogin log;
        public FrmLogin()
        {
            InitializeComponent();
            log = new ManejadorLogin();
        }
    void Logear()
        {
            int valor = log.ObtenerLogins(txtUser.Text, txtPassword.Text);
            if (valor == 1)
            {
                FrmPrincipal p = new FrmPrincipal();
                p.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Logear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
