
namespace View.Dialog
{
    partial class IzmeniStavkeRentiranja
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
            this.dgvIzmeniStavke = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtInstruktor = new System.Windows.Forms.TextBox();
            this.txtCas = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnSacuvajIzmene = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzmeniStavke)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIzmeniStavke
            // 
            this.dgvIzmeniStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzmeniStavke.Location = new System.Drawing.Point(52, 214);
            this.dgvIzmeniStavke.Name = "dgvIzmeniStavke";
            this.dgvIzmeniStavke.RowHeadersWidth = 51;
            this.dgvIzmeniStavke.RowTemplate.Height = 24;
            this.dgvIzmeniStavke.Size = new System.Drawing.Size(590, 161);
            this.dgvIzmeniStavke.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Instruktor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cas:";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(178, 57);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(100, 22);
            this.txtDatum.TabIndex = 4;
            // 
            // txtInstruktor
            // 
            this.txtInstruktor.Location = new System.Drawing.Point(178, 93);
            this.txtInstruktor.Name = "txtInstruktor";
            this.txtInstruktor.Size = new System.Drawing.Size(100, 22);
            this.txtInstruktor.TabIndex = 5;
            // 
            // txtCas
            // 
            this.txtCas.Location = new System.Drawing.Point(178, 141);
            this.txtCas.Name = "txtCas";
            this.txtCas.Size = new System.Drawing.Size(100, 22);
            this.txtCas.TabIndex = 6;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(673, 229);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "+";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(673, 309);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 8;
            this.btnObrisi.Text = "-";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // btnSacuvajIzmene
            // 
            this.btnSacuvajIzmene.Location = new System.Drawing.Point(684, 404);
            this.btnSacuvajIzmene.Name = "btnSacuvajIzmene";
            this.btnSacuvajIzmene.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSacuvajIzmene.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvajIzmene.TabIndex = 9;
            this.btnSacuvajIzmene.Text = "Sacuvaj ";
            this.btnSacuvajIzmene.UseVisualStyleBackColor = true;
            // 
            // IzmeniStavkeRentiranja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSacuvajIzmene);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtCas);
            this.Controls.Add(this.txtInstruktor);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIzmeniStavke);
            this.Name = "IzmeniStavkeRentiranja";
            this.Text = "IzmeniStavkeRentiranja";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzmeniStavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIzmeniStavke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtInstruktor;
        private System.Windows.Forms.TextBox txtCas;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnSacuvajIzmene;
    }
}