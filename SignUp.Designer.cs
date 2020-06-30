namespace MoviewReviewSystem
{
    partial class SignUp
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtboxFName = new System.Windows.Forms.TextBox();
            this.txtboxLName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtboxUname = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtboxSetpwd = new System.Windows.Forms.TextBox();
            this.lblSetPwd = new System.Windows.Forms.Label();
            this.btnSignUpR = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(167, 54);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(94, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name :";
            // 
            // txtboxFName
            // 
            this.txtboxFName.Location = new System.Drawing.Point(286, 56);
            this.txtboxFName.Name = "txtboxFName";
            this.txtboxFName.Size = new System.Drawing.Size(159, 20);
            this.txtboxFName.TabIndex = 1;
            // 
            // txtboxLName
            // 
            this.txtboxLName.Location = new System.Drawing.Point(286, 98);
            this.txtboxLName.Name = "txtboxLName";
            this.txtboxLName.Size = new System.Drawing.Size(159, 20);
            this.txtboxLName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(167, 96);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(94, 20);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name :";
            // 
            // txtboxUname
            // 
            this.txtboxUname.Location = new System.Drawing.Point(286, 138);
            this.txtboxUname.Name = "txtboxUname";
            this.txtboxUname.Size = new System.Drawing.Size(159, 20);
            this.txtboxUname.TabIndex = 5;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(167, 138);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(87, 20);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Username:";
            // 
            // txtboxSetpwd
            // 
            this.txtboxSetpwd.Location = new System.Drawing.Point(286, 178);
            this.txtboxSetpwd.Name = "txtboxSetpwd";
            this.txtboxSetpwd.Size = new System.Drawing.Size(159, 20);
            this.txtboxSetpwd.TabIndex = 7;
            // 
            // lblSetPwd
            // 
            this.lblSetPwd.AutoSize = true;
            this.lblSetPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetPwd.Location = new System.Drawing.Point(167, 178);
            this.lblSetPwd.Name = "lblSetPwd";
            this.lblSetPwd.Size = new System.Drawing.Size(115, 20);
            this.lblSetPwd.TabIndex = 6;
            this.lblSetPwd.Text = "Set Password :";
            // 
            // btnSignUpR
            // 
            this.btnSignUpR.Location = new System.Drawing.Point(283, 235);
            this.btnSignUpR.Name = "btnSignUpR";
            this.btnSignUpR.Size = new System.Drawing.Size(75, 23);
            this.btnSignUpR.TabIndex = 8;
            this.btnSignUpR.Text = "Sign Up";
            this.btnSignUpR.UseVisualStyleBackColor = true;
            this.btnSignUpR.Click += new System.EventHandler(this.btnSignUpR_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(385, 235);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSignUpR);
            this.Controls.Add(this.txtboxSetpwd);
            this.Controls.Add(this.lblSetPwd);
            this.Controls.Add(this.txtboxUname);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtboxLName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtboxFName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtboxFName;
        private System.Windows.Forms.TextBox txtboxLName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtboxUname;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtboxSetpwd;
        private System.Windows.Forms.Label lblSetPwd;
        private System.Windows.Forms.Button btnSignUpR;
        private System.Windows.Forms.Button btnReset;
    }
}