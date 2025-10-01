using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration; 
using Jpbr.WpfWidgets;                  

namespace CRM_Jara_s_Palm_Beach_Resort
{
    public partial class Dashboard : Form
    {

        private string currentUserName;
        private string currentUserPosition;
        private string currentUserFirstName;
        private string currentUserLastName;

        public Dashboard(string firstName, string lastName, string position)
        {
            InitializeComponent();

            // Store the user information
            currentUserFirstName = firstName;
            currentUserLastName = lastName;
            currentUserName = $"{firstName} {lastName}";
            currentUserPosition = position;

            // Update the UI immediately
            UpdateUserDisplay();

            topNavBar1.SetActive("Dashboard");
            topNavBar1.Dock = DockStyle.Top;

            panelCalendarHost.Size = new Size(1772, 589);

            var host = new ElementHost
            {
                Size = new Size(773, 493),
                Location = new Point(40, (panelCalendarHost.Height - 493) / 2),
                Anchor = AnchorStyles.None
            };

            // WPF UserControl
            var bookingCalendar = new BookingCalendar();
            host.Child = bookingCalendar;
            panelCalendarHost.Controls.Add(host);
        }

        // Keep the existing parameterless constructor for compatibility
        public Dashboard() : this("Admin", "User", "Administrator")
        {
        }

        private void UpdateUserDisplay()
        {
            // Update the user label with the actual user's first name
            if (userLbl.InvokeRequired)
            {
                userLbl.Invoke(new Action(() => userLbl.Text = $"{currentUserFirstName}!"));
            }
            else
            {
                userLbl.Text = $"{currentUserFirstName} {currentUserLastName}!";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void crmLbl_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userLbl_Click(object sender, EventArgs e)
        {

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

        // Update the month label to show current month
        private void UpdateMonthLabel()
        {
            monthLbl.Text = DateTime.Now.ToString("MMMM");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Ensure the user label is updated on load
            UpdateUserDisplay();

            // Load dashboard data
            LoadDashboardData();

            // Style tables
            StyleDataGridViews();

            // Update month label
            UpdateMonthLabel();
        }

        private void StyleDataGridViews()
        {
            // Style checkInTable
            checkInTable.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 10F, FontStyle.Bold);
            checkInTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            checkInTable.DefaultCellStyle.Font = new Font("Poppins", 9F, FontStyle.Regular);
            checkInTable.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            checkInTable.RowHeadersVisible = false;

            // Style checkOutTable
            checkOutTable.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 10F, FontStyle.Bold);
            checkOutTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            checkOutTable.DefaultCellStyle.Font = new Font("Poppins", 9F, FontStyle.Regular);
            checkOutTable.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            checkOutTable.RowHeadersVisible = false;
        }

        private void LoadDashboardData()
        {
            try
            {
                var accountManager = new AccountManager();

                // Load bookings count for current month
                int monthlyBookings = GetMonthlyBookingsCount();
                bookingsVal.Text = monthlyBookings.ToString();

                // Load check-ins and check-outs
                LoadCheckIns();
                LoadCheckOuts();

                // Set non-functional panels to 0
                repeatGuestsVal.Text = "0";
                openTicketsVal.Text = "0";
                activeCampaignsVal.Text = "0";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetMonthlyBookingsCount()
        {
            // Remove 'using' since AccountManager does not implement IDisposable
            var accountManager = new AccountManager();
            DataTable bookings = accountManager.GetBookingList();

            // Filter for current month bookings
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;

            int monthlyCount = 0;
            foreach (DataRow row in bookings.Rows)
            {
                if (row["Date"] != DBNull.Value)
                {
                    DateTime bookingDate = Convert.ToDateTime(row["Date"]);
                    if (bookingDate.Month == currentMonth && bookingDate.Year == currentYear)
                    {
                        monthlyCount++;
                    }
                }
            }

            return monthlyCount;
        }

        private void LoadCheckIns()
        {
            try
            {
                var accountManager = new AccountManager();
                DataTable checkIns = accountManager.GetUpcomingCheckIns();

                checkInTable.Rows.Clear();
                foreach (DataRow row in checkIns.Rows)
                {
                    checkInTable.Rows.Add(
                        row["GuestName"],
                        row["Package"],
                        row["Pax"],
                        Convert.ToDateTime(row["CheckInDate"]).ToString("MM-dd-yyyy"),
                        row["Status"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading check-ins: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCheckOuts()
        {
            try
            {
                var accountManager = new AccountManager();
                DataTable checkOuts = accountManager.GetUpcomingCheckOuts();

                checkOutTable.Rows.Clear();
                foreach (DataRow row in checkOuts.Rows)
                {
                    checkOutTable.Rows.Add(
                        row["GuestName"],
                        row["Package"],
                        row["Pax"],
                        Convert.ToDateTime(row["CheckOutDate"]).ToString("MM-dd-yyyy"),
                        "" // Leave time blank as per your request
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading check-outs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void kryptonMonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {

        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
