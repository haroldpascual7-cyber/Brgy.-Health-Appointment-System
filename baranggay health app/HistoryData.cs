using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baranggay_health_app
{
    class HistoryData
    {
        private static string connectionString = "Server=localhost;Database=barranggay;Uid=root;Pwd=harold0328;";

        public static DataTable GetHistory()

        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM history";
                    ;

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt); // Fill DataTable with query results
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading appointments: " + ex.Message);
                }
            }
            return dt;
        }
    }
}
