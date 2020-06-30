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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtboxUname.Text = "";
            txtboxSetpwd.Text = "";
            txtboxLName.Text = "";
            txtboxFName.Text = "";
        }

        private void btnSignUpR_Click(object sender, EventArgs e)
        {
            string fname = txtboxFName.Text;
            string lname = txtboxLName.Text;
            string uname = txtboxUname.Text;
            string pwd = txtboxSetpwd.Text;
            
            
            DBConnection db = new DBConnection();
            SqlConnection conn = db.dbConnection();


            string sql = "insert into Users values(@fname,@lname,@uname,@pwd);";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@uname", uname);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            int i = cmd.ExecuteNonQuery();
            conn.Close();

            if (i != 0)
            {
                MessageBox.Show("Sign up Completed . Please Login");
                ReviewerLogin rlogin = new ReviewerLogin();
                this.Hide();
                rlogin.Show();

            }
        }
    }
}
