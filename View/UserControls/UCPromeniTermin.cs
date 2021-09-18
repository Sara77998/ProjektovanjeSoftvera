using System.Windows.Forms;
using View.ClientController;

namespace View.UserControls
{
    public partial class UCPromeniTermin : UserControl
    {
        private TerminController terminController;
        public DateTimePicker DtpDatum { get => dtpDatumIVreme; }
        public ComboBox CmbInstruktor { get => cmbInstruktor; }
        public ComboBox CmbCas { get => cmbCas; }
        public DataGridView DgvTermini { get => dgvTermini; }
        public UCPromeniTermin(TerminController terminController)
        {
            this.terminController = terminController;
            InitializeComponent();
            terminController.InitForm(this);
        }

        private void UCPromeniTermin_Load(object sender, System.EventArgs e)
        {
            terminController.InitUCPromeniTermin();
        }

        private void btnPronadjiTerminDatum_Click(object sender, System.EventArgs e)
        {
            terminController.SearchTerminDatum();
        }

        private void btnPronadjiTerminInstruktor_Click(object sender, System.EventArgs e)
        {
            terminController.SearchTerminInstruktor();
        }

        private void btnPronadjiTerminCas_Click(object sender, System.EventArgs e)
        {
            terminController.SearchTerminCas();
        }

        private void btnDodajStavku_Click(object sender, System.EventArgs e)
        {
            terminController.AddStavkaTermina();
        }

        private void btnObrisiStavku_Click(object sender, System.EventArgs e)
        {
            terminController.RemoveStavkaTermina();
        }
        private void btnIzmeni_Click(object sender, System.EventArgs e)
        {
            terminController.UpdateTermin();
        }
    }
}
