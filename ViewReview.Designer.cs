namespace MoviewReviewSystem
{
    partial class ViewReview
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
            this.dgvReview = new System.Windows.Forms.DataGridView();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnMovieRating = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReview)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReview
            // 
            this.dgvReview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReview.Location = new System.Drawing.Point(12, 12);
            this.dgvReview.Name = "dgvReview";
            this.dgvReview.Size = new System.Drawing.Size(619, 340);
            this.dgvReview.TabIndex = 0;
            this.dgvReview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReview_CellContentClick);
            // 
            // btnhome
            // 
            this.btnhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Location = new System.Drawing.Point(666, 12);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(84, 29);
            this.btnhome.TabIndex = 1;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnMovieRating
            // 
            this.btnMovieRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieRating.Location = new System.Drawing.Point(666, 61);
            this.btnMovieRating.Name = "btnMovieRating";
            this.btnMovieRating.Size = new System.Drawing.Size(131, 29);
            this.btnMovieRating.TabIndex = 2;
            this.btnMovieRating.Text = "View By Rating";
            this.btnMovieRating.UseVisualStyleBackColor = true;
            this.btnMovieRating.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMovieRating);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.dgvReview);
            this.Name = "ViewReview";
            this.Text = "View Movie Rating";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReview;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnMovieRating;
    }
}