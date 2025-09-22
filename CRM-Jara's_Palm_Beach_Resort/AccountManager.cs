using BCrypt.Net;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public (bool Success, int BookingID) CreateBooking(BookingFormData data, int userID)
        {
            if (userID <= 0)
            {
                MessageBox.Show("You must be logged in to create a booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false, -1);
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    // Insert into Guest table
                    string guestQuery = @"INSERT INTO [dbo].[Guest] (FName, MName, LName, Suffix, Email, Phone, Address, [Contact-able])
                                         OUTPUT INSERTED.GuestID
                                         VALUES (@FName, @MName, @LName, @Suffix, @Email, @Phone, @Address, @Contactable)";
                    int guestID;
                    using (SqlCommand guestCmd = new SqlCommand(guestQuery, conn, transaction))
                    {
                        guestCmd.Parameters.AddWithValue("@FName", data.FirstName);
                        guestCmd.Parameters.AddWithValue("@MName", (object)data.MiddleName ?? DBNull.Value);
                        guestCmd.Parameters.AddWithValue("@LName", data.LastName);
                        guestCmd.Parameters.AddWithValue("@Suffix", (object)data.Suffix ?? DBNull.Value);
                        guestCmd.Parameters.AddWithValue("@Email", (object)data.Email ?? DBNull.Value);
                        guestCmd.Parameters.AddWithValue("@Phone", data.Contact);
                        guestCmd.Parameters.AddWithValue("@Address", data.Address);
                        guestCmd.Parameters.AddWithValue("@Contactable", 1);
                        guestID = (int)guestCmd.ExecuteScalar();
                    }

                    // Insert into BookingDetails table
                    string package = data.PackageASelected ? "Package A" : "Package B";
                    string bookingDetailsQuery = @"INSERT INTO [dbo].[BookingDetails] (BookingDate, CheckInDate, CheckOutDate, BookingStatus, Pax, Package)
                                                 OUTPUT INSERTED.BookingDetailsID
                                                 VALUES (@BookingDate, @CheckInDate, @CheckOutDate, @BookingStatus, @Pax, @Package)";
                    int bookingDetailsID;
                    using (SqlCommand bookingDetailsCmd = new SqlCommand(bookingDetailsQuery, conn, transaction))
                    {
                        bookingDetailsCmd.Parameters.AddWithValue("@BookingDate", data.BookingDate.Date);
                        bookingDetailsCmd.Parameters.AddWithValue("@CheckInDate", data.CheckIn.Date);
                        bookingDetailsCmd.Parameters.AddWithValue("@CheckOutDate", data.CheckOut.Date);
                        bookingDetailsCmd.Parameters.AddWithValue("@BookingStatus", "Pending");
                        bookingDetailsCmd.Parameters.AddWithValue("@Pax", data.GuestQty);
                        bookingDetailsCmd.Parameters.AddWithValue("@Package", package);
                        bookingDetailsID = (int)bookingDetailsCmd.ExecuteScalar();
                    }

                    // Insert into PaymentDetails table (placeholder values)
                    string paymentQuery = @"INSERT INTO [dbo].[PaymentDetails] (PaymentDate, Amount, PaymentMethod, PaymentStatus)
                                          OUTPUT INSERTED.PaymentID
                                          VALUES (@PaymentDate, @Amount, @PaymentMethod, @PaymentStatus)";
                    int paymentID;
                    using (SqlCommand paymentCmd = new SqlCommand(paymentQuery, conn, transaction))
                    {
                        paymentCmd.Parameters.AddWithValue("@PaymentDate", DateTime.Today);
                        paymentCmd.Parameters.AddWithValue("@Amount", 0.00m); // Placeholder
                        paymentCmd.Parameters.AddWithValue("@PaymentMethod", "Pending"); // Placeholder
                        paymentCmd.Parameters.AddWithValue("@PaymentStatus", "Pending");
                        paymentID = (int)paymentCmd.ExecuteScalar();
                    }

                    // Insert into Booking table
                    string bookingQuery = @"INSERT INTO [dbo].[Booking] (GuestID, BookingDetailsID, PaymentID)
                                          OUTPUT INSERTED.BookingID
                                          VALUES (@GuestID, @BookingDetailsID, @PaymentID)";
                    int bookingID;
                    using (SqlCommand bookingCmd = new SqlCommand(bookingQuery, conn, transaction))
                    {
                        bookingCmd.Parameters.AddWithValue("@GuestID", guestID);
                        bookingCmd.Parameters.AddWithValue("@BookingDetailsID", bookingDetailsID);
                        bookingCmd.Parameters.AddWithValue("@PaymentID", paymentID);
                        bookingID = (int)bookingCmd.ExecuteScalar();
                    }

                    // Log the action
                    LogAction(userID, "CreateBooking", $"Created booking ID {bookingID} for guest {data.FirstName} {data.LastName}");
                    transaction.Commit();
                    return (true, bookingID);
                }
                catch (Exception ex)
                {
                    transaction?.Rollback();
                    MessageBox.Show($"Error creating booking: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (false, -1);
                }
            }
        }

        public DataTable GetBookingList()
        {
            DataTable bookings = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT BookingID, GuestName, [Date], [Status], [Payment] FROM [dbo].[BookingListView]";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        adapter.Fill(bookings);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading bookings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return bookings;
            }
        }

    }
}
