﻿
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeTermina)).BeginInit();
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
            this.dgvStavkeTermina.Location = new System.Drawing.Point(35, 216);
            this.dgvStavkeTermina.Name = "dgvStavkeTermina";
            this.dgvStavkeTermina.RowHeadersWidth = 51;
            this.dgvStavkeTermina.RowTemplate.Height = 24;
            this.dgvStavkeTermina.Size = new System.Drawing.Size(399, 150);
            this.dgvStavkeTermina.TabIndex = 4;
            // 
            // dtpDatumIVreme
            // 
            this.dtpDatumIVreme.Location = new System.Drawing.Point(193, 82);
            this.dtpDatumIVreme.Name = "dtpDatumIVreme";
            this.dtpDatumIVreme.Size = new System.Drawing.Size(200, 22);
            this.dtpDatumIVreme.TabIndex = 5;
            // 
            // cmbInstruktor
            // 
            this.cmbInstruktor.FormattingEnabled = true;
            this.cmbInstruktor.Location = new System.Drawing.Point(193, 128);
            this.cmbInstruktor.Name = "cmbInstruktor";
            this.cmbInstruktor.Size = new System.Drawing.Size(200, 24);
            this.cmbInstruktor.TabIndex = 6;
            // 
            // cmbCas
            // 
            this.cmbCas.FormattingEnabled = true;
            this.cmbCas.Location = new System.Drawing.Point(193, 170);
            this.cmbCas.Name = "cmbCas";
            this.cmbCas.Size = new System.Drawing.Size(200, 24);
            this.cmbCas.TabIndex = 7;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(308, 372);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(126, 41);
            this.btnSacuvaj.TabIndex = 8;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // UCDodajTermin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.cmbCas);
            this.Controls.Add(this.cmbInstruktor);
            this.Controls.Add(this.dtpDatumIVreme);
            this.Controls.Add(this.dgvStavkeTermina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCDodajTermin";
            this.Size = new System.Drawing.Size(477, 437);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeTermina)).EndInit();
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
    }
}
