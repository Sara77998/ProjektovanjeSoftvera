using Common;
using Controller;
using Domain;
using System;
using System.ComponentModel;
using System.IO;
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

        private readonly BindingList<Instruktor> instruktori;
        private Instruktor ulogovaniInstruktor;

        public Obrada(Socket klijentSoket, BindingList<Instruktor> instruktori)
        {
            this.klijentSoket = klijentSoket;
            this.instruktori = instruktori;
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
                        throw;
                    }
                    formater.Serialize(tok, o);
                }
            }
            catch (IOException)//greska kod upotrebe razl devajseva
            {
                //Console.WriteLine(">>>" + ex.Message);
                //Server.PrijavljeniUpravnici.Remove(upravnik);
                System.Windows.Forms.MessageBox.Show("Veza je prekinuta!");
                instruktori.Remove(ulogovaniInstruktor);
            }
            catch (SerializationException ex)
            {
                //Console.WriteLine(">>>" + ex.Message);
                //Server.PrijavljeniUpravnici.Remove(upravnik);
                System.Windows.Forms.MessageBox.Show("Veza je prekinuta!");
                instruktori.Remove(ulogovaniInstruktor);
            }
            finally
            {
                if (klijentSoket != null && klijentSoket.Connected)
                {
                    klijentSoket.Close();
                }
            }
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
                    instruktori.Add(ulogovaniInstruktor);
                    break;



                case Operacija.ZapamtiUcenika:
                    Kontroler.Instance.SaveUcenik((Ucenik)z.Objekat);
                    break;
                case Operacija.PretraziUcenika:
                    Kontroler.Instance.SearchUcenika((Ucenik)z.Objekat);
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
                    Kontroler.Instance.SearchCas((Cas)z.Objekat);
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
                    Kontroler.Instance.SearchTermin((Termin)z.Objekat);
                    break;
                case Operacija.UcitajTermin:
                    o.Rezultat = Kontroler.Instance.GetAllTermin();
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
