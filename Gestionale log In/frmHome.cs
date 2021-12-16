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
    public partial class frmHome : Form
    {

        private string password;
        private string username;
        private string isAdmin;
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string IsAdmin { get => isAdmin; set => isAdmin = value; }

        List<modelStudent> lstStud = new List<modelStudent>();
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            
            StreamReader sr2 = new StreamReader("student.json");
            string testo = sr2.ReadToEnd();
            sr2.Close();
            richTextBox1.Text = testo;

            lstStud = JsonConvert.DeserializeObject<List<modelStudent>>(testo);
            lblCognome.Text = Username;
            lblIsAdmin.Text = IsAdmin;

            StreamReader sr = new StreamReader("random_student.json");
            string testoFile = sr.ReadToEnd();
            sr.Close();
            rtbC.Text = testoFile;

            lstStud = JsonConvert.DeserializeObject<List<modelStudent>>(testoFile);
            lblCognome.Text = Username;
            lblIsAdmin.Text = IsAdmin;


        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateNewUser_Click(object sender, EventArgs e)
        {
            if (lblIsAdmin.Text == "yes") 
            {
                frmCreate frm = new frmCreate();
                frm.Show();
            }
            else
            {
                MessageBox.Show("you dont have permission..");
            }
           
        }
    }
}
