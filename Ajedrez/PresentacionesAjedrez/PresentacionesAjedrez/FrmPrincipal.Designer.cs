
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPartida = new System.Windows.Forms.Button();
            this.btnHotel = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnPais = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnPartida);
            this.panel1.Controls.Add(this.btnHotel);
            this.panel1.Controls.Add(this.btnUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPais);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 553);
            this.panel1.TabIndex = 0;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentacionesAjedrez.Properties.Resources.ajedrezin;
            this.pictureBox1.Location = new System.Drawing.Point(376, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 562);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnPartida
            // 
            this.btnPartida.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPartida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPartida.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPartida.Image = global::PresentacionesAjedrez.Properties.Resources.PartidaAjedrez_ConvertImage;
            this.btnPartida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPartida.Location = new System.Drawing.Point(16, 431);
            this.btnPartida.Margin = new System.Windows.Forms.Padding(4);
            this.btnPartida.Name = "btnPartida";
            this.btnPartida.Size = new System.Drawing.Size(330, 108);
            this.btnPartida.TabIndex = 4;
            this.btnPartida.Text = "Partida";
            this.btnPartida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPartida.UseVisualStyleBackColor = false;
            // 
            // btnHotel
            // 
            this.btnHotel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHotel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHotel.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHotel.Image = global::PresentacionesAjedrez.Properties.Resources.HotelAjedrez_ConvertImage;
            this.btnHotel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHotel.Location = new System.Drawing.Point(16, 315);
            this.btnHotel.Margin = new System.Windows.Forms.Padding(4);
            this.btnHotel.Name = "btnHotel";
            this.btnHotel.Size = new System.Drawing.Size(330, 108);
            this.btnHotel.TabIndex = 3;
            this.btnHotel.Text = "Hotel";
            this.btnHotel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHotel.UseVisualStyleBackColor = false;
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsuario.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUsuario.Image = global::PresentacionesAjedrez.Properties.Resources.UsuarioAjedrez_ConvertImage;
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(16, 199);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(330, 108);
            this.btnUsuario.TabIndex = 2;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnPais
            // 
            this.btnPais.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnPais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPais.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPais.ForeColor = System.Drawing.Color.White;
            this.btnPais.Image = global::PresentacionesAjedrez.Properties.Resources.PaisAjedrez_ConvertImage;
            this.btnPais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPais.Location = new System.Drawing.Point(16, 84);
            this.btnPais.Margin = new System.Windows.Forms.Padding(4);
            this.btnPais.Name = "btnPais";
            this.btnPais.Size = new System.Drawing.Size(330, 108);
            this.btnPais.TabIndex = 0;
            this.btnPais.Text = "Pais";
            this.btnPais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPais.UseVisualStyleBackColor = false;
            this.btnPais.Click += new System.EventHandler(this.btnPais_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPartida;
        private System.Windows.Forms.Button btnHotel;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}