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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }

        SqlBaglanti baglan = new SqlBaglanti();
        private void FrmBrans_Load(object sender, EventArgs e)
        {
            //Branşları data tablosuna çekme
            DataTable dt = new DataTable();
            SqlDataAdapter sda= new SqlDataAdapter("Select * from TblBrans",baglan.baglanti());
            sda.Fill(dt);
            dataGridView1.DataSource = dt;




        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut= new SqlCommand("insert into TblBrans (BransAd) values (@b2)",baglan.baglanti());
            komut.Parameters.AddWithValue("@b2", TxtBransAd.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Branş Eklendi");

            TxtBransid.Text = "";
            TxtBransAd.Text = "";
            TxtBransAd.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from TblBrans", baglan.baglanti());
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TblBrans where Bransid=@b1", baglan.baglanti());
            komut.Parameters.AddWithValue("@b1", TxtBransid.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Branş Silindi");

            TxtBransid.Text = "";
            TxtBransAd.Text = "";
            TxtBransAd.Focus();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TblBrans set BransAd=@b2 where Bransid=@b1", baglan.baglanti());
            komut.Parameters.AddWithValue("@b1",TxtBransid.Text);
            komut.Parameters.AddWithValue("@b2", TxtBransAd.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Branş Güncellendi");

            TxtBransid.Text = "";
            TxtBransAd.Text = "";
            TxtBransAd.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen =  dataGridView1.SelectedCells[0].RowIndex;
            TxtBransid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtBransAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            
        }

    
    }
}
