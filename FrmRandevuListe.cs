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
    public partial class FrmRandevuListe : Form
    {
        public FrmRandevuListe()
        {
            InitializeComponent();
        }

        SqlBaglanti baglan = new SqlBaglanti();
        private void FrmRandevuListe_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TblRandevuDetay",baglan.baglanti());
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

     
    }
}
