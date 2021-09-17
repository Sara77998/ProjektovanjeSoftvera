using System;

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
