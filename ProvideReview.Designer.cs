namespace MoviewReviewSystem
{
    partial class ProvideReview
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
            this.lblSelectMovie = new System.Windows.Forms.Label();
            this.cmbMovies = new System.Windows.Forms.ComboBox();
            this.lblMovie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRating = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LableRDate = new System.Windows.Forms.Label();
            this.LableActor = new System.Windows.Forms.Label();
            this.LableMovie = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxComment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSelectMovie
            // 
            this.lblSelectMovie.AutoSize = true;
            this.lblSelectMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectMovie.Location = new System.Drawing.Point(137, 59);
            this.lblSelectMovie.Name = "lblSelectMovie";
            this.lblSelectMovie.Size = new System.Drawing.Size(107, 20);
            this.lblSelectMovie.TabIndex = 0;
            this.lblSelectMovie.Text = "Select Movie :";
            // 
            // cmbMovies
            // 
            this.cmbMovies.FormattingEnabled = true;
            this.cmbMovies.Location = new System.Drawing.Point(287, 61);
            this.cmbMovies.Name = "cmbMovies";
            this.cmbMovies.Size = new System.Drawing.Size(257, 21);
            this.cmbMovies.TabIndex = 1;
            this.cmbMovies.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovie.Location = new System.Drawing.Point(140, 99);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(104, 20);
            this.lblMovie.TabIndex = 2;
            this.lblMovie.Text = "Movie Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Actors  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Release Date :";
            // 
            // cmbRating
            // 
            this.cmbRating.FormattingEnabled = true;
            this.cmbRating.Location = new System.Drawing.Point(287, 245);
            this.cmbRating.Name = "cmbRating";
            this.cmbRating.Size = new System.Drawing.Size(121, 21);
            this.cmbRating.TabIndex = 5;
            this.cmbRating.SelectedIndexChanged += new System.EventHandler(this.cmbRating_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rating :";
            // 
            // LableRDate
            // 
            this.LableRDate.AutoSize = true;
            this.LableRDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableRDate.Location = new System.Drawing.Point(283, 202);
            this.LableRDate.Name = "LableRDate";
            this.LableRDate.Size = new System.Drawing.Size(158, 20);
            this.LableRDate.TabIndex = 7;
            this.LableRDate.Text = "Release Date Lable :";
            // 
            // LableActor
            // 
            this.LableActor.AutoSize = true;
            this.LableActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableActor.Location = new System.Drawing.Point(283, 148);
            this.LableActor.Name = "LableActor";
            this.LableActor.Size = new System.Drawing.Size(98, 20);
            this.LableActor.TabIndex = 8;
            this.LableActor.Text = "Actor Lable :";
            // 
            // LableMovie
            // 
            this.LableMovie.AutoSize = true;
            this.LableMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableMovie.Location = new System.Drawing.Point(283, 99);
            this.LableMovie.Name = "LableMovie";
            this.LableMovie.Size = new System.Drawing.Size(89, 20);
            this.LableMovie.TabIndex = 9;
            this.LableMovie.Text = "MovieLable";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(287, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add Review";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(641, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(121, 33);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Review Comment:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtboxComment
            // 
            this.txtboxComment.Location = new System.Drawing.Point(287, 286);
            this.txtboxComment.Name = "txtboxComment";
            this.txtboxComment.Size = new System.Drawing.Size(257, 20);
            this.txtboxComment.TabIndex = 13;
            // 
            // ProvideReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtboxComment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LableMovie);
            this.Controls.Add(this.LableActor);
            this.Controls.Add(this.LableRDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbRating);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMovie);
            this.Controls.Add(this.cmbMovies);
            this.Controls.Add(this.lblSelectMovie);
            this.Name = "ProvideReview";
            this.Text = "ProvideReview";
            this.Load += new System.EventHandler(this.ProvideReview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectMovie;
        private System.Windows.Forms.ComboBox cmbMovies;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LableRDate;
        private System.Windows.Forms.Label LableActor;
        private System.Windows.Forms.Label LableMovie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxComment;
    }
}