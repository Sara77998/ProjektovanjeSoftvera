using Common;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Remoting;

namespace View.Communication
{
    public class KomunikacijaKlijent
    {
        private Primalac primalac;
        private Posiljalac posiljalac;
        public KomunikacijaKlijent(Socket klijentSocket)
        {
            posiljalac = new Posiljalac(klijentSocket);
            primalac = new Primalac(klijentSocket);
        }


        public void PosaljiZahtev(Zahtev z)
        {
            try
            {
                posiljalac.Posalji(z);
            }
            catch (IOException ex)
            {
                throw new ServerException(ex.Message);
            }
            catch (SocketException ex)
            {

                throw new ServerException(ex.Message);
            }
        }
        public object VratiOdgovor()
        {
            Odgovor o = (Odgovor)primalac.Primi();
            if (o.UspesnoKreiranOdgovor)
            {
                return o.Rezultat;
            }
            else
            {
                throw new SystemOperationException(o.Error);
            }
        }
    }
}
