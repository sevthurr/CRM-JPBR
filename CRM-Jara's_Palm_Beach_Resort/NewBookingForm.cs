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

        private void proceedPaymentBtn_Click(object sender, EventArgs e)
        {
            var paymentForm = new BookingPayment(GetFormData());
            paymentForm.StartPosition = FormStartPosition.CenterParent;
            paymentForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            paymentForm.ShowInTaskbar = false;
            paymentForm.MaximizeBox = false;
            paymentForm.MinimizeBox = true;
            this.Hide();
            paymentForm.ShowDialog(this);
            if (paymentForm.DialogResult == DialogResult.Retry)
            {
                // User clicked backBtn in BookingPayment
                if (paymentForm.RestoreData != null)
                {
                    SetFormData(paymentForm.RestoreData);
                }
                this.Show();
            }
            else if (paymentForm.DialogResult == DialogResult.OK)
            {
                // User confirmed booking, close this form
                this.Close();
            }
            else
            {
                // User closed payment form, just show this form again
                this.Show();
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
    }

    public class BookingFormData
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
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
