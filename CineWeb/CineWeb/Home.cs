using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineWeb
{
    public partial class Home : Form
    {
        Client c = new Client();

        public Home(Client client)
        {
            InitializeComponent();
             c = client;
        }
       

        private void Home_Load(object sender, EventArgs e)
        {
            Avengers.Font = new Font(Avengers.Font, FontStyle.Italic);
            Deadpool.Font = new Font(Deadpool.Font, FontStyle.Italic);
            BVS.Font = new Font(BVS.Font, FontStyle.Italic);
            Inception.Font = new Font(Inception.Font, FontStyle.Italic);
        }

        private void PersonalButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonalInfo d = new PersonalInfo(c);
            d.ShowDialog();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
            
        }

        private void AvengersPicture_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeletedMovie form = new SeletedMovie(c, "Avengers: Endgame");
            form.ShowDialog();
        }

        private void DeadpoolPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeletedMovie form = new SeletedMovie(c, "Deadpool");
            form.ShowDialog();
        }

        private void BVSPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeletedMovie form = new SeletedMovie(c, "Batman v Superman: Dawn of Justice");
            form.ShowDialog();
        }

        private void InceptionPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeletedMovie form = new SeletedMovie(c, "Inception");
            form.ShowDialog();
        }

        private void otherButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllMovies form = new AllMovies(c);   
            form.ShowDialog();
        }
    }
}

        

       