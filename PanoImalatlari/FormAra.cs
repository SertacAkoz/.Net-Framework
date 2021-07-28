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
    public partial class FormAra : Form
    {
        public FormAra()
        {
            InitializeComponent();
        }

        private void FormAra_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cetinPanoDataSet.tblCetinPano' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-OT5P8L5\\SQLEXPRESS;Initial Catalog=CetinPano;Integrated Security=True");
        DataSet daset = new DataSet();
        private void araToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void Ara()
        {
            baglan.Open();
            SqlCommand Ara = new SqlCommand("select * from tblCetinPano where FirmaAdi=@p1", baglan);
            Ara.Parameters.AddWithValue("@p1", txtAranacak.Text);
            SqlDataAdapter adtr = new SqlDataAdapter();
            adtr.SelectCommand = Ara;
            adtr.Fill(daset, "tblCetinPano");
            dataGridView1.DataSource = daset.Tables["tblCetinPano"];
            baglan.Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 geri = new Form1();
            geri.Show();
            this.Hide();
        }
        int a = 0;
        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtAranacak.Text=="")
                MessageBox.Show("Lütfen Firma Adı Giriniz !!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                for (int i = 1; i <3 ; i++)
                {
                    if (a + i >= a && i != 1)
                        daset.Clear();
                }
                Ara();
                a++;
            }
            
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[i].DefaultCellStyle.BackColor = Color.LightBlue;
            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                //dataGridView1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                if (int.Parse(dataGridView1.Rows[i].Cells["SiparisMEK"].Value.ToString()) == 1)
                {
                    dataGridView1.Rows[i].Cells["SiparisMEK"].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    dataGridView1.Rows[i].Cells["SiparisMEK"].Style.BackColor = Color.PaleVioletRed;
                }
                if (int.Parse(dataGridView1.Rows[i].Cells["CizimMEK"].Value.ToString()) == 1)
                {
                    dataGridView1.Rows[i].Cells["CizimMEK"].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    dataGridView1.Rows[i].Cells["CizimMEK"].Style.BackColor = Color.PaleVioletRed;
                }
                if (int.Parse(dataGridView1.Rows[i].Cells["CizimELK"].Value.ToString()) == 1)
                {
                    dataGridView1.Rows[i].Cells["CizimELK"].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    dataGridView1.Rows[i].Cells["CizimELK"].Style.BackColor = Color.PaleVioletRed;
                }
                if (int.Parse(dataGridView1.Rows[i].Cells["SiparisELK"].Value.ToString()) == 1)
                {
                    dataGridView1.Rows[i].Cells["SiparisELK"].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    dataGridView1.Rows[i].Cells["SiparisELK"].Style.BackColor = Color.PaleVioletRed;
                }
                if (int.Parse(dataGridView1.Rows[i].Cells["MalzemeELK"].Value.ToString()) == 1)
                {
                    dataGridView1.Rows[i].Cells["MalzemeELK"].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    dataGridView1.Rows[i].Cells["MalzemeELK"].Style.BackColor = Color.PaleVioletRed;
                }
                if (int.Parse(dataGridView1.Rows[i].Cells["MalzemeMEK"].Value.ToString()) == 1)
                {
                    dataGridView1.Rows[i].Cells["MalzemeMEK"].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    dataGridView1.Rows[i].Cells["MalzemeMEK"].Style.BackColor = Color.PaleVioletRed;
                }
                if (int.Parse(dataGridView1.Rows[i].Cells["MontajMEK"].Value.ToString()) == 1)
                {
                    dataGridView1.Rows[i].Cells["MontajMEK"].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    dataGridView1.Rows[i].Cells["MontajMEK"].Style.BackColor = Color.PaleVioletRed;
                }
                if (int.Parse(dataGridView1.Rows[i].Cells["MontajELK"].Value.ToString()) == 1)
                {
                    dataGridView1.Rows[i].Cells["MontajELK"].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    dataGridView1.Rows[i].Cells["MontajELK"].Style.BackColor = Color.PaleVioletRed;
                }
                if (int.Parse(dataGridView1.Rows[i].Cells["MikrodanCikis"].Value.ToString()) == 1)
                {
                    dataGridView1.Rows[i].Cells["MikrodanCikis"].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    dataGridView1.Rows[i].Cells["MikrodanCikis"].Style.BackColor = Color.PaleVioletRed;
                }
            }
        }
    }
}
