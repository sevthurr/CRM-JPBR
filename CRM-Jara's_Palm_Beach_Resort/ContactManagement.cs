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
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ContactManagement_Load(object sender, EventArgs e)
        {
            guestTable.Columns.Clear();
            string[] headers = { "Guest Name", "Channel", "Tag", "Last Booking" };
            foreach (var header in headers)
            {
                guestTable.Columns.Add(header.Replace(" ", ""), header);
            }

            // Add Actions column for edit/delete
            var actionsCol = new DataGridViewTextBoxColumn();
            actionsCol.Name = "Actions";
            actionsCol.HeaderText = "Actions";
            guestTable.Columns.Add(actionsCol);

            guestTable.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 12F, FontStyle.Bold);
            guestTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guestTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            guestTable.DefaultCellStyle.Font = new Font("Poppins", 9F, FontStyle.Regular);
            guestTable.DefaultCellStyle.ForeColor = Color.Black;

            // SAMPLE DATA -- REMOVE THIS DURING BACKEND DEVELOPMENT GUYS
            guestTable.Rows.Add("John Doe", "Facebook", "Family", "2024-06-01", "");
            guestTable.Rows.Add("Jane Smith", "Instagram", "Couple", "2024-06-05", "");
            guestTable.Rows.Add("Alice Brown", "Mobile", "Solo", "2024-06-10", "");
            guestTable.Rows.Add("Bob Lee", "Walk-In", "Group", "2024-06-15", "");

            // TODO: Add Krypton Icon Buttons to the Actions column once resources and correct usage are available.
        }


        private void guestTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == guestTable.Columns["Actions"].Index && e.RowIndex >= 0)
            {
                var cell = guestTable[e.ColumnIndex, e.RowIndex];
                var cellRect = guestTable.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                int buttonWidth = (cellRect.Width - 12) / 2;
                Rectangle editRect = new Rectangle(cellRect.Left + 4, cellRect.Top + 4, buttonWidth, cellRect.Height - 8);
                Rectangle deleteRect = new Rectangle(cellRect.Left + buttonWidth + 8, cellRect.Top + 4, buttonWidth, cellRect.Height - 8);
                Point mouse = guestTable.PointToClient(Cursor.Position);
                if (editRect.Contains(mouse))
                {
                    MessageBox.Show($"Edit clicked for {guestTable[1, e.RowIndex].Value}");
                }
                else if (deleteRect.Contains(mouse))
                {
                    MessageBox.Show($"Delete clicked for {guestTable[1, e.RowIndex].Value}");
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
    }
}
