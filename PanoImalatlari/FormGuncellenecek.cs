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
    public partial class FormGuncellenecek : Form
    {
        public FormGuncellenecek()
        {
            InitializeComponent();
        }
        FormGuncelle fr = new FormGuncelle();
        SqlConnection baglanG = new SqlConnection("Data Source=DESKTOP-OT5P8L5\\SQLEXPRESS;Initial Catalog=CetinPano;Integrated Security=True");
        public void Guncellenecek()
        {
            baglanG.Open();
            SqlCommand guncelle = new SqlCommand("select * from tblCetinPano where PanoNO=@p1", baglanG);
            guncelle.Parameters.AddWithValue("@p1", txtGuncellenecek.Text);
            SqlDataReader dr = guncelle.ExecuteReader();
            if(dr.Read())
            {
                this.Hide();
                fr.bilgiGuncelle = txtGuncellenecek.Text;
                fr.ShowDialog();
                
            }
            else
                MessageBox.Show("Hatali giris yaptiniz !!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanG.Close();
        }
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            
            Guncellenecek();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form1 geri = new Form1();
            geri.Show();
            this.Hide();
        }

        private void FormGuncellenecek_Load(object sender, EventArgs e)
        {

        }
    }
}
