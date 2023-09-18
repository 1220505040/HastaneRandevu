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
    public partial class FrmHastaKayıt : Form
    {
        public FrmHastaKayıt()
        {
            InitializeComponent();
        }
        SqlBaglanti bglnt = new SqlBaglanti();

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("insert into TblHasta (HastaAd,HastaSoyad,HastaTc,HastaTelefon,HastaSifre,Cinsiyet) values (@f1,@f2,@f3,@f4,@f5,@f6)",bglnt.baglanti());
            komut.Parameters.AddWithValue("@f1",TxtAd.Text);
            komut.Parameters.AddWithValue("@f2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@f3", MsktxtTC.Text);
            komut.Parameters.AddWithValue("@f4", MskTxtTelefon.Text);
            komut.Parameters.AddWithValue("@f5", TxtSifre.Text);
            komut.Parameters.AddWithValue("@f6", CmbCinsiyet.Text);
            komut.ExecuteNonQuery();
            bglnt.baglanti().Close();
            MessageBox.Show("Hasta Kaydı Yapıldı. Şifreniz:"+TxtSifre.Text,"Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);



        }
    }
}
