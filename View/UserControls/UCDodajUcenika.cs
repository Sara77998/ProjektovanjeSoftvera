using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.UserControls
{
    public partial class UCDodajUcenika : UserControl
    {
        private UcenikController ucenikController;

        
        public TextBox TxtIme { get => txtIme; }
        public TextBox TxtPrezime { get => txtPrezime; }     
        public DateTimePicker DtpDatumRodjenja { get => dtpDatumRodjenja; }
        public TextBox TxtTelefon { get => txtTelefon; }
        public TextBox TxtEmail { get => txtEmail; }


        public Label LblIme { get => lblIme; set { } }
        public Label LblPrezime { get => lblPrezime; set { } }
        public Label LblDatumRodjenja { get => lblDatumRodjenja; set { } }
        public Label LblTelefon { get => lblTelefon; set { } }
        public Label LblEmail { get => lblEmail; set { } }


        public UCDodajUcenika(UcenikController ucenikController)
        {
            InitializeComponent();
            this.ucenikController = ucenikController;
        }

        private void btnSacuvajUcenika_Click(object sender, EventArgs e)
        {
            ucenikController.Save(this);
        }
    }
}
