
namespace EsUniversità
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTestController = new System.Windows.Forms.Button();
            this.btnTestControllerPS = new System.Windows.Forms.Button();
            this.btnDatiStudente = new System.Windows.Forms.Button();
            this.pnlStudente = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtMatricola = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertStudente = new System.Windows.Forms.Button();
            this.btnUpdateStudente = new System.Windows.Forms.Button();
            this.btnDeleteStudente = new System.Windows.Forms.Button();
            this.btnGsetFacoltà = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlStudente.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(210, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnTestController
            // 
            this.btnTestController.Location = new System.Drawing.Point(12, 23);
            this.btnTestController.Name = "btnTestController";
            this.btnTestController.Size = new System.Drawing.Size(177, 44);
            this.btnTestController.TabIndex = 1;
            this.btnTestController.Text = "test controller studenti";
            this.btnTestController.UseVisualStyleBackColor = true;
            this.btnTestController.Click += new System.EventHandler(this.btnTestController_Click);
            // 
            // btnTestControllerPS
            // 
            this.btnTestControllerPS.Location = new System.Drawing.Point(12, 89);
            this.btnTestControllerPS.Name = "btnTestControllerPS";
            this.btnTestControllerPS.Size = new System.Drawing.Size(177, 44);
            this.btnTestControllerPS.TabIndex = 2;
            this.btnTestControllerPS.Text = "test controller piano di studi";
            this.btnTestControllerPS.UseVisualStyleBackColor = true;
            this.btnTestControllerPS.Click += new System.EventHandler(this.btnTestControllerPS_Click);
            // 
            // btnDatiStudente
            // 
            this.btnDatiStudente.Location = new System.Drawing.Point(12, 148);
            this.btnDatiStudente.Name = "btnDatiStudente";
            this.btnDatiStudente.Size = new System.Drawing.Size(177, 44);
            this.btnDatiStudente.TabIndex = 3;
            this.btnDatiStudente.Text = "dati studente";
            this.btnDatiStudente.UseVisualStyleBackColor = true;
            this.btnDatiStudente.Visible = false;
            this.btnDatiStudente.Click += new System.EventHandler(this.btnDatiStudente_Click);
            // 
            // pnlStudente
            // 
            this.pnlStudente.Controls.Add(this.btnOK);
            this.pnlStudente.Controls.Add(this.btnAnnulla);
            this.pnlStudente.Controls.Add(this.txtNome);
            this.pnlStudente.Controls.Add(this.txtCognome);
            this.pnlStudente.Controls.Add(this.txtMatricola);
            this.pnlStudente.Controls.Add(this.label3);
            this.pnlStudente.Controls.Add(this.label2);
            this.pnlStudente.Controls.Add(this.label1);
            this.pnlStudente.Location = new System.Drawing.Point(210, 307);
            this.pnlStudente.Name = "pnlStudente";
            this.pnlStudente.Size = new System.Drawing.Size(328, 167);
            this.pnlStudente.TabIndex = 4;
            this.pnlStudente.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(218, 127);
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
            this.btnAnnulla.Location = new System.Drawing.Point(118, 127);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(78, 32);
            this.btnAnnulla.TabIndex = 6;
            this.btnAnnulla.Text = "annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(118, 82);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(166, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(118, 50);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(166, 20);
            this.txtCognome.TabIndex = 4;
            // 
            // txtMatricola
            // 
            this.txtMatricola.Location = new System.Drawing.Point(118, 17);
            this.txtMatricola.Name = "txtMatricola";
            this.txtMatricola.Size = new System.Drawing.Size(166, 20);
            this.txtMatricola.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "cognome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "matricola";
            // 
            // btnInsertStudente
            // 
            this.btnInsertStudente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertStudente.Location = new System.Drawing.Point(210, 245);
            this.btnInsertStudente.Name = "btnInsertStudente";
            this.btnInsertStudente.Size = new System.Drawing.Size(137, 48);
            this.btnInsertStudente.TabIndex = 5;
            this.btnInsertStudente.Text = "INSERIMENTO STUDENTE";
            this.btnInsertStudente.UseVisualStyleBackColor = true;
            this.btnInsertStudente.Visible = false;
            this.btnInsertStudente.Click += new System.EventHandler(this.btnInsertStudente_Click);
            // 
            // btnUpdateStudente
            // 
            this.btnUpdateStudente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudente.Location = new System.Drawing.Point(357, 245);
            this.btnUpdateStudente.Name = "btnUpdateStudente";
            this.btnUpdateStudente.Size = new System.Drawing.Size(137, 48);
            this.btnUpdateStudente.TabIndex = 6;
            this.btnUpdateStudente.Text = "MODIFICA STUDENTE";
            this.btnUpdateStudente.UseVisualStyleBackColor = true;
            this.btnUpdateStudente.Visible = false;
            this.btnUpdateStudente.Click += new System.EventHandler(this.btnUpdateStudente_Click);
            // 
            // btnDeleteStudente
            // 
            this.btnDeleteStudente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudente.Location = new System.Drawing.Point(500, 245);
            this.btnDeleteStudente.Name = "btnDeleteStudente";
            this.btnDeleteStudente.Size = new System.Drawing.Size(137, 48);
            this.btnDeleteStudente.TabIndex = 7;
            this.btnDeleteStudente.Text = "CANCELLA STUDENTE";
            this.btnDeleteStudente.UseVisualStyleBackColor = true;
            this.btnDeleteStudente.Visible = false;
            this.btnDeleteStudente.Click += new System.EventHandler(this.btnDeleteStudente_Click);
            // 
            // btnGsetFacoltà
            // 
            this.btnGsetFacoltà.Location = new System.Drawing.Point(12, 249);
            this.btnGsetFacoltà.Name = "btnGsetFacoltà";
            this.btnGsetFacoltà.Size = new System.Drawing.Size(177, 44);
            this.btnGsetFacoltà.TabIndex = 8;
            this.btnGsetFacoltà.Text = "gestione facoltà";
            this.btnGsetFacoltà.UseVisualStyleBackColor = true;
            this.btnGsetFacoltà.Click += new System.EventHandler(this.btnGsetFacoltà_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.btnGsetFacoltà);
            this.Controls.Add(this.btnDeleteStudente);
            this.Controls.Add(this.btnUpdateStudente);
            this.Controls.Add(this.btnInsertStudente);
            this.Controls.Add(this.pnlStudente);
            this.Controls.Add(this.btnDatiStudente);
            this.Controls.Add(this.btnTestControllerPS);
            this.Controls.Add(this.btnTestController);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlStudente.ResumeLayout(false);
            this.pnlStudente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTestController;
        private System.Windows.Forms.Button btnTestControllerPS;
        private System.Windows.Forms.Button btnDatiStudente;
        private System.Windows.Forms.Panel pnlStudente;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtMatricola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertStudente;
        private System.Windows.Forms.Button btnUpdateStudente;
        private System.Windows.Forms.Button btnDeleteStudente;
        private System.Windows.Forms.Button btnGsetFacoltà;
    }
}

