using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineWeb
{
    public partial class Receipt : Form
    {
        Client client = new Client();
        Movie Movie = new Movie();
        Seat seat = new Seat();

        private String connectionString = "Data Source=Cinema.db";
        public Receipt(Client c,Movie m , Seat s)
        {
            InitializeComponent();
            client = c;
            Movie = m;
            seat = s;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = @"INSERT INTO Seat (Seat_id,Client_id, Movie_id, seat_number, available, date) 
                             VALUES (@SeatId, @Client_id, @MovieId, @SeatNumber, @Available, @Date)";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SeatId", seat.Seat_id);
                    command.Parameters.AddWithValue("@Client_id", client.Client_id);
                    command.Parameters.AddWithValue("@MovieId", Movie.Movie_id);
                    command.Parameters.AddWithValue("@SeatNumber", seat.Seat_number);
                    command.Parameters.AddWithValue("@Available", "false");
                    command.Parameters.AddWithValue("@Date", seat.Date);

                    command.ExecuteNonQuery();
                }
            }
            String seatNumber = seat.Seat_number;
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
            else if (seatNumber.Equals("thirty"))
            {
                Seat_number = 30;
            }
                Reservation.Text = (seat.Seat_id + Movie.Movie_id + client.Client_id).ToString();
            Client_id.Text = client.Client_id.ToString();
            name.Text = client.Name;
            Moviename.Text = Movie.Movie_name;
            Date.Text = seat.Date;
            Time.Text = Movie.Time;
            NumberOfSeat.Text = Seat_number.ToString();
            Price.Text = Movie.Price.ToString("0.00") + "$";




        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
