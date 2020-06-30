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
    public partial class ViewReview : Form
    {
        public ViewReview()
        {
            InitializeComponent();
            DBConnection db = new DBConnection();
            SqlConnection conn = db.dbConnection();
            string sql = "select * from Reviews";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvReview.DataSource = dt;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvReview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewByRating vr = new ViewByRating();
            vr.Show();
        }
    }
}
