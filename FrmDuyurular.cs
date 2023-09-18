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
    public partial class FrmDuyurular : Form
    {
        public FrmDuyurular()
        {
            InitializeComponent();
        }
        SqlBaglanti sql = new SqlBaglanti();

        private void FrmDuyurular_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from TblDuyurular",sql.baglanti());
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }

     
    }
}
