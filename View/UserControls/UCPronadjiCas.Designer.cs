
namespace View.UserControls
{
    partial class UCPronadjiCas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbStazaLokacija = new System.Windows.Forms.CheckBox();
            this.cbTezinaCasa = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.btnPronadjiCas = new System.Windows.Forms.Button();
            this.txtStazaLokacija = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.cmbTezina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(386, 182);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbStazaLokacija
            // 
            this.cbStazaLokacija.AutoSize = true;
            this.cbStazaLokacija.Location = new System.Drawing.Point(41, 66);
            this.cbStazaLokacija.Name = "cbStazaLokacija";
            this.cbStazaLokacija.Size = new System.Drawing.Size(127, 21);
            this.cbStazaLokacija.TabIndex = 1;
            this.cbStazaLokacija.Text = "Staza (lokacija)";
            this.cbStazaLokacija.UseVisualStyleBackColor = true;
            // 
            // cbTezinaCasa
            // 
            this.cbTezinaCasa.AutoSize = true;
            this.cbTezinaCasa.Location = new System.Drawing.Point(41, 113);
            this.cbTezinaCasa.Name = "cbTezinaCasa";
            this.cbTezinaCasa.Size = new System.Drawing.Size(77, 21);
            this.cbTezinaCasa.TabIndex = 2;
            this.cbTezinaCasa.Text = "Težina:";
            this.cbTezinaCasa.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(41, 158);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(67, 21);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Cena:";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // btnPronadjiCas
            // 
            this.btnPronadjiCas.Location = new System.Drawing.Point(352, 113);
            this.btnPronadjiCas.Name = "btnPronadjiCas";
            this.btnPronadjiCas.Size = new System.Drawing.Size(75, 68);
            this.btnPronadjiCas.TabIndex = 4;
            this.btnPronadjiCas.Text = "Pronadji";
            this.btnPronadjiCas.UseVisualStyleBackColor = true;
            // 
            // txtStazaLokacija
            // 
            this.txtStazaLokacija.Location = new System.Drawing.Point(172, 66);
            this.txtStazaLokacija.Name = "txtStazaLokacija";
            this.txtStazaLokacija.Size = new System.Drawing.Size(145, 22);
            this.txtStazaLokacija.TabIndex = 5;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(172, 156);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(145, 22);
            this.txtCena.TabIndex = 6;
            // 
            // cmbTezina
            // 
            this.cmbTezina.FormattingEnabled = true;
            this.cmbTezina.Location = new System.Drawing.Point(172, 111);
            this.cmbTezina.Name = "cmbTezina";
            this.cmbTezina.Size = new System.Drawing.Size(145, 24);
            this.cmbTezina.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pretraga časa";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(352, 387);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 73);
            this.btnPrikazi.TabIndex = 9;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            // 
            // UCPronadjiCas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTezina);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtStazaLokacija);
            this.Controls.Add(this.btnPronadjiCas);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.cbTezinaCasa);
            this.Controls.Add(this.cbStazaLokacija);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UCPronadjiCas";
            this.Size = new System.Drawing.Size(464, 463);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox cbStazaLokacija;
        private System.Windows.Forms.CheckBox cbTezinaCasa;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button btnPronadjiCas;
        private System.Windows.Forms.TextBox txtStazaLokacija;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.ComboBox cmbTezina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrikazi;
    }
}
