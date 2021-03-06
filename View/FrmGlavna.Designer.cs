
namespace View
{
    partial class FrmGlavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGlavna));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.učenikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajUčenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pronađiUčenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrišiUčenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.časToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajČasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pronađiČasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrišiČasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajTerminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promeniTerminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sviTerminiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlGlavna = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUlogovaniInstruktor = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlGlavna.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.učenikToolStripMenuItem,
            this.časToolStripMenuItem,
            this.terminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // učenikToolStripMenuItem
            // 
            this.učenikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajUčenikaToolStripMenuItem,
            this.pronađiUčenikaToolStripMenuItem,
            this.obrišiUčenikaToolStripMenuItem});
            this.učenikToolStripMenuItem.Name = "učenikToolStripMenuItem";
            this.učenikToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.učenikToolStripMenuItem.Text = "Učenik";
            // 
            // dodajUčenikaToolStripMenuItem
            // 
            this.dodajUčenikaToolStripMenuItem.Name = "dodajUčenikaToolStripMenuItem";
            this.dodajUčenikaToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.dodajUčenikaToolStripMenuItem.Text = "Dodaj učenika";
            this.dodajUčenikaToolStripMenuItem.Click += new System.EventHandler(this.dodajUčenikaToolStripMenuItem_Click);
            // 
            // pronađiUčenikaToolStripMenuItem
            // 
            this.pronađiUčenikaToolStripMenuItem.Name = "pronađiUčenikaToolStripMenuItem";
            this.pronađiUčenikaToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.pronađiUčenikaToolStripMenuItem.Text = "Pronađi učenika";
            this.pronađiUčenikaToolStripMenuItem.Click += new System.EventHandler(this.pronađiUčenikaToolStripMenuItem_Click);
            // 
            // obrišiUčenikaToolStripMenuItem
            // 
            this.obrišiUčenikaToolStripMenuItem.Name = "obrišiUčenikaToolStripMenuItem";
            this.obrišiUčenikaToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.obrišiUčenikaToolStripMenuItem.Text = "Obriši učenika";
            this.obrišiUčenikaToolStripMenuItem.Click += new System.EventHandler(this.obrišiUčenikaToolStripMenuItem_Click);
            // 
            // časToolStripMenuItem
            // 
            this.časToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajČasToolStripMenuItem,
            this.pronađiČasToolStripMenuItem,
            this.obrišiČasToolStripMenuItem});
            this.časToolStripMenuItem.Name = "časToolStripMenuItem";
            this.časToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.časToolStripMenuItem.Text = "Čas";
            // 
            // dodajČasToolStripMenuItem
            // 
            this.dodajČasToolStripMenuItem.Name = "dodajČasToolStripMenuItem";
            this.dodajČasToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.dodajČasToolStripMenuItem.Text = "Dodaj čas";
            this.dodajČasToolStripMenuItem.Click += new System.EventHandler(this.dodajČasToolStripMenuItem_Click);
            // 
            // pronađiČasToolStripMenuItem
            // 
            this.pronađiČasToolStripMenuItem.Name = "pronađiČasToolStripMenuItem";
            this.pronađiČasToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.pronađiČasToolStripMenuItem.Text = "Pronađi čas";
            this.pronađiČasToolStripMenuItem.Click += new System.EventHandler(this.pronađiČasToolStripMenuItem_Click);
            // 
            // obrišiČasToolStripMenuItem
            // 
            this.obrišiČasToolStripMenuItem.Name = "obrišiČasToolStripMenuItem";
            this.obrišiČasToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.obrišiČasToolStripMenuItem.Text = "Obriši čas";
            this.obrišiČasToolStripMenuItem.Click += new System.EventHandler(this.obrišiČasToolStripMenuItem_Click);
            // 
            // terminToolStripMenuItem
            // 
            this.terminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajTerminToolStripMenuItem,
            this.promeniTerminToolStripMenuItem,
            this.sviTerminiToolStripMenuItem});
            this.terminToolStripMenuItem.Name = "terminToolStripMenuItem";
            this.terminToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.terminToolStripMenuItem.Text = "Termin";
            // 
            // dodajTerminToolStripMenuItem
            // 
            this.dodajTerminToolStripMenuItem.Name = "dodajTerminToolStripMenuItem";
            this.dodajTerminToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.dodajTerminToolStripMenuItem.Text = "Dodaj termin";
            this.dodajTerminToolStripMenuItem.Click += new System.EventHandler(this.dodajTerminToolStripMenuItem_Click);
            // 
            // promeniTerminToolStripMenuItem
            // 
            this.promeniTerminToolStripMenuItem.Name = "promeniTerminToolStripMenuItem";
            this.promeniTerminToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.promeniTerminToolStripMenuItem.Text = "Promeni termin";
            this.promeniTerminToolStripMenuItem.Click += new System.EventHandler(this.promeniTerminToolStripMenuItem_Click);
            // 
            // sviTerminiToolStripMenuItem
            // 
            this.sviTerminiToolStripMenuItem.Name = "sviTerminiToolStripMenuItem";
            this.sviTerminiToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.sviTerminiToolStripMenuItem.Text = "Svi termini";
            this.sviTerminiToolStripMenuItem.Click += new System.EventHandler(this.sviTerminiToolStripMenuItem_Click);
            // 
            // pnlGlavna
            // 
            this.pnlGlavna.Controls.Add(this.panel1);
            this.pnlGlavna.Controls.Add(this.label1);
            this.pnlGlavna.Controls.Add(this.label2);
            this.pnlGlavna.Controls.Add(this.lblUlogovaniInstruktor);
            this.pnlGlavna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGlavna.Location = new System.Drawing.Point(0, 28);
            this.pnlGlavna.Name = "pnlGlavna";
            this.pnlGlavna.Size = new System.Drawing.Size(706, 575);
            this.pnlGlavna.TabIndex = 1;
            this.pnlGlavna.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGlavna_Paint);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(17, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 274);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ulogovani instruktor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Plan skijalista:";
            // 
            // lblUlogovaniInstruktor
            // 
            this.lblUlogovaniInstruktor.AutoSize = true;
            this.lblUlogovaniInstruktor.Location = new System.Drawing.Point(232, 529);
            this.lblUlogovaniInstruktor.Name = "lblUlogovaniInstruktor";
            this.lblUlogovaniInstruktor.Size = new System.Drawing.Size(16, 17);
            this.lblUlogovaniInstruktor.TabIndex = 0;
            this.lblUlogovaniInstruktor.Text = "//";
            // 
            // FrmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 603);
            this.Controls.Add(this.pnlGlavna);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmGlavna";
            this.Text = "Glavna";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGlavna_FormClosed);
            this.Load += new System.EventHandler(this.FrmGlavna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlGlavna.ResumeLayout(false);
            this.pnlGlavna.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnlGlavna;
        private System.Windows.Forms.ToolStripMenuItem časToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajČasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pronađiČasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrišiČasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem učenikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajUčenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pronađiUčenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrišiUčenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajTerminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promeniTerminToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUlogovaniInstruktor;
        private System.Windows.Forms.ToolStripMenuItem sviTerminiToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}