using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Storage;
using Storage.Implementation.Database;
using SystemOperations;
using SystemOperations.InstruktorSO;

namespace Controller
{
    public class Kontroler
    {
        private GenericRepository repository;
        public Instruktor Instruktor { get; set; }


        private static Kontroler instance;

        private static object _lock = new object();
        public static Kontroler Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new Kontroler();
                        }
                    }
                }
                return instance;
            }
        }

        private Kontroler()
        {
            repository = new GenericRepository();
        }

        public Instruktor Login(Instruktor instruktor)
        {
            LoginSO so = new LoginSO();
            so.ExecuteTemplate(instruktor);
            return so.Rezulat;
        }
        //SVE SISTEMSKE OPERACIJE JA MISLIM
        public void SaveUcenik(Ucenik ucenik)
        {
            ZapamtiUcenikaSO so = new ZapamtiUcenikaSO();
            so.ExecuteTemplate(ucenik);
        }
        public List<Ucenik> SearchUcenika(Ucenik ucenik)
        {
            VratiUcenikePoKriterijumuSO so = new VratiUcenikaPoKriterijumuSO();
            so.ExecuteTemplate(ucenik);
            return so.Result;
        }
        public object GetAllUcenik()
        {
            UcitajUcenikeSO so = new UcitajUcenikeSO();
            so.ExecuteTemplate(new Ucenik());
            return so.Result;
        }
        public void DeleteUcenik(Ucenik ucenik)
        {
            ObrisiUcenikaSO so = new ObrisiUcenikaSO();
            so.ExecuteTemplate(ucenik);

        }
        //***************************************************************
        public void SaveCas(Cas cas)
        {
            ZapamtiCasSO so = new ZapamtiCasSO();
            so.ExecuteTemplate(cas);
        }
        public List<Cas> SearchCas(Cas cas)
        {
            VratiCasovePoKriterijumuSO so = new VratiCasovePoKriterijumuSO();
            so.ExecuteTemplate(cas);
            return so.Result;
        }
        public object GetAllCas()
        {
            UcitajCasoveSO so = new UcitajCasoveSO();
            so.ExecuteTemplate(new Cas());
            return so.Result;
        }
        public void DeleteCas(Cas cas)
        {
            ObrisiCasSO so = new ObrisiCasSO();
            so.ExecuteTemplate(cas);

        }
        //*********************************************
        public void SaveTermin(Cas cas)
        {
            ZapamtiTerminSO so = new ZapamtiTerminSO();
            so.ExecuteTemplate(cas);
        }
        public List<Cas> SearchTermin(Termin termin)
        {
            VratiTerminePoKriterijumuSO so = new VratiTerminePoKriterijumuSO();
            so.ExecuteTemplate(termin);
            return so.Result;
        }
        public object GetAllTermin()
        {
            UcitajTerminSO so = new UcitajTerminSO();
            so.ExecuteTemplate(new Termin());
            return so.Result;
        }
        //****************************************************
        public void UpdateTermin(Termin termin)
        {
            PromenaTerminaSO so = new PromenaTerminaSO();
            so.ExecuteTemplate(termin);

        }
        //**********************************************
        public void SaveStavkaTermina(StavkaTermina stavkaTermina)
        {
            ZapamtiStavkuTerminaSO so = new ZapamtiStavkuTerminaSO();
            so.ExecuteTemplate(stavkaTermina);

        }
        public void DeleteStavkaTermina(StavkaTermina stavkaTermina)
        {
            ObrisiStavkuTerminaSO so = new ObrisiStavkuTerminaSO();
            so.ExecuteTemplate(stavkaTermina);
        }


        ////////////////////////////////

        

        
        //public void UpdateAutomobil(Automobil automobil)
        //{

        //    IzmeniAutomobilSO so = new IzmeniAutomobilSO();
        //    so.ExecuteTemplate(automobil);

        //}



        





    }
}
