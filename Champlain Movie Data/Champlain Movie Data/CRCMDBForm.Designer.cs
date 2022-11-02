namespace Champlain_Movie_Data
{
    partial class movieDatabaseForm
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
            this.moviesButton = new System.Windows.Forms.Button();
            this.actorsButton = new System.Windows.Forms.Button();
            this.genreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // moviesButton
            // 
            this.moviesButton.Location = new System.Drawing.Point(44, 47);
            this.moviesButton.Margin = new System.Windows.Forms.Padding(4);
            this.moviesButton.Name = "moviesButton";
            this.moviesButton.Size = new System.Drawing.Size(124, 28);
            this.moviesButton.TabIndex = 0;
            this.moviesButton.Text = "Manage Movies";
            this.moviesButton.UseVisualStyleBackColor = true;
            this.moviesButton.Click += new System.EventHandler(this.moviesButton_Click);
            // 
            // actorsButton
            // 
            this.actorsButton.Location = new System.Drawing.Point(180, 47);
            this.actorsButton.Margin = new System.Windows.Forms.Padding(4);
            this.actorsButton.Name = "actorsButton";
            this.actorsButton.Size = new System.Drawing.Size(124, 28);
            this.actorsButton.TabIndex = 1;
            this.actorsButton.Text = "Manage Actors";
            this.actorsButton.UseVisualStyleBackColor = true;
            this.actorsButton.Click += new System.EventHandler(this.actorsButton_Click);
            // 
            // genreButton
            // 
            this.genreButton.Location = new System.Drawing.Point(320, 47);
            this.genreButton.Margin = new System.Windows.Forms.Padding(4);
            this.genreButton.Name = "genreButton";
            this.genreButton.Size = new System.Drawing.Size(124, 28);
            this.genreButton.TabIndex = 2;
            this.genreButton.Text = "Genre";
            this.genreButton.UseVisualStyleBackColor = true;
            this.genreButton.Click += new System.EventHandler(this.genreButton_Click);
            // 
            // movieDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 123);
            this.Controls.Add(this.genreButton);
            this.Controls.Add(this.actorsButton);
            this.Controls.Add(this.moviesButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "movieDatabaseForm";
            this.Text = "CRCMDB";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button moviesButton;
        private System.Windows.Forms.Button actorsButton;
        private System.Windows.Forms.Button genreButton;
    }
}

