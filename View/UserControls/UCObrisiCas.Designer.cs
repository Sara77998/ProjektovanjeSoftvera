﻿
namespace View.UserControls
{
    partial class UCObrisiCas
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
            this.dgvSviCasovi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviCasovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSviCasovi
            // 
            this.dgvSviCasovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSviCasovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviCasovi.Location = new System.Drawing.Point(16, 109);
            this.dgvSviCasovi.Name = "dgvSviCasovi";
            this.dgvSviCasovi.RowHeadersWidth = 51;
            this.dgvSviCasovi.RowTemplate.Height = 24;
            this.dgvSviCasovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSviCasovi.Size = new System.Drawing.Size(575, 257);
            this.dgvSviCasovi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista svih casova:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(343, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Obrisi cas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UCObrisiCas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSviCasovi);
            this.Name = "UCObrisiCas";
            this.Size = new System.Drawing.Size(611, 458);
            this.Load += new System.EventHandler(this.UCObrisiCas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviCasovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSviCasovi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
