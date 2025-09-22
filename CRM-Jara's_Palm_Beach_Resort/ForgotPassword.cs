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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            resetPasswordBtn.Click += (s, e) =>
            {
                this.Close();
            };
            this.accountIdTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.accountIdTb_KeyPress);
        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void accountIdTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetPasswordBtn_Click(object sender, EventArgs e)
        {
            // Validate UserID input
            string userIdText = accountIdTb.Text;
            if (!int.TryParse(userIdText, out int userID) || userID <= 0)
            {
                MessageBox.Show("Please enter a valid Account ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newPassword = newPasswordTb.Text; // Adjust if TextBox name differs
            string confirmPassword = confirmPasswordTb.Text; // Adjust if TextBox name differs

            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please enter both new password and confirmation password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Optional: Password strength check
            if (newPassword.Length < 6)
            {
                MessageBox.Show("New password must be at least 6 characters long.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AccountManager manager = new AccountManager();
            if (manager.ResetPassword(userID, newPassword))
            {
                MessageBox.Show("Password reset successfully. You can now log in with your new password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to reset password. Account ID may not exist or account is inactive.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accountIdTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Allow only digits and control keys (e.g., backspace)
            }
        }
    }
}
