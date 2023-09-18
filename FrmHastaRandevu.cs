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
using System.Data.Common;

namespace HastaneRandevu
{
    public partial class FrmHastaRandevu : Form
    {
        public FrmHastaRandevu()
        {
            InitializeComponent();
        }
        public string tc;

        SqlBaglanti baglantı2 = new SqlBaglanti();
        private void FrmHastaRandevu_Load(object sender, EventArgs e)
        {
            //Veri tablosuyla otomatik şekilde alltaki yorum satırından istenilen bilgiler listelenebilir ancak bu projede--
            //-- kendimiz manuel olarak verileri çekicez.->>>> (Alltaki yorum satırı) 
          //  this.tblRandevuDetayTableAdapter.Fill(this.hastaneRandevuVTDataSet.TblRandevuDetay);
           
            //Girilen tc ve ad soyad labeller yardımıyla ekrana yazdırıldı.
            LblTc.Text = tc;

            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad from TblHasta where HastaTc=@a1 ", baglantı2.baglanti());
            komut.Parameters.AddWithValue("@a1",tc);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                LblAdSoyad.Text= dr[0] +" "+ dr[1] ;
            }
            baglantı2.baglanti().Close();

            //Veriyi manuel olarak tabloya çekme
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from tblrandevudetay where Hastatc="+tc,baglantı2.baglanti());
            sda.Fill(dt);
            dataGridView1.DataSource = dt;


            //Branş bölümü
            SqlCommand brkomut = new SqlCommand("Select BransAd from TblBrans", baglantı2.baglanti());
            SqlDataReader sdr= brkomut.ExecuteReader();
            while (sdr.Read())
            {
                CmbBrans.Items.Add(sdr[0]);
            }
            baglantı2.baglanti().Close();

         
            



        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("Select DoktorAd , DoktorSoyad from TblDoktor where DoktorBrans=@a1", baglantı2.baglanti());
            komut.Parameters.AddWithValue("@a1", CmbBrans.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                CmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            baglantı2.baglanti().Close();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TblRandevuDetay where RandevuBrans='"+CmbBrans.Text +"'"+ "and RandevuDoktor='"+CmbDoktor.Text+"'and RandevuDurum=0", baglantı2.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            textBox1.Text= dataGridView2.Rows[secilen].Cells[0].Value.ToString();

        }

        private void BtnRandevu_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TblRandevuDetay set RandevuDurum=1 , HastaTc=@p1,HastaSikayet=@p2 where Randevuid=@p3", baglantı2.baglanti());
            komut.Parameters.AddWithValue("@p1",LblTc.Text);
            komut.Parameters.AddWithValue("@p2", RchTxtSikayet.Text);
            komut.Parameters.AddWithValue("@p3",textBox1.Text);
            komut.ExecuteNonQuery();
            baglantı2.baglanti().Close();
            MessageBox.Show("Randevu alındı");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHastaGiris frm = new FrmHastaGiris();
            frm.Show();
            this.Hide();
        }

       
    }
}
