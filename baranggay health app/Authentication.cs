using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baranggay_health_app
{
    public static class Authentication
    {
       
        
         
            private static string connectionString = "Server=localhost;Database=barranggay;Uid=root;Pwd=harold0328;";


        public static bool AuthenticateUser(string username, string password)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT COUNT(*) FROM users WHERE username = @Username AND password = @Password";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Username", username);
                            command.Parameters.AddWithValue("@Password", password); 
                            int result = Convert.ToInt32(command.ExecuteScalar());
                            return result > 0;
                        }
                    }
                    catch (MySqlException ex)
                    {
                      
                        throw new Exception("Error connecting to the database: " + ex.Message);
                    }
                }
            }
        }
    }

