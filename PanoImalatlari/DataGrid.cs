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
using System.Drawing.Printing;
using System.Collections;

namespace PanoImalatlari
{
    public partial class DataGrid : Form
    {
        public DataGrid()
        {
            InitializeComponent();
        }

        private void DataGrid_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-OT5P8L5\\SQLEXPRESS;Initial Catalog=CetinPano;Integrated Security=True");
        DataSet daset = new DataSet();
        private void DataGrid_Load(object sender, EventArgs e)
        {
            kayitGoster();
        }

        private void kayitGoster()
        {
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from tblCetinPano where PlanlananSevkTarihi=''",baglan);
            adtr.Fill(daset,"tblCetinPano");
            dataGridView1.DataSource = daset.Tables["tblCetinPano"];
            baglan.Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Columns.Count ; i++)
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
