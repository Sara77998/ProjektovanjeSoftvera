using System;
using System.Windows.Forms;
using View.ClientController;

namespace View
{
    public partial class FrmLogin : Form
    {
        private LoginController loginController;
        public FrmLogin(LoginController loginController)
        {
            this.loginController = loginController;
            InitializeComponent();
            //txtKorisnickoIme.Text = "sara";
            //txtLozinka.Text = "sara";
        }
       

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            
                loginController.Login(txtKorisnickoIme, txtLozinka, this);
            

        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            loginController.PoveziSe();
        }
    }
}
