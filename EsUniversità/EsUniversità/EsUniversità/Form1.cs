using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EsUniversità.Controller;
using EsUniversità.Model;
namespace EsUniversità
{
    public partial class Form1 : Form
    {
        bool modifica = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestController_Click(object sender, EventArgs e)
        {
            StudentiController sc = new StudentiController();

            dataGridView1.DataSource = sc.GetAllStudenti();

            btnInsertStudente.Visible = true;
            btnUpdateStudente.Visible = true;
            btnDeleteStudente.Visible = true;

        }

        private void btnTestControllerPS_Click(object sender, EventArgs e)
        {
            PianoStudiController psc = new PianoStudiController();

            dataGridView1.DataSource = psc.GetAllPianoStudio();

            btnDatiStudente.Visible = true;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            pnlStudente.Visible = false;
            btnDatiStudente.Visible = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            StudentiController stc = new StudentiController();
            if(modifica)
            {
                stc.UpdateStudente(Convert.ToInt32(txtMatricola.Text), txtNome.Text, txtCognome.Text);
                modifica = false;            
            }
            else
                stc.PutStudente(Convert.ToInt32(txtMatricola.Text), txtNome.Text, txtCognome.Text);




            pnlStudente.Visible = false;
            btnDatiStudente.Visible = false;
        }

        private void btnDatiStudente_Click(object sender, EventArgs e)
        {
            int codicePS;

            PianoStudiController psc = new PianoStudiController();
            PianoStudi ps;



            codicePS = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            ps = psc.GetPianoStudi(codicePS);

            //txtMatricola.Text =Convert.ToString(psc.GetPianoStudi(codicePS).Matricola);
            //txtCognome.Text = psc.GetPianoStudi(codicePS).St.Cognome;
            //txtNome.Text = psc.GetPianoStudi(codicePS).St.Nome;


            txtMatricola.Text = Convert.ToString(ps.Matricola);
            txtCognome.Text = ps.St.Cognome;
            txtNome.Text = ps.St.Nome;

            pnlStudente.Visible = true;
        }

        private void btnInsertStudente_Click(object sender, EventArgs e)
        {
            txtMatricola.Text = "";
            txtCognome.Text = "";
            txtNome.Text = "";
            txtMatricola.Focus();
            pnlStudente.Visible = true;
        }

        private void btnUpdateStudente_Click(object sender, EventArgs e)
        {
            int matricola;

            StudentiController sc = new StudentiController();
            Studente st;



            matricola = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            st = sc.GetStudente(matricola);


            txtMatricola.Text = Convert.ToString(st.Matricola);
            txtCognome.Text = st.Cognome;
            txtNome.Text = st.Nome;

            pnlStudente.Visible = true;
        }

        private void btnDeleteStudente_Click(object sender, EventArgs e)
        {
            int matricola;
            StudentiController sc = new StudentiController();
            matricola = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            sc.DeleteStudente(matricola);
        }

        private void btnGsetFacoltà_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
