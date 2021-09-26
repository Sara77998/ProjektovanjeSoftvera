
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
            this.dgvPretragaCasa = new System.Windows.Forms.DataGridView();
            this.btnPretraziTezina = new System.Windows.Forms.Button();
            this.txtStazaLokacija = new System.Windows.Forms.TextBox();
            this.cmbTezina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretraziStaza = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretragaCasa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPretragaCasa
            // 
            this.dgvPretragaCasa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPretragaCasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPretragaCasa.Location = new System.Drawing.Point(24, 319);
            this.dgvPretragaCasa.Name = "dgvPretragaCasa";
            this.dgvPretragaCasa.RowHeadersWidth = 51;
            this.dgvPretragaCasa.RowTemplate.Height = 24;
            this.dgvPretragaCasa.Size = new System.Drawing.Size(639, 182);
            this.dgvPretragaCasa.TabIndex = 0;
            // 
            // btnPretraziTezina
            // 
            this.btnPretraziTezina.Location = new System.Drawing.Point(564, 21);
            this.btnPretraziTezina.Name = "btnPretraziTezina";
            this.btnPretraziTezina.Size = new System.Drawing.Size(75, 68);
            this.btnPretraziTezina.TabIndex = 4;
            this.btnPretraziTezina.Text = "Pronadji";
            this.btnPretraziTezina.UseVisualStyleBackColor = true;
            this.btnPretraziTezina.Click += new System.EventHandler(this.btnPretraziTezina_Click);
            // 
            // txtStazaLokacija
            // 
            this.txtStazaLokacija.Location = new System.Drawing.Point(173, 46);
            this.txtStazaLokacija.Name = "txtStazaLokacija";
            this.txtStazaLokacija.Size = new System.Drawing.Size(255, 22);
            this.txtStazaLokacija.TabIndex = 5;
            // 
            // cmbTezina
            // 
            this.cmbTezina.FormattingEnabled = true;
            this.cmbTezina.Location = new System.Drawing.Point(173, 49);
            this.cmbTezina.Name = "cmbTezina";
            this.cmbTezina.Size = new System.Drawing.Size(255, 24);
            this.cmbTezina.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pretraga časa";
            // 
            // btnPretraziStaza
            // 
            this.btnPretraziStaza.Location = new System.Drawing.Point(564, 21);
            this.btnPretraziStaza.Name = "btnPretraziStaza";
            this.btnPretraziStaza.Size = new System.Drawing.Size(75, 73);
            this.btnPretraziStaza.TabIndex = 9;
            this.btnPretraziStaza.Text = "Pretrazi";
            this.btnPretraziStaza.UseVisualStyleBackColor = true;
            this.btnPretraziStaza.Click += new System.EventHandler(this.btnPretraziStaza_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnPretraziStaza);
            this.groupBox1.Controls.Add(this.txtStazaLokacija);
            this.groupBox1.Location = new System.Drawing.Point(24, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga po lokaciji";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Staza - lokacija:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnPretraziTezina);
            this.groupBox2.Controls.Add(this.cmbTezina);
            this.groupBox2.Location = new System.Drawing.Point(24, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga po tezini";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tezina:";
            // 
            // UCPronadjiCas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPretragaCasa);
            this.Name = "UCPronadjiCas";
            this.Size = new System.Drawing.Size(687, 548);
            this.Load += new System.EventHandler(this.UCPronadjiCas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretragaCasa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPretragaCasa;
        private System.Windows.Forms.Button btnPretraziTezina;
        private System.Windows.Forms.TextBox txtStazaLokacija;
        private System.Windows.Forms.ComboBox cmbTezina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretraziStaza;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}
