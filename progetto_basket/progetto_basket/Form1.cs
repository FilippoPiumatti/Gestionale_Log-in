using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace progetto_basket
{
    public partial class Form1 : Form
    {
        volatile object lock_campo = new object();
        volatile Random rnd = new Random();

        Thread Arbitro;
        const int TOTALE_TIRI = 10;
        const int PALLONE_X = 377;
        const int PALLONE_Y = 62;
        const int PALLONE_CENTRO_X = 359;
        const int PALLONE_CENTRO_Y = 247;
        const int PALLONE_CANESTRO_Y = 412;
        const int score1=0, score2=0;
        volatile Dictionary<int, string> GestoreGiocatori;
        volatile int[] punteggio = new int[2]; // array del punteggio

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAvvia_Click(object sender, EventArgs e)
        {
            GestoreGiocatori = new Dictionary<int, string>();
            if (txtGiocatore1.Text == "" || txtGiocatore2.Text == "")
            {
                MessageBox.Show("ERRORE: NON HA INSERITO IL NOME DI UN GIOCATORE","ERRORE DI SISTEMA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            ptbPalla.Location = new Point(PALLONE_X, PALLONE_Y);

            lblStatus.Text = txtGiocatore1.Text + " ( " + score1 + " - " + score2 + " ) " + txtGiocatore2.Text;
            Arbitro = new Thread(EseguiTurno);
            Arbitro.Start();
        }

        private void EseguiTurno()
        {
            
        }
    }
}
