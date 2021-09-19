using Domain;
using System;
using System.Windows.Forms;
using View.Communication;

namespace View.ClientController
{
    public class LoginController
    {
        public bool PoveziSe()
        {
            return Komunikacija.Instance.PoveziSe();
        }
        public void Login(TextBox txtKorisnickoIme, TextBox txtLozinka, FrmLogin frmLogin)
        {

            if (!UserControlHelpers.UCHelpers.PraznoPoljeValidacija(txtKorisnickoIme) | !UserControlHelpers.UCHelpers.PraznoPoljeValidacija(txtLozinka))
            {
                return;
            }
            try
            {
                Instruktor i = Komunikacija.Instance.PrijaviSe(txtKorisnickoIme.Text, txtLozinka.Text);
                MainCoordinator.Instance.Instruktor = i;
                MessageBox.Show($"Dobrodošao {i.Ime} {i.Prezime}");
                MainCoordinator.Instance.OpenMainForm();
                frmLogin.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
