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
    public partial class UCSviTermini : UserControl
    {
        private TerminController terminController;
        public DataGridView DgvSviTerminiSaUcenicima { get => dgvSviTerminiSaUcenicima; }
        public UCSviTermini(TerminController terminController)
        {
            InitializeComponent();
            this.terminController = terminController;
        }

        private void UCSviTermini_Load(object sender, EventArgs e)
        {
            terminController.InitUCSviTermini(this);
        }

        private void dgvSviTerminiSaUcenicima_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
