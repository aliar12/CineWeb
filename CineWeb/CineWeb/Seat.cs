using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineWeb
{
    public class Seat
    {
        private int seat_id, movie_id;
        private string available, date, seat_number;

        public Seat(int seat_id, int movie_id, string seat_number, string available, string date)
        {
            this.seat_id = seat_id;
            this.movie_id = movie_id;
            this.seat_number = seat_number;
            this.available = available;
            this.date = date;
        }
        public Seat() { }
        public int Seat_id
        {
            get { return seat_id; }
            set { seat_id = value; }
        }
        public int Movie_id
        {
            get { return movie_id; }
            set { movie_id = value; }
        }
        public string Seat_number
        {
            get { return seat_number; }
            set { seat_number = value; }
        }
        public string Available
        {
            get { return available; }
            set { available = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}
