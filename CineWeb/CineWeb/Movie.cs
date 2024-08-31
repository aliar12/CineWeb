using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CineWeb
{
    public class Movie
    {

        private string movie_name, movie_url, movie_description, type, day, time;
        private int movie_id;
        private double price;

        public Movie(string movie_name, string movie_url, string movie_description, string type, string day, string time, int movie_id, double price)
        {
            this.movie_name = movie_name;
            this.movie_url = movie_url;
            this.movie_description = movie_description;
            this.type = type;
            this.day = day;
            this.time = time;
            this.movie_id = movie_id;
            this.price = price;
        }
        public Movie()
        {
            this.movie_name = "";
            this.movie_url = "";
            this.movie_description = "";
            this.type = "";
            this.day = "";
            this.time = "";
            this.movie_id = 0;
            this.price = 0.00;
        }
        public string Movie_name
        {
            get { return movie_name; }
            set { movie_name = value; }
        }
        public string Movie_url
        {
            get { return movie_url; }
            set { movie_url = value; }
        }
        public string Movie_description
        {
            get { return movie_description; }
            set { movie_description = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Day
        {
            get { return day; }
            set { day = value; }
        }
        public string Time
        {
            get { return time; }
            set { time = value; }
        }
        public int Movie_id
        {
            get { return movie_id; }
            set { movie_id = value; }
        }


        public string DaytoString()
        {
            return this.day;
        }
        public string TimeToString()
        {
            return this.time;
        }
        public override string ToString()
        {

            return this.movie_id + "\r" + this.movie_name + "\n" + this.type + "\n" + this.price + "\n" + this.day + "\n" + this.time + "\n" + this.movie_description + "\n" + this.movie_url;

        }

    }
}
