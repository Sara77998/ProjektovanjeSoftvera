
namespace View.UserControls
{
    partial class UCPronadjiUcenika
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
            this.dgvUcenici = new System.Windows.Forms.DataGridView();
            this.btnPronadjiIme = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPronadjiPrezime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcenici)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pronadji učenika";
            // 
            // dgvUcenici
            // 
            this.dgvUcenici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUcenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUcenici.ColumnHeadersVisible = false;
            this.dgvUcenici.EnableHeadersVisualStyles = false;
            this.dgvUcenici.Location = new System.Drawing.Point(27, 343);
            this.dgvUcenici.Name = "dgvUcenici";
            this.dgvUcenici.RowHeadersWidth = 51;
            this.dgvUcenici.RowTemplate.Height = 24;
            this.dgvUcenici.Size = new System.Drawing.Size(642, 160);
            this.dgvUcenici.TabIndex = 3;
            // 
            // btnPronadjiIme
            // 
            this.btnPronadjiIme.Location = new System.Drawing.Point(541, 21);
            this.btnPronadjiIme.Name = "btnPronadjiIme";
            this.btnPronadjiIme.Size = new System.Drawing.Size(75, 66);
            this.btnPronadjiIme.TabIndex = 4;
            this.btnPronadjiIme.Text = "Pronadji";
            this.btnPronadjiIme.UseVisualStyleBackColor = true;
            this.btnPronadjiIme.Click += new System.EventHandler(this.btnPronadjiIme_Click);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(234, 43);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(182, 22);
            this.txtIme.TabIndex = 6;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(234, 43);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(182, 22);
            this.txtPrezime.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnPronadjiIme);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Location = new System.Drawing.Point(27, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga po imenu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ime:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnPronadjiPrezime);
            this.groupBox2.Controls.Add(this.txtPrezime);
            this.groupBox2.Location = new System.Drawing.Point(27, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga po prezimenu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prezime:";
            // 
            // btnPronadjiPrezime
            // 
            this.btnPronadjiPrezime.Location = new System.Drawing.Point(541, 21);
            this.btnPronadjiPrezime.Name = "btnPronadjiPrezime";
            this.btnPronadjiPrezime.Size = new System.Drawing.Size(75, 66);
            this.btnPronadjiPrezime.TabIndex = 4;
            this.btnPronadjiPrezime.Text = "Pronadji";
            this.btnPronadjiPrezime.UseVisualStyleBackColor = true;
            this.btnPronadjiPrezime.Click += new System.EventHandler(this.btnPronadjiPrezime_Click);
            // 
            // UCPronadjiUcenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvUcenici);
            this.Controls.Add(this.label1);
            this.Name = "UCPronadjiUcenika";
            this.Size = new System.Drawing.Size(701, 517);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcenici)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUcenici;
        private System.Windows.Forms.Button btnPronadjiIme;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPronadjiPrezime;
    }
}
