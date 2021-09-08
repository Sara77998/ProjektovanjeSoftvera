using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Common
{
    [Serializable]
    public class Odgovor
    {
        public bool UspesnoKreiranOdgovor { get; set; }
        public object Rezultat { get; set; }
        public string Error { get; set; }
    }
}
