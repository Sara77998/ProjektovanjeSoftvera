using System;

namespace Common
{
    [Serializable]
    public enum Operacija
    {
        Login,
        ZapamtiUcenika,
        PretraziUcenika,
        PretraziUcenikaIme,
        PretraziUcenikaPrezime,
        PrikaziUcenika,
        ObrisiUcenika,
        ZapamtiCas,
        PretraziCas,
        PretraziCasStazaLokacija,
        PretraziCasTezina,
        ObrisiCas,
        UcitajCasove,
        UcitajUcenika,
        KreirajTermin,
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
