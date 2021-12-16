using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Gestionale_log_In
{
    public partial class frmlogIn : Form
    {
      
        List<modelStudent> lstStudenti = new List<modelStudent>();

        public frmlogIn()
        {
            InitializeComponent();
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("student.json");
            string testoFile = sr.ReadToEnd();
            sr.Close();
            lstStudenti = JsonConvert.DeserializeObject<List<modelStudent>>(testoFile);
            string isAdmin = "";
            bool trovatoUser = false;
            bool trovatoPass = false;
            int i = 0;
            foreach (modelStudent st in lstStudenti)
            {
                if (txtUsername.Text == lstStudenti[i].Username)
                {
                    trovatoUser = true;
                    isAdmin = lstStudenti[i].IsAdmin;
                }
                if (txtPassword.Text == lstStudenti[i].Password)
                {
                    trovatoPass = true;
                }
                i++;
            }

            if (trovatoUser == true && trovatoPass == true)
            {
                MessageBox.Show("WELCOME!!!");
                txtPassword.Clear();
                frmHome f1 = new frmHome();
                f1.Username = txtUsername.Text;
                f1.Password = txtPassword.Text;
                f1.IsAdmin = isAdmin;
                f1.Show();
            }
            else
            {
                MessageBox.Show(" Le credenziali di accesso sono errate o non sono presenti","ERRORE NEL LOG IN",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


            StreamReader sr2 = new StreamReader("random_student.json");
            string testo = sr2.ReadToEnd();
            sr2.Close();
            lstStudenti = JsonConvert.DeserializeObject<List<modelStudent>>(testo);
            isAdmin = "";
            trovatoUser = false;
            trovatoPass = false;
            i = 0;
            foreach (modelStudent st in lstStudenti)
            {
                if (txtUsername.Text == lstStudenti[i].Username)
                {
                    trovatoUser = true;
                    isAdmin = lstStudenti[i].IsAdmin;
                }
                if (txtPassword.Text == lstStudenti[i].Password)
                {
                    trovatoPass = true;
                }
                i++;
            }

            if (trovatoUser == true && trovatoPass == true)
            {
                MessageBox.Show("WELCOME!!!");
                txtPassword.Clear();
                frmHome f1 = new frmHome();
                f1.Username = txtUsername.Text;
                f1.Password = txtPassword.Text;
                f1.IsAdmin = isAdmin;
                f1.Show();
            }

        }

        private void frmlogIn_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
