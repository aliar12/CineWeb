namespace CineWeb
{
    partial class SeletedMovie
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
            this.MovieName = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.SelectButton = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.Kind = new System.Windows.Forms.TextBox();
            this.Backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieName
            // 
            this.MovieName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MovieName.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieName.ForeColor = System.Drawing.Color.Transparent;
            this.MovieName.Location = new System.Drawing.Point(12, 404);
            this.MovieName.Name = "MovieName";
            this.MovieName.Size = new System.Drawing.Size(407, 93);
            this.MovieName.TabIndex = 18;
            this.MovieName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PictureBox
            // 
            this.PictureBox.ErrorImage = global::CineWeb.Properties.Resources.Avengers;
            this.PictureBox.InitialImage = global::CineWeb.Properties.Resources.Avengers;
            this.PictureBox.Location = new System.Drawing.Point(12, 40);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(210, 361);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 17;
            this.PictureBox.TabStop = false;
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.Black;
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.ForeColor = System.Drawing.Color.White;
            this.Description.Location = new System.Drawing.Point(286, 40);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Size = new System.Drawing.Size(466, 219);
            this.Description.TabIndex = 19;
            // 
            // SelectButton
            // 
            this.SelectButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectButton.ForeColor = System.Drawing.Color.White;
            this.SelectButton.Location = new System.Drawing.Point(649, 500);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(139, 64);
            this.SelectButton.TabIndex = 22;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = false;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // dateTime
            // 
            this.dateTime.BackColor = System.Drawing.Color.Black;
            this.dateTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.ForeColor = System.Drawing.Color.White;
            this.dateTime.Location = new System.Drawing.Point(286, 319);
            this.dateTime.Name = "dateTime";
            this.dateTime.ReadOnly = true;
            this.dateTime.Size = new System.Drawing.Size(368, 19);
            this.dateTime.TabIndex = 23;
            // 
            // amount
            // 
            this.amount.BackColor = System.Drawing.Color.Black;
            this.amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.ForeColor = System.Drawing.Color.White;
            this.amount.Location = new System.Drawing.Point(286, 364);
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Size = new System.Drawing.Size(250, 19);
            this.amount.TabIndex = 24;
            // 
            // Kind
            // 
            this.Kind.BackColor = System.Drawing.Color.Black;
            this.Kind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Kind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kind.ForeColor = System.Drawing.Color.White;
            this.Kind.Location = new System.Drawing.Point(286, 275);
            this.Kind.Name = "Kind";
            this.Kind.ReadOnly = true;
            this.Kind.Size = new System.Drawing.Size(250, 19);
            this.Kind.TabIndex = 25;
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.ForeColor = System.Drawing.Color.White;
            this.Backbtn.Location = new System.Drawing.Point(12, 500);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(139, 64);
            this.Backbtn.TabIndex = 26;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // SeletedMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CineWeb.Properties.Resources.Backgroud;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.Kind);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.MovieName);
            this.Controls.Add(this.PictureBox);
            this.Name = "SeletedMovie";
            this.Text = "SeletedMovie";
            this.Load += new System.EventHandler(this.SeletedMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MovieName;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.TextBox dateTime;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.TextBox Kind;
        private System.Windows.Forms.Button Backbtn;
    }
}