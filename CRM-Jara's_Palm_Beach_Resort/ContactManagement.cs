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

            // Add cell formatting event for tag color coding
            guestTable.CellFormatting += guestTable_CellFormatting;
        }

        private void guestTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Tag column index is 2
            if (guestTable.Columns[e.ColumnIndex].Name == "Tag")
            {
                if (e.Value != null)
                {
                    string tag = e.Value.ToString();
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    e.CellStyle.SelectionForeColor = Color.White;
                    e.CellStyle.Padding = new Padding(10, 5, 10, 5); // Pill effect
                    switch (tag)
                    {
                        case "Family":
                            e.CellStyle.BackColor = ColorTranslator.FromHtml("#26B070");
                            e.CellStyle.SelectionBackColor = ColorTranslator.FromHtml("#26B070");
                            break;
                        case "Group":
                            e.CellStyle.BackColor = ColorTranslator.FromHtml("#F4991A");
                            e.CellStyle.SelectionBackColor = ColorTranslator.FromHtml("#F4991A");
                            break;
                        case "Couple":
                            e.CellStyle.BackColor = ColorTranslator.FromHtml("#E45A92");
                            e.CellStyle.SelectionBackColor = ColorTranslator.FromHtml("#E45A92");
                            break;
                        case "Solo":
                            e.CellStyle.BackColor = ColorTranslator.FromHtml("#4FB7B3");
                            e.CellStyle.SelectionBackColor = ColorTranslator.FromHtml("#4FB7B3");
                            break;
                        default:
                            e.CellStyle.BackColor = Color.White;
                            e.CellStyle.SelectionBackColor = Color.White;
                            e.CellStyle.ForeColor = Color.Black;
                            break;
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
