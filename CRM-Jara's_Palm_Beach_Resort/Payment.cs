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
    public partial class Payment : Form
    {
        private readonly AccountManager _accountManager;
        private readonly int _bookingID;

        public Payment(int bookingID)
        {
            InitializeComponent();
            _accountManager = new AccountManager();
            _bookingID = bookingID;

            addPaymentBtn.Click += addPaymentBtn_Click;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadPaymentHistory()
        {
            DataTable payments = _accountManager.GetPaymentHistory(_bookingID);
            paymentTable.Rows.Clear();
            if (payments.Rows.Count == 0)
            {
                MessageBox.Show($"No payments found for Booking ID {_bookingID}.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            foreach (DataRow row in payments.Rows)
            {
                paymentTable.Rows.Add(
                    row["PaymentID"],
                    $"Php {Convert.ToDecimal(row["Amount"]):N2}",
                    row["Purpose"] != DBNull.Value ? row["Purpose"] : "N/A",
                    Convert.ToDateTime(row["PaymentDate"]).ToString("yyyy-MM-dd"),
                    row["GuestName"]
                );
            }

            // Display total due and total paid
            decimal totalDue = _accountManager.GetTotalDue(_bookingID);
            decimal totalPaid = _accountManager.GetTotalPaid(_bookingID);
        }

        private void addPaymentBtn_Click(object sender, EventArgs e)
        {
            // Validate session
            if (Session.CurrentUserID <= 0)
            {
                MessageBox.Show("You must be logged in to add a payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate payment fields
            if (string.IsNullOrWhiteSpace(paymentMethodCb.Text))
            {
                MessageBox.Show("Please select a payment method.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (paymentMethodCb.Text != "Cash" && (string.IsNullOrWhiteSpace(accountNameTb.Text) || string.IsNullOrWhiteSpace(accountNumberTb.Text)))
            {
                MessageBox.Show("Please provide account name and number for non-cash payments.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(amountTb.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid payment amount greater than zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(purposeCb.Text))
            {
                MessageBox.Show("Please select a payment purpose.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calculate remaining balance
            decimal totalDue = _accountManager.GetTotalDue(_bookingID);
            decimal totalPaid = _accountManager.GetTotalPaid(_bookingID);
            decimal remainingBalance = totalDue - totalPaid;

            // Validate amount based on purpose
            if (purposeCb.Text == "Full Payment" && amount != remainingBalance)
            {
                MessageBox.Show($"For Full Payment, the amount (₱ {amount:N0}) must equal the remaining balance (₱ {remainingBalance:N0}).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (purposeCb.Text == "Downpayment" && amount > remainingBalance)
            {
                MessageBox.Show($"For Downpayment, the amount (₱ {amount:N0}) cannot exceed the remaining balance (₱ {remainingBalance:N0}).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add payment
            bool success = _accountManager.AddPayment(_bookingID, Session.CurrentUserID, paymentMethodCb.Text, purposeCb.Text, amount);
            if (success)
            {
                MessageBox.Show("Payment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPaymentHistory(); // Refresh payment table
                // Clear input fields
                paymentMethodCb.SelectedIndex = -1;
                accountNameTb.Clear();
                accountNumberTb.Clear();
                amountTb.Clear();
                purposeCb.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Failed to add payment. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            LoadPaymentHistory();
        }
    }
}
