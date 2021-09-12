using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using View.Communication;
using View.UserControlHelpers;
using Domain;

namespace View.Dialog
{
    public partial class DodajStavkuRentiranjaDialog : Form
    {
        private int RB;
        public StavkaTermina stavkaTermina { get; set; }
        public DodajStavkuRentiranjaDialog(int RB)
        {
            try
            {
                InitializeComponent();
                this.RB = RB;
                txtRedniBroj.Text = Convert.ToString(RB);
                cmbUcenik.DataSource = Komunikacija.Instance.GetAllUcenik();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            try
            {
                if (!UCHelpers.ComboBoxValidacija(cmbUcenik, lblUcenik))
                {
                    return;
                }
                stavkaTermina = new StavkaTermina
                {
                    RB = RB,
                    Ucenik = (Ucenik)cmbUcenik.SelectedItem
                };
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
