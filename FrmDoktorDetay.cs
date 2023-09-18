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
namespace HastaneRandevu
{
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        SqlBaglanti baglan = new SqlBaglanti();

        private void button3_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris frm = new FrmDoktorGiris();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doktor_Duyuru dkt = new Doktor_Duyuru();
            dkt.Show();
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string Tc;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            Lbltc.Text= Tc;

            //Ad Soyad label çekme
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from TblDoktor where DoktorTc=@t1", baglan.baglanti());
            komut.Parameters.AddWithValue("@t1", Lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                LblAd.Text = dr[0] + " " + dr[1];
            }
            baglan.baglanti().Close();

            //veri çekme tabloya
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TblRandevuDetay where RandevuDoktor='" + LblAd.Text + "'", baglan.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richTextBox1.Text= dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
