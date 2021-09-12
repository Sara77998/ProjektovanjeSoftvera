
namespace View.Dialog
{
    partial class DodajStavkuRentiranjaDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRedniBroj = new System.Windows.Forms.TextBox();
            this.cmbUcenik = new System.Windows.Forms.ComboBox();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.lblUcenik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Redni broj:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ucenik:";
            // 
            // txtRedniBroj
            // 
            this.txtRedniBroj.Enabled = false;
            this.txtRedniBroj.Location = new System.Drawing.Point(135, 61);
            this.txtRedniBroj.Name = "txtRedniBroj";
            this.txtRedniBroj.Size = new System.Drawing.Size(121, 22);
            this.txtRedniBroj.TabIndex = 2;
            // 
            // cmbUcenik
            // 
            this.cmbUcenik.FormattingEnabled = true;
            this.cmbUcenik.Location = new System.Drawing.Point(135, 118);
            this.cmbUcenik.Name = "cmbUcenik";
            this.cmbUcenik.Size = new System.Drawing.Size(220, 24);
            this.cmbUcenik.TabIndex = 3;
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Location = new System.Drawing.Point(135, 199);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(220, 38);
            this.btnDodajStavku.TabIndex = 4;
            this.btnDodajStavku.Text = "Dodaj u termin";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // lblUcenik
            // 
            this.lblUcenik.AutoSize = true;
            this.lblUcenik.ForeColor = System.Drawing.Color.Red;
            this.lblUcenik.Location = new System.Drawing.Point(372, 121);
            this.lblUcenik.Name = "lblUcenik";
            this.lblUcenik.Size = new System.Drawing.Size(0, 17);
            this.lblUcenik.TabIndex = 5;
            // 
            // DodajStavkuRentiranjaDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 269);
            this.Controls.Add(this.lblUcenik);
            this.Controls.Add(this.btnDodajStavku);
            this.Controls.Add(this.cmbUcenik);
            this.Controls.Add(this.txtRedniBroj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodajStavkuRentiranjaDialog";
            this.Text = "DodajStavkuRentiranjaDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRedniBroj;
        private System.Windows.Forms.ComboBox cmbUcenik;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.Label lblUcenik;
    }
}