using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineWeb
{
    public partial class ChooseDate : Form
    {
        Client client = new Client();
        Movie movie = new Movie();
        String date = "";
        
        public ChooseDate(Client c, Movie m)
        {
            InitializeComponent();
            movie = m;
            client = c;
            moviname.Text = m.Movie_name;
            monthCalendar1.MinDate = DateTime.Today.AddDays(1);
            monthCalendar1.MaxDate = DateTime.Today.AddMonths(3);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart; // Get the selected date
            string allowedDayString = movie.Day; // Replace with your allowed day as string

            if (Enum.TryParse(allowedDayString, out DayOfWeek allowedDay))
            {
                if (selectedDate.DayOfWeek != allowedDay)
                {
                    MessageBox.Show("This movie is only available to watch on " + allowedDayString + "s");

                }
                else
                {
                    date = selectedDate.ToLongDateString();
                    
                }
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seats form = new Seats(client,movie,date);
            form.ShowDialog();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeletedMovie form = new SeletedMovie(client, movie.Movie_name);
            form.ShowDialog();
        }
    }
}
