using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Jara_s_Palm_Beach_Resort
{
    public partial class NewBookingForm : Form
    {
        public NewBookingForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Attach event handlers for package selection
            packageARBtn.CheckedChanged += packageARBtn_CheckedChanged;
            packageBRbtn.CheckedChanged += packageBRbtn_CheckedChanged;
            packageAPanel.Paint += packageAPanel_Paint;
            packageBPanel.Paint += packageBPanel_Paint;
            proceedPaymentBtn.Click += proceedPaymentBtn_Click;
            guestQty.ValueChanged += guestQty_ValueChanged;
        }

        // Store form data in a serializable object
        public BookingFormData GetFormData()
        {
            return new BookingFormData
            {
                FirstName = firstNameTb.Text,
                MiddleName = middleNameTb.Text,
                LastName = lastNameTb.Text,
                Suffix = suffixCb.Text,
                Email = emailTb.Text,
                Address = addressTb.Text,
                Contact = contactTb.Text,
                Platform = platformCb.Text,
                BookingDate = bookingDateDp.Value,
                CheckIn = checkInDp.Value,
                CheckOut = checkOutDp.Value,
                GuestQty = (int)guestQty.Value,
                PromoCode = textBox1.Text,
                PackageASelected = packageARBtn.Checked,
                PackageBSelected = packageBRbtn.Checked
            };
        }

        public void SetFormData(BookingFormData data)
        {
            firstNameTb.Text = data.FirstName;
            middleNameTb.Text = data.MiddleName;
            lastNameTb.Text = data.LastName;
            suffixCb.Text = data.Suffix;
            emailTb.Text = data.Email;
            addressTb.Text = data.Address;
            contactTb.Text = data.Contact;
            platformCb.Text = data.Platform;
            bookingDateDp.Value = data.BookingDate;
            checkInDp.Value = data.CheckIn;
            checkOutDp.Value = data.CheckOut;
            guestQty.Value = data.GuestQty;
            textBox1.Text = data.PromoCode;
            packageARBtn.Checked = data.PackageASelected;
            packageBRbtn.Checked = data.PackageBSelected;
        }

        private void guestQty_ValueChanged(object sender, EventArgs e)
        {
            int maxGuests = packageARBtn.Checked ? 30 : packageBRbtn.Checked ? 20 : 0;

            if (maxGuests > 0 && guestQty.Value > maxGuests)
            {
                string packageName = packageARBtn.Checked ? "Package A" : "Package B";
                MessageBox.Show(
                    $"Warning: Guest quantity exceeds the limit of {maxGuests} for {packageName}. " +
                    "Excess guests will be charged ₱100 per person per night.",
                    "Guest Limit",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void proceedPaymentBtn_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(firstNameTb.Text) ||
                string.IsNullOrWhiteSpace(lastNameTb.Text) ||
                string.IsNullOrWhiteSpace(addressTb.Text) ||
                string.IsNullOrWhiteSpace(contactTb.Text) ||
                string.IsNullOrWhiteSpace(platformCb.Text) ||
                string.IsNullOrWhiteSpace(emailTb.Text))
            {
                MessageBox.Show("Please fill in all required fields (First Name, Last Name, Address, Contact, Platform, Email).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate contact
            if (!Regex.IsMatch(contactTb.Text, @"^\+?\d{10,15}$"))
            {
                MessageBox.Show("Please enter a valid contact number (10-15 digits, optional + prefix).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (new AccountManager().IsContactNumberUsed(contactTb.Text))
            {
                MessageBox.Show("Contact number is already used.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate email
            if (!Regex.IsMatch(emailTb.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate dates
            DateTime today = DateTime.Today;
            if (bookingDateDp.Value.Date < today)
            {
                MessageBox.Show("Booking Date cannot be in the past.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (checkInDp.Value.Date < bookingDateDp.Value.Date)
            {
                MessageBox.Show("Check-In Date cannot be before Booking Date.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (checkOutDp.Value.Date <= checkInDp.Value.Date)
            {
                MessageBox.Show("Check-Out Date must be after Check-In Date.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate package selection
            if (!packageARBtn.Checked && !packageBRbtn.Checked)
            {
                MessageBox.Show("Please select a package (Package A or Package B).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate GuestQty
            if (guestQty.Value <= 0)
            {
                MessageBox.Show("Guest Quantity must be greater than 0.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Proceed to payment
            using (var paymentForm = new BookingPayment(GetFormData()))
            {
                paymentForm.StartPosition = FormStartPosition.CenterParent;
                paymentForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                paymentForm.ShowInTaskbar = false;
                paymentForm.MaximizeBox = false;
                paymentForm.MinimizeBox = true;
                this.Hide();
                var result = paymentForm.ShowDialog(this);
                if (result == DialogResult.Retry)
                {
                    if (paymentForm.RestoreData != null)
                    {
                        SetFormData(paymentForm.RestoreData);
                    }
                    this.Show();
                }
                else if (result == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    this.Show();
                }
            }
        }

        private readonly Color highlightColor = Color.FromArgb(235, 197, 149);
        private bool suppressEvents = false;

        private void packageARBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (suppressEvents) return;
            if (packageARBtn.Checked)
            {
                packageAPanel.BorderStyle = BorderStyle.FixedSingle;
                packageBPanel.BorderStyle = BorderStyle.None;
                packageBRbtn.Enabled = false;
            }
            else
            {
                packageAPanel.BorderStyle = BorderStyle.None;
                packageBRbtn.Enabled = true;
            }
            packageAPanel.Invalidate();
            packageBPanel.Invalidate();
        }

        private void packageBRbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (suppressEvents) return;
            if (packageBRbtn.Checked)
            {
                packageBPanel.BorderStyle = BorderStyle.FixedSingle;
                packageAPanel.BorderStyle = BorderStyle.None;
                packageARBtn.Enabled = false;
            }
            else
            {
                packageBPanel.BorderStyle = BorderStyle.None;
                packageARBtn.Enabled = true;
            }
            packageBPanel.Invalidate();
            packageAPanel.Invalidate();
        }

        // Custom border color for highlight
        private void packageAPanel_Paint(object sender, PaintEventArgs e)
        {
            if (packageAPanel.BorderStyle == BorderStyle.FixedSingle && packageARBtn.Checked)
            {
                using (Pen p = new Pen(highlightColor, 3))
                {
                    e.Graphics.DrawRectangle(p, 1, 1, packageAPanel.Width - 3, packageAPanel.Height - 3);
                }
            }
        }

        private void packageBPanel_Paint(object sender, PaintEventArgs e)
        {
            if (packageBPanel.BorderStyle == BorderStyle.FixedSingle && packageBRbtn.Checked)
            {
                using (Pen p = new Pen(highlightColor, 3))
                {
                    e.Graphics.DrawRectangle(p, 1, 1, packageBPanel.Width - 3, packageBPanel.Height - 3);
                }
            }
        }

        // Allow unselecting the selected radio button and re-enable the other
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            // If click is outside both panels, unselect both
            if (!packageAPanel.Bounds.Contains(PointToClient(MousePosition)) &&
                !packageBPanel.Bounds.Contains(PointToClient(MousePosition)))
            {
                suppressEvents = true;
                packageARBtn.Checked = false;
                packageBRbtn.Checked = false;
                packageARBtn.Enabled = true;
                packageBRbtn.Enabled = true;
                packageAPanel.BorderStyle = BorderStyle.None;
                packageBPanel.BorderStyle = BorderStyle.None;
                packageAPanel.Invalidate();
                packageBPanel.Invalidate();
                suppressEvents = false;
            }
        }

        private void packageAPanel_Click(object sender, EventArgs e)
        {
            if (!packageARBtn.Checked)
            {
                packageARBtn.Checked = true;
            }
            else
            {
                suppressEvents = true;
                packageARBtn.Checked = false;
                packageBRbtn.Enabled = true;
                packageAPanel.BorderStyle = BorderStyle.None;
                packageAPanel.Invalidate();
                suppressEvents = false;
            }
        }

        private void packageBPanel_Click(object sender, EventArgs e)
        {
            if (!packageBRbtn.Checked)
            {
                packageBRbtn.Checked = true;
            }
            else
            {
                suppressEvents = true;
                packageBRbtn.Checked = false;
                packageARBtn.Enabled = true;
                packageBPanel.BorderStyle = BorderStyle.None;
                packageBPanel.Invalidate();
                suppressEvents = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void proceedPaymentBtn_Click_1(object sender, EventArgs e)
        {

        }
    }

    public class BookingFormData
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Platform { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int GuestQty { get; set; }
        public string PromoCode { get; set; }
        public bool PackageASelected { get; set; }
        public bool PackageBSelected { get; set; }
    }
}
