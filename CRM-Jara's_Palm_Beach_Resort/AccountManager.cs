using BCrypt.Net;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        public (bool Success, int BookingID) CreateBooking(BookingFormData data, int userID, string paymentMethod, string purpose, decimal amount)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    // Step 1: Insert into Guest table
                    string guestQuery = @"
    INSERT INTO [dbo].[Guest] (FName, MName, LName, Suffix, Email, Phone, Address, Platform, [Contact-able])
    OUTPUT INSERTED.GuestID
    VALUES (@FName, @MName, @LName, @Suffix, @Email, @Phone, @Address, @Platform, @ContactAble)";
                    int guestID;
                    using (SqlCommand guestCmd = new SqlCommand(guestQuery, conn, transaction))
                    {
                        guestCmd.Parameters.AddWithValue("@FName", data.FirstName);
                        guestCmd.Parameters.AddWithValue("@MName", string.IsNullOrWhiteSpace(data.MiddleName) ? (object)DBNull.Value : data.MiddleName);
                        guestCmd.Parameters.AddWithValue("@LName", data.LastName);
                        guestCmd.Parameters.AddWithValue("@Suffix", string.IsNullOrWhiteSpace(data.Suffix) ? (object)DBNull.Value : data.Suffix);
                        guestCmd.Parameters.AddWithValue("@Email", data.Email);
                        guestCmd.Parameters.AddWithValue("@Phone", data.Contact);
                        guestCmd.Parameters.AddWithValue("@Address", data.Address);
                        guestCmd.Parameters.AddWithValue("@Platform", data.Platform);
                        guestCmd.Parameters.AddWithValue("@ContactAble", 1); // Parameter for Contact-able
                        guestID = (int)guestCmd.ExecuteScalar();
                    }

                    // Step 2: Calculate TotalDue (reuse logic from GetTotalDue)
                    string package = data.PackageASelected ? "Package A" : "Package B";
                    decimal basePrice = data.PackageASelected ? 15000m : 12000m;
                    int maxGuests = data.PackageASelected ? 30 : 20;
                    decimal extraGuestRate = 100m;
                    int daysStaying = (data.CheckOut.Date - data.CheckIn.Date).Days;
                    if (daysStaying <= 0)
                    {
                        throw new Exception("Check-out date must be after check-in date.");
                    }
                    int excessGuests = Math.Max(0, data.GuestQty - maxGuests);
                    decimal excessAmount = excessGuests * extraGuestRate * daysStaying;
                    decimal totalBeforeDiscount = (basePrice * daysStaying) + excessAmount;
                    decimal discountPercentage = data.PromoCode == "SUMMER25" ? 25m : 0m;
                    decimal discountAmount = totalBeforeDiscount * (discountPercentage / 100m);
                    decimal totalDue = totalBeforeDiscount - discountAmount;

                    // Step 3: Insert into BookingDetails table (now including TotalDue)
                    string bookingDetailsQuery = @"
                INSERT INTO [dbo].[BookingDetails] (BookingDate, CheckInDate, CheckOutDate, BookingStatus, Pax, Package, PromoCode, TotalDue)
                OUTPUT INSERTED.BookingDetailsID
                VALUES (@BookingDate, @CheckInDate, @CheckOutDate, 'Booked', @Pax, @Package, @PromoCode, @TotalDue)";
                    int bookingDetailsID;
                    using (SqlCommand bookingDetailsCmd = new SqlCommand(bookingDetailsQuery, conn, transaction))
                    {
                        bookingDetailsCmd.Parameters.AddWithValue("@BookingDate", data.BookingDate);
                        bookingDetailsCmd.Parameters.AddWithValue("@CheckInDate", data.CheckIn);
                        bookingDetailsCmd.Parameters.AddWithValue("@CheckOutDate", data.CheckOut);
                        bookingDetailsCmd.Parameters.AddWithValue("@Pax", data.GuestQty);
                        bookingDetailsCmd.Parameters.AddWithValue("@Package", package);
                        bookingDetailsCmd.Parameters.AddWithValue("@PromoCode", string.IsNullOrWhiteSpace(data.PromoCode) ? (object)DBNull.Value : data.PromoCode);
                        bookingDetailsCmd.Parameters.AddWithValue("@TotalDue", totalDue);  // New: Insert calculated TotalDue
                        bookingDetailsID = (int)bookingDetailsCmd.ExecuteScalar();
                    }

                    // Step 4: Insert into PaymentDetails table
                    string paymentQuery = @"
                INSERT INTO [dbo].[PaymentDetails] (PaymentDate, Amount, PaymentMethod, PaymentStatus, Purpose)
                OUTPUT INSERTED.PaymentID
                VALUES (@PaymentDate, @Amount, @PaymentMethod, 'Pending', @Purpose)";
                    int paymentID;
                    using (SqlCommand paymentCmd = new SqlCommand(paymentQuery, conn, transaction))
                    {
                        paymentCmd.Parameters.AddWithValue("@PaymentDate", DateTime.Now);
                        paymentCmd.Parameters.AddWithValue("@Amount", amount);
                        paymentCmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                        paymentCmd.Parameters.AddWithValue("@Purpose", purpose);
                        paymentID = (int)paymentCmd.ExecuteScalar();
                    }

                    // Step 5: Insert into Booking table
                    string bookingQuery = @"
                INSERT INTO [dbo].[Booking] (GuestID, BookingDetailsID, PaymentID)
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
                    LogAction(userID, "CreateBooking", $"Created new booking with ID {bookingID} for guest ID {guestID}");

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
                    SUM(pd.Amount) AS Amount
                FROM [dbo].[Booking] b
                JOIN [dbo].[Guest] g ON b.GuestID = g.GuestID
                JOIN [dbo].[BookingDetails] bd ON b.BookingDetailsID = bd.BookingDetailsID
                JOIN [dbo].[PaymentDetails] pd ON b.PaymentID = pd.PaymentID
                WHERE b.BookingDetailsID = (SELECT BookingDetailsID FROM [dbo].[Booking] WHERE BookingID = @BookingID)
                GROUP BY 
                    g.FName, g.MName, g.LName, 
                    bd.Package, bd.CheckInDate, bd.CheckOutDate, bd.Pax";
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
                    string query = @"
                SELECT 
                    MIN(b.BookingID) AS BookingID,
                    g.FName + ' ' + ISNULL(g.MName + ' ', '') + g.LName AS GuestName,
                    bd.CheckInDate AS [Date],
                    bd.BookingStatus AS [Status],
                    SUM(pd.Amount) AS [Payment]
                FROM [dbo].[Booking] b
                JOIN [dbo].[Guest] g ON b.GuestID = g.GuestID
                JOIN [dbo].[BookingDetails] bd ON b.BookingDetailsID = bd.BookingDetailsID
                JOIN [dbo].[PaymentDetails] pd ON b.PaymentID = pd.PaymentID
                GROUP BY 
                    b.BookingDetailsID,
                    g.FName, g.MName, g.LName, bd.CheckInDate, bd.BookingStatus
                ORDER BY MIN(b.BookingID) DESC"; // Added ORDER BY
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

        // Method to check for date conflicts
        public bool CheckBookingOverlap(DateTime checkIn, DateTime checkOut)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT COUNT(1)
                        FROM [dbo].[BookingDetails] bd
                        JOIN [dbo].[Booking] b ON bd.BookingDetailsID = b.BookingDetailsID
                        WHERE bd.BookingStatus != 'Canceled'
                        AND (
                            (@CheckIn <= bd.CheckOutDate AND @CheckOut >= bd.CheckInDate)
                        )";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CheckIn", checkIn.Date);
                        cmd.Parameters.AddWithValue("@CheckOut", checkOut.Date);
                        return (int)cmd.ExecuteScalar() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error checking booking overlap: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true; // Assume overlap on error to prevent booking
                }
            }
        }

        public DataTable GetPaymentHistory(int bookingID)
        {
            DataTable payments = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            pd.PaymentID,
                            pd.Amount,
                            pd.Purpose,
                            pd.PaymentDate,
                            g.FName + ' ' + ISNULL(g.MName + ' ', '') + g.LName AS GuestName
                        FROM [dbo].[PaymentDetails] pd
                        JOIN [dbo].[Booking] b ON pd.PaymentID = b.PaymentID
                        JOIN [dbo].[Guest] g ON b.GuestID = g.GuestID
                        WHERE b.BookingDetailsID = (
                            SELECT BookingDetailsID
                            FROM [dbo].[Booking]
                            WHERE BookingID = @BookingID
                        )";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookingID", bookingID);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(payments);
                        }
                    }
                    if (payments.Rows.Count == 0)
                    {
                        LogAction(0, "GetPaymentHistory", $"No payments found for BookingID {bookingID}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching payment history: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LogAction(0, "GetPaymentHistoryError", $"Error for BookingID {bookingID}: {ex.Message}");
                }
                return payments;
            }
        }

        public bool AddPayment(int bookingID, int userID, string paymentMethod, string purpose, decimal amount)
        {
            if (userID <= 0)
            {
                MessageBox.Show("You must be logged in to add a payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(purpose))
            {
                MessageBox.Show("Payment purpose is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (amount <= 0)
            {
                MessageBox.Show("Payment amount must be greater than zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    // Get GuestID and BookingDetailsID from Booking table
                    string idsQuery = @"
                        SELECT GuestID, BookingDetailsID
                        FROM [dbo].[Booking]
                        WHERE BookingID = @BookingID";
                    int guestID = 0, bookingDetailsID = 0;
                    using (SqlCommand idsCmd = new SqlCommand(idsQuery, conn, transaction))
                    {
                        idsCmd.Parameters.AddWithValue("@BookingID", bookingID);
                        using (SqlDataReader reader = idsCmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Booking not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                transaction?.Rollback();
                                return false;
                            }
                            guestID = (int)reader["GuestID"];
                            bookingDetailsID = (int)reader["BookingDetailsID"];
                        }
                    }

                    // Insert into PaymentDetails table
                    string paymentQuery = @"
                        INSERT INTO [dbo].[PaymentDetails] (PaymentDate, Amount, PaymentMethod, PaymentStatus, Purpose)
                        OUTPUT INSERTED.PaymentID
                        VALUES (@PaymentDate, @Amount, @PaymentMethod, @PaymentStatus, @Purpose)";
                    int paymentID;
                    using (SqlCommand paymentCmd = new SqlCommand(paymentQuery, conn, transaction))
                    {
                        paymentCmd.Parameters.AddWithValue("@PaymentDate", DateTime.Today);
                        paymentCmd.Parameters.AddWithValue("@Amount", amount);
                        paymentCmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                        paymentCmd.Parameters.AddWithValue("@PaymentStatus", "Pending");
                        paymentCmd.Parameters.AddWithValue("@Purpose", purpose);
                        paymentID = (int)paymentCmd.ExecuteScalar();
                    }

                    // Insert into Booking table to link the new payment
                    string bookingQuery = @"
                        INSERT INTO [dbo].[Booking] (GuestID, BookingDetailsID, PaymentID)
                        VALUES (@GuestID, @BookingDetailsID, @PaymentID)";
                    using (SqlCommand bookingCmd = new SqlCommand(bookingQuery, conn, transaction))
                    {
                        bookingCmd.Parameters.AddWithValue("@GuestID", guestID);
                        bookingCmd.Parameters.AddWithValue("@BookingDetailsID", bookingDetailsID);
                        bookingCmd.Parameters.AddWithValue("@PaymentID", paymentID);
                        bookingCmd.ExecuteNonQuery();
                    }

                    // Log the action
                    LogAction(userID, "AddPayment", $"Added payment of ₱{amount:N2} with purpose {purpose} for booking ID {bookingID}");
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction?.Rollback();
                    MessageBox.Show($"Error adding payment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public decimal GetTotalDue(int bookingID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT bd.Pax, bd.Package, bd.PromoCode, bd.CheckInDate, bd.CheckOutDate
                        FROM [dbo].[Booking] b
                        JOIN [dbo].[BookingDetails] bd ON b.BookingDetailsID = bd.BookingDetailsID
                        WHERE b.BookingID = @BookingID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookingID", bookingID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int pax = Convert.ToInt32(reader["Pax"]);
                                string package = reader["Package"].ToString();
                                string promoCode = reader["PromoCode"] != DBNull.Value ? reader["PromoCode"].ToString() : null;
                                DateTime checkIn = Convert.ToDateTime(reader["CheckInDate"]);
                                DateTime checkOut = Convert.ToDateTime(reader["CheckOutDate"]);

                                decimal basePrice = package == "Package A" ? 15000m : 12000m;
                                int maxGuests = package == "Package A" ? 30 : 20;
                                decimal extraGuestRate = 100m;
                                int daysStaying = (checkOut.Date - checkIn.Date).Days;
                                int excessGuests = Math.Max(0, pax - maxGuests);
                                decimal excessAmount = excessGuests * extraGuestRate * daysStaying;
                                decimal totalBeforeDiscount = (basePrice * daysStaying) + excessAmount;
                                decimal discountPercentage = promoCode == "SUMMER25" ? 25m : 0m;
                                decimal discountAmount = totalBeforeDiscount * (discountPercentage / 100m);
                                return totalBeforeDiscount - discountAmount;
                            }
                        }
                    }
                    return 0m;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error calculating total due: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0m;
                }
            }
        }

        public decimal GetTotalPaid(int bookingID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT SUM(pd.Amount)
                        FROM [dbo].[PaymentDetails] pd
                        JOIN [dbo].[Booking] b ON pd.PaymentID = b.PaymentID
                        WHERE b.BookingDetailsID = (
                            SELECT BookingDetailsID
                            FROM [dbo].[Booking]
                            WHERE BookingID = @BookingID
                        )";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookingID", bookingID);
                        object result = cmd.ExecuteScalar();
                        return result != DBNull.Value ? Convert.ToDecimal(result) : 0m;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error calculating total paid: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0m;
                }
            }
        }

        public void UpdateBookingStatuses()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                UPDATE [dbo].[BookingDetails]
                SET BookingStatus = 
                    CASE 
                        WHEN CheckInDate > @CurrentDate THEN 'Booked'
                        WHEN CheckInDate <= @CurrentDate AND CheckOutDate > @CurrentDate THEN 'Staying'
                        WHEN CheckOutDate <= @CurrentDate THEN 'Completed'
                        ELSE BookingStatus
                    END
                WHERE BookingStatus NOT IN ('Cancelled', 'Completed')";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CurrentDate", DateTime.Now.Date);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating booking statuses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
