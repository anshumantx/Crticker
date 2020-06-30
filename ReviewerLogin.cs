using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviewReviewSystem
{
    public partial class ReviewerLogin : Form
    {
        public ReviewerLogin()
        {
            InitializeComponent();
        }
        public string Username()
        {
            return txtboxUname.Text;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtboxUname.Text = "";
            txtboxPwd.Text = "";
        }

        private void ReviewerLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signup = new SignUp();
            signup.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProvideReview pr = new ProvideReview();
            pr.Show();
            Username();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }
    }
}
