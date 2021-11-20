
namespace PresentacionesAjedrez
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPais = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRepresenta = new System.Windows.Forms.ToolStripMenuItem();
            this.participantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnParticipante = new System.Windows.Forms.ToolStripMenuItem();
            this.btnJugador = new System.Windows.Forms.ToolStripMenuItem();
            this.btnArbitro = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHotel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAloja = new System.Windows.Forms.ToolStripMenuItem();
            this.salasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPartidas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMovimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::PresentacionesAjedrez.Properties.Resources.Black_and_White_Chess_Pattern_generated;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 564);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paisToolStripMenuItem,
            this.participantesToolStripMenuItem,
            this.hotelToolStripMenuItem,
            this.salasToolStripMenuItem,
            this.btnSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(852, 45);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paisToolStripMenuItem
            // 
            this.paisToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.paisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPais,
            this.btnRepresenta});
            this.paisToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paisToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.paisToolStripMenuItem.Name = "paisToolStripMenuItem";
            this.paisToolStripMenuItem.Size = new System.Drawing.Size(80, 41);
            this.paisToolStripMenuItem.Text = "Pais";
            // 
            // btnPais
            // 
            this.btnPais.BackColor = System.Drawing.Color.Black;
            this.btnPais.ForeColor = System.Drawing.Color.White;
            this.btnPais.Image = global::PresentacionesAjedrez.Properties.Resources.icons8_country_80px;
            this.btnPais.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPais.Name = "btnPais";
            this.btnPais.Size = new System.Drawing.Size(302, 86);
            this.btnPais.Text = "Pais";
            this.btnPais.Click += new System.EventHandler(this.btnPais_Click_2);
            // 
            // btnRepresenta
            // 
            this.btnRepresenta.BackColor = System.Drawing.Color.Black;
            this.btnRepresenta.ForeColor = System.Drawing.Color.White;
            this.btnRepresenta.Image = global::PresentacionesAjedrez.Properties.Resources.icons8_ubicación_en_todo_el_mundo_48;
            this.btnRepresenta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRepresenta.Name = "btnRepresenta";
            this.btnRepresenta.Size = new System.Drawing.Size(302, 86);
            this.btnRepresenta.Text = "Representa";
            this.btnRepresenta.Click += new System.EventHandler(this.btnRepresenta_Click);
            // 
            // participantesToolStripMenuItem
            // 
            this.participantesToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.participantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnParticipante,
            this.btnJugador,
            this.btnArbitro});
            this.participantesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participantesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.participantesToolStripMenuItem.Name = "participantesToolStripMenuItem";
            this.participantesToolStripMenuItem.Size = new System.Drawing.Size(198, 41);
            this.participantesToolStripMenuItem.Text = "Participantes";
            // 
            // btnParticipante
            // 
            this.btnParticipante.BackColor = System.Drawing.Color.Black;
            this.btnParticipante.ForeColor = System.Drawing.Color.White;
            this.btnParticipante.Image = global::PresentacionesAjedrez.Properties.Resources.icons8_users_48px;
            this.btnParticipante.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnParticipante.Name = "btnParticipante";
            this.btnParticipante.Size = new System.Drawing.Size(315, 86);
            this.btnParticipante.Text = "Participante";
            this.btnParticipante.Click += new System.EventHandler(this.btnParticipante_Click_1);
            // 
            // btnJugador
            // 
            this.btnJugador.BackColor = System.Drawing.Color.Black;
            this.btnJugador.ForeColor = System.Drawing.Color.White;
            this.btnJugador.Image = global::PresentacionesAjedrez.Properties.Resources.icons8_jugador_48;
            this.btnJugador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnJugador.Name = "btnJugador";
            this.btnJugador.Size = new System.Drawing.Size(315, 86);
            this.btnJugador.Text = "Jugador";
            this.btnJugador.Click += new System.EventHandler(this.btnJugador_Click_1);
            // 
            // btnArbitro
            // 
            this.btnArbitro.BackColor = System.Drawing.Color.Black;
            this.btnArbitro.ForeColor = System.Drawing.Color.White;
            this.btnArbitro.Image = global::PresentacionesAjedrez.Properties.Resources.icons8_árbitro_80;
            this.btnArbitro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnArbitro.Name = "btnArbitro";
            this.btnArbitro.Size = new System.Drawing.Size(315, 86);
            this.btnArbitro.Text = "Arbitro";
            this.btnArbitro.Click += new System.EventHandler(this.btnArbitro_Click_1);
            // 
            // hotelToolStripMenuItem
            // 
            this.hotelToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.hotelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHotel,
            this.btnAloja});
            this.hotelToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.hotelToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.hotelToolStripMenuItem.Name = "hotelToolStripMenuItem";
            this.hotelToolStripMenuItem.Size = new System.Drawing.Size(101, 41);
            this.hotelToolStripMenuItem.Text = "Hotel";
            // 
            // btnHotel
            // 
            this.btnHotel.BackColor = System.Drawing.Color.Black;
            this.btnHotel.ForeColor = System.Drawing.Color.White;
            this.btnHotel.Image = global::PresentacionesAjedrez.Properties.Resources.icons8_hotel_96px;
            this.btnHotel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHotel.Name = "btnHotel";
            this.btnHotel.Size = new System.Drawing.Size(260, 102);
            this.btnHotel.Text = "Hotel";
            this.btnHotel.Click += new System.EventHandler(this.btnHotel_Click_1);
            // 
            // btnAloja
            // 
            this.btnAloja.BackColor = System.Drawing.Color.Black;
            this.btnAloja.ForeColor = System.Drawing.Color.White;
            this.btnAloja.Image = global::PresentacionesAjedrez.Properties.Resources.icons8_note_64px;
            this.btnAloja.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAloja.Name = "btnAloja";
            this.btnAloja.Size = new System.Drawing.Size(260, 102);
            this.btnAloja.Text = "Aloja";
            this.btnAloja.Click += new System.EventHandler(this.btnAloja_Click);
            // 
            // salasToolStripMenuItem
            // 
            this.salasToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.salasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalas,
            this.btnPartidas,
            this.btnMovimiento});
            this.salasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salasToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.salasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salasToolStripMenuItem.Name = "salasToolStripMenuItem";
            this.salasToolStripMenuItem.Size = new System.Drawing.Size(94, 41);
            this.salasToolStripMenuItem.Text = "Salas";
            // 
            // btnSalas
            // 
            this.btnSalas.BackColor = System.Drawing.Color.Black;
            this.btnSalas.ForeColor = System.Drawing.Color.White;
            this.btnSalas.Image = global::PresentacionesAjedrez.Properties.Resources.icons8_room_64;
            this.btnSalas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalas.Name = "btnSalas";
            this.btnSalas.Size = new System.Drawing.Size(300, 70);
            this.btnSalas.Text = "Salas";
            this.btnSalas.Click += new System.EventHandler(this.btnSalas_Click_1);
            // 
            // btnPartidas
            // 
            this.btnPartidas.BackColor = System.Drawing.Color.Black;
            this.btnPartidas.ForeColor = System.Drawing.Color.White;
            this.btnPartidas.Image = global::PresentacionesAjedrez.Properties.Resources.icons8_head_to_head_48px;
            this.btnPartidas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPartidas.Name = "btnPartidas";
            this.btnPartidas.Size = new System.Drawing.Size(300, 70);
            this.btnPartidas.Text = "Partidas";
            this.btnPartidas.Click += new System.EventHandler(this.btnPartidas_Click_1);
            // 
            // btnMovimiento
            // 
            this.btnMovimiento.BackColor = System.Drawing.Color.Black;
            this.btnMovimiento.ForeColor = System.Drawing.Color.White;
            this.btnMovimiento.Image = global::PresentacionesAjedrez.Properties.Resources.icons8_move_32px;
            this.btnMovimiento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMovimiento.Name = "btnMovimiento";
            this.btnMovimiento.Size = new System.Drawing.Size(300, 70);
            this.btnMovimiento.Text = "Movimiento";
            this.btnMovimiento.Click += new System.EventHandler(this.btnMovimiento_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 41);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(852, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnPais;
        private System.Windows.Forms.ToolStripMenuItem btnRepresenta;
        private System.Windows.Forms.ToolStripMenuItem participantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnParticipante;
        private System.Windows.Forms.ToolStripMenuItem btnJugador;
        private System.Windows.Forms.ToolStripMenuItem btnArbitro;
        private System.Windows.Forms.ToolStripMenuItem hotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnHotel;
        private System.Windows.Forms.ToolStripMenuItem btnAloja;
        private System.Windows.Forms.ToolStripMenuItem salasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSalas;
        private System.Windows.Forms.ToolStripMenuItem btnPartidas;
        private System.Windows.Forms.ToolStripMenuItem btnMovimiento;
        private System.Windows.Forms.ToolStripMenuItem btnSalir;
    }
}