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
    public partial class AccountManagement : Form
    {
        private AccountManager accountManager;

        public AccountManagement()
        {
            InitializeComponent();
            accountManager = new AccountManager();
            this.Load += AccountManagement_Load;

            addAccountBtn.Click += AddAccountBtn_Click;
            activateAccountBtn.Click += ActivateAccountBtn_Click;
            disableAccountBtn.Click += DisableAccountBtn_Click;
            viewPasswordIcon.Click += ViewPasswordIcon_Click;
            viewConfirmPasswordIcon.Click += ViewConfirmPasswordIcon_Click;
        }

        private void AccountManagement_Load(object sender, EventArgs e)
        {
            accountsTable.EnableHeadersVisualStyles = false;
            accountsTable.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 10F, FontStyle.Bold);
            accountsTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            accountsTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            accountsTable.ColumnHeadersDefaultCellStyle.BackColor = Color.White;

            accountsTable.DefaultCellStyle.Font = new Font("Poppins", 9F, FontStyle.Regular);
            accountsTable.DefaultCellStyle.ForeColor = Color.Black;
            accountsTable.DefaultCellStyle.SelectionForeColor = Color.Black;

            accountsTable.RowHeadersVisible = false;
            accountsTable.MultiSelect = false;
            accountsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Load sample data only if table is empty to avoid duplicate entries
            if (accountsTable.Rows.Count == 0)
            {
                accountsTable.Rows.Add("A001", "Ballerina Capuccina", "Staff", "bcapuccina", "mm/dd/yyyy", "Active");
                accountsTable.Rows.Add("A002", "Tung Tung Sahur", "Admin", "tsahur", "mm/dd/yyyy", "Active");
                accountsTable.Rows.Add("A003", "Tralalelo Tralala", "Staff", "ttralala", "mm/dd/yyyy", "Disabled");
            }

            ConfigureDataGridView();
            LoadAccountsData();
        }

        private void ConfigureDataGridView()
        {
            accountsTable.EnableHeadersVisualStyles = false;
            accountsTable.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 10F, FontStyle.Bold);
            accountsTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            accountsTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            accountsTable.ColumnHeadersDefaultCellStyle.BackColor = Color.White;

            accountsTable.DefaultCellStyle.Font = new Font("Poppins", 9F, FontStyle.Regular);
            accountsTable.DefaultCellStyle.ForeColor = Color.Black;
            accountsTable.DefaultCellStyle.SelectionForeColor = Color.Black;

            accountsTable.RowHeadersVisible = false;
            accountsTable.MultiSelect = false;
            accountsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            accountsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadAccountsData()
        {
            try
            {
                DataTable accounts = accountManager.GetAccounts();
                accountsTable.DataSource = accounts;

                // Rename columns to match your expected format
                if (accountsTable.Columns.Contains("UserID"))
                    accountsTable.Columns["UserID"].HeaderText = "Account ID";
                if (accountsTable.Columns.Contains("AccountName"))
                    accountsTable.Columns["AccountName"].HeaderText = "Name";
                if (accountsTable.Columns.Contains("Role"))
                    accountsTable.Columns["Role"].HeaderText = "Role";
                if (accountsTable.Columns.Contains("UserName"))
                    accountsTable.Columns["UserName"].HeaderText = "User Name";
                if (accountsTable.Columns.Contains("DateCreated"))
                    accountsTable.Columns["DateCreated"].HeaderText = "Date Created";
                if (accountsTable.Columns.Contains("Status"))
                    accountsTable.Columns["Status"].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading accounts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddAccountBtn_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(firstNameTb.Text) ||
                string.IsNullOrWhiteSpace(lastNameTb.Text) ||
                string.IsNullOrWhiteSpace(usernameTb.Text) ||
                string.IsNullOrWhiteSpace(enterPasswordTb.Text) ||
                string.IsNullOrWhiteSpace(confirmPasswordTb.Text) ||
                roleCb.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (enterPasswordTb.Text != confirmPasswordTb.Text)
            {
                MessageBox.Show("Passwords do not match.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (enterPasswordTb.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool success = accountManager.CreateAccount(
                    firstNameTb.Text.Trim(),
                    lastNameTb.Text.Trim(),
                    usernameTb.Text.Trim(),
                    enterPasswordTb.Text,
                    roleCb.SelectedItem.ToString()
                );

                if (success)
                {
                    MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadAccountsData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActivateAccountBtn_Click(object sender, EventArgs e)
        {
            UpdateSelectedAccountStatus("Active");
        }

        private void DisableAccountBtn_Click(object sender, EventArgs e)
        {
            UpdateSelectedAccountStatus("Disabled");
        }

        private void UpdateSelectedAccountStatus(string status)
        {
            if (accountsTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an account first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = accountsTable.SelectedRows[0];
            int userID = Convert.ToInt32(selectedRow.Cells["accountID"].Value);
            string currentStatus = selectedRow.Cells["accountStatus"].Value.ToString();

            if (currentStatus == status)
            {
                MessageBox.Show($"Account is already {status.ToLower()}.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to {status.ToLower()} this account?",
                "Confirm Action",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                bool success = accountManager.UpdateAccountStatus(userID, status);
                if (success)
                {
                    MessageBox.Show($"Account {status.ToLower()} successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAccountsData();
                }
            }
        }

        private void ViewPasswordIcon_Click(object sender, EventArgs e)
        {
            enterPasswordTb.UseSystemPasswordChar = !enterPasswordTb.UseSystemPasswordChar;
            viewPasswordIcon.IconChar = enterPasswordTb.UseSystemPasswordChar ?
                FontAwesome.Sharp.IconChar.Eye : FontAwesome.Sharp.IconChar.EyeSlash;
        }

        private void ViewConfirmPasswordIcon_Click(object sender, EventArgs e)
        {
            confirmPasswordTb.UseSystemPasswordChar = !confirmPasswordTb.UseSystemPasswordChar;
            viewConfirmPasswordIcon.IconChar = confirmPasswordTb.UseSystemPasswordChar ?
                FontAwesome.Sharp.IconChar.Eye : FontAwesome.Sharp.IconChar.EyeSlash;
        }

        private void ClearForm()
        {
            firstNameTb.Clear();
            lastNameTb.Clear();
            usernameTb.Clear();
            enterPasswordTb.Clear();
            confirmPasswordTb.Clear();
            roleCb.SelectedIndex = -1;
        }
    }
}

