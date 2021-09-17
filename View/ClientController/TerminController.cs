using Domain;
using System;
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
        private BindingList<StavkaTermina> stavkeTermina = new BindingList<StavkaTermina>();
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
                    //DatumIVreme = DataSourceUpdateMode,
                    Instruktor = i,
                    CasId = c,
                    StavkeTermina = stavkeTermina.ToList()
                    //InsertValues = $"'{m.JMBG}','{DateTime.Now.ToString("MM/dd/yyyy")}',{k}"


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
    }
}
