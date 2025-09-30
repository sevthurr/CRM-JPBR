namespace CRM_Jara_s_Palm_Beach_Resort
{
    partial class AccountManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            topNavBar1 = new TopNavBar();
            accountManagementLbl = new Label();
            accountsPanel = new Panel();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            activateAccountBtn = new Button();
            disableAccountBtn = new Button();
            accountsTable = new DataGridView();
            accountTableLbl = new Label();
            addAccountPanel = new Panel();
            addUserIcon = new FontAwesome.Sharp.IconPictureBox();
            viewConfirmPasswordIcon = new FontAwesome.Sharp.IconPictureBox();
            viewPasswordIcon = new FontAwesome.Sharp.IconPictureBox();
            addAccountBtn = new Button();
            confirmPasswordTb = new TextBox();
            confirmPasswordLbl = new Label();
            enterPasswordTb = new TextBox();
            passwordLbl = new Label();
            usernameTb = new TextBox();
            usernameLbl = new Label();
            horizontalLine = new Label();
            roleCb = new ComboBox();
            roleLbl = new Label();
            lastNameTb = new TextBox();
            lastNameLbl = new Label();
            firstNameTb = new TextBox();
            firstNameLbl = new Label();
            addAccountLbl = new Label();
            accountID = new DataGridViewTextBoxColumn();
            accountName = new DataGridViewTextBoxColumn();
            accountRole = new DataGridViewTextBoxColumn();
            userName = new DataGridViewTextBoxColumn();
            dateCreated = new DataGridViewTextBoxColumn();
            accountStatus = new DataGridViewTextBoxColumn();
            accountsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountsTable).BeginInit();
            addAccountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addUserIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewConfirmPasswordIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewPasswordIcon).BeginInit();
            SuspendLayout();
            // 
            // topNavBar1
            // 
            topNavBar1.Location = new Point(0, 0);
            topNavBar1.Name = "topNavBar1";
            topNavBar1.Size = new Size(2394, 71);
            topNavBar1.TabIndex = 0;
            // 
            // accountManagementLbl
            // 
            accountManagementLbl.AutoSize = true;
            accountManagementLbl.Font = new Font("Poppins", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountManagementLbl.Location = new Point(55, 101);
            accountManagementLbl.Name = "accountManagementLbl";
            accountManagementLbl.Size = new Size(419, 60);
            accountManagementLbl.TabIndex = 5;
            accountManagementLbl.Text = "Account Management";
            // 
            // accountsPanel
            // 
            accountsPanel.BackColor = Color.White;
            accountsPanel.Controls.Add(iconPictureBox5);
            accountsPanel.Controls.Add(iconPictureBox4);
            accountsPanel.Controls.Add(activateAccountBtn);
            accountsPanel.Controls.Add(disableAccountBtn);
            accountsPanel.Controls.Add(accountsTable);
            accountsPanel.Controls.Add(accountTableLbl);
            accountsPanel.Location = new Point(645, 180);
            accountsPanel.Name = "accountsPanel";
            accountsPanel.Size = new Size(1214, 768);
            accountsPanel.TabIndex = 9;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.Gray;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            iconPictureBox5.IconColor = Color.White;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 25;
            iconPictureBox5.Location = new Point(980, 713);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(25, 25);
            iconPictureBox5.TabIndex = 46;
            iconPictureBox5.TabStop = false;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.FromArgb(38, 176, 112);
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            iconPictureBox4.IconColor = Color.White;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 25;
            iconPictureBox4.Location = new Point(740, 713);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(25, 25);
            iconPictureBox4.TabIndex = 45;
            iconPictureBox4.TabStop = false;
            // 
            // activateAccountBtn
            // 
            activateAccountBtn.BackColor = Color.FromArgb(38, 176, 112);
            activateAccountBtn.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            activateAccountBtn.ForeColor = Color.Transparent;
            activateAccountBtn.Location = new Point(720, 703);
            activateAccountBtn.Name = "activateAccountBtn";
            activateAccountBtn.Size = new Size(213, 45);
            activateAccountBtn.TabIndex = 44;
            activateAccountBtn.Text = "    Activate Account";
            activateAccountBtn.UseVisualStyleBackColor = false;
            // 
            // disableAccountBtn
            // 
            disableAccountBtn.BackColor = Color.Gray;
            disableAccountBtn.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            disableAccountBtn.ForeColor = Color.Transparent;
            disableAccountBtn.Location = new Point(958, 703);
            disableAccountBtn.Name = "disableAccountBtn";
            disableAccountBtn.Size = new Size(213, 45);
            disableAccountBtn.TabIndex = 29;
            disableAccountBtn.Text = "    Disable Account";
            disableAccountBtn.UseVisualStyleBackColor = false;
            // 
            // accountsTable
            // 
            accountsTable.AllowUserToAddRows = false;
            accountsTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 197, 149);
            accountsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            accountsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            accountsTable.BackgroundColor = Color.White;
            accountsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            accountsTable.Columns.AddRange(new DataGridViewColumn[] { accountID, accountName, accountRole, userName, dateCreated, accountStatus });
            accountsTable.GridColor = Color.White;
            accountsTable.Location = new Point(58, 102);
            accountsTable.Name = "accountsTable";
            accountsTable.ReadOnly = true;
            accountsTable.RowHeadersWidth = 51;
            accountsTable.Size = new Size(1113, 578);
            accountsTable.TabIndex = 43;
            // 
            // accountTableLbl
            // 
            accountTableLbl.AutoSize = true;
            accountTableLbl.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountTableLbl.Location = new Point(58, 42);
            accountTableLbl.Name = "accountTableLbl";
            accountTableLbl.Size = new Size(201, 40);
            accountTableLbl.TabIndex = 9;
            accountTableLbl.Text = "Accounts Table";
            // 
            // addAccountPanel
            // 
            addAccountPanel.BackColor = Color.White;
            addAccountPanel.BorderStyle = BorderStyle.FixedSingle;
            addAccountPanel.Controls.Add(addUserIcon);
            addAccountPanel.Controls.Add(viewConfirmPasswordIcon);
            addAccountPanel.Controls.Add(viewPasswordIcon);
            addAccountPanel.Controls.Add(addAccountBtn);
            addAccountPanel.Controls.Add(confirmPasswordTb);
            addAccountPanel.Controls.Add(confirmPasswordLbl);
            addAccountPanel.Controls.Add(enterPasswordTb);
            addAccountPanel.Controls.Add(passwordLbl);
            addAccountPanel.Controls.Add(usernameTb);
            addAccountPanel.Controls.Add(usernameLbl);
            addAccountPanel.Controls.Add(horizontalLine);
            addAccountPanel.Controls.Add(roleCb);
            addAccountPanel.Controls.Add(roleLbl);
            addAccountPanel.Controls.Add(lastNameTb);
            addAccountPanel.Controls.Add(lastNameLbl);
            addAccountPanel.Controls.Add(firstNameTb);
            addAccountPanel.Controls.Add(firstNameLbl);
            addAccountPanel.Controls.Add(addAccountLbl);
            addAccountPanel.Location = new Point(64, 180);
            addAccountPanel.Name = "addAccountPanel";
            addAccountPanel.Size = new Size(532, 768);
            addAccountPanel.TabIndex = 8;
            // 
            // addUserIcon
            // 
            addUserIcon.BackColor = Color.FromArgb(82, 169, 181);
            addUserIcon.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            addUserIcon.IconColor = Color.White;
            addUserIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addUserIcon.IconSize = 25;
            addUserIcon.Location = new Point(183, 675);
            addUserIcon.Name = "addUserIcon";
            addUserIcon.Size = new Size(25, 25);
            addUserIcon.TabIndex = 28;
            addUserIcon.TabStop = false;
            // 
            // viewConfirmPasswordIcon
            // 
            viewConfirmPasswordIcon.BackColor = Color.White;
            viewConfirmPasswordIcon.ForeColor = SystemColors.ControlDarkDark;
            viewConfirmPasswordIcon.IconChar = FontAwesome.Sharp.IconChar.Eye;
            viewConfirmPasswordIcon.IconColor = SystemColors.ControlDarkDark;
            viewConfirmPasswordIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            viewConfirmPasswordIcon.IconSize = 30;
            viewConfirmPasswordIcon.Location = new Point(462, 582);
            viewConfirmPasswordIcon.Name = "viewConfirmPasswordIcon";
            viewConfirmPasswordIcon.Size = new Size(30, 30);
            viewConfirmPasswordIcon.TabIndex = 27;
            viewConfirmPasswordIcon.TabStop = false;
            // 
            // viewPasswordIcon
            // 
            viewPasswordIcon.BackColor = Color.White;
            viewPasswordIcon.ForeColor = SystemColors.ControlDarkDark;
            viewPasswordIcon.IconChar = FontAwesome.Sharp.IconChar.Eye;
            viewPasswordIcon.IconColor = SystemColors.ControlDarkDark;
            viewPasswordIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            viewPasswordIcon.IconSize = 30;
            viewPasswordIcon.Location = new Point(462, 508);
            viewPasswordIcon.Name = "viewPasswordIcon";
            viewPasswordIcon.Size = new Size(30, 30);
            viewPasswordIcon.TabIndex = 26;
            viewPasswordIcon.TabStop = false;
            // 
            // addAccountBtn
            // 
            addAccountBtn.BackColor = Color.FromArgb(82, 169, 181);
            addAccountBtn.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addAccountBtn.ForeColor = Color.Transparent;
            addAccountBtn.Location = new Point(152, 667);
            addAccountBtn.Name = "addAccountBtn";
            addAccountBtn.Size = new Size(213, 42);
            addAccountBtn.TabIndex = 25;
            addAccountBtn.Text = "    Add Account";
            addAccountBtn.UseVisualStyleBackColor = false;
            // 
            // confirmPasswordTb
            // 
            confirmPasswordTb.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPasswordTb.Location = new Point(195, 578);
            confirmPasswordTb.Multiline = true;
            confirmPasswordTb.Name = "confirmPasswordTb";
            confirmPasswordTb.PasswordChar = '*';
            confirmPasswordTb.PlaceholderText = "Confirm Password";
            confirmPasswordTb.Size = new Size(251, 36);
            confirmPasswordTb.TabIndex = 24;
            // 
            // confirmPasswordLbl
            // 
            confirmPasswordLbl.AutoSize = true;
            confirmPasswordLbl.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPasswordLbl.Location = new Point(47, 583);
            confirmPasswordLbl.Name = "confirmPasswordLbl";
            confirmPasswordLbl.Size = new Size(132, 31);
            confirmPasswordLbl.TabIndex = 23;
            confirmPasswordLbl.Text = "Re-Password";
            // 
            // enterPasswordTb
            // 
            enterPasswordTb.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enterPasswordTb.Location = new Point(195, 505);
            enterPasswordTb.Multiline = true;
            enterPasswordTb.Name = "enterPasswordTb";
            enterPasswordTb.PlaceholderText = "Enter Password";
            enterPasswordTb.Size = new Size(251, 36);
            enterPasswordTb.TabIndex = 22;
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLbl.Location = new Point(47, 510);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(100, 31);
            passwordLbl.TabIndex = 21;
            passwordLbl.Text = "Password";
            // 
            // usernameTb
            // 
            usernameTb.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTb.Location = new Point(195, 432);
            usernameTb.Multiline = true;
            usernameTb.Name = "usernameTb";
            usernameTb.PlaceholderText = "Enter Username";
            usernameTb.Size = new Size(251, 36);
            usernameTb.TabIndex = 20;
            // 
            // usernameLbl
            // 
            usernameLbl.AutoSize = true;
            usernameLbl.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLbl.Location = new Point(47, 437);
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(107, 31);
            usernameLbl.TabIndex = 19;
            usernameLbl.Text = "Username";
            // 
            // horizontalLine
            // 
            horizontalLine.AutoSize = true;
            horizontalLine.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            horizontalLine.ForeColor = SystemColors.ControlDarkDark;
            horizontalLine.Location = new Point(47, 364);
            horizontalLine.Name = "horizontalLine";
            horizontalLine.Size = new Size(428, 26);
            horizontalLine.TabIndex = 18;
            horizontalLine.Text = "----------------------------------------------------";
            // 
            // roleCb
            // 
            roleCb.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roleCb.FormattingEnabled = true;
            roleCb.Items.AddRange(new object[] { "Staff", "Admin" });
            roleCb.Location = new Point(195, 284);
            roleCb.Name = "roleCb";
            roleCb.Size = new Size(251, 38);
            roleCb.TabIndex = 16;
            // 
            // roleLbl
            // 
            roleLbl.AutoSize = true;
            roleLbl.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roleLbl.Location = new Point(48, 289);
            roleLbl.Name = "roleLbl";
            roleLbl.Size = new Size(52, 31);
            roleLbl.TabIndex = 15;
            roleLbl.Text = "Role";
            // 
            // lastNameTb
            // 
            lastNameTb.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameTb.Location = new Point(195, 212);
            lastNameTb.Multiline = true;
            lastNameTb.Name = "lastNameTb";
            lastNameTb.PlaceholderText = "Enter Last Name";
            lastNameTb.Size = new Size(251, 36);
            lastNameTb.TabIndex = 12;
            // 
            // lastNameLbl
            // 
            lastNameLbl.AutoSize = true;
            lastNameLbl.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLbl.Location = new Point(47, 217);
            lastNameLbl.Name = "lastNameLbl";
            lastNameLbl.Size = new Size(110, 31);
            lastNameLbl.TabIndex = 11;
            lastNameLbl.Text = "Last Name";
            // 
            // firstNameTb
            // 
            firstNameTb.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameTb.Location = new Point(195, 139);
            firstNameTb.Multiline = true;
            firstNameTb.Name = "firstNameTb";
            firstNameTb.PlaceholderText = "Enter first name";
            firstNameTb.Size = new Size(251, 36);
            firstNameTb.TabIndex = 10;
            // 
            // firstNameLbl
            // 
            firstNameLbl.AutoSize = true;
            firstNameLbl.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameLbl.Location = new Point(47, 144);
            firstNameLbl.Name = "firstNameLbl";
            firstNameLbl.Size = new Size(110, 31);
            firstNameLbl.TabIndex = 9;
            firstNameLbl.Text = "First Name";
            // 
            // addAccountLbl
            // 
            addAccountLbl.AutoSize = true;
            addAccountLbl.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addAccountLbl.Location = new Point(175, 42);
            addAccountLbl.Name = "addAccountLbl";
            addAccountLbl.Size = new Size(170, 40);
            addAccountLbl.TabIndex = 8;
            addAccountLbl.Text = "Add Account";
            // 
            // accountID
            // 
            accountID.DataPropertyName = "UserID";
            accountID.HeaderText = "Account ID";
            accountID.MinimumWidth = 6;
            accountID.Name = "accountID";
            accountID.ReadOnly = true;
            // 
            // accountName
            // 
            accountName.DataPropertyName = "AccountName";
            accountName.HeaderText = "Name";
            accountName.MinimumWidth = 6;
            accountName.Name = "accountName";
            accountName.ReadOnly = true;
            // 
            // accountRole
            // 
            accountRole.DataPropertyName = "Role";
            accountRole.HeaderText = "Role";
            accountRole.MinimumWidth = 6;
            accountRole.Name = "accountRole";
            accountRole.ReadOnly = true;
            // 
            // userName
            // 
            userName.DataPropertyName = "UserName";
            userName.HeaderText = "User Name";
            userName.MinimumWidth = 6;
            userName.Name = "userName";
            userName.ReadOnly = true;
            // 
            // dateCreated
            // 
            dateCreated.DataPropertyName = "DateCreated";
            dateCreated.HeaderText = "Date Created";
            dateCreated.MinimumWidth = 6;
            dateCreated.Name = "dateCreated";
            dateCreated.ReadOnly = true;
            // 
            // accountStatus
            // 
            accountStatus.DataPropertyName = "Status";
            accountStatus.HeaderText = "Status";
            accountStatus.MinimumWidth = 6;
            accountStatus.Name = "accountStatus";
            accountStatus.ReadOnly = true;
            // 
            // AccountManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 977);
            Controls.Add(accountsPanel);
            Controls.Add(addAccountPanel);
            Controls.Add(accountManagementLbl);
            Controls.Add(topNavBar1);
            Name = "AccountManagement";
            Text = "Account Management";
            accountsPanel.ResumeLayout(false);
            accountsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountsTable).EndInit();
            addAccountPanel.ResumeLayout(false);
            addAccountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addUserIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewConfirmPasswordIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewPasswordIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TopNavBar topNavBar1;
        private Label accountManagementLbl;
        private Panel accountsPanel;
        private Label accountTableLbl;
        private Panel addAccountPanel;
        private TextBox confirmPasswordTb;
        private Label confirmPasswordLbl;
        private TextBox enterPasswordTb;
        private Label passwordLbl;
        private TextBox usernameTb;
        private Label usernameLbl;
        private Label horizontalLine;
        private ComboBox roleCb;
        private Label roleLbl;
        private TextBox lastNameTb;
        private Label lastNameLbl;
        private TextBox firstNameTb;
        private Label firstNameLbl;
        private Label addAccountLbl;
        private FontAwesome.Sharp.IconPictureBox viewPasswordIcon;
        private Button addAccountBtn;
        private FontAwesome.Sharp.IconPictureBox addUserIcon;
        private FontAwesome.Sharp.IconPictureBox viewConfirmPasswordIcon;
        private DataGridView accountsTable;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Button activateAccountBtn;
        private Button disableAccountBtn;
        private DataGridViewTextBoxColumn accountID;
        private DataGridViewTextBoxColumn accountName;
        private DataGridViewTextBoxColumn accountRole;
        private DataGridViewTextBoxColumn userName;
        private DataGridViewTextBoxColumn dateCreated;
        private DataGridViewTextBoxColumn accountStatus;
    }
}