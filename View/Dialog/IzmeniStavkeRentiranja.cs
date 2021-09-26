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
using View.ClientController;
using View.Communication;

namespace View.Dialog
{
    public partial class IzmeniStavkeRentiranja : Form
    {
        public Termin Termin{ get; set; }
        public BindingList<StavkaTermina> bindinglista { get; set; }
        
        public IzmeniStavkeRentiranja(Termin termin)
        {
            InitializeComponent();
            Termin = termin;
            txtDatum.Text = termin.DatumIVreme.ToString();
            txtInstruktor.Text = termin.Instruktor.Ime +" "+ termin.Instruktor.Prezime;
            txtCas.Text = termin.CasId.StazaLokacija;
            cmbInstruktorIzmena.DataSource = Komunikacija.Instance.GetAllInstrukruktor();
            cmbCasIzmena.DataSource = Komunikacija.Instance.GetAllCas();
            //dgvIzmeniStavke.DataSource = Komunikacija.Instance.GetAllStavkaTermina().Where(i => i.TerminId.TerminId == termin.TerminId).ToList();



            List<StavkaTermina> stavke = new List<StavkaTermina>();
            //stavke = termin.StavkeTermina;
            stavke = Komunikacija.Instance.GetAllStavkaTermina().Where(i => i.TerminId.TerminId == termin.TerminId).ToList();
          

            bindinglista = new BindingList<StavkaTermina>(stavke);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow red = dgvIzmeniStavke.SelectedRows[0];
                StavkaTermina st = (StavkaTermina)red.DataBoundItem;
                bindinglista.Remove(st);
                //for (int i = 0; i < bindinglista.Count; i++)
                //{
                //    bindinglista[i].RB = i + 1;
                //}

            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("morate odabrati red!");
            }

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            
            int broj = bindinglista.Count + 1;
            DodajStavkuRentiranjaDialog dialog = new DodajStavkuRentiranjaDialog(broj);
            dialog.ShowDialog();
            Ucenik u = dialog.stavkaTermina.Ucenik;
            if (dialog.stavkaTermina != null && bindinglista.All(s => s.Ucenik.UcenikId != u.UcenikId))
            {
                bindinglista.Add(dialog.stavkaTermina);
            }
            else
            {
                MessageBox.Show("Izabrani ucenik vec postoji u ovom treminu!");
            }

        }

        private void IzmeniStavkeRentiranja_Load(object sender, EventArgs e)
        {
            dgvIzmeniStavke.DataSource = bindinglista;

            dgvIzmeniStavke.Columns["terminid"].Visible = false;
            dgvIzmeniStavke.Columns["RB"].Visible = false;
            //dgvIzmeniStavke.Columns["Ucenik"].Visible = false;
            //DataGridViewComboBoxColumn n = new DataGridViewComboBoxColumn();
            //n.DataSource = Komunikacija.Instance.GetAllUcenik();
            //n.HeaderText = "Ucenik";
            //n.Name = "Ucenik";
            //n.DataPropertyName = "Ucenik";
            //n.ValueMember = "Objekat";
            //n.DisplayMember = "Prikaz";
            //dgvIzmeniStavke.Columns.Add(n);
        }

        private void btnSacuvajIzmene_Click(object sender, EventArgs e)
        {
            Instruktor instruktor = (Instruktor)cmbInstruktorIzmena.SelectedItem;
            Cas cas = (Cas)cmbCasIzmena.SelectedItem;
            Termin t = new Termin
            {
                TerminId = Termin.TerminId,
                DatumIVreme = Termin.DatumIVreme,
                Instruktor = instruktor,
                CasId = cas,
                StavkeTermina = bindinglista.ToList(),
                WhereCondition = "terminid=",
                WhereValue = $"{Termin.TerminId}",
                UpdateText = $"instruktor={instruktor.InstruktorId},casid={cas.CasId}"
            };
            Komunikacija.Instance.UpdateTermin(t);
            MessageBox.Show("Sacuvane izmene!");
        }
    }
}
