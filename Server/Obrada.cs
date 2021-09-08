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
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;

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
                
            }
            return o;
        }

        internal void Zaustavi()
        {
            klijentSoket.Close();
        }
    }
}
