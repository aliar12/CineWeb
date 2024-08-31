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
    public partial class PersonalInfo : Form
    {
        Client c = new Client();
        private String connectionString = "Data Source=Cinema.db";
        List<Reservation> reservations = new List<Reservation>();
        int count = 0;
        public PersonalInfo(Client client)
        {
            InitializeComponent();
            this.c = client;
            displayDetails(c);
            ExtractReservations(c);
            if (reservations.Count > 0)
            {
                DisplayYourReservations(reservations.ElementAt(count));
            }
            else { displayDetails(c); }
        }
        public void DisplayYourReservations(Reservation r)
        {
            Res_id.Text = r.Reservation_id.ToString();
            ClientName.Text = r.ClientName;
            MovieName.Text = r.MovieName;
            SeatNumber.Text = r.Seat_number.ToString();
            Date.Text = r.Date;
            Time.Text = r.Time;

        }
        public void displayDetails(Client c)
        {
            
                ID.Text = c.Client_id.ToString();
                age.Text = c.Age.ToString();
                name.Text = c.Name;
                phone.Text = c.PhoneNumber;
                emailtextbox.Text = c.Email;
                pass.Text = c.Password;



            
        }
        public void ExtractReservations(Client c)
        {
            int Reservation_id = 0;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = @"SELECT s.Seat_id, s.Movie_id, s.seat_number, s.date, m.movie_name, m.Time
                             FROM Seat s
                             INNER JOIN Movie m ON s.Movie_id = m.Movie_id
                             WHERE s.Client_id = @ClientId";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClientId", c.Client_id);

                    connection.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Access each record's columns by name or index
                            int seatId = Convert.ToInt32(reader["Seat_id"]);
                            int movieId = Convert.ToInt32(reader["Movie_id"]);
                            string seatNumber = Convert.ToString(reader["seat_number"]);
                            string date = Convert.ToString(reader["date"]);
                            string movieName = Convert.ToString(reader["movie_name"]);
                            string time = Convert.ToString(reader["Time"]);
                            Reservation_id = seatId + movieId + c.Client_id;
                            int Seat_number = 0;
                            if (seatNumber.Equals("one"))
                            {
                                Seat_number = 1;
                            }
                            else if (seatNumber.Equals("two")) { Seat_number = 2; }
                            else if (seatNumber.Equals("three")) { Seat_number = 3; }
                            else if (seatNumber.Equals("four")) { Seat_number = 4; }
                            else if (seatNumber.Equals("five")) { Seat_number = 5; }
                            else if (seatNumber.Equals("six")) { Seat_number = 6; }
                            else if (seatNumber.Equals("seven")) { Seat_number = 7; }
                            else if (seatNumber.Equals("eight")) { Seat_number = 8; }
                            else if (seatNumber.Equals("nine")) { Seat_number = 9; }
                            else if (seatNumber.Equals("ten")) { Seat_number = 10; }
                            else if (seatNumber.Equals("eleven")) { Seat_number = 11; }
                            else if (seatNumber.Equals("twelve")) { Seat_number = 12; }
                            else if (seatNumber.Equals("thirteen")) { Seat_number = 13; }
                            else if (seatNumber.Equals("fourteen")) { Seat_number = 14; }
                            else if (seatNumber.Equals("fifteen")) { Seat_number = 15; }
                            else if (seatNumber.Equals("sixteen")) { Seat_number = 16; }
                            else if (seatNumber.Equals("seventeen")) { Seat_number = 17; }
                            else if (seatNumber.Equals("eighteen")) { Seat_number = 18; }
                            else if (seatNumber.Equals("nineteen")) { Seat_number = 19; }
                            else if (seatNumber.Equals("twenty")) { Seat_number = 20; }
                            else if (seatNumber.Equals("twenty_one")) { Seat_number = 21; }
                            else if (seatNumber.Equals("twenty_two")) { Seat_number = 22; }
                            else if (seatNumber.Equals("twenty_three")) { Seat_number = 23; }
                            else if (seatNumber.Equals("twenty_four")) { Seat_number = 24; }
                            else if (seatNumber.Equals("twenty_five")) { Seat_number = 25; }
                            else if (seatNumber.Equals("twenty_six")) { Seat_number = 26; }
                            else if (seatNumber.Equals("twenty_seven")) { Seat_number = 27; }
                            else if (seatNumber.Equals("twenty_eight")) { Seat_number = 28; }
                            else if (seatNumber.Equals("twenty_nine")) { Seat_number = 29; }
                            else if (seatNumber.Equals("thirty")) { Seat_number = 30; }
                            Reservation r = new Reservation(Reservation_id, c.Name, movieName, Seat_number, date, time);
                            reservations.Add(r);




                        }
                    }
                }
            } // Connection is
        }

        private void Next_Click(object sender, EventArgs e)
        {
            count++;
            if (count > reservations.Count - 1)
            {
                count = 0;
                DisplayYourReservations(reservations.ElementAt(count));

            }
            else
            {
                DisplayYourReservations(reservations.ElementAt(count));
            }
        }

        private void previous_Click(object sender, EventArgs e)
        {
            count--;
            if (count <= 0)
            {
                count = reservations.Count - 1;
                DisplayYourReservations(reservations.ElementAt(count));
            }
            else
            {
                DisplayYourReservations(reservations.ElementAt(count));
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home(c);
            h.ShowDialog();

        }
    }
}
