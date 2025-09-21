using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using BCrypt;

namespace CRM_Jara_s_Palm_Beach_Resort
{
    public class DatabaseHelper
    {
        private static readonly string connectionString = @"Server=localhost;Database=JPBR;Trusted_Connection=True;TrustServerCertificate=True;";

        public static bool TestConnection()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Connection successful!");
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Connection failed: {ex.Message}");
                    return false;
                }
            }
        }

        public static void GeneratePasswordHash(string password)
        {
            string hash = BCrypt.Net.BCrypt.HashPassword(password);
            MessageBox.Show($"Generated hash for '{password}': {hash}", "Password Hash");
        }
    }
}
