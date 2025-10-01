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

        // Method for Login
        public (bool Success, int UserID, string Position, string FirstName, string LastName) Authenticate(string userName, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT UserID, HashedPassword, UserPosition, FirstName, LastName FROM [dbo].[Account] WHERE UserName = @UserName";
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
                                    string firstName = reader["FirstName"].ToString();
                                    string lastName = reader["LastName"].ToString();
                                    return (true, userID, position, firstName, lastName);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Authentication error: {ex.Message}");
                }
                return (false, -1, null, null, null);
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

        // Method for Booking
        public (bool Success, int BookingID) CreateBooking(BookingFormData data, int userID, string paymentMethod, string purpose, decimal amount)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    // Insert Guest
                    string insertGuest = @"
                INSERT INTO [dbo].[Guest] (FName, MName, LName, Suffix, Email, Phone, Address, [Contact-able], Platform, Tag, MarketingConsent)
                OUTPUT INSERTED.GuestID
                VALUES (@FName, @MName, @LName, @Suffix, @Email, @Phone, @Address, @Contactable, @Platform, @Tag, @MarketingConsent)";
                    int guestID;
                    using (SqlCommand cmd = new SqlCommand(insertGuest, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@FName", data.FirstName);
                        cmd.Parameters.AddWithValue("@MName", string.IsNullOrEmpty(data.MiddleName) ? DBNull.Value : data.MiddleName);
                        cmd.Parameters.AddWithValue("@LName", data.LastName);
                        cmd.Parameters.AddWithValue("@Suffix", string.IsNullOrEmpty(data.Suffix) ? DBNull.Value : data.Suffix);
                        cmd.Parameters.AddWithValue("@Email", data.Email);
                        cmd.Parameters.AddWithValue("@Phone", data.Contact);
                        cmd.Parameters.AddWithValue("@Address", data.Address);
                        cmd.Parameters.AddWithValue("@Contactable", true); // Assuming default true
                        cmd.Parameters.AddWithValue("@Platform", data.Platform);
                        cmd.Parameters.AddWithValue("@Tag", DBNull.Value); // Assuming null for now
                        cmd.Parameters.AddWithValue("@MarketingConsent", false); // Assuming default false
                        guestID = (int)cmd.ExecuteScalar();
                    }

                    // Calculate totals
                    string package = data.PackageASelected ? "Package A" : "Package B";
                    decimal basePrice = data.PackageASelected ? 15000m : 12000m;
                    int maxGuests = data.PackageASelected ? 30 : 20;
                    decimal extraGuestRate = 100m;
                    int daysStaying = (data.CheckOut.Date - data.CheckIn.Date).Days;
                    int excessGuests = Math.Max(0, data.GuestQty - maxGuests);
                    decimal excessAmount = excessGuests * extraGuestRate * daysStaying;
                    decimal totalBeforeDiscount = (basePrice * daysStaying) + excessAmount;

                    decimal discountAmountCalc = 0m;
                    string promoCode = data.PromoCode;

                    if (!string.IsNullOrWhiteSpace(promoCode))
                    {
                        var (valid, type, value) = ValidatePromoCode(promoCode, data.BookingDate);
                        if (valid)
                        {
                            if (type == "Percentage")
                            {
                                discountAmountCalc = totalBeforeDiscount * (value / 100m);
                            }
                            else if (type == "Fixed")
                            {
                                discountAmountCalc = value;
                            }
                        }
                        else
                        {
                            throw new Exception("Invalid promo code.");
                        }
                    }

                    decimal totalDue = totalBeforeDiscount - discountAmountCalc;

                    // Insert BookingDetails
                    string insertBookingDetails = @"
                INSERT INTO [dbo].[BookingDetails] (BookingDate, CheckInDate, CheckOutDate, BookingStatus, Pax, Package, PromoCode, TotalDue)
                OUTPUT INSERTED.BookingDetailsID
                VALUES (@BookingDate, @CheckInDate, @CheckOutDate, @BookingStatus, @Pax, @Package, @PromoCode, @TotalDue)";
                    int bookingDetailsID;
                    using (SqlCommand cmd = new SqlCommand(insertBookingDetails, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@BookingDate", data.BookingDate);
                        cmd.Parameters.AddWithValue("@CheckInDate", data.CheckIn);
                        cmd.Parameters.AddWithValue("@CheckOutDate", data.CheckOut);
                        cmd.Parameters.AddWithValue("@BookingStatus", "Booked"); // Initial status
                        cmd.Parameters.AddWithValue("@Pax", data.GuestQty);
                        cmd.Parameters.AddWithValue("@Package", package);
                        cmd.Parameters.AddWithValue("@PromoCode", string.IsNullOrEmpty(promoCode) ? DBNull.Value : promoCode);
                        cmd.Parameters.AddWithValue("@TotalDue", totalDue);
                        bookingDetailsID = (int)cmd.ExecuteScalar();
                    }

                    // Insert PaymentDetails
                    string insertPayment = @"
                INSERT INTO [dbo].[PaymentDetails] (PaymentDate, Amount, PaymentMethod, PaymentStatus, Purpose)
                OUTPUT INSERTED.PaymentID
                VALUES (@PaymentDate, @Amount, @PaymentMethod, @PaymentStatus, @Purpose)";
                    int paymentID;
                    using (SqlCommand cmd = new SqlCommand(insertPayment, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@PaymentDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Amount", amount);
                        cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                        cmd.Parameters.AddWithValue("@PaymentStatus", "Paid"); // Assume paid
                        cmd.Parameters.AddWithValue("@Purpose", purpose);
                        paymentID = (int)cmd.ExecuteScalar();
                    }

                    // Insert Booking
                    string insertBooking = @"
                INSERT INTO [dbo].[Booking] (GuestID, BookingDetailsID, PaymentID)
                OUTPUT INSERTED.BookingID
                VALUES (@GuestID, @BookingDetailsID, @PaymentID)";
                    int bookingID;
                    using (SqlCommand cmd = new SqlCommand(insertBooking, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@GuestID", guestID);
                        cmd.Parameters.AddWithValue("@BookingDetailsID", bookingDetailsID);
                        cmd.Parameters.AddWithValue("@PaymentID", paymentID);
                        bookingID = (int)cmd.ExecuteScalar();
                    }

                    // Log action
                    LogAction(userID, "CreateBooking", $"Created booking {bookingID} for guest {guestID}");

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
                    ISNULL(bd.TotalDue, 0) AS TotalDue,  -- Handle NULL values
                    SUM(pd.Amount) AS Amount
                FROM [dbo].[Booking] b
                JOIN [dbo].[Guest] g ON b.GuestID = g.GuestID
                JOIN [dbo].[BookingDetails] bd ON b.BookingDetailsID = bd.BookingDetailsID
                JOIN [dbo].[PaymentDetails] pd ON b.PaymentID = pd.PaymentID
                WHERE b.BookingDetailsID = (SELECT BookingDetailsID FROM [dbo].[Booking] WHERE BookingID = @BookingID)
                GROUP BY 
                    g.FName, g.MName, g.LName, 
                    bd.Package, bd.CheckInDate, bd.CheckOutDate, bd.Pax, bd.TotalDue";
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
                                    TotalDue = Convert.ToDecimal(reader["TotalDue"]),
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
                    ISNULL(SUM(pd.Amount), 0) AS [Payment]
                FROM [dbo].[Booking] b
                JOIN [dbo].[Guest] g ON b.GuestID = g.GuestID
                JOIN [dbo].[BookingDetails] bd ON b.BookingDetailsID = bd.BookingDetailsID
                LEFT JOIN [dbo].[PaymentDetails] pd ON b.PaymentID = pd.PaymentID
                GROUP BY 
                    b.BookingDetailsID,
                    g.FName, g.MName, g.LName, bd.CheckInDate, bd.BookingStatus
                ORDER BY MIN(b.BookingID) DESC";
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
                WHERE bd.BookingStatus NOT IN ('Cancelled', 'Completed')  -- Exclude cancelled and completed bookings
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

                    string paymentStatus = purpose?.ToLower() == "full payment" ? "Fully Paid" :
                      purpose?.ToLower() == "downpayment" ? "Partially Paid" : "Pending";

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
                        paymentCmd.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
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

        public bool CancelBooking(int bookingID, int userID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    // First, check if the booking exists and get its current status
                    string checkQuery = @"
                SELECT bd.BookingStatus, bd.CheckInDate
                FROM [dbo].[BookingDetails] bd
                JOIN [dbo].[Booking] b ON bd.BookingDetailsID = b.BookingDetailsID
                WHERE b.BookingID = @BookingID";

                    string currentStatus = "";
                    DateTime checkInDate = DateTime.MinValue;

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn, transaction))
                    {
                        checkCmd.Parameters.AddWithValue("@BookingID", bookingID);
                        using (SqlDataReader reader = checkCmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Booking not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                transaction?.Rollback();
                                return false;
                            }
                            currentStatus = reader["BookingStatus"].ToString();
                            checkInDate = Convert.ToDateTime(reader["CheckInDate"]);
                        }
                    }

                    // Validate if booking can be cancelled
                    if (currentStatus == "Cancelled")
                    {
                        MessageBox.Show("This booking is already cancelled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        transaction?.Rollback();
                        return false;
                    }

                    if (currentStatus == "Completed")
                    {
                        MessageBox.Show("Cannot cancel a completed booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        transaction?.Rollback();
                        return false;
                    }

                    // Check if check-in date has already passed
                    if (checkInDate.Date <= DateTime.Today.Date && currentStatus == "Staying")
                    {
                        MessageBox.Show("Cannot cancel a booking that has already started.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        transaction?.Rollback();
                        return false;
                    }

                    // Update the booking status to "Cancelled"
                    string updateQuery = @"
                UPDATE [dbo].[BookingDetails] 
                SET BookingStatus = 'Cancelled'
                WHERE BookingDetailsID = (
                    SELECT BookingDetailsID 
                    FROM [dbo].[Booking] 
                    WHERE BookingID = @BookingID
                )";

                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction))
                    {
                        updateCmd.Parameters.AddWithValue("@BookingID", bookingID);
                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("Failed to cancel booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction?.Rollback();
                            return false;
                        }
                    }

                    // Log the action
                    LogAction(userID, "CancelBooking", $"Cancelled booking with ID {bookingID}. Previous status: {currentStatus}");

                    transaction.Commit();
                    MessageBox.Show("Booking cancelled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                catch (Exception ex)
                {
                    transaction?.Rollback();
                    MessageBox.Show($"Error cancelling booking: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public (bool Valid, string DiscountType, decimal DiscountValue) ValidatePromoCode(string code, DateTime referenceDate)
        {
            if (string.IsNullOrWhiteSpace(code)) return (false, null, 0m);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT DiscountType, DiscountValue, UsageLimit, ExpiryDate
                FROM [dbo].[PromoCode]
                WHERE Code = @Code";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Code", code);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read()) return (false, null, 0m);

                            string type = reader["DiscountType"].ToString();
                            decimal value = (decimal)reader["DiscountValue"];
                            int limit = (int)reader["UsageLimit"];
                            DateTime expiry = (DateTime)reader["ExpiryDate"];

                            reader.Close();

                            if (expiry < referenceDate.Date) return (false, null, 0m);

                            // Check usage
                            string usageQuery = "SELECT COUNT(*) FROM [dbo].[BookingDetails] WHERE PromoCode = @Code";
                            using (SqlCommand usageCmd = new SqlCommand(usageQuery, conn))
                            {
                                usageCmd.Parameters.AddWithValue("@Code", code);
                                int used = (int)usageCmd.ExecuteScalar();
                                if (used >= limit) return (false, null, 0m);
                            }

                            return (true, type, value);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error validating promo code: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (false, null, 0m);
                }
            }
        }

        // Methods for Guest / Conact Management
        public DataTable GetGuests(string searchTerm = "", string filter = "")
        {
            DataTable guests = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string baseQuery = @"
                SELECT 
                    g.GuestID,
                    g.FName + ' ' + ISNULL(g.MName + ' ', '') + g.LName AS GuestName,
                    ISNULL(g.Tag, 'None') AS Tag,
                    MAX(bd.CheckInDate) AS LastBooking
                FROM [dbo].[Guest] g
                LEFT JOIN [dbo].[Booking] b ON g.GuestID = b.GuestID
                LEFT JOIN [dbo].[BookingDetails] bd ON b.BookingDetailsID = bd.BookingDetailsID
            ";

                    string whereClause = "";
                    List<SqlParameter> parameters = new List<SqlParameter>();

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        if (!string.IsNullOrEmpty(whereClause)) whereClause += " AND ";
                        whereClause += @"(
                    g.GuestID LIKE @SearchTerm 
                    OR g.FName + ' ' + ISNULL(g.MName + ' ', '') + g.LName LIKE @SearchTerm 
                    OR ISNULL(g.Tag, 'None') LIKE @SearchTerm
                )";
                        parameters.Add(new SqlParameter("@SearchTerm", "%" + searchTerm + "%"));
                    }

                    if (!string.IsNullOrEmpty(filter) && filter != "All")
                    {
                        if (!string.IsNullOrEmpty(whereClause)) whereClause += " AND ";
                        whereClause += "ISNULL(g.Tag, 'None') = @Filter";
                        parameters.Add(new SqlParameter("@Filter", filter));
                    }

                    if (!string.IsNullOrEmpty(whereClause)) whereClause = " WHERE " + whereClause;

                    string groupByOrderBy = @"
                GROUP BY 
                    g.GuestID, g.FName, g.MName, g.LName, g.Tag
                ORDER BY g.GuestID DESC";

                    string query = baseQuery + whereClause + groupByOrderBy;

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(guests);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading guests: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return guests;
        }

        public List<string> GetDistinctTags()
        {
            List<string> tags = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT DISTINCT ISNULL(Tag, 'None') AS Tag
                FROM [dbo].[Guest]
                ORDER BY Tag";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tags.Add(reader["Tag"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading distinct tags: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return tags;
        }

        public GuestDetails GetGuestDetails(string guestID)
        {
            GuestDetails details = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            g.GuestID,
                            g.FName + ' ' + ISNULL(g.MName + ' ', '') + g.LName AS FullName,
                            g.Phone,
                            ISNULL(g.Tag, 'None') AS Tag,
                            COUNT(b.BookingID) AS BookingCount,
                            g.MarketingConsent -- NEW: Fetch MarketingConsent
                        FROM [dbo].[Guest] g
                        LEFT JOIN [dbo].[Booking] b ON g.GuestID = b.GuestID
                        WHERE g.GuestID = @GuestID
                        GROUP BY g.GuestID, g.FName, g.MName, g.LName, g.Phone, g.Tag, g.MarketingConsent"; // UPDATED: Include in GROUP BY
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@GuestID", guestID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                details = new GuestDetails
                                {
                                    GuestID = reader["GuestID"].ToString(),
                                    FullName = reader["FullName"].ToString(),
                                    Phone = reader["Phone"].ToString(),
                                    Tag = reader["Tag"].ToString(),
                                    BookingCount = Convert.ToInt32(reader["BookingCount"]),
                                    MarketingConsent = Convert.ToBoolean(reader["MarketingConsent"]) // NEW: Convert BIT/TINYINT to bool
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading guest details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return details;
        }

        public bool UpdateGuestMarketingConsent(string guestID, bool consentValue)
        {
            if (string.IsNullOrEmpty(guestID))
            {
                MessageBox.Show("Invalid Guest ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Verify GuestID exists
                    string verifyQuery = "SELECT COUNT(1) FROM [dbo].[Guest] WHERE GuestID = @GuestID";
                    using (SqlCommand verifyCmd = new SqlCommand(verifyQuery, conn))
                    {
                        verifyCmd.Parameters.AddWithValue("@GuestID", guestID);
                        int count = (int)verifyCmd.ExecuteScalar();
                        if (count == 0)
                        {
                            MessageBox.Show("Guest ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }

                    // Update MarketingConsent
                    string updateQuery = "UPDATE [dbo].[Guest] SET MarketingConsent = @MarketingConsent WHERE GuestID = @GuestID";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@GuestID", guestID);
                        updateCmd.Parameters.AddWithValue("@MarketingConsent", consentValue ? 1 : 0); // Convert bool to 1/0 for BIT/TINYINT
                        int rowsAffected = updateCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Optional: Log the action (pass current UserID if available, e.g., from session)
                            // LogAction(currentUserID, "UpdateMarketingConsent", $"Guest {guestID} marketing consent set to {(consentValue ? "On" : "Off")}");
                            return true;
                        }
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating marketing consent: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        // Methods for the Account Management
        public bool CreateAccount(string firstName, string lastName, string userName, string password, string position)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if username already exists
                    string checkQuery = "SELECT COUNT(1) FROM [dbo].[Account] WHERE UserName = @UserName";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@UserName", userName);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }

                    // Insert new account
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                    string insertQuery = @"
                INSERT INTO [dbo].[Account] (FirstName, LastName, UserName, HashedPassword, UserPosition, UserStatus, DateCreated)
                VALUES (@FirstName, @LastName, @UserName, @HashedPassword, @UserPosition, 'Active', @DateCreated)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@FirstName", firstName);
                        insertCmd.Parameters.AddWithValue("@LastName", lastName);
                        insertCmd.Parameters.AddWithValue("@UserName", userName);
                        insertCmd.Parameters.AddWithValue("@HashedPassword", hashedPassword);
                        insertCmd.Parameters.AddWithValue("@UserPosition", position);
                        insertCmd.Parameters.AddWithValue("@DateCreated", DateTime.Now);

                        int rowsAffected = insertCmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public DataTable GetAccounts()
        {
            DataTable accounts = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    UserID,
                    FirstName + ' ' + LastName AS AccountName,
                    UserPosition AS Role,
                    UserName,
                    DateCreated,
                    UserStatus AS Status
                FROM [dbo].[Account]
                ORDER BY UserID DESC";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        adapter.Fill(accounts);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading accounts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return accounts;
        }

        public bool UpdateAccountStatus(int userID, string status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE [dbo].[Account] SET UserStatus = @Status WHERE UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.Parameters.AddWithValue("@Status", status);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating account status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        // Method for Dashboard
        public DataTable GetUpcomingCheckIns()
        {
            DataTable checkIns = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
        SELECT 
            g.FName + ' ' + ISNULL(g.MName + ' ', '') + g.LName AS GuestName,
            bd.Package,
            bd.Pax,
            bd.CheckInDate,
            bd.BookingStatus AS Status
        FROM [dbo].[Booking] b
        JOIN [dbo].[Guest] g ON b.GuestID = g.GuestID
        JOIN [dbo].[BookingDetails] bd ON b.BookingDetailsID = bd.BookingDetailsID
        WHERE bd.CheckInDate >= @Today
        AND bd.BookingStatus IN ('Booked', 'Staying')
        ORDER BY bd.CheckInDate";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Today", DateTime.Today);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(checkIns);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching today's check-ins: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return checkIns;
        }

        public DataTable GetUpcomingCheckOuts()
        {
            DataTable checkOuts = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
        SELECT 
            g.FName + ' ' + ISNULL(g.MName + ' ', '') + g.LName AS GuestName,
            bd.Package,
            bd.Pax,
            bd.CheckOutDate
        FROM [dbo].[Booking] b
        JOIN [dbo].[Guest] g ON b.GuestID = g.GuestID
        JOIN [dbo].[BookingDetails] bd ON b.BookingDetailsID = bd.BookingDetailsID
        WHERE bd.CheckOutDate >= @Today
        AND bd.BookingStatus IN ('Staying', 'Completed', 'Booked')
        ORDER BY bd.CheckOutDate";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Today", DateTime.Today);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(checkOuts);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching today's check-outs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return checkOuts;
        }

        // Method for Account Information
        public UserDetails GetUserDetails(int userID)
        {
            UserDetails details = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT FirstName, LastName, UserName, UserPosition AS Position, Email, Phone
                        FROM [dbo].[Account]
                        WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                details = new UserDetails
                                {
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    UserName = reader["UserName"].ToString(),
                                    Position = reader["Position"].ToString(),
                                    Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader["Email"].ToString(),
                                    Phone = reader.IsDBNull(reader.GetOrdinal("Phone")) ? null : reader["Phone"].ToString()
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading user details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return details;
        }

        public bool UpdateUserInfo(int userID, string firstName, string lastName, string userName, string email, string phone, string newPassword)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        UPDATE [dbo].[Account]
                        SET FirstName = @FirstName,
                            LastName = @LastName,
                            UserName = @UserName,
                            Email = @Email,
                            Phone = @Phone";
                    if (!string.IsNullOrEmpty(newPassword))
                    {
                        query += ", HashedPassword = @HashedPassword";
                    }
                    query += " WHERE UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@UserName", userName);
                        cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(email) ? DBNull.Value : email);
                        cmd.Parameters.AddWithValue("@Phone", string.IsNullOrEmpty(phone) ? DBNull.Value : phone);
                        if (!string.IsNullOrEmpty(newPassword))
                        {
                            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);
                            cmd.Parameters.AddWithValue("@HashedPassword", hashedPassword);
                        }
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            LogAction(userID, "UpdateAccountInfo", "User updated their account information.");
                            return true;
                        }
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating user information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        // Method for Campaigns
        public int? CreatePromoCode(string code, string discountType, int usageLimit, DateTime expiryDate, decimal discountValue)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if code already exists
                    string checkQuery = "SELECT COUNT(1) FROM [dbo].[PromoCode] WHERE Code = @Code";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Code", code);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Promo code already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return null;
                        }
                    }

                    // Insert promo code
                    string insertQuery = @"
                INSERT INTO [dbo].[PromoCode] (Code, DiscountType, UsageLimit, ExpiryDate, DiscountValue)
                OUTPUT INSERTED.PromoCodeID
                VALUES (@Code, @DiscountType, @UsageLimit, @ExpiryDate, @DiscountValue)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@Code", code);
                        insertCmd.Parameters.AddWithValue("@DiscountType", discountType);
                        insertCmd.Parameters.AddWithValue("@UsageLimit", usageLimit);
                        insertCmd.Parameters.AddWithValue("@ExpiryDate", expiryDate);
                        insertCmd.Parameters.AddWithValue("@DiscountValue", discountValue);
                        return (int)insertCmd.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating promo code: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        public int? CreateCampaign(string headline, string description, string type, string emailMessage, int? promoCodeID, DateTime startDate, DateTime endDate, string status, string tag)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string insertQuery = @"
                INSERT INTO [dbo].[Campaign] (Headline, Description, Type, EmailMessage, PromoCodeID, StartDate, EndDate, Status, Tag)
                OUTPUT INSERTED.CampaignID
                VALUES (@Headline, @Description, @Type, @EmailMessage, @PromoCodeID, @StartDate, @EndDate, @Status, @Tag)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@Headline", headline);
                        insertCmd.Parameters.AddWithValue("@Description", description);
                        insertCmd.Parameters.AddWithValue("@Type", type);
                        insertCmd.Parameters.AddWithValue("@EmailMessage", emailMessage);
                        insertCmd.Parameters.AddWithValue("@PromoCodeID", promoCodeID.HasValue ? (object)promoCodeID.Value : DBNull.Value);
                        insertCmd.Parameters.AddWithValue("@StartDate", startDate);
                        insertCmd.Parameters.AddWithValue("@EndDate", endDate);
                        insertCmd.Parameters.AddWithValue("@Status", status);
                        insertCmd.Parameters.AddWithValue("@Tag", tag);
                        return (int)insertCmd.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating campaign: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        public bool AssignGuestsToCampaign(int campaignID, string[] tags)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Build the IN clause for tags
                    string tagsInClause = string.Join(",", tags.Select(t => $"'{t}'"));

                    // Select eligible guests: MarketingConsent = 1, Email not null, Tag in tags
                    string selectGuestsQuery = $@"
                SELECT GuestID
                FROM [dbo].[Guest]
                WHERE MarketingConsent = 1
                AND Email IS NOT NULL
                AND Tag IN ({tagsInClause})";

                    DataTable guests = new DataTable();
                    using (SqlCommand selectCmd = new SqlCommand(selectGuestsQuery, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(selectCmd))
                        {
                            adapter.Fill(guests);
                        }
                    }

                    if (guests.Rows.Count == 0)
                    {
                        return true; // No guests to assign, but not an error
                    }

                    // Insert into CampaignGuest for each guest
                    string insertQuery = @"
                INSERT INTO [dbo].[CampaignGuest] (CampaignID, GuestID, DeliveredCount, DeliveryStatus)
                VALUES (@CampaignID, @GuestID, 0, 'Pending')";

                    foreach (DataRow row in guests.Rows)
                    {
                        int guestID = (int)row["GuestID"];
                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@CampaignID", campaignID);
                            insertCmd.Parameters.AddWithValue("@GuestID", guestID);
                            insertCmd.ExecuteNonQuery();
                        }
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error assigning guests to campaign: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public List<CampaignData> GetCampaigns()
        {
            List<CampaignData> campaigns = new List<CampaignData>();
            DateTime now = new DateTime(2025, 10, 1); // Use the provided current date

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Update statuses first
                    string updateStatusQuery = @"
                UPDATE [dbo].[Campaign]
                SET Status = 'Completed'
                WHERE Status = 'Active' AND EndDate < @Now";
                    using (SqlCommand updateCmd = new SqlCommand(updateStatusQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@Now", now);
                        updateCmd.ExecuteNonQuery();
                    }

                    // Fetch campaigns
                    string query = @"
                SELECT c.*, pc.Code AS PromoCode
                FROM [dbo].[Campaign] c
                LEFT JOIN [dbo].[PromoCode] pc ON c.PromoCodeID = pc.PromoCodeID
                ORDER BY c.StartDate DESC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CampaignData data = new CampaignData
                                {
                                    CampaignID = (int)reader["CampaignID"],
                                    Headline = reader["Headline"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    Type = reader["Type"].ToString(),
                                    EmailMessage = reader["EmailMessage"].ToString(),
                                    StartDate = (DateTime)reader["StartDate"],
                                    EndDate = (DateTime)reader["EndDate"],
                                    Status = reader["Status"].ToString(),
                                    Tag = reader["Tag"].ToString(),
                                    PromoCode = reader.IsDBNull(reader.GetOrdinal("PromoCode")) ? null : reader["PromoCode"].ToString()
                                };
                                campaigns.Add(data);
                            }
                        }
                    }

                    // Fetch delivered and total for each campaign
                    foreach (var data in campaigns)
                    {
                        string guestQuery = @"
                    SELECT COUNT(*) AS TotalAssigned, 
                           SUM(DeliveredCount) AS Delivered
                    FROM [dbo].[CampaignGuest]
                    WHERE CampaignID = @CampaignID";
                        using (SqlCommand guestCmd = new SqlCommand(guestQuery, conn))
                        {
                            guestCmd.Parameters.AddWithValue("@CampaignID", data.CampaignID);
                            using (SqlDataReader guestReader = guestCmd.ExecuteReader())
                            {
                                if (guestReader.Read())
                                {
                                    data.TotalAssigned = guestReader.GetInt32("TotalAssigned");
                                    data.Delivered = guestReader.GetInt32("Delivered");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading campaigns: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return campaigns;
        }

        public CampaignData GetCampaignByID(int campaignID)
        {
            CampaignData data = null;
            DateTime now = new DateTime(2025, 10, 1); // Use the provided current date

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Update status if needed
                    string updateStatusQuery = @"
                UPDATE [dbo].[Campaign]
                SET Status = 'Completed'
                WHERE CampaignID = @CampaignID AND Status = 'Active' AND EndDate < @Now";
                    using (SqlCommand updateCmd = new SqlCommand(updateStatusQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@CampaignID", campaignID);
                        updateCmd.Parameters.AddWithValue("@Now", now);
                        updateCmd.ExecuteNonQuery();
                    }

                    // Fetch campaign
                    string query = @"
                SELECT c.*, pc.Code AS PromoCode
                FROM [dbo].[Campaign] c
                LEFT JOIN [dbo].[PromoCode] pc ON c.PromoCodeID = pc.PromoCodeID
                WHERE c.CampaignID = @CampaignID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CampaignID", campaignID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                data = new CampaignData
                                {
                                    CampaignID = (int)reader["CampaignID"],
                                    Headline = reader["Headline"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    Type = reader["Type"].ToString(),
                                    EmailMessage = reader["EmailMessage"].ToString(),
                                    StartDate = (DateTime)reader["StartDate"],
                                    EndDate = (DateTime)reader["EndDate"],
                                    Status = reader["Status"].ToString(),
                                    Tag = reader["Tag"].ToString(),
                                    PromoCode = reader.IsDBNull(reader.GetOrdinal("PromoCode")) ? null : reader["PromoCode"].ToString()
                                };
                            }
                        }
                    }

                    if (data != null)
                    {
                        // Fetch delivered and total
                        string guestQuery = @"
                    SELECT COUNT(*) AS TotalAssigned, 
                           SUM(DeliveredCount) AS Delivered
                    FROM [dbo].[CampaignGuest]
                    WHERE CampaignID = @CampaignID";
                        using (SqlCommand guestCmd = new SqlCommand(guestQuery, conn))
                        {
                            guestCmd.Parameters.AddWithValue("@CampaignID", campaignID);
                            using (SqlDataReader guestReader = guestCmd.ExecuteReader())
                            {
                                if (guestReader.Read())
                                {
                                    data.TotalAssigned = guestReader.GetInt32("TotalAssigned");
                                    data.Delivered = guestReader.GetInt32("Delivered");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading campaign: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            return data;
        }
    }

    public class BookingDetailsData
    {
        public string GuestName { get; set; }
        public string Package { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int Pax { get; set; }
        public decimal TotalDue { get; set; }
        public decimal Amount { get; set; }
    }

    public class GuestDetails
    {
        public string GuestID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Tag { get; set; }
        public int BookingCount { get; set; }
        public bool MarketingConsent { get; set; }
    }

    public class UserDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    public class CampaignData
    {
        public int CampaignID { get; set; }
        public string Headline { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string EmailMessage { get; set; }
        public string PromoCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public string Tag { get; set; }
        public int Delivered { get; set; }
        public int TotalAssigned { get; set; }
    }
}
