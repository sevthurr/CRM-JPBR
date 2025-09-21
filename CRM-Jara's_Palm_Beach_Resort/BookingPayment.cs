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
    public partial class BookingPayment : Form
    {
        private BookingFormData _restoreData;
        public BookingFormData RestoreData => _restoreData;

        public BookingPayment(BookingFormData data)
        {
            InitializeComponent();
            backBtn.Click += backBtn_Click;
            confirmBookingBtn.Click += confirmBookingBtn_Click;
            _restoreData = data; //so user info will remain when going back
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            // pass data back to NewBookingForm
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void confirmBookingBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
