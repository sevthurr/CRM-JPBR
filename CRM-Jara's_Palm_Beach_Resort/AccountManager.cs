using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using BCrypt.Net;

namespace CRM_Jara_s_Palm_Beach_Resort
{
    public class AccountManager
    {
        private readonly string connectionString = @"Server=localhost;Database=JPBR;Trusted_Connection=True;TrustServerCertificate=True;";

        public (bool Success, int UserID, string Position) Authenticate(string userName, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT UserID, HashedPassword, UserPosition FROM [dbo].[Account] WHERE UserName = @UserName";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", userName);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHash = reader["HashedPassword"].ToString();
                                if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                                {
                                    int userID = (int)reader["UserID"];
                                    string position = reader["UserPosition"].ToString();
                                    return (true, userID, position);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Authentication error: {ex.Message}");
                }
                return (false, -1, null);
            }
        }

        public void LogAction(int userID, string action, string details)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO [dbo].[Logs] (UserID, Action, Details)
                                    VALUES (@UserID, @Action, @Details)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.Parameters.AddWithValue("@Action", action);
                        cmd.Parameters.AddWithValue("@Details", details ?? (object)DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Logging error: {ex.Message}");
                }
            }
        }

        public bool ResetPassword(int userID, string newPassword)
        {
            if (userID <= 0)
            {
                MessageBox.Show("Invalid Account ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("New password is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Verify UserID exists and account is active
                    string verifyQuery = @"SELECT COUNT(1) FROM [dbo].[Account] 
                                          WHERE UserID = @UserID AND UserStatus = 'Active'";
                    using (SqlCommand verifyCmd = new SqlCommand(verifyQuery, conn))
                    {
                        verifyCmd.Parameters.AddWithValue("@UserID", userID);
                        int count = (int)verifyCmd.ExecuteScalar();
                        if (count == 0)
                        {
                            MessageBox.Show("Account ID not found or account is inactive. Please contact an administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }

                    // Update the password
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);
                    string updateQuery = @"UPDATE [dbo].[Account]
                                          SET HashedPassword = @HashedPassword
                                          WHERE UserID = @UserID";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@UserID", userID);
                        updateCmd.Parameters.AddWithValue("@HashedPassword", hashedPassword);
                        int rowsAffected = updateCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            LogAction(userID, "ResetPassword", $"User with ID {userID} reset their password via forgot password");
                            return true;
                        }
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error resetting password: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}
