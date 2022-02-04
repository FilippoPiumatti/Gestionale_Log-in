using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EsUniversità.Controller;
using Newtonsoft.Json;

namespace EsUniversità
{
    public partial class Form2 : Form
    {
        FacoltàController f_Controller;
        LaureaController l_Controller;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnVisLauree_Click(object sender, EventArgs e)
        {
            int codFac = Convert.ToInt32(dgvFac.SelectedRows[0].Cells[0].Value);
            dgvLauree.DataSource = f_Controller.GetFacoltà(codFac).LstLauree;

            dgvLauree.Visible = true;
            btnNascondi.Visible = true;
        }

        private void btnNascondi_Click(object sender, EventArgs e)
        {
            dgvLauree.Visible = false;
            btnNascondi.Visible = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            pnlFacoltà.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            f_Controller = new FacoltàController();
            l_Controller = new LaureaController();

            dgvFac.DataSource = f_Controller.GetAllFacoltà();
        }

        private void btnInsertFac_Click(object sender, EventArgs e)
        {
            txtCodFac.Text = "";
            txtNomeFac.Text = "";
            txtIndFac.Text = "";
            txtCodFac.Focus();

            pnlFacoltà.Visible = true;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            pnlFacoltà.Visible = false;
        }

        private void btnLaurea_Click(object sender, EventArgs e)
        {
            txtL1.Text = "";
            txtN.Text = "";
            txtC.Text = "";
            txtL1.Focus();
           
        }

        private void btnInsertLaurea_Click(object sender, EventArgs e)
        {
            List<FacoltàController> lstf = new List<FacoltàController>();
            pnlLaurea.Visible = true;
            string testo;
            StreamReader sr = new StreamReader("facoltà.json");
            testo = sr.ReadToEnd();
            lstf = JsonConvert.DeserializeObject<List<FacoltàController>>(testo);

            cmbFacolta.Items.Add(lstf);

        }
    }
}
