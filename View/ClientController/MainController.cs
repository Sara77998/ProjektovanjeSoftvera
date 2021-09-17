using System;
using View.Communication;
using View.UserControls;
using View.ClientController;

namespace View.ClientController
{
    public class MainController
    {
        internal void CloseFrmGlavna()
        {
            Komunikacija.Instance.Disconnect();
            MainCoordinator.Instance.OpenFrmLogin();
        }

        internal void OpenUCDodajUcenika(FrmGlavna frmGlavna)
        {
            frmGlavna.SetPanel(new UCDodajUcenika(new UcenikController()));
        }

        internal void OpenUCPronadjiUcenika(FrmGlavna frmGlavna)
        {
            frmGlavna.SetPanel(new UCPronadjiUcenika(new UcenikController()));
        }

        internal void OpenUCObrisiUcenika(FrmGlavna frmGlavna)
        {
            // frmGlavna.SetPanel(new UCObrisiUcenika(new UcenikController()));
        }

        internal void OpenUCDodajCas(FrmGlavna frmGlavna)
        {
            frmGlavna.SetPanel(new UCDodajCas(new CasController()));
        }



        internal void OpenUCObrisiCas(FrmGlavna frmGlavna)
        {
            // throw new NotImplementedException();
        }

        internal void OpenUCPRonadjiCas(FrmGlavna frmGlavna)
        {
            frmGlavna.SetPanel(new UCPronadjiCas(new CasController()));
        }

        internal void OpenUCDodajTermin(FrmGlavna frmGlavna)
        {
            frmGlavna.SetPanel(new UCDodajTermin(new TerminController()));
        }

        internal void OpenUCPromeniTermin(FrmGlavna frmGlavna)
        {
            frmGlavna.SetPanel(new UCPromeniTermin(new TerminController()));

        }
    }
}
