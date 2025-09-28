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
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowInTaskbar = false;
            this.MinimizeBox = true;

            PopulateSummary();
        }

        private void PopulateSummary()
        {
            // Package
            string packageName = _restoreData.PackageASelected ? "Package A" : "Package B";
            decimal basePrice = _restoreData.PackageASelected ? 15000m : 12000m;
            int maxGuests = _restoreData.PackageASelected ? 30 : 20;
            decimal extraGuestRate = 100m;

            packageVal.Text = packageName;
            packageAmount.Text = $"(₱ {basePrice:N0})";

            // Days staying
            int daysStaying = (_restoreData.CheckOut.Date - _restoreData.CheckIn.Date).Days;
            daysStayingVal.Text = $"{daysStaying} night{(daysStaying > 1 ? "s" : "")}";
            daysStayingAmount.Text = $"(₱ {basePrice * daysStaying:N0})";

            // Excess persons
            int excessGuests = Math.Max(0, _restoreData.GuestQty - maxGuests);
            decimal excessAmount = excessGuests * extraGuestRate * daysStaying;
            excessPersonVal.Text = excessGuests > 0 ? $"{excessGuests} person{(excessGuests > 1 ? "s" : "")}" : "None";
            excessPersonAmount.Text = $"(₱ {excessAmount:N0})";

            // Promo discount
            decimal discountPercentage = 0m;
            if (_restoreData.PromoCode == "SUMMER25")
            {
                discountPercentage = 25m;
            }
            decimal totalBeforeDiscount = (basePrice * daysStaying) + excessAmount;
            decimal discountAmount = totalBeforeDiscount * (discountPercentage / 100m);
            promoDiscountLbl.Text = string.IsNullOrWhiteSpace(_restoreData.PromoCode) ? "No Promo Code" : _restoreData.PromoCode;
            this.discountPercentage.Text = discountPercentage > 0 ? $"{discountPercentage}%" : "0%";
            this.discountAmount.Text = $"(₱ {discountAmount:N0})";

            // Total amount
            decimal totalAmount = totalBeforeDiscount - discountAmount;
            totalAmountVal.Text = $"₱ {totalAmount:N0}";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            // pass data back to NewBookingForm
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void confirmBookingBtn_Click(object sender, EventArgs e)
        {
            // Validate session
            if (Session.CurrentUserID <= 0)
            {
                MessageBox.Show("You must be logged in to confirm a booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return;
            }

            // Validate form data (basic check, as NewBookingForm validates most fields)
            if (string.IsNullOrWhiteSpace(_restoreData.FirstName) ||
                string.IsNullOrWhiteSpace(_restoreData.LastName) ||
                string.IsNullOrWhiteSpace(_restoreData.Address) ||
                string.IsNullOrWhiteSpace(_restoreData.Contact) ||
                (!_restoreData.PackageASelected && !_restoreData.PackageBSelected))
            {
                MessageBox.Show("Invalid booking data. Please go back and complete all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Retry;
                this.Close();
                return;
            }

            // TODO: Add payment field validation (e.g., amountTb, paymentMethodCb)
            // Example:
            if (string.IsNullOrWhiteSpace(amountTb.Text) || !decimal.TryParse(amountTb.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid payment amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.Retry;
                this.Close();
                return;
            }

            AccountManager manager = new AccountManager();
            var (success, bookingID) = manager.CreateBooking(_restoreData, Session.CurrentUserID, paymentMethodCb.Text);
            if (success)
            {
                MessageBox.Show($"Booking created successfully! Booking ID: {bookingID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to create booking. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
