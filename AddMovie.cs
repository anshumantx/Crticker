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
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            string movie = txtBoxMovie.Text;
            string actors = txtBoxActors.Text;
            string releaseDate = dtReleaseDate.Value.ToString();
            DBConnection db = new DBConnection();
            SqlConnection conn = db.dbConnection();
            
            
            string sql = "insert into Movies values(@movie,@actor,@rDate,getdate());";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@movie",movie );
            cmd.Parameters.AddWithValue("@actor", actors);
            cmd.Parameters.AddWithValue("@rDate", releaseDate);
            int i=cmd.ExecuteNonQuery();
            conn.Close();

            if (i != 0)
            {
                MessageBox.Show( "Data Saved : 1 Record Added");
            }
        }

        private void dtReleaseDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
