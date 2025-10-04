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
        public Dashboard()
        {
            InitializeComponent();
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
                BackColor = Color.White,
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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Style checkInTable
            checkInTable.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 10F, FontStyle.Bold);
            checkInTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            checkInTable.DefaultCellStyle.Font = new Font("Poppins", 9F, FontStyle.Regular);
            checkInTable.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            checkInTable.Rows.Clear();
            checkInTable.Rows.Add("John Doe", "A", "2", "09-13-2025", "Staying");
            checkInTable.Rows.Add("Jane Smith", "B", "4", "09-16-2025", "Booked");
            checkInTable.Rows.Add("Alice Brown", "A", "10", "09-25-2025", "Booked");

            // Style checkOutTable
            checkOutTable.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 10F, FontStyle.Bold);
            checkOutTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            checkOutTable.DefaultCellStyle.Font = new Font("Poppins", 9F, FontStyle.Regular);
            checkOutTable.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            checkOutTable.Rows.Clear();
            checkOutTable.Rows.Add("Bob Lee", "A", "2", "09-12-2025", "09:00 AM");
            checkOutTable.Rows.Add("Mary Green", "B", "3", "09-08-2025", "10:30 AM");
            checkOutTable.Rows.Add("Tom Black", "B", "1", "09-02-2025", "11:15 AM");
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
