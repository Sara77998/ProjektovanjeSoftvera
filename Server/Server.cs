using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Domain;

namespace Server
{
    class Server
    {
        private Socket serverSoket;     
        private List<Obrada> klijenti = new List<Obrada>();
        private BindingList<Instruktor> instruktori = new BindingList<Instruktor>();
        public BindingList<Instruktor> Instruktori
        {
            get { return instruktori; }
        }


        public Server()
        {
            serverSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public void Pokreni()
        {
            
            serverSoket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9000));
            serverSoket.Listen(5);
            bool kraj = false;
            while (!kraj)
            {
                try
                {

                    Socket klijentSoket = serverSoket.Accept();
                    Obrada o = new Obrada(klijentSoket, instruktori);
                    klijenti.Add(o);
                    Thread nit = new Thread(o.ObradiZahtev);
                    nit.IsBackground = true;
                    nit.Start();

                }
                catch (SocketException)
                {

                    System.Windows.Forms.MessageBox.Show("greska - klijentsSoket na serverskoj strani - kraj rada!");
                    kraj = true;

                } 
            }
        }
        public void Zaustavi()
        {
            serverSoket.Close();
            foreach (Obrada o in klijenti)
            {
                o.Zaustavi();
            }
            klijenti.Clear();
        }
    }
}
