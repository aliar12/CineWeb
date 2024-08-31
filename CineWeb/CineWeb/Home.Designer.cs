namespace CineWeb
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.InceptionPictureBox = new System.Windows.Forms.PictureBox();
            this.BVSPictureBox = new System.Windows.Forms.PictureBox();
            this.DeadpoolPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AvengersPicture = new System.Windows.Forms.PictureBox();
            this.Avengers = new System.Windows.Forms.Label();
            this.Deadpool = new System.Windows.Forms.Label();
            this.BVS = new System.Windows.Forms.Label();
            this.Inception = new System.Windows.Forms.Label();
            this.PersonalButton = new System.Windows.Forms.Button();
            this.otherButton = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InceptionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BVSPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeadpoolPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvengersPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Backgroud.jpg");
            // 
            // InceptionPictureBox
            // 
            this.InceptionPictureBox.Image = global::CineWeb.Properties.Resources.Inception;
            this.InceptionPictureBox.Location = new System.Drawing.Point(812, 171);
            this.InceptionPictureBox.Name = "InceptionPictureBox";
            this.InceptionPictureBox.Size = new System.Drawing.Size(210, 361);
            this.InceptionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InceptionPictureBox.TabIndex = 15;
            this.InceptionPictureBox.TabStop = false;
            this.InceptionPictureBox.Click += new System.EventHandler(this.InceptionPictureBox_Click);
            // 
            // BVSPictureBox
            // 
            this.BVSPictureBox.ErrorImage = null;
            this.BVSPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("BVSPictureBox.Image")));
            this.BVSPictureBox.InitialImage = null;
            this.BVSPictureBox.Location = new System.Drawing.Point(556, 171);
            this.BVSPictureBox.Name = "BVSPictureBox";
            this.BVSPictureBox.Size = new System.Drawing.Size(210, 361);
            this.BVSPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BVSPictureBox.TabIndex = 14;
            this.BVSPictureBox.TabStop = false;
            this.BVSPictureBox.Click += new System.EventHandler(this.BVSPictureBox_Click);
            // 
            // DeadpoolPictureBox
            // 
            this.DeadpoolPictureBox.Image = global::CineWeb.Properties.Resources.Deadpool;
            this.DeadpoolPictureBox.Location = new System.Drawing.Point(294, 171);
            this.DeadpoolPictureBox.Name = "DeadpoolPictureBox";
            this.DeadpoolPictureBox.Size = new System.Drawing.Size(210, 361);
            this.DeadpoolPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeadpoolPictureBox.TabIndex = 13;
            this.DeadpoolPictureBox.TabStop = false;
            this.DeadpoolPictureBox.Click += new System.EventHandler(this.DeadpoolPictureBox_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 38.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(384, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 144);
            this.label1.TabIndex = 12;
            this.label1.Text = "Popular Movies";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AvengersPicture
            // 
            this.AvengersPicture.ErrorImage = global::CineWeb.Properties.Resources.Avengers;
            this.AvengersPicture.Image = global::CineWeb.Properties.Resources.Avengers;
            this.AvengersPicture.InitialImage = global::CineWeb.Properties.Resources.Avengers;
            this.AvengersPicture.Location = new System.Drawing.Point(30, 171);
            this.AvengersPicture.Name = "AvengersPicture";
            this.AvengersPicture.Size = new System.Drawing.Size(210, 361);
            this.AvengersPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AvengersPicture.TabIndex = 11;
            this.AvengersPicture.TabStop = false;
            this.AvengersPicture.Click += new System.EventHandler(this.AvengersPicture_Click);
            // 
            // Avengers
            // 
            this.Avengers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Avengers.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Avengers.ForeColor = System.Drawing.Color.Transparent;
            this.Avengers.Location = new System.Drawing.Point(30, 558);
            this.Avengers.Name = "Avengers";
            this.Avengers.Size = new System.Drawing.Size(210, 56);
            this.Avengers.TabIndex = 16;
            this.Avengers.Text = "Avengers\r\nEndGame";
            this.Avengers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Deadpool
            // 
            this.Deadpool.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Deadpool.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deadpool.ForeColor = System.Drawing.Color.Transparent;
            this.Deadpool.Location = new System.Drawing.Point(294, 558);
            this.Deadpool.Name = "Deadpool";
            this.Deadpool.Size = new System.Drawing.Size(210, 56);
            this.Deadpool.TabIndex = 17;
            this.Deadpool.Text = "DeadPool";
            this.Deadpool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BVS
            // 
            this.BVS.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BVS.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVS.ForeColor = System.Drawing.Color.Transparent;
            this.BVS.Location = new System.Drawing.Point(556, 558);
            this.BVS.Name = "BVS";
            this.BVS.Size = new System.Drawing.Size(210, 90);
            this.BVS.TabIndex = 18;
            this.BVS.Text = "Batman\r\nVs\r\nSuperman";
            this.BVS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Inception
            // 
            this.Inception.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Inception.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inception.ForeColor = System.Drawing.Color.Transparent;
            this.Inception.Location = new System.Drawing.Point(812, 558);
            this.Inception.Name = "Inception";
            this.Inception.Size = new System.Drawing.Size(210, 56);
            this.Inception.TabIndex = 19;
            this.Inception.Text = "Inception";
            this.Inception.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PersonalButton
            // 
            this.PersonalButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PersonalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalButton.ForeColor = System.Drawing.Color.White;
            this.PersonalButton.Location = new System.Drawing.Point(485, 660);
            this.PersonalButton.Name = "PersonalButton";
            this.PersonalButton.Size = new System.Drawing.Size(93, 54);
            this.PersonalButton.TabIndex = 20;
            this.PersonalButton.Text = "Peronal\r\nDetails";
            this.PersonalButton.UseVisualStyleBackColor = false;
            this.PersonalButton.Click += new System.EventHandler(this.PersonalButton_Click);
            // 
            // otherButton
            // 
            this.otherButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.otherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherButton.ForeColor = System.Drawing.Color.White;
            this.otherButton.Location = new System.Drawing.Point(929, 660);
            this.otherButton.Name = "otherButton";
            this.otherButton.Size = new System.Drawing.Size(93, 54);
            this.otherButton.TabIndex = 21;
            this.otherButton.Text = "Other\r\nMovies";
            this.otherButton.UseVisualStyleBackColor = false;
            this.otherButton.Click += new System.EventHandler(this.otherButton_Click);
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.ForeColor = System.Drawing.Color.White;
            this.Backbtn.Location = new System.Drawing.Point(30, 660);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(93, 54);
            this.Backbtn.TabIndex = 22;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CineWeb.Properties.Resources.Backgroud;
            this.ClientSize = new System.Drawing.Size(1046, 726);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.otherButton);
            this.Controls.Add(this.PersonalButton);
            this.Controls.Add(this.Inception);
            this.Controls.Add(this.BVS);
            this.Controls.Add(this.Deadpool);
            this.Controls.Add(this.Avengers);
            this.Controls.Add(this.InceptionPictureBox);
            this.Controls.Add(this.BVSPictureBox);
            this.Controls.Add(this.DeadpoolPictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AvengersPicture);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InceptionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BVSPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeadpoolPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvengersPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.PictureBox InceptionPictureBox;
        private System.Windows.Forms.PictureBox BVSPictureBox;
        private System.Windows.Forms.PictureBox DeadpoolPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox AvengersPicture;
        private System.Windows.Forms.Label Avengers;
        private System.Windows.Forms.Label Deadpool;
        private System.Windows.Forms.Label BVS;
        private System.Windows.Forms.Label Inception;
        private System.Windows.Forms.Button PersonalButton;
        private System.Windows.Forms.Button otherButton;
        private System.Windows.Forms.Button Backbtn;
    }
}