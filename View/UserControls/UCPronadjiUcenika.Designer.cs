
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
            this.cbIme = new System.Windows.Forms.CheckBox();
            this.cbPrezime = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPronadjiUcenika = new System.Windows.Forms.Button();
            this.btnPrikaziUcenika = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pronadji učenika";
            // 
            // cbIme
            // 
            this.cbIme.AutoSize = true;
            this.cbIme.Location = new System.Drawing.Point(44, 100);
            this.cbIme.Name = "cbIme";
            this.cbIme.Size = new System.Drawing.Size(52, 21);
            this.cbIme.TabIndex = 1;
            this.cbIme.Text = "Ime";
            this.cbIme.UseVisualStyleBackColor = true;
            // 
            // cbPrezime
            // 
            this.cbPrezime.AutoSize = true;
            this.cbPrezime.Location = new System.Drawing.Point(44, 160);
            this.cbPrezime.Name = "cbPrezime";
            this.cbPrezime.Size = new System.Drawing.Size(81, 21);
            this.cbPrezime.TabIndex = 2;
            this.cbPrezime.Text = "Prezime";
            this.cbPrezime.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(397, 160);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnPronadjiUcenika
            // 
            this.btnPronadjiUcenika.Location = new System.Drawing.Point(353, 138);
            this.btnPronadjiUcenika.Name = "btnPronadjiUcenika";
            this.btnPronadjiUcenika.Size = new System.Drawing.Size(75, 66);
            this.btnPronadjiUcenika.TabIndex = 4;
            this.btnPronadjiUcenika.Text = "Pronadji";
            this.btnPronadjiUcenika.UseVisualStyleBackColor = true;
            // 
            // btnPrikaziUcenika
            // 
            this.btnPrikaziUcenika.Location = new System.Drawing.Point(353, 376);
            this.btnPrikaziUcenika.Name = "btnPrikaziUcenika";
            this.btnPrikaziUcenika.Size = new System.Drawing.Size(75, 64);
            this.btnPrikaziUcenika.TabIndex = 5;
            this.btnPrikaziUcenika.Text = "Prikaži";
            this.btnPrikaziUcenika.UseVisualStyleBackColor = true;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(150, 100);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(182, 22);
            this.txtIme.TabIndex = 6;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(150, 160);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(182, 22);
            this.txtPrezime.TabIndex = 7;
            // 
            // UCPronadjiUcenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnPrikaziUcenika);
            this.Controls.Add(this.btnPronadjiUcenika);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbPrezime);
            this.Controls.Add(this.cbIme);
            this.Controls.Add(this.label1);
            this.Name = "UCPronadjiUcenika";
            this.Size = new System.Drawing.Size(457, 443);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbIme;
        private System.Windows.Forms.CheckBox cbPrezime;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPronadjiUcenika;
        private System.Windows.Forms.Button btnPrikaziUcenika;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
    }
}
