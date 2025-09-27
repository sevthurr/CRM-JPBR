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
    public partial class Support : Form
    {
        public Support()
        {
            InitializeComponent();
            topNavBar1.SetActive("Support");
            topNavBar1.Dock = DockStyle.Top;
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Support_Load(object sender, EventArgs e)
        {
            ticketsTable.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 10F, FontStyle.Bold);
            ticketsTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ticketsTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            ticketsTable.DefaultCellStyle.Font = new Font("Poppins", 9F, FontStyle.Regular);
            ticketsTable.DefaultCellStyle.ForeColor = Color.Black;

            // SAMPLE DATA -- REMOVE THIS DURING BACKEND DEVELOPMENT GUYS
            ticketsTable.Rows.Add("T001", "Broken AC", "Casa Keona", "Repair", "Ballerina Capucina", "High");
            ticketsTable.Rows.Add("T002", "Additional tubig", "Function Hall", "Equipment/Product Request", "Tung Tung Sahur", "Medium");
          
        }

        private void ticketsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void s_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
