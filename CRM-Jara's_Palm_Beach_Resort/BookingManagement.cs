using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace CRM_Jara_s_Palm_Beach_Resort
{
    public partial class BookingManagement : Form
    {

        private readonly AccountManager _accountManager;

        public BookingManagement()
        {
            InitializeComponent();
            _accountManager = new AccountManager(); // Initialize to prevent NullReferenceException
            topNavBar1.SetActive("BookingManagement");
            topNavBar1.Dock = DockStyle.Top;
            paymentHistoryBtn.Click += paymentHistoryBtn_Click;
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
            string[] headers = { "Booking ID", "Guest Name", "Date", "Status", "Payment"};
            foreach (var header in headers)
            {
                bookingsTable.Columns.Add(header.Replace(" ", ""), header);
            }

            bookingsTable.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 12F, FontStyle.Bold);
            bookingsTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bookingsTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            bookingsTable.DefaultCellStyle.Font = new Font("Poppins", 10F, FontStyle.Regular);
            bookingsTable.DefaultCellStyle.ForeColor = Color.Black;

            // Load data from database
            DataTable bookings = _accountManager.GetBookingList();
            foreach (DataRow row in bookings.Rows)
            {
                bookingsTable.Rows.Add(
                    row["BookingID"],
                    row["GuestName"],
                    Convert.ToDateTime(row["Date"]).ToString("MM-dd-yyyy"),
                    row["Status"],
                    row["Payment"]
                    ); // Placeholder for Actions
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void welcomeLbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show modal form centered, no blur
            using (var modal = new NewBookingForm())
            {
                modal.StartPosition = FormStartPosition.CenterParent;
                modal.FormBorderStyle = FormBorderStyle.FixedDialog;
                modal.ShowInTaskbar = false;
                modal.MaximizeBox = false; // Disable maximize
                modal.MinimizeBox = true;  // Allow minimize if you want
                modal.ShowDialog(this);
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
            using (var paymentForm = new Payment())
            {
                paymentForm.StartPosition = FormStartPosition.CenterParent;
                paymentForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                paymentForm.ShowInTaskbar = false;
                paymentForm.MaximizeBox = false;
                paymentForm.MinimizeBox = true;
                paymentForm.ShowDialog(this);
            }
        }
    }
}
