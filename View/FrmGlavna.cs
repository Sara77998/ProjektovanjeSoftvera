using Domain;
using System.Windows.Forms;
using View.ClientController;

namespace View
{
    public partial class FrmGlavna : Form
    {
        private MainController mainController;
        public FrmGlavna(MainController mainController, Instruktor i)
        {
            this.mainController = mainController;
            InitializeComponent();
            lblUlogovaniInstruktor.Text = $"{i.Ime} {i.Prezime}";
        }
        public void SetPanel(UserControl userControl)
        {
            pnlGlavna.Controls.Clear();
            userControl.Parent = pnlGlavna;
            userControl.Dock = DockStyle.Fill;
        }

        private void dodajUčenikaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            mainController.OpenUCDodajUcenika(this);
        }

        private void pronađiUčenikaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            mainController.OpenUCPronadjiUcenika(this);
        }

        private void obrišiUčenikaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            mainController.OpenUCObrisiUcenika(this);
        }

        private void dodajČasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            mainController.OpenUCDodajCas(this);
        }

        private void pronađiČasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            mainController.OpenUCPRonadjiCas(this);
        }

        private void obrišiČasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            mainController.OpenUCObrisiCas(this);
        }

        private void dodajTerminToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            mainController.OpenUCDodajTermin(this);
        }

        private void promeniTerminToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            mainController.OpenUCPromeniTermin(this);
        }

        private void FrmGlavna_Load(object sender, System.EventArgs e)
        {

        }

        private void FrmGlavna_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainController.CloseFrmGlavna();
        }

        private void sviTerminiToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            mainController.OpenUCSviTermini(this);
        }

        private void pnlGlavna_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
