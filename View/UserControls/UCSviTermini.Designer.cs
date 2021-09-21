
namespace View.UserControls
{
    partial class UCSviTermini
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSviTerminiSaUcenicima = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviTerminiSaUcenicima)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSviTerminiSaUcenicima);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 476);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Svi termini sa ucenicima";
            // 
            // dgvSviTerminiSaUcenicima
            // 
            this.dgvSviTerminiSaUcenicima.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSviTerminiSaUcenicima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviTerminiSaUcenicima.Location = new System.Drawing.Point(6, 45);
            this.dgvSviTerminiSaUcenicima.Name = "dgvSviTerminiSaUcenicima";
            this.dgvSviTerminiSaUcenicima.RowHeadersWidth = 51;
            this.dgvSviTerminiSaUcenicima.RowTemplate.Height = 24;
            this.dgvSviTerminiSaUcenicima.Size = new System.Drawing.Size(628, 425);
            this.dgvSviTerminiSaUcenicima.TabIndex = 0;
            // 
            // UCSviTermini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UCSviTermini";
            this.Size = new System.Drawing.Size(671, 543);
            this.Load += new System.EventHandler(this.UCSviTermini_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviTerminiSaUcenicima)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSviTerminiSaUcenicima;
    }
}
