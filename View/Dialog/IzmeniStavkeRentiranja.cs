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

namespace View.Dialog
{
    public partial class IzmeniStavkeRentiranja : Form
    {
        public Termin Termin{ get; set; }
        public BindingList<StavkaTermina> bindinglista;

        public IzmeniStavkeRentiranja(Termin termin)
        {
            InitializeComponent();
            Termin = termin;
            txtDatum.Text = termin.DatumIVreme.ToString();
            txtInstruktor.Text = termin.Instruktor.Prezime;
            txtInstruktor.Text = termin.CasId.StazaLokacija;
            dgvIzmeniStavke.DataSource = termin.StavkeTermina;
            List<StavkaTermina> stavke = termin.StavkeTermina;
            bindinglista = new BindingList<StavkaTermina>(stavke);

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = dgvIzmeniStavke.SelectedRows.OfType<DataGridViewRow>().Where(row => !row.IsNewRow).ToArray();
                foreach (var row in selectedRows)
                {
                    dgvIzmeniStavke.Rows.Remove(row);
                    //bindinglista.Remove(row);
                }
                dgvIzmeniStavke.ClearSelection();
            }
            catch (Exception)
            {
                MessageBox.Show("morate odabrati red!");
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            StavkaTermina st = new StavkaTermina();

            bindinglista.Add(st);
            
        }

        private void IzmeniStavkeRentiranja_Load(object sender, EventArgs e)
        {
            //dgvIzmeniStavke.DataSource = bindinglista;

            dgvIzmeniStavke.Columns["Ucenik"].Visible = false;
            DataGridViewComboBoxColumn n = new DataGridViewComboBoxColumn();
            
            n.DataSource = Komunikacija.Instance.GetAllUcenik();
            n.HeaderText = "Ucenik";
            n.Name = "Ucenik";
            n.DataPropertyName = "Ucenik";
            n.ValueMember = "Objekat";
            n.DisplayMember = "Prikaz";
            dgvIzmeniStavke.Columns.Add(n);
        }

        private void btnSacuvajIzmene_Click(object sender, EventArgs e)
        {
            Komunikacija.Instance.SaveTermin(Termin);
        }
    }
}
