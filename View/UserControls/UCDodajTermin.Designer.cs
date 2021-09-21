
namespace View.UserControls
{
    partial class UCDodajTermin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvStavkeTermina = new System.Windows.Forms.DataGridView();
            this.dtpDatumIVreme = new System.Windows.Forms.DateTimePicker();
            this.cmbInstruktor = new System.Windows.Forms.ComboBox();
            this.cmbCas = new System.Windows.Forms.ComboBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnObrisiStavku = new System.Windows.Forms.Button();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblDatumIVreme = new System.Windows.Forms.Label();
            this.lblInstruktor = new System.Windows.Forms.Label();
            this.lblCas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeTermina)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj termin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum i vreme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Instruktor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cas:";
            // 
            // dgvStavkeTermina
            // 
            this.dgvStavkeTermina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeTermina.Location = new System.Drawing.Point(6, 32);
            this.dgvStavkeTermina.Name = "dgvStavkeTermina";
            this.dgvStavkeTermina.RowHeadersWidth = 51;
            this.dgvStavkeTermina.RowTemplate.Height = 24;
            this.dgvStavkeTermina.Size = new System.Drawing.Size(491, 191);
            this.dgvStavkeTermina.TabIndex = 4;
            // 
            // dtpDatumIVreme
            // 
            this.dtpDatumIVreme.Location = new System.Drawing.Point(193, 82);
            this.dtpDatumIVreme.Name = "dtpDatumIVreme";
            this.dtpDatumIVreme.Size = new System.Drawing.Size(307, 22);
            this.dtpDatumIVreme.TabIndex = 5;
            // 
            // cmbInstruktor
            // 
            this.cmbInstruktor.FormattingEnabled = true;
            this.cmbInstruktor.Location = new System.Drawing.Point(193, 128);
            this.cmbInstruktor.Name = "cmbInstruktor";
            this.cmbInstruktor.Size = new System.Drawing.Size(307, 24);
            this.cmbInstruktor.TabIndex = 6;
            // 
            // cmbCas
            // 
            this.cmbCas.FormattingEnabled = true;
            this.cmbCas.Location = new System.Drawing.Point(193, 170);
            this.cmbCas.Name = "cmbCas";
            this.cmbCas.Size = new System.Drawing.Size(307, 24);
            this.cmbCas.TabIndex = 7;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(434, 479);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(147, 41);
            this.btnSacuvaj.TabIndex = 8;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnObrisiStavku);
            this.groupBox1.Controls.Add(this.btnDodajStavku);
            this.groupBox1.Controls.Add(this.dgvStavkeTermina);
            this.groupBox1.Location = new System.Drawing.Point(3, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 247);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stavke termina - ucenici";
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiStavku.Location = new System.Drawing.Point(503, 147);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(75, 63);
            this.btnObrisiStavku.TabIndex = 6;
            this.btnObrisiStavku.Text = "-";
            this.btnObrisiStavku.UseVisualStyleBackColor = true;
            this.btnObrisiStavku.Click += new System.EventHandler(this.btnObrisiStavku_Click);
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajStavku.Location = new System.Drawing.Point(503, 53);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(75, 63);
            this.btnDodajStavku.TabIndex = 5;
            this.btnDodajStavku.Text = "+";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // lblDatumIVreme
            // 
            this.lblDatumIVreme.AutoSize = true;
            this.lblDatumIVreme.ForeColor = System.Drawing.Color.Red;
            this.lblDatumIVreme.Location = new System.Drawing.Point(412, 83);
            this.lblDatumIVreme.Name = "lblDatumIVreme";
            this.lblDatumIVreme.Size = new System.Drawing.Size(0, 17);
            this.lblDatumIVreme.TabIndex = 10;
            // 
            // lblInstruktor
            // 
            this.lblInstruktor.AutoSize = true;
            this.lblInstruktor.ForeColor = System.Drawing.Color.Red;
            this.lblInstruktor.Location = new System.Drawing.Point(412, 132);
            this.lblInstruktor.Name = "lblInstruktor";
            this.lblInstruktor.Size = new System.Drawing.Size(0, 17);
            this.lblInstruktor.TabIndex = 11;
            // 
            // lblCas
            // 
            this.lblCas.AutoSize = true;
            this.lblCas.ForeColor = System.Drawing.Color.Red;
            this.lblCas.Location = new System.Drawing.Point(412, 174);
            this.lblCas.Name = "lblCas";
            this.lblCas.Size = new System.Drawing.Size(0, 17);
            this.lblCas.TabIndex = 12;
            // 
            // UCDodajTermin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCas);
            this.Controls.Add(this.lblInstruktor);
            this.Controls.Add(this.lblDatumIVreme);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.cmbCas);
            this.Controls.Add(this.cmbInstruktor);
            this.Controls.Add(this.dtpDatumIVreme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCDodajTermin";
            this.Size = new System.Drawing.Size(599, 532);
            this.Load += new System.EventHandler(this.UCDodajTermin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeTermina)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvStavkeTermina;
        private System.Windows.Forms.DateTimePicker dtpDatumIVreme;
        private System.Windows.Forms.ComboBox cmbInstruktor;
        private System.Windows.Forms.ComboBox cmbCas;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnObrisiStavku;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblDatumIVreme;
        private System.Windows.Forms.Label lblInstruktor;
        private System.Windows.Forms.Label lblCas;
    }
}
