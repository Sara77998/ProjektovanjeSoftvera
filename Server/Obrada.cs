using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Common;
using Controller;

namespace Server
{
    class Obrada
    {
        private Socket klijentSoket;
        private NetworkStream tok;
        private BinaryFormatter formater;
        public Obrada(Socket klijentSoket)
        {
            this.klijentSoket = klijentSoket;
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
            catch (IOException ex)//greska kod upotrebe razl devajseva
            {
                Console.WriteLine(">>>" + ex.Message);
                Server.PrijavljeniUpravnici.Remove(upravnik);
            }
            catch (SerializationException ex)
            {
                Console.WriteLine(">>>" + ex.Message);
                Server.PrijavljeniUpravnici.Remove(upravnik);
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
                case Login:
                    Odgovor.Rezultat = Kontroler.Instance.Login();
                    Instruktor ulogovaniInstruktor = instruktori.First(i => i.KorisnickoIme == z.Instruktor.KorisnickoIme && i.Lozinka == z.Instruktor.Lozinka);
                    o.Instruktor = ulogovaniInstruktor;
                    return o;
                default:
                    break;
            }
            return o;
        }
    }
}
