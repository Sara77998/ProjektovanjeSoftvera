using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Net.Sockets;


namespace View.Communication
{
    public class Komunikacija
    {
        private Socket klijentSoket;

        internal void Disconnect()
        {
            klijentSoket.Close();
            klijentSoket = null;
        }

        //private NetworkStream tok;
        //private BinaryFormatter formater = new BinaryFormatter();

        private KomunikacijaKlijent klijent;

        private static Komunikacija instance;
        public static Komunikacija Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Komunikacija();
                }

                return instance;
            }
        }

        public object GetAllInstrukruktor { get; internal set; }

        public Komunikacija()
        {
            klijentSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        internal object GetAllInstrukruktor()
        {
            throw new NotImplementedException();
        }

        public bool PoveziSe()
        {
            try
            {
                klijentSoket.Connect("127.0.0.1", 9000);
                tok = new NetworkStream(klijentSoket);
                return true;
            }
            catch (SocketException)
            {
                System.Windows.Forms.MessageBox.Show("Nije se povezao klijent");
                return false;
            }
        }


        internal Instruktor PrijaviSe(string username, string password)
        {
            Zahtev z = new Zahtev()
            {
                Operacija = Operacija.Login,
                Objekat = new Instruktor
                {
                    KorisnickoIme = username,
                    Lozinka = password
                }
            };
            klijent.PosaljiZahtev(z);

            return (Instruktor)klijent.VratiOdgovor();
        }

        //***************************************************
        internal void SaveUcenik(Ucenik u)
        {
            Zahtev z = new Zahtev()
            {
                Operacija = Operacija.ZapamtiUcenika,
                Objekat = u
            };
            klijent.PosaljiZahtev(z);



            klijent.VratiOdgovor();
        }

        internal List<Ucenik> SearchUcenik(Ucenik u)
        {
            Zahtev z = new Zahtev()
            {
                Operacija = Operacija.PretraziUcenika,
                Objekat = u
            };
            List<Ucenik> ucenici;
            klijent.PosaljiZahtev(z);


            ucenici = (List<Ucenik>)klijent.VratiOdgovor();
            if (ucenici.Count == 0 || ucenici == null)
            {
                throw new Exception("Ne postoji ucenik sa zadatim kriterijumom!");
            }
            return ucenici;
        }

        internal List<Ucenik> GetAllUcenik()
        {
            List<Ucenik> ucenici = new List<Ucenik>();
            Zahtev z = new Zahtev()
            {
                Operacija = Operacija.UcitajUcenika,
                Objekat = new Ucenik
                {

                }
            };
            klijent.PosaljiZahtev(z);


            ucenici = (List<Ucenik>)klijent.VratiOdgovor();
            return ucenici;
        }

        internal void DeleteUcenik(Ucenik u)
        {
            Zahtev z = new Zahtev()
            {
                Operacija = Operacija.ObrisiUcenika,
                Objekat = u
            };
            try
            {
                klijent.PosaljiZahtev(z);
                klijent.VratiOdgovor();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //******************************************************
        internal void SaveCas(Cas c)
        {
            Zahtev z = new Zahtev
            {
                Operacija = Operacija.ZapamtiCas,
                Objekat = c
            };
            klijent.PosaljiZahtev(z);




            klijent.VratiOdgovor();
        }
        internal List<Cas> SearchCas(Cas c)
        {
            Zahtev z = new Zahtev
            {
                Operacija = Operacija.PretraziCas,
                Objekat = c
            };
            List<Cas> casovi;
            klijent.PosaljiZahtev(z);


            casovi = (List<Cas>)klijent.VratiOdgovor();
            if (casovi.Count == 0 || casovi == null)
            {
                throw new Exception("Ne postoji cas sa zadatim kriterijumom!");
            }
            return casovi;
        }
        internal List<Cas> GetAllCas()
        {
            List<Cas> casovi = new List<Cas>();
            Zahtev z = new Zahtev()
            {
                Operacija = Operacija.PretraziCas,
                Objekat = new Cas
                {

                }
            };
            klijent.PosaljiZahtev(z);


            casovi = (List<Cas>)klijent.VratiOdgovor();
            return casovi;
        }
        internal void DeleteCas(Cas c)
        {
            Zahtev z = new Zahtev()
            {
                Operacija = Operacija.ObrisiCas,
                Objekat = c
            };
            try
            {
                klijent.PosaljiZahtev(z);
                klijent.VratiOdgovor();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //******************************************************
        internal void SaveTermin(Termin t)
        {
            Zahtev z = new Zahtev
            {
                Operacija = Operacija.ZapamtiTermin,
                Objekat = t
            };
            klijent.PosaljiZahtev(z);



            klijent.VratiOdgovor();
        }
        internal List<Termin> SearchTermin(Termin t)
        {
            List<Termin> termini;
            Zahtev z = new Zahtev()
            {
                Operacija = Operacija.PretraziTermin,
                Objekat = t
            };
            klijent.PosaljiZahtev(z);


            termini = (List<Termin>)klijent.VratiOdgovor();
            if (termini == null || termini.Count == 0)
            {
                throw new Exception("Ne postoji termin sa zadatim kriterijumom!");
            }
            return termini;
        }
        internal List<Termin> GetAllTermin()
        {
            List<Termin> termini = new List<Termin>();
            Zahtev z = new Zahtev()
            {
                Operacija = Operacija.UcitajTermin,
                Objekat = new Termin
                {

                }
            };
            klijent.PosaljiZahtev(z);


            termini = (List<Termin>)klijent.VratiOdgovor();
            return termini;
        }
        //******************************************************
        internal void UpdateTermin(Termin t)
        {
            Zahtev z = new Zahtev()
            {
                Operacija = Operacija.IzmeniTermin,
                Objekat = t
            };
            klijent.PosaljiZahtev(z);


            klijent.VratiOdgovor();
        }
        //******************************************************
        internal void SaveStavkaTermina(StavkaTermina stavkaTermina)
        {
            Zahtev z = new Zahtev()
            {
                Operacija = Operacija.ZapamtiStvakuTermina,
                Objekat = stavkaTermina
            };
            klijent.PosaljiZahtev(z);




            klijent.VratiOdgovor();
        }
        internal void DeleteStavkaTermina(StavkaTermina stavkaTermina)
        {
            Zahtev z = new Zahtev()
            {
                Operacija = Operacija.ObrisiStavkuTermina,
                Objekat = stavkaTermina
            };
            klijent.PosaljiZahtev(z);




            klijent.VratiOdgovor();
        }




    }
}
