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

namespace CineWeb
{
    public partial class Seats : Form
    {
        Client client = new Client();
        Movie movie = new Movie();
        Seat Seat = new Seat();
        String date = "";
        private String connectionString = "Data Source=Cinema.db";
        public Seats(Client c, Movie m,String d)
        {
            InitializeComponent();
            client = c;
            movie = m;
            moviname.Text = m.Movie_name;
            date = d;
            seatStaus();
        }

        public void seatStaus()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand("SELECT seat_number, available FROM Seat WHERE Movie_id = @MovieId AND Date = @Date", connection))
                {
                    command.Parameters.AddWithValue("@MovieId", movie.Movie_id);
                    command.Parameters.AddWithValue("@Date", date);


                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string seatNumber = reader.GetString(0); // Assuming seat_number is stored as string in the database
                            string availableStatus = reader.GetString(1);

                            // Find the button by name (assuming buttons are named after seat strings)
                            Button button = Controls.Find(seatNumber, true).FirstOrDefault() as Button;

                            if (button != null)
                            {
                                if (availableStatus == "false")
                                {
                                    button.BackColor = Color.DarkRed;
                                    button.ForeColor = Color.White;
                                    button.Enabled = false;
                                }
                            }
                        }
                    }
                }
                connection.Close();

            }
        }

        private void SeatClicked_Click(object sender, EventArgs e)
        {
            Button seat = sender as Button;
            string seatName = seat.Name;
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("SELECT MAX(Seat_id) FROM Seat", connection);
            int lastSeatId = Convert.ToInt32(command.ExecuteScalar());
           //determine the next seat_id;
            int incrementedSeatId = lastSeatId + 1;
            connection.Close();
            Seat = new Seat(incrementedSeatId, movie.Movie_id, seatName, "false", date);
            this.Hide();
            Payment form = new Payment(client, movie, Seat);
            form.ShowDialog();

        }
                

               
            
      

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseDate form = new ChooseDate(client, movie);
            form.ShowDialog();
        }
    }
}

        
    

