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

        private Panel chartPanel;
        private ComboBox dataTypeComboBox;
        private ComboBox intervalComboBox;
        private System.Windows.Forms.Label dataTypeLbl;
        private System.Windows.Forms.Label intervalLbl;
        private System.Windows.Forms.Label trendTitleLbl;
        private System.Windows.Forms.Label totalBookingsLbl;
        private System.Windows.Forms.Label totalBookingsVal;
        private System.Windows.Forms.Label totalCancellationsLbl;
        private System.Windows.Forms.Label totalCancellationsVal;
        private System.Windows.Forms.Label totalRevenueLbl;
        private System.Windows.Forms.Label totalRevenueVal;
        
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

            // Calculate the exact width and position of tables
            int totalTablesWidth = checkInsPanel.Width + checkOutPanel.Width + (checkOutPanel.Left - (checkInsPanel.Left + checkInsPanel.Width));
            int leftPosition = checkInsPanel.Left;
            
            // Set calendar panel dimensions
            calendarPanel.Left = leftPosition;
            calendarPanel.Width = totalTablesWidth;
            calendarPanel.Height = 700; // Increased height to show circles properly
            calendarPanel.Top = checkInsPanel.Bottom + 35;

            // Ensure there's no padding that would affect alignment
            calendarPanel.Padding = new Padding(0);
            
            // Create ElementHost to host WPF control that fills the entire calendarPanel
            var host = new ElementHost
            {
                Dock = DockStyle.Fill,
                BackColor = System.Drawing.Color.White,
                Margin = new Padding(0)
            };

            // WPF UserControl with the Booking Calendar
            var bookingCalendar = new BookingCalendar();
            host.Child = bookingCalendar;
            
            // Clear any existing controls and add our ElementHost
            calendarPanel.Controls.Clear();
            calendarPanel.Controls.Add(host);
            
            // Force layout update
            calendarPanel.PerformLayout();

            // Initialize Analytics Panel
            InitializeAnalyticsPanel(leftPosition, totalTablesWidth);
        }

        private void InitializeAnalyticsPanel(int leftPosition, int width)
        {
            // Set analytics panel position and size
            analyticsPanel.Left = leftPosition;
            analyticsPanel.Width = width;
            analyticsPanel.Height = 700;
            analyticsPanel.Top = calendarPanel.Bottom + 35;
            analyticsPanel.BackColor = System.Drawing.Color.White;
            analyticsPanel.Padding = new Padding(40); // Increased padding from 20 to 40

            // Title Label
            trendTitleLbl = new System.Windows.Forms.Label
            {
                Text = "Booking Trends for 2025",
                Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold),
                Location = new Point(40, 30), // Adjusted for new padding
                AutoSize = true
            };
            analyticsPanel.Controls.Add(trendTitleLbl);

            // Data Type Label
            dataTypeLbl = new System.Windows.Forms.Label
            {
                Text = "Data Type:",
                Font = new System.Drawing.Font("Poppins", 9F),
                Location = new Point(width - 650, 35), // Move further left
                AutoSize = true
            };
            analyticsPanel.Controls.Add(dataTypeLbl);

            // Data Type ComboBox
            dataTypeComboBox = new ComboBox
            {
                Font = new System.Drawing.Font("Poppins", 9F),
                Location = new Point(width - 540, 32), // Move further left
                Size = new Size(130, 30),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            dataTypeComboBox.Items.AddRange(new object[] { "Bookings", "Revenue" });
            dataTypeComboBox.SelectedIndex = 0;
            dataTypeComboBox.SelectedIndexChanged += DataTypeComboBox_SelectedIndexChanged;
            analyticsPanel.Controls.Add(dataTypeComboBox);

            // Interval Label
            intervalLbl = new System.Windows.Forms.Label
            {
                Text = "Interval:",
                Font = new System.Drawing.Font("Poppins", 9F),
                Location = new Point(width - 390, 35), // Move further left
                AutoSize = true
            };
            analyticsPanel.Controls.Add(intervalLbl);

            // Interval ComboBox
            intervalComboBox = new ComboBox
            {
                Font = new System.Drawing.Font("Poppins", 9F),
                Location = new Point(width - 300, 32), // Move further left and add gap
                Size = new Size(130, 30),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            intervalComboBox.Items.AddRange(new object[] { "Weekly", "Monthly" });
            intervalComboBox.SelectedIndex = 1;
            intervalComboBox.SelectedIndexChanged += IntervalComboBox_SelectedIndexChanged;
            analyticsPanel.Controls.Add(intervalComboBox);

            // Initialize Custom Chart Panel
            chartPanel = new Panel
            {
                Location = new Point(40, 90), // Adjusted for new padding
                Size = new Size(width - 80, 500), // Adjusted for new padding (40 on each side)
                BackColor = System.Drawing.Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            chartPanel.Paint += ChartPanel_Paint;
            analyticsPanel.Controls.Add(chartPanel);

            // Summary Labels for Bookings
            totalBookingsLbl = new System.Windows.Forms.Label
            {
                Text = "Total Bookings",
                Font = new System.Drawing.Font("Poppins", 10F),
                Location = new Point((width / 2) - 200, 610), // Adjusted for new padding
                AutoSize = true,
                ForeColor = System.Drawing.Color.Gray
            };
            analyticsPanel.Controls.Add(totalBookingsLbl);

            totalBookingsVal = new System.Windows.Forms.Label
            {
                Text = "2",
                Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold),
                Location = new Point((width / 2) - 200, 635), // Adjusted for new padding
                AutoSize = true,
                ForeColor = System.Drawing.Color.FromArgb(82, 169, 181)
            };
            analyticsPanel.Controls.Add(totalBookingsVal);

            totalCancellationsLbl = new System.Windows.Forms.Label
            {
                Text = "Total Cancellations",
                Font = new System.Drawing.Font("Poppins", 10F),
                Location = new Point((width / 2) + 50, 610), // Adjusted for new padding
                AutoSize = true,
                ForeColor = System.Drawing.Color.Gray
            };
            analyticsPanel.Controls.Add(totalCancellationsLbl);

            totalCancellationsVal = new System.Windows.Forms.Label
            {
                Text = "0",
                Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold),
                Location = new Point((width / 2) + 50, 635), // Adjusted for new padding
                AutoSize = true,
                ForeColor = System.Drawing.Color.Red
            };
            analyticsPanel.Controls.Add(totalCancellationsVal);

            // Revenue label (initially hidden)
            totalRevenueLbl = new System.Windows.Forms.Label
            {
                Text = "Total Revenue",
                Font = new System.Drawing.Font("Poppins", 10F),
                Location = new Point((width / 2) - 75, 610), // Adjusted for new padding
                AutoSize = true,
                ForeColor = System.Drawing.Color.Gray,
                Visible = false
            };
            analyticsPanel.Controls.Add(totalRevenueLbl);

            totalRevenueVal = new System.Windows.Forms.Label
            {
                Text = "₱27,000.00",
                Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold),
                Location = new Point((width / 2) - 75, 635), // Adjusted for new padding
                AutoSize = true,
                ForeColor = System.Drawing.Color.FromArgb(255, 193, 7),
                Visible = false
            };
            analyticsPanel.Controls.Add(totalRevenueVal);
        }

        private void DataTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChart();
        }

        private void IntervalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChart();
        }

        private void UpdateChart()
        {
            string dataType = dataTypeComboBox.SelectedItem?.ToString() ?? "Bookings";
            
            if (dataType == "Bookings")
            {
                // Show booking summary labels
                totalBookingsLbl.Visible = true;
                totalBookingsVal.Visible = true;
                totalCancellationsLbl.Visible = true;
                totalCancellationsVal.Visible = true;
                totalRevenueLbl.Visible = false;
                totalRevenueVal.Visible = false;
            }
            else // Revenue
            {
                // Show revenue summary label
                totalBookingsLbl.Visible = false;
                totalBookingsVal.Visible = false;
                totalCancellationsLbl.Visible = false;
                totalCancellationsVal.Visible = false;
                totalRevenueLbl.Visible = true;
                totalRevenueVal.Visible = true;
            }

            chartPanel.Invalidate();
        }

        private void ChartPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            string dataType = dataTypeComboBox?.SelectedItem?.ToString() ?? "Bookings";
            string interval = intervalComboBox?.SelectedItem?.ToString() ?? "Monthly";

            int padding = 50;
            int width = chartPanel.Width - 2 * padding;
            int height = chartPanel.Height - 2 * padding;

            // Draw grid
            using (Pen gridPen = new Pen(System.Drawing.Color.LightGray, 1))
            {
                for (int i = 0; i <= 10; i++)
                {
                    int y = padding + (height * i / 10);
                    g.DrawLine(gridPen, padding, y, padding + width, y);
                }
            }

            if (dataType == "Bookings")
            {
                if (interval == "Monthly")
                {
                    string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct" };
                    int[] bookings = { 0, 0, 0, 0, 0, 0, 0, 0, 1, 2 };
                    int[] cancellations = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

                    DrawLineChart(g, padding, width, height, months, bookings, System.Drawing.Color.FromArgb(82, 169, 181), "Bookings");
                    DrawLineChart(g, padding, width, height, months, cancellations, System.Drawing.Color.Red, "Cancellations");
                    DrawXLabels(g, padding, width, height, months);
                }
                else // Weekly
                {
                    string[] weeks = { "Week 1", "Week 2", "Week 3", "Week 4" };
                    int[] bookings = { 0, 1, 0, 1 };
                    int[] cancellations = { 0, 0, 0, 0 };

                    DrawLineChart(g, padding, width, height, weeks, bookings, System.Drawing.Color.FromArgb(82, 169, 181), "Bookings");
                    DrawLineChart(g, padding, width, height, weeks, cancellations, System.Drawing.Color.Red, "Cancellations");
                    DrawXLabels(g, padding, width, height, weeks);
                }
            }
            else // Revenue
            {
                if (interval == "Monthly")
                {
                    string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct" };
                    double[] revenue = { 0, 0, 0, 0, 0, 0, 0, 0, 2000, 27000 };

                    DrawRevenueChart(g, padding, width, height, months, revenue);
                    DrawXLabels(g, padding, width, height, months);
                }
                else // Weekly
                {
                    string[] weeks = { "Week 1", "Week 2", "Week 3", "Week 4" };
                    double[] revenue = { 0, 12000, 0, 15000 };

                    DrawRevenueChart(g, padding, width, height, weeks, revenue);
                    DrawXLabels(g, padding, width, height, weeks);
                }
            }
        }

        private void DrawLineChart(Graphics g, int padding, int width, int height, string[] labels, int[] values, System.Drawing.Color color, string label)
        {
            int maxValue = 10;
            List<Point> points = new List<Point>();

            for (int i = 0; i < values.Length; i++)
            {
                int x = padding + (width * i / (values.Length - 1));
                int y = padding + height - (height * values[i] / maxValue);
                points.Add(new Point(x, y));
            }

            // Draw line
            using (Pen linePen = new Pen(color, 3))
            {
                for (int i = 0; i < points.Count - 1; i++)
                {
                    g.DrawLine(linePen, points[i], points[i + 1]);
                }
            }

            // Draw markers
            using (SolidBrush markerBrush = new SolidBrush(color))
            {
                foreach (Point point in points)
                {
                    g.FillEllipse(markerBrush, point.X - 4, point.Y - 4, 8, 8);
                }
            }
        }

        private void DrawRevenueChart(Graphics g, int padding, int width, int height, string[] labels, double[] values)
        {
            double maxValue = 100000;
            List<Point> points = new List<Point>();

            for (int i = 0; i < values.Length; i++)
            {
                int x = padding + (width * i / (values.Length - 1));
                int y = padding + height - (int)(height * values[i] / maxValue);
                points.Add(new Point(x, y));
            }

            // Draw line
            using (Pen linePen = new Pen(System.Drawing.Color.FromArgb(255, 193, 7), 3))
            {
                for (int i = 0; i < points.Count - 1; i++)
                {
                    g.DrawLine(linePen, points[i], points[i + 1]);
                }
            }

            // Draw markers
            using (SolidBrush markerBrush = new SolidBrush(System.Drawing.Color.FromArgb(255, 193, 7)))
            {
                foreach (Point point in points)
                {
                    g.FillEllipse(markerBrush, point.X - 4, point.Y - 4, 8, 8);
                }
            }
        }

        private void DrawXLabels(Graphics g, int padding, int width, int height, string[] labels)
        {
            using (System.Drawing.Font font = new System.Drawing.Font("Poppins", 8F))
            using (SolidBrush brush = new SolidBrush(System.Drawing.Color.Black))
            {
                for (int i = 0; i < labels.Length; i++)
                {
                    int x = padding + (width * i / (labels.Length - 1));
                    int y = padding + height + 10;
                    SizeF size = g.MeasureString(labels[i], font);
                    g.DrawString(labels[i], font, brush, x - size.Width / 2, y);
                }
            }
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
