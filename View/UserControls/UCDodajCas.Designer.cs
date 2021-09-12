
namespace View.UserControls
{
    partial class UCDodajCas
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnSacuvajCas = new System.Windows.Forms.Button();
            this.cmbTezinaCasa = new System.Windows.Forms.ComboBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtStazaLokacija = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStazaLokacija = new System.Windows.Forms.Label();
            this.lblTezinaCasa = new System.Windows.Forms.Label();
            this.lblCena = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "Novi čas";
            // 
            // btnSacuvajCas
            // 
            this.btnSacuvajCas.Location = new System.Drawing.Point(166, 293);
            this.btnSacuvajCas.Name = "btnSacuvajCas";
            this.btnSacuvajCas.Size = new System.Drawing.Size(155, 44);
            this.btnSacuvajCas.TabIndex = 14;
            this.btnSacuvajCas.Text = "Sacuvaj cas";
            this.btnSacuvajCas.UseVisualStyleBackColor = true;
            // 
            // cmbTezinaCasa
            // 
            this.cmbTezinaCasa.FormattingEnabled = true;
            this.cmbTezinaCasa.Location = new System.Drawing.Point(166, 163);
            this.cmbTezinaCasa.Name = "cmbTezinaCasa";
            this.cmbTezinaCasa.Size = new System.Drawing.Size(155, 24);
            this.cmbTezinaCasa.TabIndex = 13;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(166, 227);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(155, 22);
            this.txtCena.TabIndex = 12;
            // 
            // txtStazaLokacija
            // 
            this.txtStazaLokacija.Location = new System.Drawing.Point(166, 97);
            this.txtStazaLokacija.Name = "txtStazaLokacija";
            this.txtStazaLokacija.Size = new System.Drawing.Size(155, 22);
            this.txtStazaLokacija.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Težina časa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Staza (lokacija):";
            // 
            // lblStazaLokacija
            // 
            this.lblStazaLokacija.AutoSize = true;
            this.lblStazaLokacija.ForeColor = System.Drawing.Color.Red;
            this.lblStazaLokacija.Location = new System.Drawing.Point(339, 102);
            this.lblStazaLokacija.Name = "lblStazaLokacija";
            this.lblStazaLokacija.Size = new System.Drawing.Size(0, 17);
            this.lblStazaLokacija.TabIndex = 16;
            // 
            // lblTezinaCasa
            // 
            this.lblTezinaCasa.AutoSize = true;
            this.lblTezinaCasa.ForeColor = System.Drawing.Color.Red;
            this.lblTezinaCasa.Location = new System.Drawing.Point(339, 170);
            this.lblTezinaCasa.Name = "lblTezinaCasa";
            this.lblTezinaCasa.Size = new System.Drawing.Size(0, 17);
            this.lblTezinaCasa.TabIndex = 17;
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.ForeColor = System.Drawing.Color.Red;
            this.lblCena.Location = new System.Drawing.Point(339, 232);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(0, 17);
            this.lblCena.TabIndex = 18;
            // 
            // UCDodajCas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.lblTezinaCasa);
            this.Controls.Add(this.lblStazaLokacija);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSacuvajCas);
            this.Controls.Add(this.cmbTezinaCasa);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtStazaLokacija);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCDodajCas";
            this.Size = new System.Drawing.Size(539, 385);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSacuvajCas;
        private System.Windows.Forms.ComboBox cmbTezinaCasa;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtStazaLokacija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStazaLokacija;
        private System.Windows.Forms.Label lblTezinaCasa;
        private System.Windows.Forms.Label lblCena;
    }
}
