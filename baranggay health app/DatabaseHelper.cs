using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baranggay_health_app
{
    public static class DatabaseHelper
    {


        // Corrected Connection String for MySQL
        private static string connectionString = "Server=localhost;Database=barranggay;Uid=root;Pwd=harold0328;";

        public static bool RegisterUser(string firstname, string middlename, string lastname, int age, DateTime dateOfBirth,
                                        string gender, string contactNumber, string location, string username, string password, string email, out string message)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO Users (Firstname, Middlename, Lastname, Age, DateOfBirth, Gender, ContactNumber, Location, Username, Password, Email)
                                     VALUES (@Firstname, @Middlename, @Lastname, @Age, @DateOfBirth, @Gender, @ContactNumber, @Location, @Username, @Password, @Email)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Firstname", firstname);
                        cmd.Parameters.AddWithValue("@Middlename", string.IsNullOrWhiteSpace(middlename) ? DBNull.Value : (object)middlename);
                        cmd.Parameters.AddWithValue("@Lastname", lastname);
                        cmd.Parameters.AddWithValue("@Age", age);
                        cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        cmd.Parameters.AddWithValue("@Location", location);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password); // Hashing recommended
                        cmd.Parameters.AddWithValue("@Email", email);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            message = "Registration successful!";
                            return true;
                        }
                        else
                        {
                            message = "Registration failed.";
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    message = "Error: " + ex.Message;
                    return false;
                }
            }
        }
        public static bool insertPatient(string patientName,  DateTime birthDate, int age, string sex,
                               string purpose, string schedule,
                               string guardian, string contactNumber, string address, out string message)
        {

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO patients (patientname, birthdate, age, sex, purpose, schedule, guardian, contactnumber, address) 
                 VALUES (@PatientName, @BirthDate, @Age, @Sex, @Purpose, @Schedule, @Guardian, @ContactNumber, @Address)";


                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add the parameters to the query

                        cmd.Parameters.AddWithValue("@PatientName", patientName);
                        cmd.Parameters.AddWithValue("@BirthDate", birthDate);
                        cmd.Parameters.AddWithValue("@Age", age);
                        cmd.Parameters.AddWithValue("@Sex", sex);
                        cmd.Parameters.AddWithValue("@Purpose", purpose);
                        cmd.Parameters.AddWithValue("@Schedule", schedule);
                        cmd.Parameters.AddWithValue("@Guardian", guardian);
                        cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        cmd.Parameters.AddWithValue("@Address", address);

                        int rows = cmd.ExecuteNonQuery(); // Execute the query
                        if (rows > 0)
                        {
                            message = "Patient added! ";
                            return true;
                        }
                        else
                        {
                            message = "Patient not added ";
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    message = "error  " + ex.Message;
                    return false;
                }


            }
        }

        public static bool AddAppointment(string PatientName, DateTime birthDate, int age, string sex,
                                          string purpose, string doctor, string schedule,
                                          string guardian, string contactNumber, string address, int doctorid, out string message)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO appointments ( PatientName , birthdate, age, sex, purpose, doctor, schedule, guardian, contactnumber, address,doctorid)
                                     VALUES (@PatientName, @BirthDate, @Age, @Sex, @Purpose, @Doctor, @Schedule, @Guardian, @ContactNumber, @Address,@DoctorId)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PatientName", PatientName);
                       
                        cmd.Parameters.AddWithValue("@BirthDate", birthDate);
                        cmd.Parameters.AddWithValue("@Age", age);
                        cmd.Parameters.AddWithValue("@Sex", sex);
                        cmd.Parameters.AddWithValue("@Purpose", purpose);
                        cmd.Parameters.AddWithValue("@Doctor", doctor);
                        cmd.Parameters.AddWithValue("@Schedule", schedule);
                        cmd.Parameters.AddWithValue("@Guardian", guardian);
                        cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@DoctorId", doctorid);



                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            message = "Appointment scheduled successfully!";
                            return true;
                        }
                        else
                        {
                            message = "Failed to schedule appointment.";
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    message = "Error: " + ex.ToString();
                    return false;
                }
            }
        }
        public static bool UpdateAppointment(int appointmentId, string patientName, DateTime birthDate, int age, string sex,
        string purpose, string doctor, string schedule, string guardian, string contactNumber, string address, int doctorId, out string message)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE appointments 
                                SET PatientName = @patientName, BirthDate = @birthDate, Age = @age, Sex = @sex, 
                                    Purpose = @purpose, Doctor = @doctor, Schedule = @schedule, Guardian = @guardian, 
                                    ContactNumber = @contactNumber, Address = @address, DoctorId = @doctorId
                                WHERE IdApp = @appointmentId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@patientName", patientName);
                        cmd.Parameters.AddWithValue("@birthDate", birthDate);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@sex", sex);
                        cmd.Parameters.AddWithValue("@purpose", purpose);
                        cmd.Parameters.AddWithValue("@doctor", doctor);
                        cmd.Parameters.AddWithValue("@schedule", schedule);
                        cmd.Parameters.AddWithValue("@guardian", guardian);
                        cmd.Parameters.AddWithValue("@contactNumber", contactNumber);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@doctorId", doctorId);
                        cmd.Parameters.AddWithValue("@appointmentId", appointmentId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            message = "Appointment updated successfully!";
                            return true;
                        }
                        else
                        {
                            message = "No changes were made to the appointment.";
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                message = $"Database error: {ex.Message}";
                return false;
            }
        }
        
        public static bool UpdateAppointment1(int appointmentId, string patientName, DateTime birthDate, int age, string sex,
        string purpose, string doctor, string schedule, string guardian, string contactNumber, string address, int doctorId, out string message)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE appointments 
                            SET PatientName = @patientName, BirthDate = @birthDate, Age = @age, Sex = @sex, 
                                Purpose = @purpose, Doctor = @doctor, Schedule = @schedule, Guardian = @guardian, 
                                ContactNumber = @contactNumber, Address = @address, DoctorId = @doctorId
                            WHERE IdApp = @appointmentId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@patientName", patientName);
                        cmd.Parameters.AddWithValue("@birthDate", birthDate);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@sex", sex);
                        cmd.Parameters.AddWithValue("@purpose", purpose);
                        cmd.Parameters.AddWithValue("@doctor", doctor);
                        cmd.Parameters.AddWithValue("@schedule", schedule);
                        cmd.Parameters.AddWithValue("@guardian", guardian);
                        cmd.Parameters.AddWithValue("@contactNumber", contactNumber);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@doctorId", doctorId);
                        cmd.Parameters.AddWithValue("@appointmentId", appointmentId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        message = rowsAffected > 0 ? "Appointment updated successfully!" : "No changes were made.";
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                message = $"Database error: {ex.Message}";
                return false;
            }
        }

        internal static bool AddAppointment(string text1, string text2, string text3, DateTime date, int v1, string v2, string v3, string v4, string v5, string text4, string text5, string text6, int v6, out string message)
        {
            throw new NotImplementedException();
        }

        internal static bool insertPatient(string text1, string text2, string text3, DateTime date, int v1, string v2, string v3, string v4, string text4, string text5, string text6, out string messages)
        {
            throw new NotImplementedException();
        }

        internal static bool insertPatient(DateTime date, int v1, string v2, string v3, string v4, string text2, string text3, string text4, out string messages)
        {
            throw new NotImplementedException();
        }
    }
}