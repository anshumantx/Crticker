namespace MoviewReviewSystem
{
    partial class AdminLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbladmUname = new System.Windows.Forms.Label();
            this.txtboxUname = new System.Windows.Forms.TextBox();
            this.txtboxPwd = new System.Windows.Forms.TextBox();
            this.lbladmnPwd = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbladmUname
            // 
            this.lbladmUname.AutoSize = true;
            this.lbladmUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmUname.Location = new System.Drawing.Point(148, 96);
            this.lbladmUname.Name = "lbladmUname";
            this.lbladmUname.Size = new System.Drawing.Size(97, 20);
            this.lbladmUname.TabIndex = 0;
            this.lbladmUname.Text = "User Name :";
            this.lbladmUname.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtboxUname
            // 
            this.txtboxUname.Location = new System.Drawing.Point(262, 98);
            this.txtboxUname.Name = "txtboxUname";
            this.txtboxUname.Size = new System.Drawing.Size(228, 20);
            this.txtboxUname.TabIndex = 1;
            // 
            // txtboxPwd
            // 
            this.txtboxPwd.Location = new System.Drawing.Point(262, 147);
            this.txtboxPwd.Name = "txtboxPwd";
            this.txtboxPwd.PasswordChar = '*';
            this.txtboxPwd.Size = new System.Drawing.Size(228, 20);
            this.txtboxPwd.TabIndex = 3;
            // 
            // lbladmnPwd
            // 
            this.lbladmnPwd.AutoSize = true;
            this.lbladmnPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmnPwd.Location = new System.Drawing.Point(148, 145);
            this.lbladmnPwd.Name = "lbladmnPwd";
            this.lbladmnPwd.Size = new System.Drawing.Size(86, 20);
            this.lbladmnPwd.TabIndex = 2;
            this.lbladmnPwd.Text = "Password :";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(262, 212);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 33);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(353, 212);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 33);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(713, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 33);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtboxPwd);
            this.Controls.Add(this.lbladmnPwd);
            this.Controls.Add(this.txtboxUname);
            this.Controls.Add(this.lbladmUname);
            this.Name = "AdminLogin";
            this.Text = "Admin Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbladmUname;
        private System.Windows.Forms.TextBox txtboxUname;
        private System.Windows.Forms.TextBox txtboxPwd;
        private System.Windows.Forms.Label lbladmnPwd;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnHome;
    }
}