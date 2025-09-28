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

        public bool IsContactNumberUsed(string contact)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(1) FROM [dbo].[Guest] WHERE Phone = @Phone";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Phone", contact);
                        return (int)cmd.ExecuteScalar() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error checking contact number: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public (bool Success, int BookingID) CreateBooking(BookingFormData data, int userID, string paymentMethod)
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
                        guestCmd.Parameters.AddWithValue("@Email", data.Email);
                        guestCmd.Parameters.AddWithValue("@Phone", data.Contact);
                        guestCmd.Parameters.AddWithValue("@Address", data.Address);
                        guestCmd.Parameters.AddWithValue("@Contactable", 1);
                        guestID = (int)guestCmd.ExecuteScalar();
                    }

                    // Insert into BookingDetails table
                    string package = data.PackageASelected ? "Package A" : "Package B";
                    string bookingDetailsQuery = @"INSERT INTO [dbo].[BookingDetails] (BookingDate, CheckInDate, CheckOutDate, BookingStatus, Pax, Package, PromoCode)
                                                 OUTPUT INSERTED.BookingDetailsID
                                                 VALUES (@BookingDate, @CheckInDate, @CheckOutDate, @BookingStatus, @Pax, @Package, @PromoCode)";
                    int bookingDetailsID;
                    using (SqlCommand bookingDetailsCmd = new SqlCommand(bookingDetailsQuery, conn, transaction))
                    {
                        bookingDetailsCmd.Parameters.AddWithValue("@BookingDate", data.BookingDate.Date);
                        bookingDetailsCmd.Parameters.AddWithValue("@CheckInDate", data.CheckIn.Date);
                        bookingDetailsCmd.Parameters.AddWithValue("@CheckOutDate", data.CheckOut.Date);
                        bookingDetailsCmd.Parameters.AddWithValue("@BookingStatus", "Pending");
                        bookingDetailsCmd.Parameters.AddWithValue("@Pax", data.GuestQty);
                        bookingDetailsCmd.Parameters.AddWithValue("@Package", package);
                        bookingDetailsCmd.Parameters.AddWithValue("@PromoCode", (object)data.PromoCode ?? DBNull.Value);
                        bookingDetailsID = (int)bookingDetailsCmd.ExecuteScalar();
                    }

                    // Calculate payment amount
                    decimal basePrice = data.PackageASelected ? 15000m : 12000m;
                    int maxGuests = data.PackageASelected ? 30 : 20;
                    decimal extraGuestRate = 100m;
                    int daysStaying = (data.CheckOut.Date - data.CheckIn.Date).Days;
                    int excessGuests = Math.Max(0, data.GuestQty - maxGuests);
                    decimal excessAmount = excessGuests * extraGuestRate * daysStaying;
                    decimal totalBeforeDiscount = (basePrice * daysStaying) + excessAmount;
                    decimal discountPercentage = data.PromoCode == "SUMMER25" ? 25m : 0m;
                    decimal discountAmount = totalBeforeDiscount * (discountPercentage / 100m);
                    decimal totalAmount = totalBeforeDiscount - discountAmount;

                    // Insert into PaymentDetails table
                    string paymentQuery = @"INSERT INTO [dbo].[PaymentDetails] (PaymentDate, Amount, PaymentMethod, PaymentStatus)
                                          OUTPUT INSERTED.PaymentID
                                          VALUES (@PaymentDate, @Amount, @PaymentMethod, @PaymentStatus)";
                    int paymentID;
                    using (SqlCommand paymentCmd = new SqlCommand(paymentQuery, conn, transaction))
                    {
                        paymentCmd.Parameters.AddWithValue("@PaymentDate", DateTime.Today);
                        paymentCmd.Parameters.AddWithValue("@Amount", totalAmount);
                        paymentCmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
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

        public (bool Success, BookingDetailsData BookingDetails) GetBookingDetails(int bookingID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            g.FName + ' ' + ISNULL(g.MName + ' ', '') + g.LName AS GuestName,
                            bd.Package,
                            bd.CheckInDate,
                            bd.CheckOutDate,
                            bd.Pax,
                            pd.Amount
                        FROM [dbo].[Booking] b
                        JOIN [dbo].[Guest] g ON b.GuestID = g.GuestID
                        JOIN [dbo].[BookingDetails] bd ON b.BookingDetailsID = bd.BookingDetailsID
                        JOIN [dbo].[PaymentDetails] pd ON b.PaymentID = pd.PaymentID
                        WHERE b.BookingID = @BookingID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookingID", bookingID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var details = new BookingDetailsData
                                {
                                    GuestName = reader["GuestName"].ToString(),
                                    Package = reader["Package"].ToString(),
                                    CheckInDate = Convert.ToDateTime(reader["CheckInDate"]),
                                    CheckOutDate = Convert.ToDateTime(reader["CheckOutDate"]),
                                    Pax = Convert.ToInt32(reader["Pax"]),
                                    Amount = Convert.ToDecimal(reader["Amount"])
                                };
                                return (true, details);
                            }
                        }
                    }
                    return (false, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching booking details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (false, null);
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

    public class BookingDetailsData
    {
        public string GuestName { get; set; }
        public string Package { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int Pax { get; set; }
        public decimal Amount { get; set; }
    }
}
