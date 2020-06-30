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

namespace MoviewReviewSystem
{
    public partial class ViewByRating : Form
    {
        public ViewByRating()
        {
            InitializeComponent();
            DBConnection db = new DBConnection();
            SqlConnection conn = db.dbConnection();
            string sql = "select Movie,AVG(Review) as 'Rating' from Reviews group by movie ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvRating.DataSource = dt;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
