using Domain;
using System;
using System.Collections.Generic;
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
                if (Komunikacija.Instance.SearchCasStazaLokacija(c) != null)
                {
                    System.Windows.Forms.MessageBox.Show("Nema takvog casa!");
                }
                else
                {
                    uCPronadjiCas.DgvCas.DataSource = Komunikacija.Instance.SearchCasStazaLokacija(c);
                    System.Windows.Forms.MessageBox.Show("Pstoji takav cas!");
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
                
                TezinaCasa = (TezinaCasa)uCPronadjiCas.CmbTezina.SelectedItem,
                WhereCondition = "c.TezinaCasa=",
                WhereValue = (string)uCPronadjiCas.CmbTezina.SelectedItem,

            };
            try
            {
                if (Komunikacija.Instance.SearchCasTezina(c) != null)
                {
                    System.Windows.Forms.MessageBox.Show("Nema takvog casa!");
                }
                else
                {
                    uCPronadjiCas.DgvCas.DataSource = Komunikacija.Instance.SearchCasTezina(c);
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
                    //StazaLokacija = uCDodajCas.TxtStazaLokacija.Text,
                    //TezinaCasa = (TezinaCasa)uCDodajCas.CmbTezinaCasa.SelectedItem,
                    //Cena = int.Parse(uCDodajCas.TxtCena.Text),
                    
                    InsertValues = $"'{uCDodajCas.TxtStazaLokacija.Text}',{(TezinaCasa)uCDodajCas.CmbTezinaCasa.SelectedItem},{int.Parse(uCDodajCas.TxtCena.Text)}"
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

        
        
    }
}
