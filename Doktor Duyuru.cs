using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HastaneRandevu
{
    public partial class Doktor_Duyuru : Form
    {
        public Doktor_Duyuru()
        {
            InitializeComponent();
        }
        SqlBaglanti sql= new SqlBaglanti();
        private void Doktor_Duyuru_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from TblDuyurular", sql.baglanti());
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

       
    }
}
