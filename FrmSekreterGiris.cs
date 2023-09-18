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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti baglan = new SqlBaglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TblSekreter where SekreterTc=@f1 and SekreterSifre=@f2 ", baglan.baglanti());
            komut.Parameters.AddWithValue("@f1",maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@f2", textBox1.Text);
            SqlDataReader sdr = komut.ExecuteReader();
            if (sdr.Read()) 
            { 
                FrmSekreterDetay frm = new FrmSekreterDetay();
                frm.tc= maskedTextBox1.Text;
                frm.Show();
                this.Hide();
             }
            else
            {
                MessageBox.Show("Yanlış TC veya Şifre", "Hata", MessageBoxButtons.OK);
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
