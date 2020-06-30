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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin admin = new AdminLogin();
            admin.Show();
                
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblaboutus1.Text = "This Application is Developed By Alok Pandey";
            lblaboutus2.Text = "Enroll. no=170607324 ,Contact:7837673163";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblaboutus1.Text = "";
            lblaboutus2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReviewerLogin rLogin = new ReviewerLogin();
            rLogin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewReview vr = new ViewReview();
            vr.Show();
        }
    }
}
