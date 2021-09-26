using Domain;
using System;
using System.Globalization;
using System.Windows.Forms;
using View.Communication;
using View.UserControlHelpers;
using View.UserControls;

namespace View.ClientController
{
    public class UcenikController
    {
        internal void Save(UCDodajUcenika UCDodajUcenika)
        {
            if (!UCHelpers.PraznoPoljeValidacija(UCDodajUcenika.TxtUcenikId)
                | !UCHelpers.PraznoPoljeValidacija(UCDodajUcenika.TxtIme)
                | !UCHelpers.PraznoPoljeValidacija(UCDodajUcenika.TxtPrezime)
                | !UCHelpers.PraznoPoljeValidacija(UCDodajUcenika.TxtDatumRodjenja)
                | !UCHelpers.PraznoPoljeValidacija(UCDodajUcenika.TxtEmail)
                | !UCHelpers.PraznoPoljeValidacija(UCDodajUcenika.TxtTelefon))
            {
                return;
            }
            if (!UCHelpers.TelefonValidacija(UCDodajUcenika.TxtUcenikId, UCDodajUcenika.LblUcenikId)|
                !UCHelpers.VlastiteImeniceValidacija(UCDodajUcenika.TxtIme, UCDodajUcenika.LblIme)
                | !UCHelpers.VlastiteImeniceValidacija(UCDodajUcenika.TxtPrezime, UCDodajUcenika.LblPrezime)
                | !UCHelpers.TelefonValidacija(UCDodajUcenika.TxtTelefon, UCDodajUcenika.LblTelefon)
                | !UCHelpers.DatumValidacija(UCDodajUcenika.TxtDatumRodjenja, UCDodajUcenika.LblDatumRodjenja)
                | !UCHelpers.EmailValidacija(UCDodajUcenika.TxtEmail, UCDodajUcenika.LblEmail)
                )
            {
                return;
            }
            try
            {
                
                Ucenik u = new Ucenik
                {
                    UcenikId = UCDodajUcenika.TxtUcenikId.Text,
                    Ime = UCDodajUcenika.TxtIme.Text,
                    Prezime = UCDodajUcenika.TxtPrezime.Text,
                    DatumRodjenja = DateTime.ParseExact(UCDodajUcenika.TxtDatumRodjenja.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    Telefon = UCDodajUcenika.TxtTelefon.Text,
                    Email = UCDodajUcenika.TxtEmail.Text,
                    WhereCondition = "u.ucenikid=",
                    WhereValue = UCDodajUcenika.TxtUcenikId.Text

                };

                Komunikacija.Instance.SaveUcenik(u);
                System.Windows.Forms.MessageBox.Show("Ucenik je sacuvan!");
                ResetForm(UCDodajUcenika);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        internal void InitUCObrisiUcenika(UCObrisiUcenika uCObrisiUcenika)
        {
            uCObrisiUcenika.DgvSviUcenici.DataSource = Komunikacija.Instance.GetAllUcenik();
        }





        internal static void SearchUcenikIme(UCPronadjiUcenika uCPronadjiUcenika)
        {
            try
            {
                Ucenik u = new Ucenik
                {
                    Ime = uCPronadjiUcenika.TxtIme.Text,
                    WhereValue = uCPronadjiUcenika.TxtIme.Text,
                    WhereCondition = "u.Ime="
                };
                if (Komunikacija.Instance.SearchUcenikIme(u))
                {
                    uCPronadjiUcenika.DgvUcenici.DataSource = null;
                    System.Windows.Forms.MessageBox.Show("Ne postoji ucenik sa tim imenom!");
                }
                else
                {
                    uCPronadjiUcenika.DgvUcenici.DataSource = Komunikacija.Instance.SearchUcenik(u);
                    System.Windows.Forms.MessageBox.Show("Pronadjen je ucenik sa zadatim imenom!");
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

 

        internal void Delete(UCObrisiUcenika uCObrisiUcenika)
        {
            try
            {

                DataGridViewRow red = uCObrisiUcenika.DgvSviUcenici.SelectedRows[0];
                Ucenik u = (Ucenik)red.DataBoundItem;
                u.WhereCondition = "ucenikId=";
                u.WhereValue = $"'{u.UcenikId}'";
                Komunikacija.Instance.DeleteUcenik(u);
                System.Windows.Forms.MessageBox.Show("Izabrani ucenik je obrisan!");
                ResetForm(uCObrisiUcenika);

            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        internal static void SearchUcenikPrezime(UCPronadjiUcenika uCPronadjiUcenika)
        {
            try
            {
                Ucenik u = new Ucenik
                {
                    Prezime = uCPronadjiUcenika.TxtPrezime.Text,
                    WhereValue = uCPronadjiUcenika.TxtPrezime.Text,
                    WhereCondition = "u.Prezime="
                };
                if (Komunikacija.Instance.SearchUcenikPrezime(u))
                {
                    uCPronadjiUcenika.DgvUcenici.DataSource = null;
                    System.Windows.Forms.MessageBox.Show("Ne postoji ucenik sa tim prezimenom!");
                }
                else
                {
                    uCPronadjiUcenika.DgvUcenici.DataSource = Komunikacija.Instance.SearchUcenik(u);
                    System.Windows.Forms.MessageBox.Show("Pronadjen je ucenik sa zadatim prezimenom");
                }
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        internal void InitUCUcenik(UCDodajUcenika uCDodajUcenika)
        {

        }

        internal void ResetForm(UCDodajUcenika uCDodajUcenika)
        {
            uCDodajUcenika.TxtUcenikId.Clear();
            uCDodajUcenika.TxtIme.Clear();
            uCDodajUcenika.TxtPrezime.Clear();
            //DateTime dt = DateTime.Now;
            uCDodajUcenika.TxtDatumRodjenja.Clear();
            uCDodajUcenika.TxtTelefon.Clear();
            uCDodajUcenika.TxtEmail.Clear();

            uCDodajUcenika.LblUcenikId.Text = "";
            uCDodajUcenika.LblIme.Text = "";
            uCDodajUcenika.LblPrezime.Text = "";
            uCDodajUcenika.LblDatumRodjenja.Text = "";
            uCDodajUcenika.LblTelefon.Text = "";
            uCDodajUcenika.LblEmail.Text = "";
        }
        internal void ResetForm(UCObrisiUcenika uCObrisiUcenika)
        {
            uCObrisiUcenika.DgvSviUcenici.DataSource = Komunikacija.Instance.GetAllUcenik();
        }

    }
}
