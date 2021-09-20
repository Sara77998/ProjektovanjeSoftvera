
namespace View.UserControls
{
    partial class UCObrisiUcenika
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
            this.dgvSviUcenici = new System.Windows.Forms.DataGridView();
            this.btnObrisiUcenika = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviUcenici)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista svih ucenika:";
            // 
            // dgvSviUcenici
            // 
            this.dgvSviUcenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviUcenici.Location = new System.Drawing.Point(20, 126);
            this.dgvSviUcenici.Name = "dgvSviUcenici";
            this.dgvSviUcenici.RowHeadersWidth = 51;
            this.dgvSviUcenici.RowTemplate.Height = 24;
            this.dgvSviUcenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSviUcenici.Size = new System.Drawing.Size(651, 317);
            this.dgvSviUcenici.TabIndex = 1;
            // 
            // btnObrisiUcenika
            // 
            this.btnObrisiUcenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiUcenika.Location = new System.Drawing.Point(441, 459);
            this.btnObrisiUcenika.Name = "btnObrisiUcenika";
            this.btnObrisiUcenika.Size = new System.Drawing.Size(230, 52);
            this.btnObrisiUcenika.TabIndex = 2;
            this.btnObrisiUcenika.Text = "Obrisi ucenika";
            this.btnObrisiUcenika.UseVisualStyleBackColor = true;
            this.btnObrisiUcenika.Click += new System.EventHandler(this.btnObrisiUcenika_Click);
            // 
            // UCObrisiUcenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnObrisiUcenika);
            this.Controls.Add(this.dgvSviUcenici);
            this.Controls.Add(this.label1);
            this.Name = "UCObrisiUcenika";
            this.Size = new System.Drawing.Size(702, 524);
            this.Load += new System.EventHandler(this.UCObrisiUcenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviUcenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSviUcenici;
        private System.Windows.Forms.Button btnObrisiUcenika;
    }
}
