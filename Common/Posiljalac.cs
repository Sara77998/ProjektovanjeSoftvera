using System;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace Common
{
    [Serializable]
    public class Posiljalac
    {
        private readonly Socket klijentSoket;
        private NetworkStream tok;
        private BinaryFormatter formater;

        public Posiljalac(Socket klijentSoket)
        {
            this.klijentSoket = klijentSoket;
            this.tok = new NetworkStream(klijentSoket);
            this.formater = new BinaryFormatter();
        }

        public void Posalji(object message) 
        {
            formater.Serialize(tok, message);
        }
    }
}
