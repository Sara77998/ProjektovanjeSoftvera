using System.Windows.Forms;
using View.ClientController;

namespace View.UserControls
{
    public partial class UCPronadjiCas : UserControl
    {
        private CasController casController;

        public TextBox TxtStazaLokacija { get => txtStazaLokacija; }
        public ComboBox CmbTezina { get => cmbTezina; }
        public DataGridView DgvCas { get => dgvPretragaCasa; }
        public UCPronadjiCas(CasController casController)
        {
            this.casController = casController;
            InitializeComponent();
        }
        private void UCPronadjiCas_Load(object sender, System.EventArgs e)
        {

        }

        private void btnPretraziStaza_Click(object sender, System.EventArgs e)
        {
            casController.SearchCasStazaLokacija(this);
        }

        private void btnPretraziTezina_Click(object sender, System.EventArgs e)
        {
            casController.SearchCasTezina(this);
        }

        
    }
}
