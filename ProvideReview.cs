using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviewReviewSystem
{
    public partial class ProvideReview : Form
    {
        public ProvideReview()
        {
            InitializeComponent();
            object[] rating = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            cmbRating.Items.AddRange(rating);
            LableActor.Text = "";
            LableMovie.Text = "";
            LableRDate.Text = "";
            DBConnection db = new DBConnection();
            SqlConnection conn = db.dbConnection();
            SqlDataReader dataReader;

            string sql = "SELECT  [Movie Name]  FROM[MoviewReview].[dbo].[Movies];";
            SqlCommand cmd = new SqlCommand(sql, conn);
            dataReader = cmd.ExecuteReader();
            List<Object> movies = new List<object>();
            while(dataReader.Read())
            {
               string a= dataReader.GetString(0);
                movies.Add(a);

            }
            conn.Close();
            Object[] moviesArray = movies.ToArray();
            cmbMovies.Items.AddRange(moviesArray);

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            SqlConnection conn = db.dbConnection();
            SqlDataReader dataReader;
            string sql = "select * from Movies where [Movie Name]=@name";
            SqlCommand cmd = new SqlCommand(sql, conn);
            string name=cmbMovies.Text;
            cmd.Parameters.AddWithValue("@name", name);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                LableMovie.Text = dataReader.GetString(0);
                LableActor.Text = dataReader.GetString(1);
                LableRDate.Text = dataReader.GetString(2);
            }
            conn.Close();
            
        }

        private void ProvideReview_Load(object sender, EventArgs e)
        {

        }

        private void cmbRating_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string movie = LableMovie.Text;
            string rating = cmbRating.Text;
            string comment = txtboxComment.Text;
            DBConnection db = new DBConnection();
            SqlConnection conn = db.dbConnection();


            string sql = "insert into Reviews values(@movie,@rating,@comment);";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@movie", movie);
            cmd.Parameters.AddWithValue("@rating", rating);
            cmd.Parameters.AddWithValue("@comment", comment);

            int i = cmd.ExecuteNonQuery();
            conn.Close();

            if (i != 0)
            {
                MessageBox.Show("Data Saved : 1 Record Added");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
