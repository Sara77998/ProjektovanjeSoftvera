using System;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace Common
{
    [Serializable]
    public class Primalac
    {
        private readonly Socket klijentSoket;
        private NetworkStream tok;
        private BinaryFormatter formater;

        public Primalac(Socket klijentSoket)
        {
            this.klijentSoket = klijentSoket;
            this.tok = new NetworkStream(klijentSoket);
            this.formater = new BinaryFormatter();
        }

        public object Primi()
        {
            return formater.Deserialize(tok);
        }
    }
}
