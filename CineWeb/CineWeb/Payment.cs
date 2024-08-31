using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace CineWeb
{
    

    public partial class Payment : Form
    {
        string cardNumberPattern = @"^\d{4}-\d{4}-\d{4}-\d{4}$";
        string cvvPattern = @"^\d{3,4}$";
        string expireDatePattern = @"^(0[1-9]|1[0-2])\/[0-9]{2}$";
        Client client = new Client();
        Movie Movie = new Movie();
        Seat seat = new Seat();

        public Payment(Client c,Movie m,Seat s)
        {
            InitializeComponent();
            Movie = m;
            client = c;
            seat = s;
            Moviename.Text = Movie.Movie_name;
            Date.Text = seat.Date;
            Time.Text = Movie.Time;
            Price.Text = Movie.Price.ToString("0.00") + "$";

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seats form = new Seats(client, Movie, seat.Date);
            form.ShowDialog();
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Card.Text, cardNumberPattern) && Regex.IsMatch(Expire.Text, expireDatePattern) && Regex.IsMatch(CVV.Text, cvvPattern))
            {
                this.Hide();
                Receipt receipt = new Receipt(client, Movie, seat);
                receipt.ShowDialog();
            }
            else
            {
                MessageBox.Show("Payement information is not provided correctly");
            }
        }
    }
}
