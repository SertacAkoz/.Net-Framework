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
    public partial class FormGuncelle : Form
    {
        public FormGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanG = new SqlConnection("Data Source=DESKTOP-OT5P8L5\\SQLEXPRESS;Initial Catalog=CetinPano;Integrated Security=True");
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int Kontrol = 0;
            if (txtCizimMEKG.Text == "1" || txtCizimMEKG.Text == "0")
            {

            }
            else
                Kontrol++;
            if (txtCizimELKG.Text == "1" || txtCizimELKG.Text == "0")
            {

            }
            else
                Kontrol++;
            if (txtSiparisMEKG.Text == "1" || txtSiparisMEKG.Text == "0")
            {

            }
            else
                Kontrol++;
            if (txtSiparisELKG.Text == "1" || txtSiparisELKG.Text == "0")
            {

            }
            else
                Kontrol++;
            if (txtMalzemeMEKG.Text == "1" || txtMalzemeMEKG.Text == "0")
            {

            }
            else
                Kontrol++;
            if (txtMalzemeELKG.Text == "1" || txtMalzemeELKG.Text == "0")
            {

            }
            else
                Kontrol++;
            if (txtMontajMEKG.Text == "1" || txtMontajMEKG.Text == "0")
            {

            }
            else
                Kontrol++;
            if (txtMontajELKG.Text == "1" || txtMontajELKG.Text == "0")
            {

            }
            else
                Kontrol++;
            if (txtMikrodanCikisG.Text == "1" || txtMikrodanCikisG.Text == "0")
            {

            }
            else
                Kontrol++;
            if (txtFirmaAdiG.Text == "" || txtPanoAdiG.Text == "" || txtTerminTarihG.Text == "" || txtCizimMEKG.Text == "" || txtCizimELKG.Text == "" ||
                txtSiparisMEKG.Text == "" || txtSiparisELKG.Text == "" || txtMalzemeMEKG.Text == "" || txtMalzemeELKG.Text == "" ||
                txtMontajMEKG.Text == "" || txtMontajELKG.Text == "" || txtMikrodanCikisG.Text == "" ||
                txtPlanlananSevkTarihiG.Text == "" || rchAciklamaG.Text == "" || Kontrol>0)
            {
                MessageBox.Show("Hatalı bir değer girdiniz lütfen kontrol edip tekrar giriniz !!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                VerileriGuncelle();
        }
        
        public string bilgiGuncelle;
        public void VerileriGuncelle()
        {
            baglanG.Open();
            SqlCommand guncelle = new SqlCommand("update tblCetinPano set FirmaAdi=@p1, PanoAdi=@p2, TerminiTarih=@p3, CizimMEK=@p4," +
                " CizimELK=@p5, SiparisMEK=@p6, SiparisELK=@p7, MalzemeMEK=@p8, MalzemeELK=@p9, MontajMEK=@p10, MontajELK=@p11, " +
                "MikrodanCikis=@p12, PlanlananSevkTarihi=@p13, Aciklama=@p14 where PanoNO=@p15",baglanG);
            guncelle.Parameters.AddWithValue("@p1",txtFirmaAdiG.Text);
            guncelle.Parameters.AddWithValue("@p2",txtPanoAdiG.Text);
            guncelle.Parameters.AddWithValue("@p3",txtTerminTarihG.Text);
            guncelle.Parameters.AddWithValue("@p4",txtCizimMEKG.Text);
            guncelle.Parameters.AddWithValue("@p5",txtCizimELKG.Text);
            guncelle.Parameters.AddWithValue("@p6",txtSiparisMEKG.Text);
            guncelle.Parameters.AddWithValue("@p7",txtSiparisELKG.Text);
            guncelle.Parameters.AddWithValue("@p8",txtMalzemeMEKG.Text);
            guncelle.Parameters.AddWithValue("@p9",txtMalzemeELKG.Text);
            guncelle.Parameters.AddWithValue("@p10",txtMontajMEKG.Text);
            guncelle.Parameters.AddWithValue("@p11",txtMontajELKG.Text);
            guncelle.Parameters.AddWithValue("@p12",txtMikrodanCikisG.Text);
            guncelle.Parameters.AddWithValue("@p13",txtPlanlananSevkTarihiG.Text);
            guncelle.Parameters.AddWithValue("@p14",rchAciklamaG.Text);
            guncelle.Parameters.AddWithValue("@p15", bilgiGuncelle);
            guncelle.ExecuteNonQuery();
            baglanG.Close();
            MessageBox.Show("Veriler Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Form1 ana = new Form1();
            ana.Show();
            this.Hide();
        }

        private void FormGuncelle_Load(object sender, EventArgs e)
        {
            baglanG.Open();
            SqlCommand bilgiDoldurma = new SqlCommand("select * from tblCetinPano where PanoNO=@ad", baglanG);
            bilgiDoldurma.Parameters.AddWithValue("@ad", bilgiGuncelle);
            SqlDataReader rdr = bilgiDoldurma.ExecuteReader();
            while(rdr.Read())
            {
                txtPanoNOG.Text = rdr["PanoNO"].ToString();
                txtFirmaAdiG.Text = rdr["FirmaAdi"].ToString();
                txtPanoAdiG.Text= rdr["PanoAdi"].ToString();
                txtTerminTarihG.Text= rdr["TerminiTarih"].ToString();
                txtCizimMEKG.Text= rdr["CizimMEK"].ToString();
                txtCizimELKG.Text= rdr["CizimELK"].ToString();
                txtSiparisMEKG.Text= rdr["SiparisMEK"].ToString();
                txtSiparisELKG.Text= rdr["SiparisELK"].ToString();
                txtMalzemeMEKG.Text= rdr["MalzemeMEK"].ToString();
                txtMalzemeELKG.Text= rdr["MalzemeELK"].ToString();
                txtMontajMEKG.Text= rdr["MontajMEK"].ToString();
                txtMontajELKG.Text= rdr["MontajELK"].ToString();
                txtMikrodanCikisG.Text= rdr["MikrodanCikis"].ToString();
                txtPlanlananSevkTarihiG.Text= rdr["PlanlananSevkTarihi"].ToString();
                rchAciklamaG.Text= rdr["Aciklama"].ToString();
            }
            baglanG.Close();
        }

        private void txtTerminTarihG_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
