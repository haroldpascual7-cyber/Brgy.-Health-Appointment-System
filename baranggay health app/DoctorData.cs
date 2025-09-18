using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace baranggay_health_app
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string FullName { get; set; }
        public string Specialization { get; set; }
        public string PatientName { get; set; }
        public string Sex { get; set; }
        public string Purpose { get; set; }
        public string Schedule { get; set; }
    }
    class DoctorData
    {
        private static string connectionString = "Server=localhost;Database=barranggay;Uid=root;Pwd=harold0328;";

        public static List<Doctor> GetDoctors()

        {
            List<Doctor> doctors = new List<Doctor>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT appointments.PatientName, appointments.Sex, appointments.Purpose, appointments.Schedule, doctors.DoctorId, doctors.FirstName, doctors.LastName, doctors.Specialization FROM appointments INNER JOIN doctors ON appointments.Doctor = doctors.FirstName";




                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read()) // Read the first row
                            {
                                Doctor doctor = new Doctor()
                                {
                                    DoctorId = (int)reader["DoctorId"],
                                    FullName = reader["FirstName"].ToString() + " " + reader["LastName"].ToString(),
                                    Specialization = reader["Specialization"].ToString(),
                                    PatientName = reader["PatientName"].ToString(),
                                    Sex = reader["Sex"].ToString(),
                                    Purpose = reader["Purpose"].ToString(),
                                    Schedule = reader["Schedule"].ToString()

                                };

                                doctors.Add(doctor);
                            }
          
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading appointments: " + ex.Message);
                }
            }
            return doctors;
        }
    }
}
