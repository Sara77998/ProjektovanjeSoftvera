using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.ClientController;

namespace View
{
    public partial class FrmLogin : Form
    {
        private LoginController loginController;
        public FrmLogin()
        {
            InitializeComponent();
        }
        public FrmLogin(FrmLogin loginController)
        {
            //this.loginController = loginController;
            InitializeComponent();
            txtKorisnickoIme.Text = "ana";
            txtLozinka.Text = "ana1";
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            if (loginController.PoveziSe())
            {
                loginController.Login(txtKorisnickoIme, txtLozinka, this);// zasto ovde prosledjujemo this
            }
                
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
