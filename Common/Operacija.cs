using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        ZapamtiStvakuTermina,
        PretraziTermin,
        PretraziTerminDatum,
        UcitajTermin
    }
}
