using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineWeb
{
    
        public class Client
        {
            private string connectionString = "Data Source=Cinema.db;";
            private string name, phone_number, email, password;
            int client_id, age;
            public Client(string name, string phone_number, string email, string password, int client_id, int age)
            {
                this.name = name;
                this.phone_number = phone_number;
                this.email = email;
                this.password = password;
                this.client_id = client_id;
                this.age = age;
            }
            public Client()
            {
                this.name = "";
                this.phone_number = "";
                this.email = "";
                this.password = "";
                this.client_id = 0;
                this.age = 0;
            }
            public string Name
            {
            get { return name; }
            set { name = value; }
            }
            public string PhoneNumber
        {
            get { return phone_number; }
            set { phone_number = value; }
        }
            public string Email
        {
            get { return email; }
            set { email = value; }
        }
            public string Password
        {
            get { return password; }
            set { password = value; }
        }
            public int Client_id
        {
            get { return client_id; }
            set { client_id = value; }
        }
            public int Age {
            get { return age; }
            set { age = value; }
        }

            public string toString()
            {
                return "Id: " + this.client_id + "\nName: " + this.name + "\nAge: " + this.age + "\nPhone: " + this.phone_number + "\nEmail: " + this.email + "\nPassword: " + this.password + "\nname: " + this.name;
            }
            public Movie SelectMovie(String name)
            {
                string selectQuery = "SELECT * FROM Movie WHERE movie_name = @Name";
                Movie movie = null;

                using (SQLiteConnection sqliteConnection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, sqliteConnection))
                    {
                        command.Parameters.AddWithValue("@Name", name);

                        try
                        {
                            sqliteConnection.Open();
                            SQLiteDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                movie = new Movie(
                                reader["movie_name"].ToString(),
                                reader["image"].ToString(),
                                reader["description"].ToString(),
                                reader["type"].ToString(),
                                reader["Day"].ToString(),
                                reader["Time"].ToString(),
                                Convert.ToInt32(reader["Movie_id"]),
                                Convert.ToDouble(reader["price"])
                            );
                            }

                            reader.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                    }
                }

                return movie;
            }
            public void SelectDate()
            {

            }
            public void SelectSeat()
            {

            }



        }
    }
