namespace CineWeb
{
    partial class PersonalInfo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailtextbox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Next = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SeatNumber = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.MovieName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Res_id = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(531, 518);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::CineWeb.Properties.Resources.Backgroud;
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.back);
            this.tabPage3.Controls.Add(this.ID);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.emailtextbox);
            this.tabPage3.Controls.Add(this.name);
            this.tabPage3.Controls.Add(this.age);
            this.tabPage3.Controls.Add(this.phone);
            this.tabPage3.Controls.Add(this.pass);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(523, 492);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Details";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(132, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 65);
            this.label3.TabIndex = 49;
            this.label3.Text = "Details";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(95, 393);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(93, 54);
            this.back.TabIndex = 48;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(233, 86);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(134, 20);
            this.ID.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(105, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 32);
            this.label5.TabIndex = 46;
            this.label5.Text = "Client ID : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailtextbox
            // 
            this.emailtextbox.Location = new System.Drawing.Point(233, 288);
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.ReadOnly = true;
            this.emailtextbox.Size = new System.Drawing.Size(134, 20);
            this.emailtextbox.TabIndex = 45;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(233, 136);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(134, 20);
            this.name.TabIndex = 44;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(233, 191);
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Size = new System.Drawing.Size(134, 20);
            this.age.TabIndex = 43;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(233, 235);
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Size = new System.Drawing.Size(134, 20);
            this.phone.TabIndex = 42;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(233, 349);
            this.pass.Name = "pass";
            this.pass.ReadOnly = true;
            this.pass.Size = new System.Drawing.Size(134, 20);
            this.pass.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(127, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 32);
            this.label6.TabIndex = 40;
            this.label6.Text = "Age :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(127, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 32);
            this.label9.TabIndex = 39;
            this.label9.Text = "Email : ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(120, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 32);
            this.label10.TabIndex = 38;
            this.label10.Text = "Phone : ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(89, 338);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 41);
            this.label11.TabIndex = 37;
            this.label11.Text = "Password : ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(127, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 32);
            this.label12.TabIndex = 36;
            this.label12.Text = "Name : ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::CineWeb.Properties.Resources.Backgroud;
            this.tabPage4.Controls.Add(this.Next);
            this.tabPage4.Controls.Add(this.previous);
            this.tabPage4.Controls.Add(this.Time);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.Date);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.SeatNumber);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.MovieName);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.ClientName);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.Res_id);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(523, 492);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Reservations";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.ForeColor = System.Drawing.Color.White;
            this.Next.Location = new System.Drawing.Point(384, 411);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(93, 54);
            this.Next.TabIndex = 66;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // previous
            // 
            this.previous.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previous.ForeColor = System.Drawing.Color.White;
            this.previous.Location = new System.Drawing.Point(57, 411);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(93, 54);
            this.previous.TabIndex = 65;
            this.previous.Text = "Previous";
            this.previous.UseVisualStyleBackColor = false;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(268, 368);
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Size = new System.Drawing.Size(209, 20);
            this.Time.TabIndex = 64;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(52, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 32);
            this.label13.TabIndex = 63;
            this.label13.Text = "Time : ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(268, 306);
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Size = new System.Drawing.Size(209, 20);
            this.Date.TabIndex = 62;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(52, 303);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(183, 32);
            this.label14.TabIndex = 61;
            this.label14.Text = "Date : ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SeatNumber
            // 
            this.SeatNumber.Location = new System.Drawing.Point(268, 253);
            this.SeatNumber.Name = "SeatNumber";
            this.SeatNumber.ReadOnly = true;
            this.SeatNumber.Size = new System.Drawing.Size(209, 20);
            this.SeatNumber.TabIndex = 60;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(52, 250);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(183, 32);
            this.label15.TabIndex = 59;
            this.label15.Text = "Seat Number : ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MovieName
            // 
            this.MovieName.Location = new System.Drawing.Point(268, 209);
            this.MovieName.Name = "MovieName";
            this.MovieName.ReadOnly = true;
            this.MovieName.Size = new System.Drawing.Size(209, 20);
            this.MovieName.TabIndex = 58;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(52, 206);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(183, 32);
            this.label16.TabIndex = 57;
            this.label16.Text = "Movie Name: ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ClientName
            // 
            this.ClientName.Location = new System.Drawing.Point(268, 151);
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            this.ClientName.Size = new System.Drawing.Size(209, 20);
            this.ClientName.TabIndex = 56;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(52, 148);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(183, 32);
            this.label17.TabIndex = 55;
            this.label17.Text = "Client Name : ";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Res_id
            // 
            this.Res_id.Location = new System.Drawing.Point(268, 104);
            this.Res_id.Name = "Res_id";
            this.Res_id.ReadOnly = true;
            this.Res_id.Size = new System.Drawing.Size(209, 20);
            this.Res_id.TabIndex = 54;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(52, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(183, 32);
            this.label18.TabIndex = 53;
            this.label18.Text = "Reservation ID : ";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(151, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(235, 65);
            this.label19.TabIndex = 52;
            this.label19.Text = "Reservations";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PersonalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 520);
            this.Controls.Add(this.tabControl1);
            this.Name = "PersonalInfo";
            this.Text = "PersonalInfo";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailtextbox;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox SeatNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox MovieName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Res_id;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}