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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CineWeb
{
    public partial class SignUp : Form
    {
        private String connectionString = "Data Source=Cinema.db";
        private Client newClient = new Client();
        string nameRegex = @"^[a-zA-Z\s]+$";
        string ageRegex = @"^(?:[1-9][0-9]?|1[0-4][0-9]|150)$";
        string phoneRegex = @"^\d{3}-\d{3}-\d{4}$";
        string emailRegex = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        string passwordRegex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z\d\s]).{8,}$";
        public SignUp()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu meni = new Menu();
            meni.ShowDialog();
            
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            bool isNameValid = Regex.IsMatch(name.Text, nameRegex);
            bool isAgeValid = Regex.IsMatch(age.Text, ageRegex);
            bool isPhoneValid = Regex.IsMatch(phone.Text, phoneRegex);
            bool isEmailValid = Regex.IsMatch(emailtextbox.Text, emailRegex);
            bool isPasswordValid = Regex.IsMatch(pass.Text, passwordRegex);
            if (isNameValid && isAgeValid && isPhoneValid && isEmailValid && isPasswordValid)
            {

                SQLiteConnection sqliteConnection = new SQLiteConnection(connectionString);

                try
                {
                    // Get the last Client_id from the Client table
                    int lastClientId = 0;
                    string getLastClientIdQuery = "SELECT MAX(Client_id) FROM Client";

                    using (SQLiteCommand command = new SQLiteCommand(getLastClientIdQuery, sqliteConnection))
                    {
                        sqliteConnection.Open();
                        object result = command.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            lastClientId = Convert.ToInt32(result);
                        }
                    }

                    int newClientId = lastClientId + 1;

                    string Name = name.Text;
                    int Age = Convert.ToInt32(age.Text);
                    string phoneNumber = phone.Text;
                    string Email = emailtextbox.Text;
                    string password = pass.Text;

                    string insertQuery = "INSERT INTO Client(Client_id, name, age, phone_number, email, password) " +
                                         "VALUES (@ClientId, @Name, @Age, @PhoneNumber, @Email, @Password)";

                    using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, sqliteConnection))
                    {
                        insertCommand.Parameters.AddWithValue("@ClientId", newClientId);
                        insertCommand.Parameters.AddWithValue("@Name", Name);
                        insertCommand.Parameters.AddWithValue("@Age", Age);
                        insertCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        insertCommand.Parameters.AddWithValue("@Email", Email);
                        insertCommand.Parameters.AddWithValue("@Password", password);

                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {

                            // Create a new Client object and store the user input
                            newClient = new Client(Name, phoneNumber, Email, password, newClientId, Age);
                            this.Hide();
                            Home m = new Home(newClient);
                            m.Show();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add new client.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Input Values " + ex);
                    ex = new Exception(ex.Message);
                }
                finally
                {
                    sqliteConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Informations Entred are Invalid");
            }
        }
    }
}

