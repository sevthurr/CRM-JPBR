using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CRM_Jara_s_Palm_Beach_Resort
{
    public partial class BookingManagement : Form
    {

        private readonly AccountManager _accountManager;
        private bool _isOpeningModal = false; // To prevent multiple modals
        private string _currentSearchText = "";
        private string _currentFilterStatus = "";

        public BookingManagement()
        {
            InitializeComponent();
            _accountManager = new AccountManager(); // Initialize to prevent NullReferenceException
            topNavBar1.SetActive("BookingManagement");
            topNavBar1.Dock = DockStyle.Top;
            paymentHistoryBtn.Click += paymentHistoryBtn_Click;
            bookingsTable.SelectionChanged += bookingsTable_SelectionChanged;

            cancelBtn.Click += cancelBtn_Click;

            // Add event handlers for search and filter
            searchBoxLbl.TextChanged += searchBoxLbl_TextChanged;
            filterComboBox.SelectedIndexChanged += filterComboBox_SelectedIndexChanged;

            // Wire edit button to open EditBooking dialog
            editBtn.Click += EditBtn_Click;
        }

        private void EditBtn_Click(object? sender, EventArgs e)
        {
            if (bookingsTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the booking ID from the selected row
            int bookingID;
            try
            {
                bookingID = Convert.ToInt32(bookingsTable.SelectedRows[0].Cells["BookingID"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Invalid booking ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Fetch fresh details from the database (this now includes Phone and Address)
            var (success, details) = _accountManager.GetBookingDetails(bookingID);
            if (!success || details == null)
            {
                MessageBox.Show("Could not load booking details for editing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Parse values from details (safer than from labels)
            string guestName = details.GuestName ?? string.Empty;
            DateTime? checkIn = details.CheckInDate;
            DateTime? checkOut = details.CheckOutDate;
            int pax = details.Pax;  // Already an int—no parsing needed now
            string packageName = details.Package ?? string.Empty;
            string contact = details.Phone ?? string.Empty;
            string address = details.Address ?? string.Empty;

            using (var editForm = new EditBooking(guestName, checkIn, checkOut, pax, packageName, contact, address))
            {
                editForm.StartPosition = FormStartPosition.CenterParent;
                editForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                editForm.ShowInTaskbar = false;
                editForm.MaximizeBox = false;
                editForm.MinimizeBox = true;

                var dr = editForm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    // Update info panel labels with returned values
                    guestNameLnkLbl.Text = editForm.GuestFullName;
                    checkInDateVal.Text = editForm.CheckIn.ToString("MM/dd/yyyy");
                    checkOutDateVal.Text = editForm.CheckOut.ToString("MM/dd/yyyy");
                    paxVal.Text = $"{editForm.Pax} guest{(editForm.Pax > 1 ? "s" : "")}";  // Keep the formatted string
                    packageVal.Text = editForm.SelectedPackage;

                    // If a row is selected in bookingsTable, update its Guest Name cell
                    if (bookingsTable.SelectedRows.Count > 0)
                    {
                        var row = bookingsTable.SelectedRows[0];
                        if (row.Cells.Count > 1)
                            row.Cells[1].Value = editForm.GuestFullName;
                    }

                    // Optional: Refresh the table to reflect any other changes (e.g., if you add saving logic later)
                    RefreshBookingsTable();
                }
            }
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            var dashboardForm = new Dashboard();
            dashboardForm.WindowState = FormWindowState.Maximized;
            dashboardForm.Show();
            this.Hide();
        }

        private void bookingsBtn_Click(object sender, EventArgs e)
        {
            var bookingForm = new BookingManagement();
            bookingForm.WindowState = FormWindowState.Maximized;
            bookingForm.Show();
            this.Hide();
        }

        private void guestsBtn_Click(object sender, EventArgs e)
        {
            var guestsForm = new ContactManagement();
            guestsForm.WindowState = FormWindowState.Maximized;
            guestsForm.Show();
            this.Hide();
        }

        private void marketingBtn_Click(object sender, EventArgs e)
        {
            var marketingForm = new Marketing();
            marketingForm.WindowState = FormWindowState.Maximized;
            marketingForm.Show();
            this.Hide();
        }

        private void supportBtn_Click(object sender, EventArgs e)
        {
            var supportForm = new Support();
            supportForm.WindowState = FormWindowState.Maximized;
            supportForm.Show();
            this.Hide();
        }

        private void BookingManagement_Load(object sender, EventArgs e)
        {
            bookingsTable.Columns.Clear();
            string[] headers = { "Booking ID", "Guest Name", "Date", "Status", "Payment" };
            foreach (var header in headers)
            {
                bookingsTable.Columns.Add(header.Replace(" ", ""), header);
            }

            bookingsTable.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 12F, FontStyle.Bold);
            bookingsTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bookingsTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            bookingsTable.DefaultCellStyle.Font = new Font("Poppins", 10F, FontStyle.Regular);
            bookingsTable.DefaultCellStyle.ForeColor = Color.Black;

            // New: Update statuses before loading
            _accountManager.UpdateBookingStatuses();
            RefreshBookingsTable();
            ClearBookingInformation();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void welcomeLbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_isOpeningModal) return; // Prevent re-entrancy
            _isOpeningModal = true;
            try
            {
                using (var modal = new NewBookingForm())
                {
                    modal.StartPosition = FormStartPosition.CenterParent;
                    modal.FormBorderStyle = FormBorderStyle.FixedDialog;
                    modal.ShowInTaskbar = false;
                    modal.MaximizeBox = false;
                    modal.MinimizeBox = true;
                    var result = modal.ShowDialog(this);
                    if (result == DialogResult.OK)
                    {
                        RefreshBookingsTable();
                    }
                }
            }
            finally
            {
                _isOpeningModal = false;
            }
        }

        private void RefreshBookingsTable()
        {
            // Ensure statuses are up-to-date before refreshing
            _accountManager.UpdateBookingStatuses();

            bookingsTable.Rows.Clear();
            DataTable bookings = _accountManager.GetBookingList();

            // Apply search and filter
            var filteredRows = bookings.AsEnumerable();

            // Apply search filter
            if (!string.IsNullOrWhiteSpace(_currentSearchText))
            {
                filteredRows = filteredRows.Where(row =>
                    row["BookingID"].ToString().Contains(_currentSearchText, StringComparison.OrdinalIgnoreCase) ||
                    row["GuestName"].ToString().Contains(_currentSearchText, StringComparison.OrdinalIgnoreCase) ||
                    row["Status"].ToString().Contains(_currentSearchText, StringComparison.OrdinalIgnoreCase) ||
                    row["Payment"].ToString().Contains(_currentSearchText, StringComparison.OrdinalIgnoreCase));
            }

            // Apply status filter only if a specific status is selected (not "All" or empty)
            if (!string.IsNullOrWhiteSpace(_currentFilterStatus))
            {
                filteredRows = filteredRows.Where(row =>
                    row["Status"].ToString().Equals(_currentFilterStatus, StringComparison.OrdinalIgnoreCase));
            }

            // Populate the table with filtered results
            foreach (DataRow row in filteredRows)
            {
                bookingsTable.Rows.Add(
                    row["BookingID"],
                    row["GuestName"],
                    Convert.ToDateTime(row["Date"]).ToString("MM-dd-yyyy"),
                    row["Status"],
                    row["Payment"]
                );
            }

            // Show message if no results found
            if (bookingsTable.Rows.Count == 0)
            {
                // Optional: You can show a message or just leave it blank
                MessageBox.Show("No bookings found matching your criteria.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bookingsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paymentHistoryBtn_Click(object sender, EventArgs e)
        {
            if (bookingsTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to view payment history.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bookingID = Convert.ToInt32(bookingsTable.SelectedRows[0].Cells["BookingID"].Value);
            using (var paymentForm = new Payment(bookingID))
            {
                paymentForm.StartPosition = FormStartPosition.CenterParent;
                paymentForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                paymentForm.ShowInTaskbar = false;
                paymentForm.MaximizeBox = false;
                paymentForm.MinimizeBox = true;
                paymentForm.ShowDialog(this);
            }
        }

        private void bookingsTable_SelectionChanged(object sender, EventArgs e)
        {
            if (bookingsTable.SelectedRows.Count > 0)
            {
                int bookingID = Convert.ToInt32(bookingsTable.SelectedRows[0].Cells["BookingID"].Value);
                var (success, details) = _accountManager.GetBookingDetails(bookingID);
                if (success && details != null)
                {
                    guestNameLnkLbl.Text = details.GuestName;
                    packageVal.Text = details.Package;
                    checkInDateVal.Text = details.CheckInDate.ToString("MM-dd-yyyy");
                    checkOutDateVal.Text = details.CheckOutDate.ToString("MM-dd-yyyy");
                    paxVal.Text = $"{details.Pax} guest{(details.Pax > 1 ? "s" : "")}";
                    paymentAmountVal.Text = $"₱ {details.Amount:N0}";
                    totalDueVal.Text = $"₱ {details.TotalDue:N0}";  // Add this line

                    // Enable action buttons
                    editBtn.Enabled = true;
                    cancelBtn.Enabled = true;
                }
                else
                {
                    ClearBookingInformation();
                }
            }
            else
            {
                ClearBookingInformation();
            }
        }

        private void ClearBookingInformation()
        {
            guestNameLnkLbl.Text = string.Empty;
            packageVal.Text = string.Empty;
            checkInDateVal.Text = string.Empty;
            checkOutDateVal.Text = string.Empty;
            paxVal.Text = string.Empty;
            paymentAmountVal.Text = string.Empty;
            editBtn.Enabled = false;
            cancelBtn.Enabled = false;
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (bookingsTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to cancel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bookingID = Convert.ToInt32(bookingsTable.SelectedRows[0].Cells["BookingID"].Value);

            // Get booking details to show confirmation message
            var (success, details) = _accountManager.GetBookingDetails(bookingID);
            if (!success)
            {
                MessageBox.Show("Could not retrieve booking details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Show confirmation dialog
            var result = MessageBox.Show(
                $"Are you sure you want to cancel the booking for {details.GuestName}?\n\n" +
                $"Package: {details.Package}\n" +
                $"Check-in: {details.CheckInDate:MM-dd-yyyy}\n" +
                $"Check-out: {details.CheckOutDate:MM-dd-yyyy}\n\n" +
                "This action cannot be undone.",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                bool cancelled = _accountManager.CancelBooking(bookingID, Session.CurrentUserID);
                if (cancelled)
                {
                    // Refresh the bookings table to reflect the cancellation
                    RefreshBookingsTable();
                    ClearBookingInformation();
                }
            }
        }

        private void totalDueLbl_Click(object sender, EventArgs e)
        {

        }

        private void searchBoxLbl_TextChanged(object sender, EventArgs e)
        {
            _currentSearchText = searchBoxLbl.Text.Trim();
            RefreshBookingsTable();
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentFilterStatus = filterComboBox.SelectedItem?.ToString();

            // If "All" is selected, clear the filter
            if (_currentFilterStatus == "All")
            {
                _currentFilterStatus = "";
            }

            RefreshBookingsTable();
        }
    }
}
