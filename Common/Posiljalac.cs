using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

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

        public void Posalji(object message) //send object
        {
            formater.Serialize(tok, message);
        }
    }
}
