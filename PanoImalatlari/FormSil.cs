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
    public partial class FormSil : Form
    {
        public FormSil()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-OT5P8L5\\SQLEXPRESS;Initial Catalog=CetinPano;Integrated Security=True");
        
        public void Silinecek()
        {
            baglan.Open();
            SqlCommand kontrol = new SqlCommand("select * from tblCetinPano where PanoNO=@p2", baglan);
            kontrol.Parameters.AddWithValue("@p2", txtSilinecek.Text);
            SqlCommand sil = new SqlCommand("delete from tblCetinPano where PanoNO=@p1", baglan);
            sil.Parameters.AddWithValue("@p1", txtSilinecek.Text);
            SqlDataReader dr = kontrol.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                sil.ExecuteNonQuery();
                MessageBox.Show("Pano silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 ac = new Form1();
                ac.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Hatali giris yaptiniz !!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglan.Close();
        }
        private void FormSil_Load(object sender, EventArgs e)
        {

        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            Silinecek();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form1 geri = new Form1();
            geri.Show();
            this.Hide();
        }
    }
}
