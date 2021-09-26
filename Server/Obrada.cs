using Common;
using Controller;
using Domain;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Server
{
    public class Obrada
    {
        private Socket klijentSoket;
        private NetworkStream tok;
        private BinaryFormatter formater;

        //private readonly BindingList<Instruktor> instruktori;
        public BindingList<Instruktor> Instruktori { get; set; } = new BindingList<Instruktor>();
        private Instruktor ulogovaniInstruktor;

        public Obrada(Socket klijentSoket, BindingList<Instruktor> instruktori)
        {
            this.klijentSoket = klijentSoket;
            this.Instruktori = instruktori;
            //tok = new NetworkStream(klijentSoket);
        }
        public void ObradiZahtev()
        {
            try
            {
                tok = new NetworkStream(klijentSoket);
                formater = new BinaryFormatter();

                while (true)
                {
                    Odgovor o;
                    Zahtev z = (Zahtev)formater.Deserialize(tok);
                    try
                    {
                        o = KreirajOdgovor(z);
                    }
                    catch (Exception ex)
                    {
                        o = new Odgovor();
                        o.UspesnoKreiranOdgovor = false;
                        o.Error = ex.Message;
                    }
                    formater.Serialize(tok, o);
                }
            }
            catch (IOException)//greska kod upotrebe razl devajseva
            {
                
                System.Windows.Forms.MessageBox.Show("Veza je prekinuta!");
                Instruktori.Remove(ulogovaniInstruktor);
            }
            catch (SerializationException ex)
            {
               
                System.Windows.Forms.MessageBox.Show("Veza je prekinuta!");
                Instruktori.Remove(ulogovaniInstruktor);
            }
            //finally
            //{
            //    if (klijentSoket != null && klijentSoket.Connected)
            //    {
            //        klijentSoket.Close();
            //    }
            //}
        }



        private Odgovor KreirajOdgovor(Zahtev z)
        {
            Odgovor o = new Odgovor();
            o.UspesnoKreiranOdgovor = true;
            switch (z.Operacija)
            {
                case Operacija.Login:
                    o.Rezultat = Kontroler.Instance.Login((Instruktor)z.Objekat);
                    ulogovaniInstruktor = (Instruktor)o.Rezultat;
                    if (Instruktori.All(i => i.KorisnickoIme != ulogovaniInstruktor.KorisnickoIme))
                    {
                        Instruktori.Add(ulogovaniInstruktor);
                    }
                    else
                    {
                        //System.Windows.Forms.MessageBox.Show("Instruktor je vec ulogovan");
                        throw new Exception("Instruktor je vec ulogovan");
                    }                  
                    break;

                case Operacija.UcitajInstruktore:
                    o.Rezultat = Kontroler.Instance.GetAllInstruktor();
                    break;



                case Operacija.ZapamtiUcenika:
                    Kontroler.Instance.SaveUcenik((Ucenik)z.Objekat);
                    break;
                case Operacija.PretraziUcenika:
                    o.Rezultat = Kontroler.Instance.SearchUcenika((Ucenik)z.Objekat);
                    break;
                case Operacija.UcitajUcenika:
                    o.Rezultat = Kontroler.Instance.GetAllUcenik();
                    break;
                case Operacija.ObrisiUcenika:
                    Kontroler.Instance.DeleteUcenik((Ucenik)z.Objekat);
                    break;



                case Operacija.ZapamtiCas:
                    Kontroler.Instance.SaveCas((Cas)z.Objekat);
                    break;
                case Operacija.PretraziCas:
                    o.Rezultat = Kontroler.Instance.SearchCas((Cas)z.Objekat);
                    break;
                case Operacija.UcitajCasove:
                    o.Rezultat = Kontroler.Instance.GetAllCas();
                    break;
                case Operacija.ObrisiCas:
                    Kontroler.Instance.DeleteCas((Cas)z.Objekat);
                    break;



                case Operacija.ZapamtiTermin:
                    Kontroler.Instance.SaveTermin((Termin)z.Objekat);
                    break;
                case Operacija.IzmeniTermin:
                    Kontroler.Instance.UpdateTermin((Termin)z.Objekat);
                    break;
                case Operacija.PretraziTermin:
                    o.Rezultat = Kontroler.Instance.SearchTermin((Termin)z.Objekat);
                    break;
                case Operacija.UcitajTermin:
                    o.Rezultat = Kontroler.Instance.GetAllTermin();
                    break;



                case Operacija.UcitajStavkuTermina:
                    o.Rezultat = Kontroler.Instance.GetAllStavkaTermina();
                    break;
                case Operacija.ZapamtiStvakuTermina:
                    Kontroler.Instance.SaveStavkaTermina((StavkaTermina)z.Objekat);
                    break;
                case Operacija.ObrisiStavkuTermina:
                    Kontroler.Instance.DeleteStavkaTermina((StavkaTermina)z.Objekat);
                    break;

            }
            return o;
        }

        internal void Zaustavi()
        {
            
            klijentSoket.Close();
        }
    }
}
