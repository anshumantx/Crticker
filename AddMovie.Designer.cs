namespace MoviewReviewSystem
{
    partial class AddMovie
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
            this.lblMovie = new System.Windows.Forms.Label();
            this.txtBoxMovie = new System.Windows.Forms.TextBox();
            this.txtBoxActors = new System.Windows.Forms.TextBox();
            this.lblActors = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dtReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovie.Location = new System.Drawing.Point(132, 54);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(104, 20);
            this.lblMovie.TabIndex = 0;
            this.lblMovie.Text = "Movie Name :";
            this.lblMovie.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxMovie
            // 
            this.txtBoxMovie.Location = new System.Drawing.Point(243, 53);
            this.txtBoxMovie.Name = "txtBoxMovie";
            this.txtBoxMovie.Size = new System.Drawing.Size(154, 20);
            this.txtBoxMovie.TabIndex = 1;
            // 
            // txtBoxActors
            // 
            this.txtBoxActors.Location = new System.Drawing.Point(243, 113);
            this.txtBoxActors.Name = "txtBoxActors";
            this.txtBoxActors.Size = new System.Drawing.Size(154, 20);
            this.txtBoxActors.TabIndex = 3;
            // 
            // lblActors
            // 
            this.lblActors.AutoSize = true;
            this.lblActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActors.Location = new System.Drawing.Point(132, 114);
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(63, 20);
            this.lblActors.TabIndex = 2;
            this.lblActors.Text = "Actors :";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseDate.Location = new System.Drawing.Point(132, 171);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(115, 20);
            this.lblReleaseDate.TabIndex = 4;
            this.lblReleaseDate.Text = "Release Date :";
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.Location = new System.Drawing.Point(243, 217);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(75, 33);
            this.btnAddMovie.TabIndex = 6;
            this.btnAddMovie.Text = "Add";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(356, 217);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 33);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dtReleaseDate
            // 
            this.dtReleaseDate.Location = new System.Drawing.Point(243, 170);
            this.dtReleaseDate.Name = "dtReleaseDate";
            this.dtReleaseDate.Size = new System.Drawing.Size(200, 20);
            this.dtReleaseDate.TabIndex = 8;
            this.dtReleaseDate.ValueChanged += new System.EventHandler(this.dtReleaseDate_ValueChanged);
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtReleaseDate);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.txtBoxActors);
            this.Controls.Add(this.lblActors);
            this.Controls.Add(this.txtBoxMovie);
            this.Controls.Add(this.lblMovie);
            this.Name = "AddMovie";
            this.Text = "Add Movie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.TextBox txtBoxMovie;
        private System.Windows.Forms.TextBox txtBoxActors;
        private System.Windows.Forms.Label lblActors;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DateTimePicker dtReleaseDate;
    }
}