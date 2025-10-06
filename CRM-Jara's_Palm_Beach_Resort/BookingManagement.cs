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
            topNavBar1.SetActive("BookingManagement");
            topNavBar1.Dock = DockStyle.Top;
            paymentHistoryBtn.Click += paymentHistoryBtn_Click;

            // Wire edit button to open EditBooking dialog
            editBtn.Click += EditBtn_Click;
        }

        private void EditBtn_Click(object? sender, EventArgs e)
        {
            // Try to gather current booking info from the info panel to prefill the editor
            string guestName = guestNameLnkLbl?.Text ?? string.Empty;
            DateTime? checkIn = null;
            DateTime parsedDate;
            if (DateTime.TryParse(checkInDateVal?.Text, out parsedDate)) checkIn = parsedDate;
            DateTime? checkOut = null;
            if (DateTime.TryParse(checkOutDateVal?.Text, out parsedDate)) checkOut = parsedDate;
            int pax = 1;
            if (int.TryParse(paxVal?.Text, out var parsedInt)) pax = parsedInt;
            string packageName = packageVal?.Text ?? string.Empty;

            using (var editForm = new EditBooking(guestName, checkIn, checkOut, pax, packageName))
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
                    paxVal.Text = editForm.Pax.ToString();
                    packageVal.Text = editForm.SelectedPackage;

                    // If a row is selected in bookingsTable, update its Guest Name cell
                    if (bookingsTable.SelectedRows.Count > 0)
                    {
                        var row = bookingsTable.SelectedRows[0];
                        if (row.Cells.Count > 1)
                            row.Cells[1].Value = editForm.GuestFullName;
                    }
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

            // SAMPLE DATA -- REMOVE THIS DURING BACKEND DEVELOPMENT GUYS
            bookingsTable.Rows.Add("B001", "John Doe", "06-23-2025", "Booked", "Fully Paid");
            bookingsTable.Rows.Add("B002", "Jane Smith", "05-06-2025", "Staying", "Partial");
            bookingsTable.Rows.Add("B003", "Alice Brown", "05-01-2025", "Completed", "Fully Paid");
            bookingsTable.Rows.Add("B004", "Bob Lee", "04-30-2025", "Cancelled", "Downpayment");

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
