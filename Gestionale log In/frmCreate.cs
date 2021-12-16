using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Gestionale_log_In
{
    public partial class frmCreate : Form
    {
        List<modelStudent> lstS = new List<modelStudent>(); 
        public frmCreate()
        {
            InitializeComponent();
        }

       

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtNat.Text == "" || txtMatricola.Text == "" || txtLast.Text == ""
                || txtIsAdmin.Text == "" || txtId.Text == ""
                || txtGender.Text == "" || txtFirst.Text == "" || txtEmail.Text == "" || txtCountry.Text == ""
                || txtCity.Text == "" || txtCell.Text == "" || txtAge.Text == "" || txtUsername.Text == ""
                || txtTitle.Text == "" || txtStreet.Text == "" || txtState.Text == "" || txtPostcode.Text == "")
            {
                MessageBox.Show("campo mancante o errato..");
            }
            else
            {
                modelStudent st = new modelStudent();
                st.Age = Convert.ToInt32(txtAge.Text);
                st.Cell = txtCell.Text;
                st.City = txtCity.Text;
                st.Country = txtCountry.Text;
                st.Email = txtEmail.Text;
                st.First = txtFirst.Text;
                st.Gender = txtGender.Text;
                st.Id = txtId.Text;
                st.IsAdmin = txtIsAdmin.Text;
                st.Last = txtLast.Text;
                st.Matricola = Convert.ToInt32(txtMatricola.Text);
                st.Nat = txtNat.Text;
                st.Password = txtPassword.Text;
                st.Postcode = txtPostcode.Text;
                st.State = txtState.Text;
                st.Street = txtStreet.Text;
                st.Title = txtTitle.Text;
                st.Username = txtUsername.Text;

                lstS.Add(st);
                string jsonAggiornato = JsonConvert.SerializeObject(lstS);
                StreamWriter sw = new StreamWriter("student.json");
                sw.Write(jsonAggiornato);
                sw.Close();


                MessageBox.Show("user creation was a success!");
            }
           
        }

        private void frmCreate_Load(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtNat.Text = "";
            txtMatricola.Text = "";
            txtLast.Text = "";
            txtIsAdmin.Text = "";
            txtId.Text = "";
            txtGender.Text = "";  
            txtFirst.Text = "";  
            txtEmail.Text = "";  
            txtCountry.Text = "";
            txtCity.Text = "";  
            txtCell.Text = "";  
            txtAge.Text = "";  
            txtUsername.Text = "";
            txtTitle.Text = "";  
            txtStreet.Text = "";  
            txtState.Text = "";  
            txtPostcode.Text = "";
        }
    }
}
