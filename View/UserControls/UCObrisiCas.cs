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
    public partial class UCObrisiCas : UserControl
    {
        private CasController casController;
        public DataGridView DgvSviCasovi { get => dgvSviCasovi; }
        public UCObrisiCas(CasController casController)
        {
            this.casController = casController;
            InitializeComponent();
        }

        private void UCObrisiCas_Load(object sender, EventArgs e)
        {
            casController.InitUCObrisiCas(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            casController.Delete(this);
        }
    }
}
