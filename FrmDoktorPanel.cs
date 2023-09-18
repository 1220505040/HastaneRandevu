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
    public partial class FrmDoktorPanel : Form
    {
        public FrmDoktorPanel()
        {
            InitializeComponent();
        }
        SqlBaglanti baglan = new SqlBaglanti();

        private void FrmDoktorPanel_Load(object sender, EventArgs e)
        {
            //Doktorları veri tablosuna aktarma
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from TblDoktor",baglan.baglanti());
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branşı comboboxa aktarma
            SqlCommand komut3 = new SqlCommand("Select BransAd from Tblbrans ", baglan.baglanti());
            SqlDataReader sdr2 = komut3.ExecuteReader();
            while (sdr2.Read())
            {
                CmbBrans.Items.Add(sdr2[0]);
            }
            baglan.baglanti().Close();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from TblDoktor", baglan.baglanti());
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblDoktor (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTc,DoktorSifre) values (@d1,@d2,@d3,@d4,@d5)", baglan.baglanti());
            komut.Parameters.AddWithValue("@d1", TxtAd.Text);
            komut.Parameters.AddWithValue("@d2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", CmbBrans.Text);
            komut.Parameters.AddWithValue("@d4", MsktxtTc.Text);
            komut.Parameters.AddWithValue("@d5", TxtSifre.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Doktor Eklendi","",MessageBoxButtons.OK,MessageBoxIcon.Information);

            MsktxtTc.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            CmbBrans.Text = "";
            TxtSifre.Text = "";
            TxtAd.Focus();




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MsktxtTc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TblDoktor where DoktorTc=@d1",baglan.baglanti());
            komut.Parameters.AddWithValue("@d1", MsktxtTc.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Doktor Silindi");

            MsktxtTc.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            CmbBrans.Text = "";
            TxtSifre.Text = "";
            TxtAd.Focus();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TblDoktor set DoktorAd=@d1,DoktorSoyad=@d2,DoktorBrans=@d3,DoktorSifre=@d5 where DoktorTc=@d4", baglan.baglanti());
            komut.Parameters.AddWithValue("@d1", TxtAd.Text);
            komut.Parameters.AddWithValue("@d2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", CmbBrans.Text);
            komut.Parameters.AddWithValue("@d4", MsktxtTc.Text);
            komut.Parameters.AddWithValue("@d5", TxtSifre.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi" , "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MsktxtTc.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            CmbBrans.Text = "";
            TxtSifre.Text = "";
            TxtAd.Focus();
        }

      
    }
}
