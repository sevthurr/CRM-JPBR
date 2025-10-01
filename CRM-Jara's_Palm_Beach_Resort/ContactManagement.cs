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

            // Initialize guestTable columns
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
                currentSelectedGuestID = guestTable.Rows[e.RowIndex].Cells["GuestID"].Value.ToString(); // NEW: Track ID
                string guestID = currentSelectedGuestID;
                AccountManager accountManager = new AccountManager();
                GuestDetails details = accountManager.GetGuestDetails(guestID);
                UpdateBookingInformationPanel(details);
            }
        }

        private void UpdateBookingInformationPanel(GuestDetails details)
        {
            isUpdatingUI = true; // NEW: Set flag to suppress CheckedChanged
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
                isUpdatingUI = false; // NEW: Reset flag after UI update
            }
        }

        private void MarketingConsentRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (isUpdatingUI || currentSelectedGuestID == null) return; // NEW: Skip if updating UI or no guest selected

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
