
namespace Server
{
    partial class FrmServer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPregledTermina = new System.Windows.Forms.DataGridView();
            this.btnPokreniServer = new System.Windows.Forms.Button();
            this.btnZaustaviServer = new System.Windows.Forms.Button();
            this.lblStanjeServera = new System.Windows.Forms.Label();
            this.lblVreme = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledTermina)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPregledTermina);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 350);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregled termina";
            // 
            // dgvPregledTermina
            // 
            this.dgvPregledTermina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledTermina.Location = new System.Drawing.Point(6, 21);
            this.dgvPregledTermina.Name = "dgvPregledTermina";
            this.dgvPregledTermina.RowHeadersWidth = 51;
            this.dgvPregledTermina.RowTemplate.Height = 24;
            this.dgvPregledTermina.Size = new System.Drawing.Size(764, 323);
            this.dgvPregledTermina.TabIndex = 0;
            // 
            // btnPokreniServer
            // 
            this.btnPokreniServer.Location = new System.Drawing.Point(51, 22);
            this.btnPokreniServer.Name = "btnPokreniServer";
            this.btnPokreniServer.Size = new System.Drawing.Size(150, 50);
            this.btnPokreniServer.TabIndex = 1;
            this.btnPokreniServer.Text = "Pokreni server";
            this.btnPokreniServer.UseVisualStyleBackColor = true;
            this.btnPokreniServer.Click += new System.EventHandler(this.btnPokreniServer_Click);
            // 
            // btnZaustaviServer
            // 
            this.btnZaustaviServer.Location = new System.Drawing.Point(236, 22);
            this.btnZaustaviServer.Name = "btnZaustaviServer";
            this.btnZaustaviServer.Size = new System.Drawing.Size(148, 50);
            this.btnZaustaviServer.TabIndex = 2;
            this.btnZaustaviServer.Text = "Zaustavi server";
            this.btnZaustaviServer.UseVisualStyleBackColor = true;
            this.btnZaustaviServer.Click += new System.EventHandler(this.btnZaustaviServer_Click);
            // 
            // lblStanjeServera
            // 
            this.lblStanjeServera.AutoSize = true;
            this.lblStanjeServera.Location = new System.Drawing.Point(409, 39);
            this.lblStanjeServera.Name = "lblStanjeServera";
            this.lblStanjeServera.Size = new System.Drawing.Size(16, 17);
            this.lblStanjeServera.TabIndex = 3;
            this.lblStanjeServera.Text = "//";
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.Location = new System.Drawing.Point(581, 39);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(0, 17);
            this.lblVreme.TabIndex = 4;
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVreme);
            this.Controls.Add(this.lblStanjeServera);
            this.Controls.Add(this.btnZaustaviServer);
            this.Controls.Add(this.btnPokreniServer);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmServer";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmServer_FormClosed);
            this.Load += new System.EventHandler(this.FrmServer_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledTermina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPregledTermina;
        private System.Windows.Forms.Button btnPokreniServer;
        private System.Windows.Forms.Button btnZaustaviServer;
        private System.Windows.Forms.Label lblStanjeServera;
        private System.Windows.Forms.Label lblVreme;
    }
}

