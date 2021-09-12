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
    public partial class UCDodajCas : UserControl
    {
        public TextBox TxtStazaLokacija { get => txtStazaLokacija; }
        public ComboBox CmbTezinaCasa { get => cmbTezinaCasa; }
        public TextBox TxtCena { get => txtCena; }


        public Label LblStazaLokacija { get => lblStazaLokacija; }
        public Label LblTezinaCasa { get => lblTezinaCasa; }
        public Label LblCena { get => lblCena; }
        public UCDodajCas(CasController casController)
        {
            InitializeComponent();
            this.casController = casController
        }

        private void UCDodajCas_Load(object sender, EventArgs e)
        {
            casController = InitUCDodajCas(this);
        }

        private void btnSacuvajCas_Click(object sender, EventArgs e)
        {
            casController.Save(this);
        }
    }
}
