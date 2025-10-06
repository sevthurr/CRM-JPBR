using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace CRM_Jara_s_Palm_Beach_Resort
{
    public partial class EditBooking : Form
    {
        // Expose edited values so calling form can read them after dialog
        public string GuestFullName => GetFullName();
        public DateTime CheckIn => checkInDp.Value;
        public DateTime CheckOut => checkOutDp.Value;
        public int Pax => (int)guestQty.Value;
        public string SelectedPackage => packageARBtn.Checked ? "Package A" : (packageBRbtn.Checked ? "Package B" : string.Empty);
        public string ContactInfo => contactTb.Text?.Trim();
        public string AddressInfo => addressTb.Text?.Trim();

        private readonly Color highlightColor = Color.FromArgb(235, 197, 149);
        private bool suppressEvents = false;

        public EditBooking()
        {
            InitializeComponent();
            // Wire the Save button
            proceedPaymentBtn.Click += ProceedPaymentBtn_Click;

            // Wire package selection behavior (copied from NewBookingForm)
            packageARBtn.CheckedChanged += packageARBtn_CheckedChanged;
            packageBRbtn.CheckedChanged += packageBRbtn_CheckedChanged;
            packageAPanel.Paint += packageAPanel_Paint;
            packageBPanel.Paint += packageBPanel_Paint;
            packageAPanel.Click += packageAPanel_Click;
            packageBPanel.Click += packageBPanel_Click;
        }

        // Convenience constructor to pre-fill fields from an existing booking
        public EditBooking(string guestFullName, DateTime? checkIn = null, DateTime? checkOut = null, int pax = 1, string packageName = "", string contact = "", string address = "") : this()
        {
            if (!string.IsNullOrWhiteSpace(guestFullName))
            {
                // Try to split full name into first and last
                var parts = guestFullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 1)
                {
                    firstNameTb.Text = parts[0];
                }
                else if (parts.Length >= 2)
                {
                    firstNameTb.Text = parts.First();
                    lastNameTb.Text = string.Join(' ', parts.Skip(1));
                }
            }

            if (checkIn.HasValue)
                checkInDp.Value = checkIn.Value;
            if (checkOut.HasValue)
                checkOutDp.Value = checkOut.Value;

            guestQty.Value = Math.Max(1, Math.Min(guestQty.Maximum, pax));

            if (!string.IsNullOrWhiteSpace(packageName))
            {
                suppressEvents = true;
                packageARBtn.Checked = packageName.Equals("Package A", StringComparison.OrdinalIgnoreCase);
                packageBRbtn.Checked = packageName.Equals("Package B", StringComparison.OrdinalIgnoreCase);
                // make sure panels reflect state
                packageAPanel.Invalidate();
                packageBPanel.Invalidate();
                suppressEvents = false;
            }

            contactTb.Text = contact ?? string.Empty;
            addressTb.Text = address ?? string.Empty;
        }

        private void ProceedPaymentBtn_Click(object? sender, EventArgs e)
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(firstNameTb.Text) && string.IsNullOrWhiteSpace(lastNameTb.Text))
            {
                MessageBox.Show("Please provide guest name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (checkOutDp.Value.Date < checkInDp.Value.Date)
            {
                MessageBox.Show("Check-out date cannot be earlier than check-in date.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Show custom confirmation dialog with Agree / Confirm / Back
            using (var dlg = new EditConfirmDialog())
            {
                var dr = dlg.ShowDialog(this);
                if (dr != DialogResult.OK)
                {
                    // user backed out
                    return;
                }
            }

            // If confirmed, close dialog with OK so caller can read properties
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private string GetFullName()
        {
            var first = firstNameTb.Text?.Trim();
            var last = lastNameTb.Text?.Trim();
            if (string.IsNullOrEmpty(first) && string.IsNullOrEmpty(last)) return string.Empty;
            if (string.IsNullOrEmpty(last)) return first;
            if (string.IsNullOrEmpty(first)) return last;
            return first + " " + last;
        }

        // -- Package selection behavior (copied and adapted from NewBookingForm)
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

        // Custom confirmation dialog shown when saving edits
        private class EditConfirmDialog : Form
        {
            private Button agreeBtn;
            private Button confirmBtn;
            private Button backBtn;
            private Label msgLbl;
            private bool agreed = false;

            public EditConfirmDialog()
            {
                InitializeComponents();
            }

            private void InitializeComponents()
            {
                this.Text = "Confirm Edit";
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.StartPosition = FormStartPosition.CenterParent;
                this.Size = new Size(480, 200);
                this.MaximizeBox = false;
                this.MinimizeBox = false;

                msgLbl = new Label()
                {
                    AutoSize = false,
                    Location = new Point(16, 16),
                    Size = new Size(440, 70),
                    Text = "These edits will change the guest's detail or their outstanding balance. Are you sure you want to edit the booking?",
                };

                agreeBtn = new Button()
                {
                    Text = "Agree",
                    Location = new Point(40, 100),
                    Size = new Size(100, 35)
                };
                agreeBtn.Click += AgreeBtn_Click;

                confirmBtn = new Button()
                {
                    Text = "Confirm",
                    Location = new Point(180, 100),
                    Size = new Size(100, 35),
                    Enabled = false
                };
                confirmBtn.Click += ConfirmBtn_Click;

                backBtn = new Button()
                {
                    Text = "Back",
                    Location = new Point(320, 100),
                    Size = new Size(100, 35)
                };
                backBtn.Click += BackBtn_Click;

                this.Controls.Add(msgLbl);
                this.Controls.Add(agreeBtn);
                this.Controls.Add(confirmBtn);
                this.Controls.Add(backBtn);
            }

            private void AgreeBtn_Click(object? sender, EventArgs e)
            {
                agreed = true;
                agreeBtn.Enabled = false;
                confirmBtn.Enabled = true;
                msgLbl.Text = "You agreed to the change. Click Confirm to apply edits or Back to cancel.";
            }

            private void ConfirmBtn_Click(object? sender, EventArgs e)
            {
                if (!agreed)
                {
                    MessageBox.Show("Please click Agree before confirming.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            private void BackBtn_Click(object? sender, EventArgs e)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
