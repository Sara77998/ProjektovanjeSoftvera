using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using View.Communication;
using View.Dialog;
using View.UserControlHelpers;
using View.UserControls;

namespace View.ClientController

{
    public class TerminController
    {
        private UCDodajTermin uCDodajTermin;
        private UCPromeniTermin uCPromeniTermin;
        private UCSviTermini uCSviTermini;
        private BindingList<StavkaTermina> stavkeTermina = new BindingList<StavkaTermina>();
        private List<Termin> termini = new List<Termin>();
        internal void InitForm(UCDodajTermin uCDodajTermin)
        {
            try
            {
                this.uCDodajTermin = uCDodajTermin;
                uCDodajTermin.DgvStavkeTermina.DataSource = stavkeTermina;
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        internal void InitUCSviTermini(UCSviTermini uCSviTermini)
        {

            try
            {
                uCSviTermini.DgvSviTerminiSaUcenicima.DataSource = Komunikacija.Instance.GetAllStavkaTermina();
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        internal void SearchTerminDatum()
        {
            try
            {
                Termin t = new Termin
                {
                    DatumIVreme = uCPromeniTermin.DtpDatum.Value,
                    WhereCondition = "t.Datum=",
                    WhereValue = uCPromeniTermin.DtpDatum.Value.ToString("MM/dd/yyyy")
                };
                termini = Komunikacija.Instance.SearchTermin(t);
                //uCPromeniTermin.DgvTermini.DataSource = termini;
                //uCUpdateRentiranje.CbPretraga.DataSource = Communication.Communication.Instance.SearchRentiranjeDatum(r);
                MessageBox.Show("Postoji termin za taj dan");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        internal void SearchTerminInstruktor()
        {
            try
            {
                Instruktor i = (Instruktor)uCPromeniTermin.CmbInstruktor.SelectedItem;
                Termin t = new Termin
                {
                    Instruktor = new Instruktor
                    {
                        InstruktorId = i.InstruktorId
                    },
                    WhereCondition = "i.Prezime=",
                    WhereValue = i.Prezime

                };
                termini = Komunikacija.Instance.SearchTermin(t);
                uCPromeniTermin.DgvTermini.DataSource = termini;
                MessageBox.Show("Postoji termin koji vodi trazeni instruktor");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        internal void SearchTerminCas()
        {
            try
            {
                Cas c = (Cas)uCPromeniTermin.CmbCas.SelectedItem;
                Termin t = new Termin
                {
                    CasId = new Cas
                    {
                        CasId = c.CasId
                    },
                    
                    WhereCondition = "c.stazalokacija=",
                    WhereValue = c.StazaLokacija

                };
                termini = Komunikacija.Instance.SearchTermin(t);
                uCPromeniTermin.DgvTermini.DataSource = termini;               
                MessageBox.Show("Postoji termin koji na zadatoj stazi");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        internal void InitUCPromeniTermin()
        {
            try
            {
                uCPromeniTermin.CmbInstruktor.DataSource = Komunikacija.Instance.GetAllInstrukruktor();
                uCPromeniTermin.CmbCas.DataSource = Komunikacija.Instance.GetAllCas();              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        internal void InitUCDodajTermin(UCDodajTermin uCDodajTermin)
        {
            try
            {
                uCDodajTermin.CmbInstruktor.DataSource = Komunikacija.Instance.GetAllInstrukruktor();
                uCDodajTermin.CmbCas.DataSource = Komunikacija.Instance.GetAllCas();
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        internal void UpdateTermin()
        {
            DataGridViewRow red = uCPromeniTermin.DgvTermini.SelectedRows[0];
            Termin t = (Termin)red.DataBoundItem;
            IzmeniStavkeRentiranja dialog2  = new IzmeniStavkeRentiranja(t);
            dialog2.ShowDialog();

            
        }

        internal void AddStavkaTermina()
        {
            int broj = stavkeTermina.Count + 1;
            DodajStavkuRentiranjaDialog dialog = new DodajStavkuRentiranjaDialog(broj);
            dialog.ShowDialog();
            if (dialog.stavkaTermina != null)
            {
                stavkeTermina.Add(dialog.stavkaTermina);
            }
        }

        internal void RemoveStavkaTermina()
        {

            if (uCDodajTermin.DgvStavkeTermina.SelectedRows.Count > 0)
            {
                DataGridViewRow row = uCDodajTermin.DgvStavkeTermina.SelectedRows[0];
                StavkaTermina stavka = (StavkaTermina)row.DataBoundItem;
                stavkeTermina.Remove(stavka);
                for (int i = 0; i < stavkeTermina.Count; i++)
                {
                    stavkeTermina[i].RB = i + 1;
                }

            }
            else
            {
                MessageBox.Show("Morate oznaciti red za brisanje!");
            }

        }

        internal void SaveTermin()
        {
            if (stavkeTermina.Count == 0)
            {
                MessageBox.Show("Termin nema ni jednog ucenika tako da se ne moze sacuvati!");
                return;
            }
            if (!UCHelpers.ComboBoxValidacija(uCDodajTermin.CmbInstruktor, uCDodajTermin.LblInstruktor) |
                !UCHelpers.ComboBoxValidacija(uCDodajTermin.CmbCas, uCDodajTermin.LblCas))
            {
                //mozda i datum treba da validiram?
                return;
            }
            try
            {
                //DateTime datumIVreme = 
                Instruktor i = (Instruktor)uCDodajTermin.CmbInstruktor.SelectedItem;
                Cas c = (Cas)uCDodajTermin.CmbCas.SelectedItem;

                Termin t = new Termin
                {
                    //DatumIVreme = DateTime.ToString("MM/dd/yyyy"),
                    Instruktor = i,
                    CasId = c,
                    StavkeTermina = stavkeTermina.ToList(),
                    InsertValues = $"'{DateTime.Now.ToString("MM/dd/yyyy")}',{i.InstruktorId},{c.CasId}"


                };

                Komunikacija.Instance.SaveTermin(t);
                MessageBox.Show("Termin je sacuvan!");
                stavkeTermina.Clear();
                InitUCDodajTermin(uCDodajTermin);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        internal void InitForm(UCPromeniTermin uCPromeniTermin)
        {
            this.uCPromeniTermin = uCPromeniTermin;

        }
    }
}
