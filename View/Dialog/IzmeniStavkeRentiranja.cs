using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace View.Dialog
{
    public partial class IzmeniStavkeRentiranja : Form
    {
        public IzmeniStavkeRentiranja(Termin termin)
        {
            InitializeComponent();
            txtDatum.Text = termin.DatumIVreme.ToString();
            txtInstruktor.Text = termin.Instruktor.Prezime;
            txtInstruktor.Text = termin.CasId.StazaLokacija;
            dgvIzmeniStavke.DataSource = termin.StavkeTermina;

        }
    }
}
