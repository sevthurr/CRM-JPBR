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
    public partial class GuestTicketDashboard : Form
    {
        public GuestTicketDashboard()
        {
            InitializeComponent();
            // Open maximized
            WindowState = FormWindowState.Maximized;
            // Wire up button click
            reviewTicketBtn.Click += reviewTicketBtn_Click;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ticketTypeLbl_Click(object sender, EventArgs e)
        {

        }

        private void reviewTicketBtn_Click(object sender, EventArgs e)
        {
            using (var modal = new SubmitTicketModal())
            {
                modal.StartPosition = FormStartPosition.CenterParent;
                modal.FormBorderStyle = FormBorderStyle.FixedDialog;
                modal.ShowInTaskbar = false;
                modal.MaximizeBox = false;
                modal.MinimizeBox = false;
                modal.ShowDialog(this); // Keeps this form open in background
            }
        }
    }
}
