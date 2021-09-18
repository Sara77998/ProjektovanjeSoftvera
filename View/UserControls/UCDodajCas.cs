using System;
using System.Windows.Forms;
using View.ClientController;

namespace View.UserControls
{
    public partial class UCDodajCas : UserControl
    {
        private CasController casController;
        public TextBox TxtStazaLokacija { get => txtStazaLokacija; }
        public ComboBox CmbTezinaCasa { get => cmbTezinaCasa; }
        public TextBox TxtCena { get => txtCena; }


        public Label LblStazaLokacija { get => lblStazaLokacija; }
        public Label LblTezinaCasa { get => lblTezinaCasa; }
        public Label LblCena { get => lblCena; }
        public UCDodajCas(CasController casController)
        {
            InitializeComponent();
            this.casController = casController;
        }

        private void btnSacuvajCas_Click_1(object sender, EventArgs e)
        {
            casController.Save(this);
        }

        private void UCDodajCas_Load_1(object sender, EventArgs e)
        {
            casController.InitUCDodajCas(this);
        }
    }
}
