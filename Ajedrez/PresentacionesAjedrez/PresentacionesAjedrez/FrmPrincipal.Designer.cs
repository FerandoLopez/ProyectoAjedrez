
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnJugador = new System.Windows.Forms.Button();
            this.btnHotel = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnArbitro = new System.Windows.Forms.Button();
            this.btnMovimiento = new System.Windows.Forms.Button();
            this.btnParticipante = new System.Windows.Forms.Button();
            this.btnPartidas = new System.Windows.Forms.Button();
            this.btnSalas = new System.Windows.Forms.Button();
            this.btnRepresenta = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnPais = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(71, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "Campeonato\r\nAjedrez";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnJugador);
            this.panel1.Controls.Add(this.btnPartidas);
            this.panel1.Controls.Add(this.btnMovimiento);
            this.panel1.Controls.Add(this.btnSalas);
            this.panel1.Controls.Add(this.btnRegistro);
            this.panel1.Controls.Add(this.btnHotel);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnArbitro);
            this.panel1.Controls.Add(this.btnParticipante);
            this.panel1.Controls.Add(this.btnRepresenta);
            this.panel1.Controls.Add(this.btnPais);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 1095);
            this.panel1.TabIndex = 0;
            // 
            // btnJugador
            // 
            this.btnJugador.FlatAppearance.BorderSize = 0;
            this.btnJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugador.ForeColor = System.Drawing.Color.White;
            this.btnJugador.Image = global::PresentacionesAjedrez.Properties.Resources.icons8_users_48px;
            this.btnJugador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJugador.Location = new System.Drawing.Point(3, 366);
            this.btnJugador.Margin = new System.Windows.Forms.Padding(4);
            this.btnJugador.Name = "btnJugador";
            this.btnJugador.Size = new System.Drawing.Size(284, 83);
            this.btnJugador.TabIndex = 15;
            this.btnJugador.Text = "Jugador";
            this.btnJugador.UseVisualStyleBackColor = true;
            this.btnJugador.Click += new System.EventHandler(this.btnJugador_Click);
            // 
            // btnHotel
            // 
            this.btnHotel.FlatAppearance.BorderSize = 0;
            this.btnHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotel.ForeColor = System.Drawing.Color.White;
            this.btnHotel.Image = global::PresentacionesAjedrez.Properties.Resources.icons8_hotel_96px;
            this.btnHotel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHotel.Location = new System.Drawing.Point(3, 538);
            this.btnHotel.Margin = new System.Windows.Forms.Padding(4);
            this.btnHotel.Name = "btnHotel";
            this.btnHotel.Size = new System.Drawing.Size(280, 83);
            this.btnHotel.TabIndex = 8;
            this.btnHotel.Text = "Hotel";
            this.btnHotel.UseVisualStyleBackColor = true;
            this.btnHotel.Click += new System.EventHandler(this.btnHotel_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(4, 976);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(284, 84);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnArbitro
            // 
            this.btnArbitro.FlatAppearance.BorderSize = 0;
            this.btnArbitro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArbitro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArbitro.ForeColor = System.Drawing.Color.White;
            this.btnArbitro.Image = global::PresentacionesAjedrez.Properties.Resources.icons8_users_48px;
            this.btnArbitro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArbitro.Location = new System.Drawing.Point(4, 457);
            this.btnArbitro.Margin = new System.Windows.Forms.Padding(4);
            this.btnArbitro.Name = "btnArbitro";
            this.btnArbitro.Size = new System.Drawing.Size(280, 84);
            this.btnArbitro.TabIndex = 16;
            this.btnArbitro.Text = "Arbitro";
            this.btnArbitro.UseVisualStyleBackColor = true;
            this.btnArbitro.Click += new System.EventHandler(this.btnArbitro_Click);
            // 
            // btnMovimiento
            // 
            this.btnMovimiento.FlatAppearance.BorderSize = 0;
            this.btnMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovimiento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimiento.ForeColor = System.Drawing.Color.White;
            this.btnMovimiento.Image = global::PresentacionesAjedrez.Properties.Resources.icons8_move_32px;
            this.btnMovimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovimiento.Location = new System.Drawing.Point(8, 884);
            this.btnMovimiento.Margin = new System.Windows.Forms.Padding(4);
            this.btnMovimiento.Name = "btnMovimiento";
            this.btnMovimiento.Size = new System.Drawing.Size(284, 84);
            this.btnMovimiento.TabIndex = 13;
            this.btnMovimiento.Text = "Movimiento";
            this.btnMovimiento.UseVisualStyleBackColor = true;
            this.btnMovimiento.Click += new System.EventHandler(this.btnMovimiento_Click);
            // 
            // btnParticipante
            // 
            this.btnParticipante.FlatAppearance.BorderSize = 0;
            this.btnParticipante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParticipante.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParticipante.ForeColor = System.Drawing.Color.White;
            this.btnParticipante.Image = global::PresentacionesAjedrez.Properties.Resources.icons8_users_48px;
            this.btnParticipante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParticipante.Location = new System.Drawing.Point(3, 290);
            this.btnParticipante.Margin = new System.Windows.Forms.Padding(4);
            this.btnParticipante.Name = "btnParticipante";
            this.btnParticipante.Size = new System.Drawing.Size(281, 83);
            this.btnParticipante.TabIndex = 7;
            this.btnParticipante.Text = "Participante";
            this.btnParticipante.UseVisualStyleBackColor = true;
            this.btnParticipante.Click += new System.EventHandler(this.btnParticipante_Click);
            // 
            // btnPartidas
            // 
            this.btnPartidas.FlatAppearance.BorderSize = 0;
            this.btnPartidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartidas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartidas.ForeColor = System.Drawing.Color.White;
            this.btnPartidas.Image = global::PresentacionesAjedrez.Properties.Resources.icons8_head_to_head_48px;
            this.btnPartidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPartidas.Location = new System.Drawing.Point(8, 804);
            this.btnPartidas.Margin = new System.Windows.Forms.Padding(4);
            this.btnPartidas.Name = "btnPartidas";
            this.btnPartidas.Size = new System.Drawing.Size(284, 84);
            this.btnPartidas.TabIndex = 11;
            this.btnPartidas.Text = "Partidas";
            this.btnPartidas.UseVisualStyleBackColor = true;
            this.btnPartidas.Click += new System.EventHandler(this.btnPartidas_Click);
            // 
            // btnSalas
            // 
            this.btnSalas.FlatAppearance.BorderSize = 0;
            this.btnSalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalas.ForeColor = System.Drawing.Color.White;
            this.btnSalas.Image = global::PresentacionesAjedrez.Properties.Resources.icons8_room_64px;
            this.btnSalas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalas.Location = new System.Drawing.Point(4, 721);
            this.btnSalas.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalas.Name = "btnSalas";
            this.btnSalas.Size = new System.Drawing.Size(284, 84);
            this.btnSalas.TabIndex = 10;
            this.btnSalas.Text = "Salas";
            this.btnSalas.UseVisualStyleBackColor = true;
            this.btnSalas.Click += new System.EventHandler(this.btnSalas_Click);
            // 
            // btnRepresenta
            // 
            this.btnRepresenta.FlatAppearance.BorderSize = 0;
            this.btnRepresenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepresenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepresenta.ForeColor = System.Drawing.Color.White;
            this.btnRepresenta.Image = global::PresentacionesAjedrez.Properties.Resources.icons8_color_wheel_80px;
            this.btnRepresenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepresenta.Location = new System.Drawing.Point(4, 199);
            this.btnRepresenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnRepresenta.Name = "btnRepresenta";
            this.btnRepresenta.Size = new System.Drawing.Size(283, 83);
            this.btnRepresenta.TabIndex = 12;
            this.btnRepresenta.Text = "      Representa";
            this.btnRepresenta.UseVisualStyleBackColor = true;
            this.btnRepresenta.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.Color.White;
            this.btnRegistro.Image = global::PresentacionesAjedrez.Properties.Resources.icons8_note_64px;
            this.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.Location = new System.Drawing.Point(8, 629);
            this.btnRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(284, 84);
            this.btnRegistro.TabIndex = 9;
            this.btnRegistro.Text = "Aloja";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnPais
            // 
            this.btnPais.FlatAppearance.BorderSize = 0;
            this.btnPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPais.ForeColor = System.Drawing.Color.White;
            this.btnPais.Image = global::PresentacionesAjedrez.Properties.Resources.icons8_country_80px;
            this.btnPais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPais.Location = new System.Drawing.Point(4, 108);
            this.btnPais.Margin = new System.Windows.Forms.Padding(4);
            this.btnPais.Name = "btnPais";
            this.btnPais.Size = new System.Drawing.Size(280, 83);
            this.btnPais.TabIndex = 6;
            this.btnPais.Text = "                 Pais";
            this.btnPais.UseVisualStyleBackColor = true;
            this.btnPais.Click += new System.EventHandler(this.btnPais_Click_1);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1132, 1095);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPais;
        private System.Windows.Forms.Button btnParticipante;
        private System.Windows.Forms.Button btnHotel;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnSalas;
        private System.Windows.Forms.Button btnPartidas;
        private System.Windows.Forms.Button btnRepresenta;
        private System.Windows.Forms.Button btnMovimiento;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnJugador;
        private System.Windows.Forms.Button btnArbitro;
    }
}