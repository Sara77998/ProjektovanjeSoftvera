using Domain;
using System;
using System.Globalization;
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

       

        //internal void Update(UCUpdateMusterija uCUpdateMusterija)
        //{
        //    if (uCUpdateMusterija.CbMusterije.SelectedItem == null)
        //    {
        //        System.Windows.Forms.MessageBox.Show("Niste izabrali musteriju koju zelite da izmenite");
        //        return;
        //    }
        //    if (!UserControlHelpers.CapitalLetterValidation(uCUpdateMusterija.TxtImeUpdate, uCUpdateMusterija.LblIme)
        //        | !UserControlHelpers.CapitalLetterValidation(uCUpdateMusterija.TxtPrezimeUpdate, uCUpdateMusterija.LblPrezime)
        //        | !UserControlHelpers.PhoneNumberValidation(uCUpdateMusterija.TxtBrojTelefonaUpdate, uCUpdateMusterija.LblBrojTelefona)
        //        | !UserControlHelpers.DateValidation(uCUpdateMusterija.DtpDatumUpdate, uCUpdateMusterija.LblDatum)
        //        )
        //    {
        //        return;
        //    }
        //    try
        //    {
        //        Musterija m = new Musterija
        //        {
        //            /*JMBG = uCUpdateMusterija.JMBG,
        //            Ime = uCUpdateMusterija.TxtImeUpdate.Text,
        //            Prezime = uCUpdateMusterija.TxtPrezimeUpdate.Text,
        //            BrojTelefona = uCUpdateMusterija.TxtBrojTelefonaUpdate.Text,
        //            DatumRodjenja = uCUpdateMusterija.DtpDatumUpdate.Value*/
        //            WhereCondition = "JMBG=",
        //            WhereValue = $"'{uCUpdateMusterija.JMBG}'",
        //            UpdateText = $"Ime='{uCUpdateMusterija.TxtImeUpdate.Text}',Prezime='{uCUpdateMusterija.TxtPrezimeUpdate.Text}', BrojTelefona='{uCUpdateMusterija.TxtBrojTelefonaUpdate.Text}', DatumRodjenja='{uCUpdateMusterija.DtpDatumUpdate.Value.ToString("MM/dd/yyyy")}'"

        //        };
        //        Communication.Communication.Instance.UpdateMusterija(m);
        //        System.Windows.Forms.MessageBox.Show("Musterija uspesno izmenjena");
        //        ResetForm(uCUpdateMusterija);
        //    }
        //    catch (Exception ex)
        //    {

        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }
        //}

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
                    System.Windows.Forms.MessageBox.Show("Ne postoji ucenim sa tim imenom!");
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

        //internal void UpdateFill(UCUpdateMusterija uCUpdateMusterija)
        //{
        //    try
        //    {
        //        Musterija m = (Musterija)uCUpdateMusterija.CbMusterije.SelectedItem;

        //        uCUpdateMusterija.TxtImeUpdate.Text = m.Ime;
        //        uCUpdateMusterija.TxtPrezimeUpdate.Text = m.Prezime;
        //        uCUpdateMusterija.TxtBrojTelefonaUpdate.Text = m.BrojTelefona;
        //        uCUpdateMusterija.DtpDatumUpdate.Value = m.DatumRodjenja;
        //        uCUpdateMusterija.JMBG = m.JMBG;
        //        System.Windows.Forms.MessageBox.Show("Ucitana musterija");
        //    }
        //    catch (Exception ex)
        //    {

        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }
        //}



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

       
    }
}
