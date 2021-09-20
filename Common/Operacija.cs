using System;

namespace Common
{
    [Serializable]
    public enum Operacija
    {
        Login,
        ZapamtiUcenika,
        PretraziUcenika,
        PrikaziUcenika,
        ObrisiUcenika,
        ZapamtiCas,
        PretraziCas,
        ObrisiCas,
        UcitajCasove,
        UcitajUcenika,
        
        ZapamtiTermin,
        IzmeniTermin,
        ZapamtiStvakuTermina,
        PretraziTermin,
        PretraziTerminDatum,
        UcitajTermin,
        ObrisiStavkuTermina,
        UcitajInstruktore
    }
}
