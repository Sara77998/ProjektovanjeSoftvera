using Domain;
using System;
using System.Windows.Forms;
using View.Communication;
using View.UserControlHelpers;

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

        private void DodajStavkuRentiranjaDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
