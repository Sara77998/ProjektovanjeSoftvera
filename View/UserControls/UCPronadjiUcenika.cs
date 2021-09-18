using System.Windows.Forms;
using View.ClientController;

namespace View.UserControls
{
    public partial class UCPronadjiUcenika : UserControl
    {
        private UcenikController ucenikController;
        public TextBox TxtIme { get => txtIme; }
        public TextBox TxtPrezime { get => txtPrezime; }
        public DataGridView DgvUcenici { get => dgvUcenici; }
        public UCPronadjiUcenika(UcenikController ucenikController)
        {
            this.ucenikController = ucenikController;
            InitializeComponent();
        }

        private void btnPronadjiIme_Click(object sender, System.EventArgs e)
        {
            UcenikController.SearchUcenikIme(this);
            dgvUcenici.Refresh();
        }

        private void btnPronadjiPrezime_Click(object sender, System.EventArgs e)
        {
            UcenikController.SearchUcenikPrezime(this);
            dgvUcenici.Refresh();
        }
    }
}
