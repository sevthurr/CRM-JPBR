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
        public BookingManagement()
        {
            InitializeComponent();
            dashboardBtn.Click += dashboardBtn_Click;
            bookingsBtn.Click += bookingsBtn_Click;
            guestsBtn.Click += guestsBtn_Click;
            marketingBtn.Click += marketingBtn_Click;
            supportBtn.Click += supportBtn_Click;
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

            bookingsTable.DefaultCellStyle.Font = new Font("Poppins", 9F, FontStyle.Regular);
            bookingsTable.DefaultCellStyle.ForeColor = Color.Black;

            // SAMPLE DATA -- REMOVE THIS DURING BACKEND DEVELOPMENT GUYS
            bookingsTable.Rows.Add("B001", "John Doe", "2024-06-01", "Booked", "Fully Paid");
            bookingsTable.Rows.Add("B002", "Jane Smith", "2024-06-05", "Staying", "Partial");
            bookingsTable.Rows.Add("B003", "Alice Brown", "2024-06-10", "Completed", "Fully Paid");
            bookingsTable.Rows.Add("B004", "Bob Lee", "2024-06-15", "Cancelled", "Downpayment");

            // TODO: Add Krypton Icon Buttons to the Actions column once resources and correct usage are available.
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void welcomeLbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
