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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        private void LnkLblÜye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayıt frm = new FrmHastaKayıt();
            frm.Show();
        }

        SqlBaglanti baglan = new SqlBaglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from tblhasta where hastatc=@a1 and hastasifre=@a2",baglan.baglanti());
            komut.Parameters.AddWithValue("@a1", mskTc.Text);
            komut.Parameters.AddWithValue("@a2", TxtSifre.Text);
            SqlDataReader rd = komut.ExecuteReader();
            if (rd.Read()) 
            {
                FrmHastaRandevu frm = new FrmHastaRandevu();
                frm.tc = mskTc.Text;

                frm.Show();

                this.Hide();
            
            }
            else
            {
                MessageBox.Show("TC veya Şifre Hatalı","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           baglan.baglanti().Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGiris frm = new FrmGiris();
            frm.Show();
            this.Hide();
        }
    }
}
