using System;
using System.Windows.Forms;
using View.ClientController;

namespace View.UserControls
{
    public partial class UCDodajTermin : UserControl
    {
        private TerminController terminController;


        public DateTimePicker DtpDatumIVreme { get => dtpDatumIVreme; }
        public ComboBox CmbInstruktor { get => cmbInstruktor; set { } }
        public ComboBox CmbCas { get => cmbCas; set { } }
        public DataGridView DgvStavkeTermina { get => dgvStavkeTermina; set { } }



        public Label LblDatumIVreme { get => lblDatumIVreme; set { } }
        public Label LblInstruktor { get => lblInstruktor; set { } }
        public Label LblCas { get => lblCas; set { } }


        public UCDodajTermin(TerminController terminController)
        {
            this.terminController = terminController;
            InitializeComponent();
            terminController.InitForm(this);
        }

        private void UCDodajTermin_Load(object sender, EventArgs e)
        {
            //kako ce inicijalno izgledati
            terminController.InitUCDodajTermin(this);
        }


        //private BindingList<StavkaTermina> stavkeTermina = new BindingList<StavkaTermina>();
        //public BindingList<StavkaTermina> StavkeTermina { get => stavkeTermina; set { } }



        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            terminController.AddStavkaTermina();
        }

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {
            terminController.RemoveStavkaTermina();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            terminController.SaveTermin();
        }
    }
}
