namespace progetto_basket
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ptbCanestro = new System.Windows.Forms.PictureBox();
            this.ptbPalla = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblControllo = new System.Windows.Forms.Label();
            this.lblGara = new System.Windows.Forms.Label();
            this.lblTiro = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGiocatore1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGiocatore2 = new System.Windows.Forms.TextBox();
            this.btnAvvia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCanestro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPalla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbCanestro
            // 
            this.ptbCanestro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbCanestro.BackgroundImage")));
            this.ptbCanestro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbCanestro.Location = new System.Drawing.Point(340, 289);
            this.ptbCanestro.Name = "ptbCanestro";
            this.ptbCanestro.Size = new System.Drawing.Size(123, 125);
            this.ptbCanestro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCanestro.TabIndex = 0;
            this.ptbCanestro.TabStop = false;
            // 
            // ptbPalla
            // 
            this.ptbPalla.BackColor = System.Drawing.Color.DarkOrange;
            this.ptbPalla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbPalla.BackgroundImage")));
            this.ptbPalla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbPalla.Location = new System.Drawing.Point(377, 201);
            this.ptbPalla.Name = "ptbPalla";
            this.ptbPalla.Size = new System.Drawing.Size(47, 50);
            this.ptbPalla.TabIndex = 1;
            this.ptbPalla.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(570, 117);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "[lblStatus]";
            // 
            // lblControllo
            // 
            this.lblControllo.AutoSize = true;
            this.lblControllo.Location = new System.Drawing.Point(469, 346);
            this.lblControllo.Name = "lblControllo";
            this.lblControllo.Size = new System.Drawing.Size(64, 13);
            this.lblControllo.TabIndex = 3;
            this.lblControllo.Text = "[lblControllo]";
            // 
            // lblGara
            // 
            this.lblGara.AutoSize = true;
            this.lblGara.Location = new System.Drawing.Point(383, 9);
            this.lblGara.Name = "lblGara";
            this.lblGara.Size = new System.Drawing.Size(46, 13);
            this.lblGara.TabIndex = 4;
            this.lblGara.Text = "[lblGara]";
            // 
            // lblTiro
            // 
            this.lblTiro.AutoSize = true;
            this.lblTiro.Location = new System.Drawing.Point(383, 33);
            this.lblTiro.Name = "lblTiro";
            this.lblTiro.Size = new System.Drawing.Size(41, 13);
            this.lblTiro.TabIndex = 5;
            this.lblTiro.Text = "[lblTiro]";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGiocatore1);
            this.groupBox1.Location = new System.Drawing.Point(21, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 41);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtGiocatore1
            // 
            this.txtGiocatore1.Location = new System.Drawing.Point(6, 15);
            this.txtGiocatore1.Name = "txtGiocatore1";
            this.txtGiocatore1.Size = new System.Drawing.Size(188, 20);
            this.txtGiocatore1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGiocatore2);
            this.groupBox2.Location = new System.Drawing.Point(21, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 42);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txtGiocatore2
            // 
            this.txtGiocatore2.Location = new System.Drawing.Point(6, 16);
            this.txtGiocatore2.Name = "txtGiocatore2";
            this.txtGiocatore2.Size = new System.Drawing.Size(188, 20);
            this.txtGiocatore2.TabIndex = 1;
            // 
            // btnAvvia
            // 
            this.btnAvvia.BackColor = System.Drawing.Color.Red;
            this.btnAvvia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAvvia.Location = new System.Drawing.Point(21, 142);
            this.btnAvvia.Name = "btnAvvia";
            this.btnAvvia.Size = new System.Drawing.Size(200, 25);
            this.btnAvvia.TabIndex = 0;
            this.btnAvvia.Text = "AVVIA PARTITA";
            this.btnAvvia.UseVisualStyleBackColor = false;
            this.btnAvvia.Click += new System.EventHandler(this.btnAvvia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 458);
            this.Controls.Add(this.btnAvvia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTiro);
            this.Controls.Add(this.lblGara);
            this.Controls.Add(this.lblControllo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.ptbPalla);
            this.Controls.Add(this.ptbCanestro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCanestro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPalla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbCanestro;
        private System.Windows.Forms.PictureBox ptbPalla;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblControllo;
        private System.Windows.Forms.Label lblGara;
        private System.Windows.Forms.Label lblTiro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGiocatore1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGiocatore2;
        private System.Windows.Forms.Button btnAvvia;
    }
}

