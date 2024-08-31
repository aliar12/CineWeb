using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineWeb
{
    public partial class AllMovies : Form
    {    Client client = new Client();
        public AllMovies(Client c)
        {
            InitializeComponent();
            client = c;
        }

        private void ActionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();
            String name = ActionBox.SelectedItem.ToString();
            SeletedMovie form = new SeletedMovie(client,name);
            form.ShowDialog();

        }

        private void RomanceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();
            String name = RomanceBox.SelectedItem.ToString();
            SeletedMovie form = new SeletedMovie(client, name);
            form.ShowDialog();
        }

        private void DramaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();
            String name = DramaBox.SelectedItem.ToString();
            SeletedMovie form = new SeletedMovie(client, name);
            form.ShowDialog();
        }

        private void ComedyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();
            String name = ComedyBox.SelectedItem.ToString();
            SeletedMovie form = new SeletedMovie(client, name);
            form.ShowDialog();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home form = new Home(client);
            form.ShowDialog();
            
        }
    }
}
