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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti baglanti = new SqlBaglanti();

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGiris frm = new FrmGiris();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TblDoktor where DoktorTc=@d1 and DoktorSifre=@d2 ",baglanti.baglanti());
            komut.Parameters.AddWithValue("@d1",maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@d2", textBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay frm = new FrmDoktorDetay();
                frm.Tc= maskedTextBox1 .Text;
                frm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış Tc veya Şifre");
            }

        }
    }
}
