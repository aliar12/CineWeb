namespace CineWeb
{
    partial class AllMovies
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
            this.ActionBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RomanceBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DramaBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComedyBox = new System.Windows.Forms.ListBox();
            this.Backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ActionBox
            // 
            this.ActionBox.BackColor = System.Drawing.Color.Black;
            this.ActionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionBox.ForeColor = System.Drawing.Color.White;
            this.ActionBox.FormattingEnabled = true;
            this.ActionBox.ItemHeight = 20;
            this.ActionBox.Items.AddRange(new object[] {
            "Avengers: Endgame",
            "Mad Max: Fury Road",
            "Inception",
            "Batman v Superman: Dawn of Justice"});
            this.ActionBox.Location = new System.Drawing.Point(33, 132);
            this.ActionBox.Name = "ActionBox";
            this.ActionBox.Size = new System.Drawing.Size(346, 84);
            this.ActionBox.TabIndex = 0;
            this.ActionBox.SelectedIndexChanged += new System.EventHandler(this.ActionBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(33, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Action Movies";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 38.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(282, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 95);
            this.label1.TabIndex = 13;
            this.label1.Text = "Movies";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(401, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 40);
            this.label3.TabIndex = 15;
            this.label3.Text = "Romance Movies";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RomanceBox
            // 
            this.RomanceBox.BackColor = System.Drawing.Color.Black;
            this.RomanceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RomanceBox.ForeColor = System.Drawing.Color.White;
            this.RomanceBox.FormattingEnabled = true;
            this.RomanceBox.ItemHeight = 20;
            this.RomanceBox.Items.AddRange(new object[] {
            "La La Land",
            "The Notebook",
            "Pride and Prejudice",
            "Before Sunrise"});
            this.RomanceBox.Location = new System.Drawing.Point(401, 132);
            this.RomanceBox.Name = "RomanceBox";
            this.RomanceBox.Size = new System.Drawing.Size(346, 84);
            this.RomanceBox.TabIndex = 14;
            this.RomanceBox.SelectedIndexChanged += new System.EventHandler(this.RomanceBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(33, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 40);
            this.label4.TabIndex = 17;
            this.label4.Text = "Drama Movies";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DramaBox
            // 
            this.DramaBox.BackColor = System.Drawing.Color.Black;
            this.DramaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DramaBox.ForeColor = System.Drawing.Color.White;
            this.DramaBox.FormattingEnabled = true;
            this.DramaBox.ItemHeight = 20;
            this.DramaBox.Items.AddRange(new object[] {
            "The Dark Knight",
            "The Shawshank Redemption",
            "Forrest Gump",
            "The Godfather",
            "Schindler\'s List",
            "The Green Mile"});
            this.DramaBox.Location = new System.Drawing.Point(33, 281);
            this.DramaBox.Name = "DramaBox";
            this.DramaBox.Size = new System.Drawing.Size(346, 124);
            this.DramaBox.TabIndex = 16;
            this.DramaBox.SelectedIndexChanged += new System.EventHandler(this.DramaBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(401, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(346, 40);
            this.label5.TabIndex = 19;
            this.label5.Text = "Comedy Movies";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComedyBox
            // 
            this.ComedyBox.BackColor = System.Drawing.Color.Black;
            this.ComedyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComedyBox.ForeColor = System.Drawing.Color.White;
            this.ComedyBox.FormattingEnabled = true;
            this.ComedyBox.ItemHeight = 20;
            this.ComedyBox.Items.AddRange(new object[] {
            "Deadpool",
            "Crazy, Stupid, Love",
            "The Hangover",
            "Superbad",
            "Anchorman: The Legend of Ron Burgundy",
            "Bridesmaids"});
            this.ComedyBox.Location = new System.Drawing.Point(401, 281);
            this.ComedyBox.Name = "ComedyBox";
            this.ComedyBox.Size = new System.Drawing.Size(346, 124);
            this.ComedyBox.TabIndex = 18;
            this.ComedyBox.SelectedIndexChanged += new System.EventHandler(this.ComedyBox_SelectedIndexChanged);
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.ForeColor = System.Drawing.Color.White;
            this.Backbtn.Location = new System.Drawing.Point(33, 413);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(139, 64);
            this.Backbtn.TabIndex = 27;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // AllMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CineWeb.Properties.Resources.Backgroud;
            this.ClientSize = new System.Drawing.Size(759, 489);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComedyBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DramaBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RomanceBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ActionBox);
            this.Name = "AllMovies";
            this.Text = "Movies";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ActionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox RomanceBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox DramaBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox ComedyBox;
        private System.Windows.Forms.Button Backbtn;
    }
}