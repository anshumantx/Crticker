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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtboxUname.Text = "";
            txtboxPwd.Text = "";
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string uname=   txtboxUname.Text;
            string password = txtboxPwd.Text;
            DBConnection db = new DBConnection();
            SqlConnection conn=  db.dbConnection();
            SqlDataReader sqlDReader;
            SqlCommand cmd;
            string sql= "select * from Users";
            cmd = new SqlCommand(sql, conn);
            sqlDReader = cmd.ExecuteReader();
            while (sqlDReader.Read())
            {
                string a = sqlDReader.GetValue(3).ToString();
                if (uname == sqlDReader.GetValue(3).ToString())
                {
                    string p = sqlDReader.GetValue(4).ToString();
                    if (password == sqlDReader.GetValue(4).ToString())
                    {
                        this.Hide();
                        MessageBox.Show("Login Successfull");
                        AddMovie addMovie = new AddMovie();
                        addMovie.Show();

                    }
                    else
                    {
                        MessageBox.Show("UserName or Password is incorrect");
                    }
                }    
                
              
            }



        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }
    }
}
