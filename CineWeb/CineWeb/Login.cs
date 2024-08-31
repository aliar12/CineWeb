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
    public partial class Login : Form
    {
        private String connectionString = "Data Source=Cinema.db";
        
        public Login()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Menu meni = new Menu();
            meni.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = PassTextBox.Text;

            // SQL command to check if email and password match in the database
            string sqlQuery = "SELECT Name, Phone_Number, Email, Password, Client_ID, Age FROM Client WHERE Email = @Email AND Password = @Password";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        connection.Open();
                        SQLiteDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            // Retrieve values from the database and create a Client object
                            string name = reader["Name"].ToString();
                            string phoneNumber = reader["Phone_Number"].ToString();
                            int clientId = Convert.ToInt32(reader["Client_ID"]);
                            int age = Convert.ToInt32(reader["Age"]);

                            // Create a Client object and store retrieved information using setters
                            this.Hide();
                            Client c = new Client(name, phoneNumber, email, password, clientId, age);
                            Home m = new Home(c);
                            m.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password", "Invalid Information");
                        }

                        reader.Close(); // Close the data reader
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            
            
        }
    }
}
            

        
    

