﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.UserControls;
using View.UserControlHelpers;
using View.Communication;
using Domain;

namespace View.ClientController
{
    public class CasController
    {
        internal void InitUCDodajCas(UCDodajCas ucDodajCas)
        {
            try
            {
                List<int> godista = new List<int>();
                for (int i = 1980; i < 2021; i++)
                {
                    godista.Add(i);

                }
                //ucAddAutomobil.CbGodiste.DataSource = Communication.Communication.Instance.GetAllMarka();
                ucAddAutomobil.CbMarka.DataSource = Communication.Communication.Instance.GetAllMarka();
                ucAddAutomobil.CbGodiste.DataSource = godista;
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        internal void InitUCUpdateAutomobil(UCUpdateAutomobil uCUpdateAutomobil)
        {
            try
            {
                List<int> godista = new List<int>();
                for (int i = 1980; i < 2021; i++)
                {
                    godista.Add(i);

                }
                //ucAddAutomobil.CbGodiste.DataSource = Communication.Communication.Instance.GetAllMarka();
                uCUpdateAutomobil.CbMarka.DataSource = Communication.Communication.Instance.GetAllMarka();
                uCUpdateAutomobil.CbGodiste.DataSource = godista;
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        internal void Save(UCDodajCas uCDodajCas)
        {
            if (!UCHelpers.ComboBoxValidacija(uCDodajCas.CmbTezinaCasa, uCDodajCas.LblTezinaCasa)
                | !UCHelpers.CenaValidacija(uCDodajCas.TxtCena, uCDodajCas.LblCena)
                )
            {

                return;
            }
            try
            {
                string c1 = CommaConversion(uCDodajCas.TxtCena.Text);
                //Model model = (Model)uCAddAutomobil.CbModel.SelectedItem;
                Cas c = new Cas()
                {

                    //WhereCondition = "a.BrojSasije=",
                    //WhereValue = uCAddAutomobil.TxtBrojSasije.Text,
                    InsertValues = $"'{uCDodajCas.TxtStazaLokacija.Text}',{(TezinaCasa)uCDodajCas.CmbTezinaCasa.SelectedItem},{c1}"

                };

               
                Komunikacija.Instance.SaveCas(c);
                System.Windows.Forms.MessageBox.Show("Cas je sacuvan!");
                ResetForm(uCDodajCas);

            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        internal void DeleteAutomobil(UCUpdateAutomobil uCUpdateAutomobil)
        {
            try
            {
                if ((Automobil)uCUpdateAutomobil.ComboBox.SelectedItem == null)
                {
                    System.Windows.Forms.MessageBox.Show("Niste izabrali automobil");
                    return;
                }
                Automobil a = (Automobil)uCUpdateAutomobil.ComboBox.SelectedItem;
                a.WhereCondition = "BrojSasije=";
                a.WhereValue = $"'{a.BrojSasije}'";
                /*try
                {
                    Communication.Communication.Instance.DeleteAutomobil(a);
                    System.Windows.Forms.MessageBox.Show("Automobil je uspesno obrisan");
                    ResetForm(uCUpdateAutomobil);
                }
                catch (Exception)
                {

                    System.Windows.Forms.MessageBox.Show("Automobil ne moze biti obrisan jer postoji rentiranje u kome ucestvuje");
                }*/
                Communication.Communication.Instance.DeleteAutomobil(a);
                System.Windows.Forms.MessageBox.Show("Automobil je uspesno obrisan");
                ResetForm(uCUpdateAutomobil);

            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        internal void UpdateAutomobil(UCUpdateAutomobil uCUpdateAutomobil)
        {
            if (uCUpdateAutomobil.ComboBox.SelectedItem == null)
            {
                System.Windows.Forms.MessageBox.Show("Niste izabrali automobil koji zelite da izmenite");
                return;
            }
            if (!UserControlHelpers.ComboBoxValidation(uCUpdateAutomobil.CbMarka, uCUpdateAutomobil.LblMarka)
                | !UserControlHelpers.ComboBoxValidation(uCUpdateAutomobil.CbModel, uCUpdateAutomobil.LblModel)
                | !UserControlHelpers.RegistrationValidation(uCUpdateAutomobil.TxtRegistracijaUpdate, uCUpdateAutomobil.LblRegistracija)

                )
            {
                return;
            }
            try
            {
                string k = CommaConversion(uCUpdateAutomobil.TxtCenaUpdate.Text);
                Model model = (Model)uCUpdateAutomobil.CbModel.SelectedItem;
                Automobil a = new Automobil
                {
                    /*BrojSasije=uCUpdateAutomobil.BrojSasije,
                    Registracija=uCUpdateAutomobil.TxtRegistracijaUpdate.Text,
                    CenaPoDanu=double.Parse(uCUpdateAutomobil.TxtCenaUpdate.Text),
                    GodinaProizvodnje=(int)uCUpdateAutomobil.CbGodiste.SelectedItem,
                    Model=(Model)uCUpdateAutomobil.CbModel.SelectedItem*/
                    WhereCondition = "BrojSasije=",
                    WhereValue = $"'{uCUpdateAutomobil.BrojSasije}'",
                    UpdateText = $"Registracija='{uCUpdateAutomobil.TxtRegistracijaUpdate.Text}',GodinaProizvodnje={(int)uCUpdateAutomobil.CbGodiste.SelectedItem},CenaPoDanu={k},ModelID={model.Id}"


                };
                Communication.Communication.Instance.UpdateAutomobil(a);
                System.Windows.Forms.MessageBox.Show("Automobil uspesno sacuvan");
                ResetForm(uCUpdateAutomobil);
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        internal void UpdateModel(UCUpdateAutomobil uCUpdateAutomobil)
        {
            try
            {
                uCUpdateAutomobil.CbModel.DataSource = Communication.Communication.Instance.GetAllModel((Marka)uCUpdateAutomobil.CbMarka.SelectedItem);

            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        internal void UpdateFill(UCUpdateAutomobil uCUpdateAutomobil)
        {
            try
            {
                Automobil a = (Automobil)uCUpdateAutomobil.ComboBox.SelectedItem;
                uCUpdateAutomobil.TxtCenaUpdate.Text = a.CenaPoDanu.ToString();
                uCUpdateAutomobil.TxtRegistracijaUpdate.Text = a.Registracija;
                uCUpdateAutomobil.CbMarka.SelectedIndex = uCUpdateAutomobil.CbMarka.FindStringExact(a.Model.Marka.ToString());
                uCUpdateAutomobil.CbModel.DataSource = Communication.Communication.Instance.GetAllModel(a.Marka);
                //System.Windows.Forms.MessageBox.Show($"{a.Model.Naziv} {a.Model.Verzija}");
                uCUpdateAutomobil.CbGodiste.SelectedIndex = uCUpdateAutomobil.CbGodiste.FindStringExact(a.GodinaProizvodnje.ToString());
                uCUpdateAutomobil.CbModel.SelectedIndex = uCUpdateAutomobil.CbModel.FindStringExact($"{a.Model.Naziv} {a.Model.Verzija}");
                //uCUpdateAutomobil.CbMarka.Text = a.Model.Marka.ToString();
                //uCUpdateAutomobil.CbModel.Text = a.Model.ToString();
                uCUpdateAutomobil.BrojSasije = a.BrojSasije;
                System.Windows.Forms.MessageBox.Show("Ucitani su podaci o automobilu");
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        internal void SearchAutomobilBrSasije(UCSearchAutomobil uCSearchAutomobil)
        {
            Automobil a = new Automobil
            {
                BrojSasije = uCSearchAutomobil.TxtBrSasisije.Text,
                WhereCondition = "a.BrojSasije=",
                WhereValue = uCSearchAutomobil.TxtBrSasisije.Text
            };
            try
            {
                if (Communication.Communication.Instance.SearchAutomobilBrSasije(a))
                {
                    System.Windows.Forms.MessageBox.Show("Nema automobila sa zadatim brojem sasije");
                }
                else
                {
                    uCSearchAutomobil.DgvAutomobili.DataSource = Communication.Communication.Instance.SearchAutomobil(a);
                    System.Windows.Forms.MessageBox.Show("Postoji automobil sa zadatim brojem sasije");
                }
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        internal void SearchCasStazaLokacija(UCPronadjiCas uCPronadjiCas)
        {
            Cas c = new Cas()
            {
                StazaLokacija = uCPronadjiCas.
                Registracija = uCSearchAutomobil.TxtRegistracija.Text,
                WhereCondition = "a.Registracija=",
                WhereValue = uCSearchAutomobil.TxtRegistracija.Text,

            };
            try
            {
                if (Komunikacija.Instance.SearchCasStazaLokacija(c))
                {
                    System.Windows.Forms.MessageBox.Show("Nema takvog casa!");
                }
                else
                {
                    uCSearchAutomobil.DgvAutomobili.DataSource = Communication.Communication.Instance.SearchAutomobil(a);
                    System.Windows.Forms.MessageBox.Show("Postoji automobil sa zadatom registracijom");
                }
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }

        internal void SearchCasStazaLokacija(UCUpdateAutomobil uCUpdateAutomobil)
        {
            Automobil a = new Automobil
            {
                Registracija = uCUpdateAutomobil.TxtRegistracija.Text,
                WhereCondition = "a.Registracija=",
                WhereValue = uCUpdateAutomobil.TxtRegistracija.Text,
            };
            try
            {
                if (Communication.Communication.Instance.SearchAutomobilRegistracija(a))
                {
                    System.Windows.Forms.MessageBox.Show("Nema automobila sa zadatom registracijom");
                }
                else
                {
                    uCUpdateAutomobil.ComboBox.DataSource = Communication.Communication.Instance.SearchAutomobil(a);
                    System.Windows.Forms.MessageBox.Show("Postoji automobil sa zadatom registracijom");
                }
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        internal void SearchAutomobilBrSasije(UCUpdateAutomobil uCUpdateAutomobil)
        {
            Automobil a = new Automobil
            {
                BrojSasije = uCUpdateAutomobil.TxtBrojSasije.Text,
                WhereCondition = "a.BrojSasije=",
                WhereValue = uCUpdateAutomobil.TxtBrojSasije.Text,
            };
            try
            {
                if (Communication.Communication.Instance.SearchAutomobilBrSasije(a))
                {
                    System.Windows.Forms.MessageBox.Show("Nema automobila sa zadatim brojem sasije");
                }
                else
                {
                    uCUpdateAutomobil.ComboBox.DataSource = Communication.Communication.Instance.SearchAutomobil(a);
                    System.Windows.Forms.MessageBox.Show("Postoji automobil sa zadatim brojem sasije");
                }
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        internal void GetAllModel(UCAddAutomobil uCAddAutomobil)
        {
            try
            {

                uCAddAutomobil.CbModel.DataSource = Communication.Communication.Instance.GetAllModel((Marka)uCAddAutomobil.CbMarka.SelectedItem);

            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        internal void ResetForm(UCDodajCas uCDodajCas)
        {
            uCDodajCas.TxtBrojSasije.Text = "";
            uCAddAutomobil.TxtRegistracija.Text = "";
            uCAddAutomobil.TxtCenaPoDanu.Text = "";
            uCAddAutomobil.LblMarka.Text = "";
            uCAddAutomobil.LblModel.Text = "";
            uCAddAutomobil.LblBrojSasije.Text = "";
            uCAddAutomobil.LblCenaPoDanu.Text = "";
            uCAddAutomobil.LblRegistracija.Text = "";
            uCAddAutomobil.LblGodinaProizvodnje.Text = "";
            uCAddAutomobil.CbModel.DataSource = null;
            InitUCAddAutomobil(uCAddAutomobil);

        }

        internal void ResetForm(UCUpdateAutomobil uCUpdateAutomobil)
        {
            uCUpdateAutomobil.TxtBrojSasije.Text = "";
            uCUpdateAutomobil.TxtRegistracija.Text = "";
            uCUpdateAutomobil.TxtCenaUpdate.Text = "";
            uCUpdateAutomobil.TxtRegistracijaUpdate.Text = "";
            uCUpdateAutomobil.CbModel.DataSource = null;
            uCUpdateAutomobil.ComboBox.DataSource = null;
            uCUpdateAutomobil.LblMarka.Text = "";
            uCUpdateAutomobil.LblModel.Text = "";
            uCUpdateAutomobil.LblCenaPoDanu.Text = "";
            uCUpdateAutomobil.LblRegistracija.Text = "";
            uCUpdateAutomobil.LblGodiste.Text = "";
            InitUCUpdateAutomobil(uCUpdateAutomobil);
        }

        internal string CommaConversion(string s)
        {
            if (s.Contains(","))
            {
                return s.Replace(",", ".");
            }
            return s;
        }
    }
}
