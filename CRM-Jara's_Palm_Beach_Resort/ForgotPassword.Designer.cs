namespace CRM_Jara_s_Palm_Beach_Resort
{
    partial class ForgotPassword
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
            loginPanel = new Panel();
            confirmPasswordTb = new TextBox();
            confirmPasswordLbl = new Label();
            newPasswordTb = new TextBox();
            accountIdTb = new TextBox();
            newPasswordLbl = new Label();
            accountIdLbl = new Label();
            panel1 = new Panel();
            resetPasswordBtn = new Button();
            loginPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.BackColor = SystemColors.Control;
            loginPanel.Controls.Add(confirmPasswordTb);
            loginPanel.Controls.Add(confirmPasswordLbl);
            loginPanel.Controls.Add(newPasswordTb);
            loginPanel.Controls.Add(accountIdTb);
            loginPanel.Controls.Add(newPasswordLbl);
            loginPanel.Controls.Add(accountIdLbl);
            loginPanel.Controls.Add(panel1);
            loginPanel.Location = new Point(0, 0);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(472, 433);
            loginPanel.TabIndex = 2;
            loginPanel.Paint += loginPanel_Paint;
            // 
            // confirmPasswordTb
            // 
            confirmPasswordTb.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPasswordTb.Location = new Point(58, 258);
            confirmPasswordTb.Multiline = true;
            confirmPasswordTb.Name = "confirmPasswordTb";
            confirmPasswordTb.PasswordChar = '*';
            confirmPasswordTb.PlaceholderText = "Confirm Password";
            confirmPasswordTb.Size = new Size(361, 40);
            confirmPasswordTb.TabIndex = 7;
            // 
            // confirmPasswordLbl
            // 
            confirmPasswordLbl.AccessibleRole = AccessibleRole.OutlineButton;
            confirmPasswordLbl.AutoSize = true;
            confirmPasswordLbl.BackColor = Color.FromArgb(40, 75, 83);
            confirmPasswordLbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmPasswordLbl.ForeColor = Color.White;
            confirmPasswordLbl.Location = new Point(58, 225);
            confirmPasswordLbl.Name = "confirmPasswordLbl";
            confirmPasswordLbl.Size = new Size(169, 20);
            confirmPasswordLbl.TabIndex = 6;
            confirmPasswordLbl.Text = "Confirm Password:";
            // 
            // newPasswordTb
            // 
            newPasswordTb.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newPasswordTb.Location = new Point(58, 162);
            newPasswordTb.Multiline = true;
            newPasswordTb.Name = "newPasswordTb";
            newPasswordTb.PasswordChar = '*';
            newPasswordTb.PlaceholderText = "Enter New Password";
            newPasswordTb.Size = new Size(361, 40);
            newPasswordTb.TabIndex = 4;
            // 
            // accountIdTb
            // 
            accountIdTb.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountIdTb.Location = new Point(58, 66);
            accountIdTb.MaxLength = 10;
            accountIdTb.Multiline = true;
            accountIdTb.Name = "accountIdTb";
            accountIdTb.PlaceholderText = "Enter account ID";
            accountIdTb.Size = new Size(361, 40);
            accountIdTb.TabIndex = 3;
            accountIdTb.TextChanged += accountIdTb_TextChanged;
            accountIdTb.KeyPress += accountIdTb_KeyPress;
            // 
            // newPasswordLbl
            // 
            newPasswordLbl.AccessibleRole = AccessibleRole.OutlineButton;
            newPasswordLbl.AutoSize = true;
            newPasswordLbl.BackColor = Color.FromArgb(40, 75, 83);
            newPasswordLbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newPasswordLbl.ForeColor = Color.White;
            newPasswordLbl.Location = new Point(58, 129);
            newPasswordLbl.Name = "newPasswordLbl";
            newPasswordLbl.Size = new Size(139, 20);
            newPasswordLbl.TabIndex = 1;
            newPasswordLbl.Text = "New Password:";
            // 
            // accountIdLbl
            // 
            accountIdLbl.AccessibleRole = AccessibleRole.OutlineButton;
            accountIdLbl.AutoSize = true;
            accountIdLbl.BackColor = Color.FromArgb(40, 75, 83);
            accountIdLbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountIdLbl.ForeColor = Color.White;
            accountIdLbl.Location = new Point(58, 33);
            accountIdLbl.Name = "accountIdLbl";
            accountIdLbl.Size = new Size(108, 20);
            accountIdLbl.TabIndex = 0;
            accountIdLbl.Text = "Account ID:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 75, 93);
            panel1.Controls.Add(resetPasswordBtn);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 407);
            panel1.TabIndex = 8;
            // 
            // resetPasswordBtn
            // 
            resetPasswordBtn.BackColor = Color.FromArgb(235, 197, 149);
            resetPasswordBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetPasswordBtn.ForeColor = SystemColors.ActiveCaptionText;
            resetPasswordBtn.Location = new Point(141, 334);
            resetPasswordBtn.Name = "resetPasswordBtn";
            resetPasswordBtn.Size = new Size(162, 37);
            resetPasswordBtn.TabIndex = 5;
            resetPasswordBtn.Text = "Reset Password";
            resetPasswordBtn.UseVisualStyleBackColor = false;
            resetPasswordBtn.Click += resetPasswordBtn_Click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 401);
            Controls.Add(loginPanel);
            Name = "ForgotPassword";
            Text = "Forgot Password";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPanel;
        private Button resetPasswordBtn;
        private TextBox newPasswordTb;
        private TextBox accountIdTb;
        private Label newPasswordLbl;
        private Label accountIdLbl;
        private TextBox confirmPasswordTb;
        private Label confirmPasswordLbl;
        private Panel panel1;
    }
}