using Domain;
using System;
using View.ClientController;

namespace View
{
    public class MainCoordinator
    {
        private MainController mainController = new MainController();
        private LoginController loginController = new LoginController();
        private FrmLogin frmLogin;
        private FrmGlavna frmGlavna;

        public Instruktor Instruktor { get; set; }

        private static MainCoordinator instance;
        private MainCoordinator() { }

        public static MainCoordinator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainCoordinator();
                }
                return instance;
            }
        }

     

        public void OpenMainForm()
        {
            frmGlavna = new FrmGlavna(mainController);
            frmGlavna.Show();
        }

        internal void OpenFrmLogin()
        {
            frmLogin = new FrmLogin(loginController);
            frmLogin.Show();
        }
    }
}
}
