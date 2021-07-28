using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanoImalatlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void btnBilgi_Click(object sender, EventArgs e)
        {
            FormBilgi frmBilgi = new FormBilgi();
            frmBilgi.Show(); 
            this.Hide();

        }

        private void btnGrid_Click(object sender, EventArgs e)
        {
            DataGrid frmdata = new DataGrid();
            frmdata.Show();
            this.Hide();
        }

        private void btnRevize_Click(object sender, EventArgs e)
        {
            FormGuncellenecek fr = new FormGuncellenecek();
            fr.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnFirmaGoster_Click(object sender, EventArgs e)
        {
            FormAra frmara = new FormAra();
            frmara.Show();
            this.Hide();
        }

        private void btnFormBiten_Click(object sender, EventArgs e)
        {
            FormBiten frr = new FormBiten();
            frr.Show();
            this.Hide();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            FormSil sil = new FormSil();
            sil.Show();
            this.Hide();
        }
    }
}
