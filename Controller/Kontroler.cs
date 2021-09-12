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

        public List<Product> GetAllProducts()
        {
            GetAllProductsSO so = new GetAllProductsSO();
            so.ExecuteTemplate(new Product());
            return so.Result;
        }

        

        public void SaveAutomobil(Automobil automobil)
        {
            ZapamtiAutomobilSO so = new ZapamtiAutomobilSO();
            so.ExecuteTemplate(automobil);
        }

        public List<Marka> GetAllMarka()
        {
            VratiListuMarkiSO so = new VratiListuMarkiSO();
            so.ExecuteTemplate(new Marka());
            return so.Result;
        }

        public List<Automobil> GetAllAutomobil()
        {
            VratiListuAutomobilaSO so = new VratiListuAutomobilaSO();
            so.ExecuteTemplate(new Automobil());
            return so.Result;
        }

        public List<Model> GetAllModel()
        {
            VratiListuModelaSO so = new VratiListuModelaSO();
            so.ExecuteTemplate(new Model());
            return so.Result;
        }

        public List<Model> SearchModel(Model model)
        {

            VratiModelePoKriterijumuSO so = new VratiModelePoKriterijumuSO();
            so.ExecuteTemplate(model);
            return so.Result;
        }



        public void SaveStavkaRentiranja(StavkaRentiranja stavkaRentirnja)
        {
            ZapamtiStavkuRentiranjaSO so = new ZapamtiStavkuRentiranjaSO();
            so.ExecuteTemplate(stavkaRentirnja);

        }

        public void DeleteStavkaRentiranja(StavkaRentiranja stavkaRentiranja)
        {
            IzbrisiStavkaRentiranjaSO so = new IzbrisiStavkaRentiranjaSO();
            so.ExecuteTemplate(stavkaRentiranja);
        }




        public List<Musterija> SearchMusterija(Musterija musterija)
        {
            VratiMusterijePoKriterijumuSO so = new VratiMusterijePoKriterijumuSO();
            so.ExecuteTemplate(musterija);
            return so.Result;
        }

        public List<Rentiranje> SearchRentiranje(Rentiranje rentiranje)
        {
            VratiRentiranjePoKriterijumuSO so = new VratiRentiranjePoKriterijumuSO();
            so.ExecuteTemplate(rentiranje);
            return so.Result;
        }

        public List<Automobil> SearchAutomobil(Automobil automobil)
        {
            VratiAutomobilePoKriterijumuSO so = new VratiAutomobilePoKriterijumuSO();
            so.ExecuteTemplate(automobil);
            return so.Result;
        }

        public object GetAllMusterija()
        {
            UcitajListuMusterijaSO so = new UcitajListuMusterijaSO();
            so.ExecuteTemplate(new Musterija());
            return so.Result;
        }

        public void SaveRentiranje(Rentiranje rentiranje)
        {
            ZapamtiRentiranjeSO so = new ZapamtiRentiranjeSO();
            so.ExecuteTemplate(rentiranje);
        }

        public object GetAllPolisa()
        {
            UcitajListuPolisaSO so = new UcitajListuPolisaSO();
            so.ExecuteTemplate(new Polisa());
            return so.Result;
        }

        public void UpdateMusterija(Musterija musterija)
        {
            IzmeniMusterijuSO so = new IzmeniMusterijuSO();
            so.ExecuteTemplate(musterija);

        }

        public void UpdateRentiranje(Rentiranje rentiranje)
        {
            IzmeniRentiranjeSO so = new IzmeniRentiranjeSO();
            so.ExecuteTemplate(rentiranje);

        }

        public void UpdateAutomobil(Automobil automobil)
        {

            IzmeniAutomobilSO so = new IzmeniAutomobilSO();
            so.ExecuteTemplate(automobil);

        }



        public object SearchStavkaReniranja(StavkaRentiranja stavkaRentiranja)
        {
            VratiStavkarentiranjaPoKriterijumuSO so = new VratiStavkarentiranjaPoKriterijumuSO();
            so.ExecuteTemplate(stavkaRentiranja);
            return so.Result;
        }

        public void DeleteAutomobil(Automobil automobil)
        {
            IzbrisiAutomobilSO so = new IzbrisiAutomobilSO();
            so.ExecuteTemplate(automobil);

        }





    }
}
