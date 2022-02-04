namespace EsUniversità
{
    partial class Form2
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
            this.dgvFac = new System.Windows.Forms.DataGridView();
            this.dgvLauree = new System.Windows.Forms.DataGridView();
            this.btnDeleteFac = new System.Windows.Forms.Button();
            this.btnUpdateFac = new System.Windows.Forms.Button();
            this.btnInsertFac = new System.Windows.Forms.Button();
            this.pnlFacoltà = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.txtIndFac = new System.Windows.Forms.TextBox();
            this.txtNomeFac = new System.Windows.Forms.TextBox();
            this.txtCodFac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVisLauree = new System.Windows.Forms.Button();
            this.btnNascondi = new System.Windows.Forms.Button();
            this.btnInsertLaurea = new System.Windows.Forms.Button();
            this.pnlLaurea = new System.Windows.Forms.Panel();
            this.btnLaurea = new System.Windows.Forms.Button();
            this.btnWrong = new System.Windows.Forms.Button();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtL1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbFacolta = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLauree)).BeginInit();
            this.pnlFacoltà.SuspendLayout();
            this.pnlLaurea.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFac
            // 
            this.dgvFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFac.Location = new System.Drawing.Point(12, 12);
            this.dgvFac.Name = "dgvFac";
            this.dgvFac.Size = new System.Drawing.Size(494, 263);
            this.dgvFac.TabIndex = 0;
            // 
            // dgvLauree
            // 
            this.dgvLauree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLauree.Location = new System.Drawing.Point(527, 290);
            this.dgvLauree.Name = "dgvLauree";
            this.dgvLauree.Size = new System.Drawing.Size(479, 246);
            this.dgvLauree.TabIndex = 1;
            this.dgvLauree.Visible = false;
            // 
            // btnDeleteFac
            // 
            this.btnDeleteFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFac.Location = new System.Drawing.Point(320, 290);
            this.btnDeleteFac.Name = "btnDeleteFac";
            this.btnDeleteFac.Size = new System.Drawing.Size(119, 48);
            this.btnDeleteFac.TabIndex = 11;
            this.btnDeleteFac.Text = "CANCELLA FACOLTA\'";
            this.btnDeleteFac.UseVisualStyleBackColor = true;
            // 
            // btnUpdateFac
            // 
            this.btnUpdateFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateFac.Location = new System.Drawing.Point(163, 290);
            this.btnUpdateFac.Name = "btnUpdateFac";
            this.btnUpdateFac.Size = new System.Drawing.Size(119, 48);
            this.btnUpdateFac.TabIndex = 10;
            this.btnUpdateFac.Text = "MODIFICA FACOLTA\'";
            this.btnUpdateFac.UseVisualStyleBackColor = true;
            // 
            // btnInsertFac
            // 
            this.btnInsertFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertFac.Location = new System.Drawing.Point(12, 290);
            this.btnInsertFac.Name = "btnInsertFac";
            this.btnInsertFac.Size = new System.Drawing.Size(119, 48);
            this.btnInsertFac.TabIndex = 9;
            this.btnInsertFac.Text = "INSERIMENTO FACOLTA\'";
            this.btnInsertFac.UseVisualStyleBackColor = true;
            this.btnInsertFac.Click += new System.EventHandler(this.btnInsertFac_Click);
            // 
            // pnlFacoltà
            // 
            this.pnlFacoltà.Controls.Add(this.btnOK);
            this.pnlFacoltà.Controls.Add(this.btnAnnulla);
            this.pnlFacoltà.Controls.Add(this.txtIndFac);
            this.pnlFacoltà.Controls.Add(this.txtNomeFac);
            this.pnlFacoltà.Controls.Add(this.txtCodFac);
            this.pnlFacoltà.Controls.Add(this.label3);
            this.pnlFacoltà.Controls.Add(this.label2);
            this.pnlFacoltà.Controls.Add(this.label1);
            this.pnlFacoltà.Location = new System.Drawing.Point(12, 352);
            this.pnlFacoltà.Name = "pnlFacoltà";
            this.pnlFacoltà.Size = new System.Drawing.Size(427, 220);
            this.pnlFacoltà.TabIndex = 8;
            this.pnlFacoltà.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(242, 127);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(66, 32);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulla.Location = new System.Drawing.Point(142, 127);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(78, 32);
            this.btnAnnulla.TabIndex = 6;
            this.btnAnnulla.Text = "annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // txtIndFac
            // 
            this.txtIndFac.Location = new System.Drawing.Point(142, 82);
            this.txtIndFac.Name = "txtIndFac";
            this.txtIndFac.Size = new System.Drawing.Size(166, 20);
            this.txtIndFac.TabIndex = 5;
            // 
            // txtNomeFac
            // 
            this.txtNomeFac.Location = new System.Drawing.Point(142, 50);
            this.txtNomeFac.Name = "txtNomeFac";
            this.txtNomeFac.Size = new System.Drawing.Size(166, 20);
            this.txtNomeFac.TabIndex = 4;
            // 
            // txtCodFac
            // 
            this.txtCodFac.Location = new System.Drawing.Point(142, 17);
            this.txtCodFac.Name = "txtCodFac";
            this.txtCodFac.Size = new System.Drawing.Size(166, 20);
            this.txtCodFac.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "indirizzo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod Facoltà";
            // 
            // btnVisLauree
            // 
            this.btnVisLauree.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisLauree.Location = new System.Drawing.Point(527, 210);
            this.btnVisLauree.Name = "btnVisLauree";
            this.btnVisLauree.Size = new System.Drawing.Size(134, 65);
            this.btnVisLauree.TabIndex = 12;
            this.btnVisLauree.Text = "VISUALIZZA CORSI DI LAUREA";
            this.btnVisLauree.UseVisualStyleBackColor = true;
            this.btnVisLauree.Click += new System.EventHandler(this.btnVisLauree_Click);
            // 
            // btnNascondi
            // 
            this.btnNascondi.Location = new System.Drawing.Point(528, 548);
            this.btnNascondi.Name = "btnNascondi";
            this.btnNascondi.Size = new System.Drawing.Size(477, 23);
            this.btnNascondi.TabIndex = 13;
            this.btnNascondi.Text = "nascondi";
            this.btnNascondi.UseVisualStyleBackColor = true;
            this.btnNascondi.Click += new System.EventHandler(this.btnNascondi_Click);
            // 
            // btnInsertLaurea
            // 
            this.btnInsertLaurea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertLaurea.Location = new System.Drawing.Point(527, 39);
            this.btnInsertLaurea.Name = "btnInsertLaurea";
            this.btnInsertLaurea.Size = new System.Drawing.Size(127, 48);
            this.btnInsertLaurea.TabIndex = 14;
            this.btnInsertLaurea.Text = "Inserimento laurea";
            this.btnInsertLaurea.UseVisualStyleBackColor = true;
            this.btnInsertLaurea.Click += new System.EventHandler(this.btnInsertLaurea_Click);
            // 
            // pnlLaurea
            // 
            this.pnlLaurea.Controls.Add(this.label7);
            this.pnlLaurea.Controls.Add(this.cmbFacolta);
            this.pnlLaurea.Controls.Add(this.btnLaurea);
            this.pnlLaurea.Controls.Add(this.btnWrong);
            this.pnlLaurea.Controls.Add(this.txtC);
            this.pnlLaurea.Controls.Add(this.txtN);
            this.pnlLaurea.Controls.Add(this.txtL1);
            this.pnlLaurea.Controls.Add(this.label4);
            this.pnlLaurea.Controls.Add(this.label5);
            this.pnlLaurea.Controls.Add(this.label6);
            this.pnlLaurea.Location = new System.Drawing.Point(680, 89);
            this.pnlLaurea.Name = "pnlLaurea";
            this.pnlLaurea.Size = new System.Drawing.Size(335, 195);
            this.pnlLaurea.TabIndex = 9;
            this.pnlLaurea.Visible = false;
            // 
            // btnLaurea
            // 
            this.btnLaurea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaurea.Location = new System.Drawing.Point(242, 154);
            this.btnLaurea.Name = "btnLaurea";
            this.btnLaurea.Size = new System.Drawing.Size(66, 32);
            this.btnLaurea.TabIndex = 7;
            this.btnLaurea.Text = "ok";
            this.btnLaurea.UseVisualStyleBackColor = true;
            this.btnLaurea.Click += new System.EventHandler(this.btnLaurea_Click);
            // 
            // btnWrong
            // 
            this.btnWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrong.Location = new System.Drawing.Point(142, 154);
            this.btnWrong.Name = "btnWrong";
            this.btnWrong.Size = new System.Drawing.Size(78, 32);
            this.btnWrong.TabIndex = 6;
            this.btnWrong.Text = "annulla";
            this.btnWrong.UseVisualStyleBackColor = true;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(142, 82);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(166, 20);
            this.txtC.TabIndex = 5;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(142, 50);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(166, 20);
            this.txtN.TabIndex = 4;
            // 
            // txtL1
            // 
            this.txtL1.Location = new System.Drawing.Point(142, 19);
            this.txtL1.Name = "txtL1";
            this.txtL1.Size = new System.Drawing.Size(166, 20);
            this.txtL1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "crediti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cod laurea";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // cmbFacolta
            // 
            this.cmbFacolta.FormattingEnabled = true;
            this.cmbFacolta.Location = new System.Drawing.Point(187, 107);
            this.cmbFacolta.Name = "cmbFacolta";
            this.cmbFacolta.Size = new System.Drawing.Size(121, 21);
            this.cmbFacolta.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Facolta associata";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 584);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pnlLaurea);
            this.Controls.Add(this.btnInsertLaurea);
            this.Controls.Add(this.btnNascondi);
            this.Controls.Add(this.btnVisLauree);
            this.Controls.Add(this.btnDeleteFac);
            this.Controls.Add(this.btnUpdateFac);
            this.Controls.Add(this.btnInsertFac);
            this.Controls.Add(this.pnlFacoltà);
            this.Controls.Add(this.dgvLauree);
            this.Controls.Add(this.dgvFac);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLauree)).EndInit();
            this.pnlFacoltà.ResumeLayout(false);
            this.pnlFacoltà.PerformLayout();
            this.pnlLaurea.ResumeLayout(false);
            this.pnlLaurea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFac;
        private System.Windows.Forms.DataGridView dgvLauree;
        private System.Windows.Forms.Button btnDeleteFac;
        private System.Windows.Forms.Button btnUpdateFac;
        private System.Windows.Forms.Button btnInsertFac;
        private System.Windows.Forms.Panel pnlFacoltà;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.TextBox txtIndFac;
        private System.Windows.Forms.TextBox txtNomeFac;
        private System.Windows.Forms.TextBox txtCodFac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVisLauree;
        private System.Windows.Forms.Button btnNascondi;
        private System.Windows.Forms.Button btnInsertLaurea;
        private System.Windows.Forms.Panel pnlLaurea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFacolta;
        private System.Windows.Forms.Button btnLaurea;
        private System.Windows.Forms.Button btnWrong;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtL1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}