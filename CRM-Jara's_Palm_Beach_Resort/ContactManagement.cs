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
        private string currentSearch = "";
        private string currentFilter = "All";
        private string currentSelectedGuestID = null;
        private bool isUpdatingUI;

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

            // Dynamically load distinct tags into filterComboBox
            AccountManager accountManager = new AccountManager();
            List<string> tags = accountManager.GetDistinctTags();
            filterComboBox.Items.Clear();
            filterComboBox.Items.Add("All");
            filterComboBox.Items.AddRange(tags.ToArray());
            filterComboBox.SelectedIndex = 0; // Default to "All"

            // Add event handlers
            searchBoxLbl.TextChanged += searchBoxLbl_TextChanged;
            filterComboBox.SelectedIndexChanged += filterComboBox_SelectedIndexChanged;
            guestTable.CellClick += guestTable_CellClick;
            marketingConsentOnChkbx.CheckedChanged += MarketingConsentRadio_CheckedChanged;
            marketingConsentOffChkbx.CheckedChanged += MarketingConsentRadio_CheckedChanged;

            // Populate guestTable with all guests initially
            LoadGuestTable(currentSearch, currentFilter);

            // Initialize bookingInformationPanel with default values
            UpdateBookingInformationPanel(null);
        }

        private void EditGuestBtn_Click(object? sender, EventArgs e)
        {
            // Get current guest info from the guest information panel to prefill the editor
            string currentName = guestName?.Text ?? string.Empty;
            string currentContactNumber = contactNumber?.Text ?? string.Empty;
            string socialInfo = label2?.Text ?? string.Empty;
            bool marketingConsent = marketingConsentOnChkbx?.Checked ?? false;

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

            using (var editGuestForm = new EditGuest(firstName, lastName, string.Empty, currentContactNumber, socials, marketingConsent, tags))
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
                    contactNumber.Text = editGuestForm.ContactNumber;
                    marketingConsentOnChkbx.Checked = editGuestForm.MarketingConsent;
                    marketingConsentOffChkbx.Checked = !editGuestForm.MarketingConsent;

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

        private void paxLbl_Click(object sender, EventArgs e)
        {

        }

        private void searchBoxLbl_TextChanged(object sender, EventArgs e)
        {
            currentSearch = searchBoxLbl.Text.Trim();
            LoadGuestTable(currentSearch, currentFilter);
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentFilter = filterComboBox.Text;
            LoadGuestTable(currentSearch, currentFilter);
        }

        private void LoadGuestTable(string searchTerm, string filter)
        {
            guestTable.Rows.Clear();
            AccountManager accountManager = new AccountManager();
            DataTable guestData = accountManager.GetGuests(searchTerm, filter);

            foreach (DataRow row in guestData.Rows)
            {
                string lastBooking = row["LastBooking"] != DBNull.Value
                    ? Convert.ToDateTime(row["LastBooking"]).ToString("MM-dd-yyyy")
                    : "No Bookings";
                guestTable.Rows.Add(
                    row["GuestID"].ToString(),
                    row["GuestName"].ToString(),
                    row["Tag"].ToString(),
                    lastBooking
                );
            }
        }

        private void guestTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                currentSelectedGuestID = guestTable.Rows[e.RowIndex].Cells["GuestID"].Value?.ToString();
                string guestID = currentSelectedGuestID;
                AccountManager accountManager = new AccountManager();
                GuestDetails details = accountManager.GetGuestDetails(guestID);
                UpdateBookingInformationPanel(details);
            }
        }

        private void UpdateBookingInformationPanel(GuestDetails details)
        {
            isUpdatingUI = true; // Set flag to suppress CheckedChanged
            try
            {
                if (details == null)
                {
                    guestName.Text = "N/A";
                    contactNumber.Text = "N/A";
                    tagVal.Text = "N/A";
                    bookingHistoryLinkLbl.Text = "N/A";
                    marketingConsentOnChkbx.Checked = false;
                    marketingConsentOffChkbx.Checked = false;
                }
                else
                {
                    guestName.Text = details.FullName;
                    contactNumber.Text = details.Phone;
                    tagVal.Text = details.Tag;
                    bookingHistoryLinkLbl.Text = details.BookingCount.ToString();
                    marketingConsentOnChkbx.Checked = details.MarketingConsent;
                    marketingConsentOffChkbx.Checked = !details.MarketingConsent;
                }
            }
            finally
            {
                isUpdatingUI = false; // Reset flag after UI update
            }
        }

        private void MarketingConsentRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (isUpdatingUI || currentSelectedGuestID == null) return; // Skip if updating UI or no guest selected

            if (marketingConsentOnChkbx.Checked || marketingConsentOffChkbx.Checked)
            {
                bool newConsent = marketingConsentOnChkbx.Checked;
                AccountManager accountManager = new AccountManager();
                bool success = accountManager.UpdateGuestMarketingConsent(currentSelectedGuestID, newConsent);
                if (success)
                {
                    MessageBox.Show("Marketing consent updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Refresh to confirm
                    GuestDetails details = accountManager.GetGuestDetails(currentSelectedGuestID);
                    UpdateBookingInformationPanel(details);
                }
            }
        }
    }
}