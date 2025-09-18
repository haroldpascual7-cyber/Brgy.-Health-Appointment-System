using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baranggay_health_app
{
    public static class deletehandler
    {
        private static string connectionString = "Server=localhost;Database=barranggay;Uid=root;Pwd=harold0328;";
        public static bool MoveToHistoryAndDelete(int appointmentId, out string message)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Move the deleted appointment to the history table
                    string moveQuery = @"
                        INSERT INTO history (id, patientname, birthdate, age, sex, purpose, doctor, schedule, guardian, contactnumber, address, DoctorId)
                        SELECT IdApp, patientname, birthdate, age, sex, purpose, doctor, schedule, guardian, contactnumber, address, DoctorId
                        FROM appointments
                        WHERE IdApp = @AppointmentID";

                    using (MySqlCommand moveCmd = new MySqlCommand(moveQuery, conn))
                    {
                        moveCmd.Parameters.AddWithValue("@AppointmentID", appointmentId);
                        moveCmd.ExecuteNonQuery();
                    }

                    // Now delete from the original table
                    string deleteQuery = "DELETE FROM appointments WHERE IdApp = @AppointmentID";

                    using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@AppointmentID", appointmentId);
                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            message = "Appointment deleted successfully and moved to history.";
                            return true;
                        }
                        else
                        {
                            message = "Deletion failed. Appointment not found.";
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
             
                public static bool DeleteHistoryRecord(int appointmentId, out string message)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string deleteQuery = @"DELETE FROM history WHERE id = @appointmentId";

                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            message = "History record deleted successfully!";
                            return true;
                        }
                        else
                        {
                            message = "No record was deleted. The appointment may not exist in history.";
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

    }
}
    

