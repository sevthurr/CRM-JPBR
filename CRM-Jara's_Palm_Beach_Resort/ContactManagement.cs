using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Jara_s_Palm_Beach_Resort
{
    public partial class ContactManagement : Form
    {
        public ContactManagement()
        {
            InitializeComponent();
            topNavBar1.SetActive("ContactManagement");
            topNavBar1.Dock = DockStyle.Top;

            // Wire edit button to open EditGuest modal
            button2.Click += EditGuestBtn_Click;

            // Initialize guestTable columns and sample data
            guestTable.Columns.Clear();
            string[] headers = { "Guest ID", "Guest Name", "Tag", "Last Booking" };
            foreach (var header in headers)
            {
                guestTable.Columns.Add(header.Replace(" ", ""), header);
            }
            guestTable.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 12F, FontStyle.Bold);
            guestTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guestTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            guestTable.DefaultCellStyle.Font = new Font("Poppins", 10F, FontStyle.Regular);
            guestTable.DefaultCellStyle.ForeColor = Color.Black;

            // Sample data
            guestTable.Rows.Add("G001", "John Doe", "Family", "06-23-2025");
            guestTable.Rows.Add("G002", "Jane Smith", "Group", "05-06-2025");
            guestTable.Rows.Add("G003", "Alice Brown", "Couple", "05-01-2025");
            guestTable.Rows.Add("G004", "Bob Lee", "Solo", "04-30-2025");
        }

        private void EditGuestBtn_Click(object? sender, EventArgs e)
        {
            // Get current guest info from the guest information panel to prefill the editor
            string currentName = guestName?.Text ?? string.Empty;
            string contactNumber = label1?.Text ?? string.Empty;
            string socialInfo = label2?.Text ?? string.Empty;
            bool marketingConsent = radioButton1?.Checked ?? false;

            // Split name into parts (basic parsing)
            var nameParts = currentName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string firstName = nameParts.Length > 0 ? nameParts[0] : string.Empty;
            string lastName = nameParts.Length > 1 ? string.Join(' ', nameParts.Skip(1)) : string.Empty;

            // Create socials list
            var socials = new List<string>();
            if (!string.IsNullOrWhiteSpace(socialInfo))
            {
                socials.Add(socialInfo);
            }

            // Parse tags from the guest table if a row is selected
            var tags = new List<string>();
            if (guestTable.SelectedRows.Count > 0)
            {
                var selectedRow = guestTable.SelectedRows[0];
                if (selectedRow.Cells.Count > 2)
                {
                    var tagValue = selectedRow.Cells[2].Value?.ToString();
                    if (!string.IsNullOrWhiteSpace(tagValue))
                    {
                        tags.Add(tagValue);
                    }
                }
            }

            using (var editGuestForm = new EditGuest(firstName, lastName, string.Empty, contactNumber, socials, marketingConsent, tags))
            {
                editGuestForm.StartPosition = FormStartPosition.CenterParent;
                editGuestForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                editGuestForm.ShowInTaskbar = false;
                editGuestForm.MaximizeBox = false;
                editGuestForm.MinimizeBox = false;

                var result = editGuestForm.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    // Update guest information panel with edited values
                    guestName.Text = editGuestForm.GuestFullName;
                    label1.Text = editGuestForm.ContactNumber;
                    radioButton1.Checked = editGuestForm.MarketingConsent;
                    radioButton2.Checked = !editGuestForm.MarketingConsent;

                    // Update socials (show first social if any)
                    if (editGuestForm.Socials.Any())
                    {
                        label2.Text = editGuestForm.Socials.First();
                    }

                    // Update guest image if changed
                    if (editGuestForm.GuestImage != null)
                    {
                        // You might want to add a PictureBox to the guestImage panel to display the image
                        // For now, this is just a placeholder for future implementation
                    }

                    // If a row is selected in guestTable, update its Guest Name and Tag cells
                    if (guestTable.SelectedRows.Count > 0)
                    {
                        var row = guestTable.SelectedRows[0];
                        if (row.Cells.Count > 1)
                            row.Cells[1].Value = editGuestForm.GuestFullName;
                        if (row.Cells.Count > 2 && editGuestForm.Tags.Any())
                            row.Cells[2].Value = editGuestForm.Tags.First();
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
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

        private void bookingInformationLbl_Click(object sender, EventArgs e)
        {

        }

        private void contactListPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkInTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
