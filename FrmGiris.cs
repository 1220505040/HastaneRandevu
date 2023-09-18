using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevu
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHastaGiris frm1= new FrmHastaGiris();
            frm1.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris frm2= new FrmDoktorGiris();
            frm2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris frm3 = new FrmSekreterGiris();
            frm3.Show();
            this.Hide();
        }

       
    }
}
