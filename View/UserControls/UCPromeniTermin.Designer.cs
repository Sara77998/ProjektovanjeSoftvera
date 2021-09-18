
namespace View.UserControls
{
    partial class UCPromeniTermin
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
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.cmbCas = new System.Windows.Forms.ComboBox();
            this.cmbInstruktor = new System.Windows.Forms.ComboBox();
            this.dtpDatumIVreme = new System.Windows.Forms.DateTimePicker();
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPronadjiTerminDatum = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPronadjiTerminInstruktor = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPronadjiTerminCas = new System.Windows.Forms.Button();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.btnObrisiStavku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(429, 558);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(126, 41);
            this.btnIzmeni.TabIndex = 17;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // cmbCas
            // 
            this.cmbCas.FormattingEnabled = true;
            this.cmbCas.Location = new System.Drawing.Point(184, 37);
            this.cmbCas.Name = "cmbCas";
            this.cmbCas.Size = new System.Drawing.Size(200, 24);
            this.cmbCas.TabIndex = 16;
            // 
            // cmbInstruktor
            // 
            this.cmbInstruktor.FormattingEnabled = true;
            this.cmbInstruktor.Location = new System.Drawing.Point(184, 33);
            this.cmbInstruktor.Name = "cmbInstruktor";
            this.cmbInstruktor.Size = new System.Drawing.Size(200, 24);
            this.cmbInstruktor.TabIndex = 15;
            // 
            // dtpDatumIVreme
            // 
            this.dtpDatumIVreme.Location = new System.Drawing.Point(184, 33);
            this.dtpDatumIVreme.Name = "dtpDatumIVreme";
            this.dtpDatumIVreme.Size = new System.Drawing.Size(200, 22);
            this.dtpDatumIVreme.TabIndex = 14;
            // 
            // dgvTermini
            // 
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Location = new System.Drawing.Point(25, 350);
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.RowHeadersWidth = 51;
            this.dgvTermini.RowTemplate.Height = 24;
            this.dgvTermini.Size = new System.Drawing.Size(519, 202);
            this.dgvTermini.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Instruktor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Datum i vreme:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Promeni termin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPronadjiTerminDatum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpDatumIVreme);
            this.groupBox1.Location = new System.Drawing.Point(25, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 74);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga po datumu";
            // 
            // btnPronadjiTerminDatum
            // 
            this.btnPronadjiTerminDatum.Location = new System.Drawing.Point(427, 22);
            this.btnPronadjiTerminDatum.Name = "btnPronadjiTerminDatum";
            this.btnPronadjiTerminDatum.Size = new System.Drawing.Size(75, 23);
            this.btnPronadjiTerminDatum.TabIndex = 15;
            this.btnPronadjiTerminDatum.Text = "Pronadji";
            this.btnPronadjiTerminDatum.UseVisualStyleBackColor = true;
            this.btnPronadjiTerminDatum.Click += new System.EventHandler(this.btnPronadjiTerminDatum_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPronadjiTerminInstruktor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbInstruktor);
            this.groupBox2.Location = new System.Drawing.Point(25, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 79);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga po instruktoru";
            // 
            // btnPronadjiTerminInstruktor
            // 
            this.btnPronadjiTerminInstruktor.Location = new System.Drawing.Point(427, 33);
            this.btnPronadjiTerminInstruktor.Name = "btnPronadjiTerminInstruktor";
            this.btnPronadjiTerminInstruktor.Size = new System.Drawing.Size(75, 23);
            this.btnPronadjiTerminInstruktor.TabIndex = 16;
            this.btnPronadjiTerminInstruktor.Text = "Pronadji";
            this.btnPronadjiTerminInstruktor.UseVisualStyleBackColor = true;
            this.btnPronadjiTerminInstruktor.Click += new System.EventHandler(this.btnPronadjiTerminInstruktor_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPronadjiTerminCas);
            this.groupBox3.Controls.Add(this.cmbCas);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(25, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(519, 77);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pretraga po casu";
            // 
            // btnPronadjiTerminCas
            // 
            this.btnPronadjiTerminCas.Location = new System.Drawing.Point(427, 34);
            this.btnPronadjiTerminCas.Name = "btnPronadjiTerminCas";
            this.btnPronadjiTerminCas.Size = new System.Drawing.Size(75, 23);
            this.btnPronadjiTerminCas.TabIndex = 17;
            this.btnPronadjiTerminCas.Text = "Pronadji";
            this.btnPronadjiTerminCas.UseVisualStyleBackColor = true;
            this.btnPronadjiTerminCas.Click += new System.EventHandler(this.btnPronadjiTerminCas_Click);
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Location = new System.Drawing.Point(27, 569);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(75, 23);
            this.btnDodajStavku.TabIndex = 20;
            this.btnDodajStavku.Text = "+";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.Location = new System.Drawing.Point(124, 569);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiStavku.TabIndex = 21;
            this.btnObrisiStavku.Text = "-";
            this.btnObrisiStavku.UseVisualStyleBackColor = true;
            this.btnObrisiStavku.Click += new System.EventHandler(this.btnObrisiStavku_Click);
            // 
            // UCPromeniTermin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnObrisiStavku);
            this.Controls.Add(this.btnDodajStavku);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.dgvTermini);
            this.Controls.Add(this.label1);
            this.Name = "UCPromeniTermin";
            this.Size = new System.Drawing.Size(574, 602);
            this.Load += new System.EventHandler(this.UCPromeniTermin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.ComboBox cmbCas;
        private System.Windows.Forms.ComboBox cmbInstruktor;
        private System.Windows.Forms.DateTimePicker dtpDatumIVreme;
        private System.Windows.Forms.DataGridView dgvTermini;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPronadjiTerminDatum;
        private System.Windows.Forms.Button btnPronadjiTerminInstruktor;
        private System.Windows.Forms.Button btnPronadjiTerminCas;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.Button btnObrisiStavku;
    }
}
