using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Common;


namespace View
{
    public class Komunikacija
    {
        private Socket klijentSoket;
        private NetworkStream tok;
        private BinaryFormatter formater = new BinaryFormatter();

        private static Komunikacija instance;
        public static Komunikacija Instance
        {
            get
            {
                if (instance == null) instance = new Komunikacija();
                return instance;
            }
        }
        public Komunikacija()
        {
            klijentSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
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
            Zahtev z = new Zahtev();
            z.Instruktor = new Instruktor
            {
                KorisnickoIme = username,
                Lozinka = password
            };
            z.Operacija = Operacija.Login;
            formater.Serialize(tok, z);

            Odgovor o = (Odgovor)formater.Deserialize(tok);
            return o.Instruktor;
        }



        //internal Odgovor VratiSveStambeneZajednice()
        //{
        //    Zahtev z = new Zahtev();
        //    z.Operacija = Operacija.VratiSveStambeneZajednice;

        //    formater.Serialize(tok, z);

        //    return (Odgovor)formater.Deserialize(tok);
        //}
        //internal Odgovor VratiSveVrsteIntervencija()
        //{
        //    Zahtev z = new Zahtev();
        //    z.Operacija = Operacija.VratiSveVrsteIntervencija;
        //    formater.Serialize(tok, z);

        //    return (Odgovor)formater.Deserialize(tok);
        //}

        

        //internal Odgovor VratiSveIntervencije()
        //{
        //    Zahtev z = new Zahtev
        //    {
        //        Operacija = Operacija.VratiSveIntervencije
        //    };
        //    formater.Serialize(tok, z);

        //    return (Odgovor)formater.Deserialize(tok);

        //}

        //internal Odgovor SacuvajIntervencije(List<Intervencija> listaIntervencija)
        //{
        //    Zahtev z = new Zahtev();
        //    z.Operacija = Operacija.SacuvajIntervencije;
        //    z.ListaIntervencija = listaIntervencija;
        //    formater.Serialize(tok, z);

        //    return (Odgovor)formater.Deserialize(tok);
        //}
    
}
}
