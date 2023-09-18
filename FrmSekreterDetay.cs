using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HastaneRandevu
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        SqlBaglanti bgln = new SqlBaglanti();
        public string tc;
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTc.Text = tc;

            //Ad Soyad
            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad from TblSekreter where SekreterTc=@a1", bgln.baglanti());
            komut.Parameters.AddWithValue("@a1", LblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0].ToString();

            }

            //Veri tablosuna branşları çekme
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("Select Bransid as 'Numara',BransAd as 'Branş Ad' from TblBrans", bgln.baglanti());
            sda.Fill(dt);
            dataGridView1.DataSource = dt;


            //Veri tablosuna doktorları çekme
            DataTable dt2 = new DataTable();
            SqlDataAdapter sda2 = new SqlDataAdapter("Select (DoktorAd +' '+ DoktorSoyad) as 'Doktor Künye' , DoktorBrans as 'Branş' from TblDoktor ", bgln.baglanti());
            sda2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branşı comboboxa aktarma
            SqlCommand komut3 = new SqlCommand("Select BransAd from Tblbrans ", bgln.baglanti());
            SqlDataReader sdr2= komut3.ExecuteReader();
            while (sdr2.Read())
            {
                CmbBrans.Items.Add(sdr2[0]);
            }
            bgln.baglanti().Close();
            
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblRandevuDetay (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgln.baglanti());
            komut.Parameters.AddWithValue("@r1", MsktxtTarih.Text);
            komut.Parameters.AddWithValue("@r2", MsktxtSaat.Text);
            komut.Parameters.AddWithValue("@r3", CmbBrans.Text);
            komut.Parameters.AddWithValue("@r4", CmbDoktor.Text);
            komut.ExecuteNonQuery();
            bgln.baglanti();
            MessageBox.Show("Randevu Oluşturuldu");
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();

            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from TblDoktor where DoktorBrans=@d1", bgln.baglanti());
            komut.Parameters.AddWithValue("@d1", CmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                CmbDoktor.Items.Add(dr[0]+" " + dr[1]);

            }
            bgln.baglanti().Close();

        }

        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblDuyurular (DuyuruAd) values (@d1)", bgln.baglanti());
            komut.Parameters.AddWithValue("@d1", RchTxtDuyuru.Text);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu","Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void BtnDoktorPanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPanel fdp = new FrmDoktorPanel();
            fdp.Show();
        }

        private void BtnBransPanel_Click(object sender, EventArgs e)
        {
            FrmBrans frmBrans = new FrmBrans();
            frmBrans.Show();
        }

        private void BtnRandevuListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListe frm = new FrmRandevuListe();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm = new FrmDuyurular();
            frm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
           FrmGiris frm = new FrmGiris();
            frm.Show();

        }

        
    }
}