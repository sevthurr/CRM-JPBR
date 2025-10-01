using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Account_Information : Form
    {

        private readonly int currentUserID;

        public Account_Information(int userID)
        {
            InitializeComponent();
            currentUserID = userID;
            LoadUserInformation();
        }

        private void LoadUserInformation()
        {
            AccountManager accountManager = new AccountManager();
            UserDetails details = accountManager.GetUserDetails(currentUserID);
            if (details != null)
            {
                fullNameLbl.Text = $"{details.FirstName} {details.LastName}";
                roleLbl.Text = $"({details.Position})";
                firstNameTb.Text = details.FirstName;
                lastNameTb.Text = details.LastName;
                usernameTb.Text = details.UserName;
                emailTb.Text = details.Email ?? "N/A";
                phoneTb.Text = details.Phone ?? "N/A";
            }
            else
            {
                MessageBox.Show("Unable to load user information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void activateAccountBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                AccountManager accountManager = new AccountManager();
                bool success = accountManager.UpdateUserInfo(
                    currentUserID,
                    firstNameTb.Text.Trim(),
                    lastNameTb.Text.Trim(),
                    usernameTb.Text.Trim(),
                    emailTb.Text.Trim(),
                    phoneTb.Text.Trim(),
                    passwordTb.Text.Trim() // Pass empty string if no change
                );

                if (success)
                {
                    MessageBox.Show("Account information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUserInformation(); // Refresh displayed info
                }
                else
                {
                    MessageBox.Show("Failed to update account information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(firstNameTb.Text))
            {
                MessageBox.Show("First name is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(lastNameTb.Text))
            {
                MessageBox.Show("Last name is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(usernameTb.Text))
            {
                MessageBox.Show("Username is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!string.IsNullOrEmpty(passwordTb.Text) && passwordTb.Text != confirmPasswordTb.Text)
            {
                MessageBox.Show("Passwords do not match.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
