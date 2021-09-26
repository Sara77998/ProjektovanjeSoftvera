using Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using View.Communication;
using View.UserControlHelpers;
using View.UserControls;

namespace View.ClientController
{
    public class CasController
    {
        internal void InitUCDodajCas(UCDodajCas ucDodajCas)
        {
            try
            {
                List<string> tezine = new List<string>();
                tezine.Add("lako");
                tezine.Add("srednje");
                tezine.Add("tesko");
                ucDodajCas.CmbTezinaCasa.DataSource = tezine;
                
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        internal void InitUCObrisiCas(UCObrisiCas uCObrisiCas)
        {
             uCObrisiCas.DgvSviCasovi.DataSource = Komunikacija.Instance.GetAllCas();

        }

        internal void Delete(UCObrisiCas uCObrisiCas)
        {
            try
            {

                DataGridViewRow red = uCObrisiCas.DgvSviCasovi.SelectedRows[0];
                Cas c = (Cas)red.DataBoundItem;
                c.WhereCondition = "casId=";
                c.WhereValue = $"'{c.CasId}'";
                Komunikacija.Instance.DeleteCas(c);
                System.Windows.Forms.MessageBox.Show("Izabrani cas je obrisan!");
                ResetForm(uCObrisiCas);

            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        internal void InitUCPronadjiCas(UCPronadjiCas uCPronadjiCas)
        {
            try
            {
                List<string> tezine = new List<string>();
                tezine.Add("lako");
                tezine.Add("srednje");
                tezine.Add("tesko");
                uCPronadjiCas.CmbTezina.DataSource = tezine;

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
                StazaLokacija = uCPronadjiCas.TxtStazaLokacija.Text,              
                WhereCondition = "c.stazalokacija=",
                WhereValue = uCPronadjiCas.TxtStazaLokacija.Text,

            };
            try
            {
                if (!Komunikacija.Instance.SearchCasStazaLokacija(c))
                {
                    uCPronadjiCas.DgvCas.DataSource = null;
                    System.Windows.Forms.MessageBox.Show("Nema takvog casa!");
                }
                else
                {
                    uCPronadjiCas.DgvCas.DataSource = Komunikacija.Instance.SearchCas(c);
                    uCPronadjiCas.DgvCas.Columns["CasId"].Visible = false;
                    System.Windows.Forms.MessageBox.Show("Postoji takav cas!");
                }
            }
            catch (Exception ex)
            {
                
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }
        internal void SearchCasTezina(UCPronadjiCas uCPronadjiCas)
        {
            Cas c = new Cas()
            {
                
                TezinaCasa = (string)uCPronadjiCas.CmbTezina.SelectedItem,
                WhereCondition = "c.TezinaCasa=",
                WhereValue = (string)uCPronadjiCas.CmbTezina.SelectedItem,

            };
            try
            {
                
                if (!Komunikacija.Instance.SearchCasTezina(c))
                {
                    uCPronadjiCas.DgvCas.DataSource = null;
                    System.Windows.Forms.MessageBox.Show("Nema takvog casa!");
                }
                else
                {
                    uCPronadjiCas.DgvCas.DataSource = Komunikacija.Instance.SearchCas(c);
                    uCPronadjiCas.DgvCas.Columns["CasId"].Visible = false;
                    System.Windows.Forms.MessageBox.Show("Postoji takav cas!");
                }
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        
        internal void Save(UCDodajCas uCDodajCas)
        {
            if (!UCHelpers.PraznoPoljeValidacija(uCDodajCas.TxtStazaLokacija)
               | !UCHelpers.PraznoPoljeValidacija(uCDodajCas.TxtCena)
               )
            {
                return;
            }
            if (!UCHelpers.ComboBoxValidacija(uCDodajCas.CmbTezinaCasa, uCDodajCas.LblTezinaCasa)
                | !UCHelpers.CenaValidacija(uCDodajCas.TxtCena, uCDodajCas.LblCena)
                )
            {
                return;
            }
            try
            {
               
                Cas c = new Cas()
                {
                    StazaLokacija = uCDodajCas.TxtStazaLokacija.Text,
                    TezinaCasa = (string)uCDodajCas.CmbTezinaCasa.SelectedItem,
                    Cena = int.Parse(uCDodajCas.TxtCena.Text),
                    WhereCondition = "c.stazalokacija=",
                    WhereValue = uCDodajCas.TxtStazaLokacija.Text,

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


        internal void ResetForm(UCDodajCas uCDodajCas)
        {
            uCDodajCas.TxtStazaLokacija.Text = "";
            uCDodajCas.CmbTezinaCasa.DataSource = null;
            uCDodajCas.TxtCena.Text = "";


            uCDodajCas.LblStazaLokacija.Text = "";
            uCDodajCas.LblTezinaCasa.Text = "";
            uCDodajCas.LblCena.Text = "";
            
            InitUCDodajCas(uCDodajCas);

        }
        internal void ResetForm(UCObrisiCas uCObrisiCas)
        {
            uCObrisiCas.DgvSviCasovi.DataSource = Komunikacija.Instance.GetAllCas();
        }


    }
}
