using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CineWeb
{
    public partial class SeletedMovie : Form
    {
        Client client = new Client();
        String name = "";
        Movie movie = new Movie();
        private String connectionString = "Data Source=Cinema.db";
        public SeletedMovie(Client c, String n)
        {
            InitializeComponent();
            client = c;
            name = n;
        }

        private void SeletedMovie_Load(object sender, EventArgs e)
        {
            extractMovieInfo();
            MovieName.Text = name;
            PictureBox.Image = ((Image)(Properties.Resources.ResourceManager.GetObject(movie.Movie_url)));
            MovieName.Text = movie.Movie_name;
            Description.Text = movie.Movie_description;
            amount.Text = "Price : "+movie.Price.ToString("0.00") + "$";
            Kind.Text = "Type : "+movie.Type;
            dateTime.Text = "Schedule : Every " + movie.Day + " at " + movie.Time;

        }

        private void extractMovieInfo()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Movie_id, type, price, Day, Time, description, image FROM Movie WHERE movie_name = @MovieName";


                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MovieName", name);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int movieId = Convert.ToInt32(reader["Movie_id"]);
                            string type = reader["type"].ToString();
                            double price = Convert.ToDouble(reader["price"]);
                            string day = reader["Day"].ToString();
                            string time = reader["Time"].ToString();
                            string description = reader["description"].ToString();
                            string image = reader["image"].ToString();
                            movie = new Movie(name,  image,  description,  type,  day,  time,  movieId,  price);

                        }
                    }
                }

                connection.Close();
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home(client);
            home.ShowDialog();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseDate form = new ChooseDate(client, movie);
            form.ShowDialog();
        }
    }
}

