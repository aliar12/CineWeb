using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineWeb
{
    public class Reservation
    {
        private int reservation_id, seat_number;
        private string movieName, date, time, clientName;

        public Reservation(int reservation_id, String clientName, String movieName, int seat_number, string date, string time)
        {
            this.reservation_id = reservation_id;
            this.clientName = clientName;
            this.seat_number = seat_number;
            this.movieName = movieName;
            this.date = date;
            this.time = time;
        }

        public Reservation()
        {
            this.reservation_id = 0;
            this.clientName = "";
            this.seat_number = 0;
            this.MovieName = "";
            this.date = "";
            this.time = "";

        }
        public int Reservation_id
        {
            get { return reservation_id; }
            set { reservation_id = value; }
        }
        public String ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }
        public int Seat_number
        {
            get { return seat_number; }
            set { seat_number = value; }
        }

        public string MovieName
        {
            get { return movieName; }
            set { movieName = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Time
        {
            get { return time; }
            set { time = value; }
        }



    }
}
