using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
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
                FrmGlavna frmGlavna = new FrmGlavna(i);
                frmGlavna.ShowDialog();
                frmLogin.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
