namespace MoviewReviewSystem
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabelAboutUs = new System.Windows.Forms.LinkLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblaboutus1 = new System.Windows.Forms.Label();
            this.lblaboutus2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Movie Review System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(166, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Login As Admin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(166, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "I am a Reviewer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabelAboutUs
            // 
            this.linkLabelAboutUs.AutoSize = true;
            this.linkLabelAboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelAboutUs.Location = new System.Drawing.Point(163, 270);
            this.linkLabelAboutUs.Name = "linkLabelAboutUs";
            this.linkLabelAboutUs.Size = new System.Drawing.Size(69, 18);
            this.linkLabelAboutUs.TabIndex = 3;
            this.linkLabelAboutUs.TabStop = true;
            this.linkLabelAboutUs.Text = "About Us";
            this.linkLabelAboutUs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(166, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 42);
            this.button3.TabIndex = 4;
            this.button3.Text = "View Movies Rating";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // lblaboutus1
            // 
            this.lblaboutus1.AutoSize = true;
            this.lblaboutus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaboutus1.Location = new System.Drawing.Point(166, 312);
            this.lblaboutus1.Name = "lblaboutus1";
            this.lblaboutus1.Size = new System.Drawing.Size(46, 18);
            this.lblaboutus1.TabIndex = 6;
            this.lblaboutus1.Text = "label3";
            // 
            // lblaboutus2
            // 
            this.lblaboutus2.AutoSize = true;
            this.lblaboutus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaboutus2.Location = new System.Drawing.Point(166, 341);
            this.lblaboutus2.Name = "lblaboutus2";
            this.lblaboutus2.Size = new System.Drawing.Size(46, 18);
            this.lblaboutus2.TabIndex = 7;
            this.lblaboutus2.Text = "label4";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblaboutus2);
            this.Controls.Add(this.lblaboutus1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.linkLabelAboutUs);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Movie Review System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabelAboutUs;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblaboutus1;
        private System.Windows.Forms.Label lblaboutus2;
    }
}

