using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Server
{
    public partial class FrmServer : Form
    {
        Server s;
        public FrmServer()
        {
            InitializeComponent();
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
            btnPokreniServer.Enabled = true;
            btnZaustaviServer.Enabled = false;
            lblStanjeServera.Text = "Server nije pokrenut";
            lblStanjeServera.ForeColor = Color.Red;



            Timer timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblVreme.Text = "Timer " + DateTime.Now.ToString("dd. MM. yyyy. HH:mm:ss");
        }



        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Environment.Exit(0);
        }

        private void btnPokreniServer_Click(object sender, EventArgs e)
        {
            try
            {
                s = new Server();
                Thread thread = new Thread(s.Pokreni);
                thread.IsBackground = true;
                thread.Start();
                btnPokreniServer.Enabled = false;
                btnZaustaviServer.Enabled = true;
                lblStanjeServera.Text = "Server je pokrenut";
                lblStanjeServera.ForeColor = Color.Green;
                s.Instruktori.ListChanged += Instruktori_ListChanged;
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Instruktori_ListChanged(object sender, ListChangedEventArgs e)
        {
            dgvPregledTermina.Invoke(new Action(() => dgvPregledTermina.DataSource = s.Instruktori.ToList()));
        }

        private void btnZaustaviServer_Click(object sender, EventArgs e)
        {
            s.Zaustavi();
            btnPokreniServer.Enabled = true;
            btnZaustaviServer.Enabled = false;
            lblStanjeServera.Text = "Server nije pokrenut";
            lblStanjeServera.ForeColor = Color.Red;
        }
    }
}
