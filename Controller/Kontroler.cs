using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseBroker;
using Domain;

namespace Controller
{
    public class Kontroler
    {
        private Broker broker = new Broker();
        public Kontroler()
        {
            
        }
        private static Kontroler instance;
        public static Kontroler Instance
        {
            get
            {
                if (instance == null) instance = new Kontroler();
                return instance;
            }
        }

        public Instruktor Login(Instruktor instruktor)
        {

            //foreach (Instruktor i in broker.VratiSve())
            //{
            //    if (u.Username == user.Username && u.Password == user.Password)
            //    {
            //        User = u;
            //        return u;
            //    }
            //}
            //throw new Exception("Login failed!");
        }
    }
}
