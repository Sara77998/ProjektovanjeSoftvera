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

namespace View.UserControls
{
    public partial class UCObrisiUcenika : UserControl
    {
        private UcenikController ucenikController;
        public DataGridView DgvSviUcenici { get => dgvSviUcenici; }
        public UCObrisiUcenika(UcenikController ucenikController)
        {
            this.ucenikController = ucenikController;
            InitializeComponent();
        }

        private void UCObrisiUcenika_Load(object sender, EventArgs e)
        {
            
            ucenikController.InitUCObrisiUcenika(this);
        }

        private void btnObrisiUcenika_Click(object sender, EventArgs e)
        {
            ucenikController.Delete(this);
        }
    }
}
