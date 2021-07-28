using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PanoImalatlari
{
    public partial class FormBilgi : Form
    {
        public FormBilgi()
        {
            InitializeComponent();

        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-OT5P8L5\\SQLEXPRESS;Initial Catalog=CetinPano;Integrated Security=True");

        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string firmaAdi;
            string panoAdi;
            string terminiTarih;
            string planlananSevkTarihi;
            string aciklama;
            firmaAdi = txtFirmaAdi.Text;
            panoAdi = txtPanoAdi.Text;
            terminiTarih = txtTerminTarih.Text;
            planlananSevkTarihi = txtPlanlananSevkTarihi.Text;
            aciklama = rchAciklama.Text;
            int Kontrol = 0;
            if (txtCizimMEK.Text == "1" || txtCizimMEK.Text == "0")
            {

            }
            else
                Kontrol++;
            if (txtCizimELK.Text == "1" || txtCizimELK.Text == "0")
            {

            }
            else
                Kontrol++;
            if (txtSiparisMEK.Text == "1" || txtSiparisMEK.Text == "0")
            {

            }
            else
                Kontrol++;
            if (txtSiparisELK.Text == "1" || txtSiparisELK.Text == "0")
            {

            }
            else
                Kontrol++;
            if (txtMalzemeMEK.Text == "1" || txtMalzemeMEK.Text == "0")
            {

            }
            else
                Kontrol++;
            if (txtMalzemeELK.Text == "1" || txtMalzemeELK.Text == "0")
            {

            }
            else
                Kontrol++;
            if (txtMontajMEK.Text == "1" || txtMontajMEK.Text == "0")
            {

            }
            else
                Kontrol++;
            if (txtMontajELK.Text == "1" || txtMontajELK.Text == "0")
            {

            }
            else
                Kontrol++;
            if (txtMikrodanCikis.Text == "1" || txtMikrodanCikis.Text == "0")
            {

            }
            else
                Kontrol++;
            if (txtFirmaAdi.Text == "" || txtPanoAdi.Text == "" || txtTerminTarih.Text == "" || txtCizimMEK.Text == "" || txtCizimELK.Text == "" ||
                txtSiparisMEK.Text == "" || txtSiparisELK.Text == "" || txtMalzemeMEK.Text == "" || txtMalzemeELK.Text == "" ||
                txtMontajMEK.Text == "" || txtMontajELK.Text == "" || txtMikrodanCikis.Text == "" || rchAciklama.Text == "" || Kontrol>0)
            {
                MessageBox.Show("Hatalı bir değer girdiniz lütfen kontrol edip tekrar giriniz !!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO tblCetinPano  (FirmaAdi,PanoNO,PanoAdi,TerminiTarih,CizimMEK,CizimELK,SiparisMEK,SiparisELK,MalzemeMEK,MalzemeELK,MontajMEK,MontajELK,MikrodanCikis,PlanlananSevkTarihi,Aciklama) VALUES ('" + txtFirmaAdi.Text + "','"
                    + txtPanoNO.Text + "','" + txtPanoAdi.Text + "','" + txtTerminTarih.Text + "','" + txtCizimMEK.Text + "','" + txtCizimELK.Text + "','" + txtSiparisMEK.Text + "','" + txtSiparisELK.Text + "','" + txtMalzemeMEK.Text + "','" + txtMalzemeELK.Text + "','"
                    + txtMontajMEK.Text + "','" + txtMontajELK.Text + "','" + txtMikrodanCikis.Text + "','" + txtPlanlananSevkTarihi.Text + "','" + rchAciklama.Text + "')", baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
                Form1 frmac = new Form1();
                frmac.Show();
                this.Hide();
            }
        }

        private void FormBilgi_Load(object sender, EventArgs e)
        {
             
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form1 geri = new Form1();
            geri.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btndeneme_Click(object sender, EventArgs e)
        {
            
        }

        private void btndeneme_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
