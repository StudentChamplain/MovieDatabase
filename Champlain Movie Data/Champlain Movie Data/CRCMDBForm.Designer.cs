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
            this.moviesButton.Location = new System.Drawing.Point(33, 38);
            this.moviesButton.Name = "moviesButton";
            this.moviesButton.Size = new System.Drawing.Size(93, 23);
            this.moviesButton.TabIndex = 0;
            this.moviesButton.Text = "Manage Movies";
            this.moviesButton.UseVisualStyleBackColor = true;
            // 
            // actorsButton
            // 
            this.actorsButton.Location = new System.Drawing.Point(135, 38);
            this.actorsButton.Name = "actorsButton";
            this.actorsButton.Size = new System.Drawing.Size(93, 23);
            this.actorsButton.TabIndex = 1;
            this.actorsButton.Text = "Manage Actors";
            this.actorsButton.UseVisualStyleBackColor = true;
            // 
            // genreButton
            // 
            this.genreButton.Location = new System.Drawing.Point(240, 38);
            this.genreButton.Name = "genreButton";
            this.genreButton.Size = new System.Drawing.Size(93, 23);
            this.genreButton.TabIndex = 2;
            this.genreButton.Text = "Genre";
            this.genreButton.UseVisualStyleBackColor = true;
            // 
            // movieDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 100);
            this.Controls.Add(this.genreButton);
            this.Controls.Add(this.actorsButton);
            this.Controls.Add(this.moviesButton);
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

