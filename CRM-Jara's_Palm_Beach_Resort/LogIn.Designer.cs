namespace CRM_Jara_s_Palm_Beach_Resort
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginPanel = new Panel();
            linkLabel1 = new LinkLabel();
            loginBtn = new Button();
            passwordTb = new TextBox();
            usernameTb = new TextBox();
            passwordLbl = new Label();
            usernameLbl = new Label();
            logo = new PictureBox();
            crmLbl = new Label();
            loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.FromArgb(40, 75, 83);
            loginPanel.Controls.Add(linkLabel1);
            loginPanel.Controls.Add(loginBtn);
            loginPanel.Controls.Add(passwordTb);
            loginPanel.Controls.Add(usernameTb);
            loginPanel.Controls.Add(passwordLbl);
            loginPanel.Controls.Add(usernameLbl);
            loginPanel.Location = new Point(70, 334);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(472, 326);
            loginPanel.TabIndex = 1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(172, 214);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(119, 23);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password";
            linkLabel1.VisitedLinkColor = Color.FromArgb(83, 169, 181);
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(235, 197, 149);
            loginBtn.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = SystemColors.ActiveCaptionText;
            loginBtn.Location = new Point(172, 253);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(119, 37);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "Log In";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += button1_Click;
            // 
            // passwordTb
            // 
            passwordTb.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTb.Location = new Point(58, 162);
            passwordTb.Multiline = true;
            passwordTb.Name = "passwordTb";
            passwordTb.PasswordChar = '*';
            passwordTb.PlaceholderText = "Enter Password";
            passwordTb.Size = new Size(361, 40);
            passwordTb.TabIndex = 4;
            // 
            // usernameTb
            // 
            usernameTb.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTb.Location = new Point(58, 66);
            usernameTb.Multiline = true;
            usernameTb.Name = "usernameTb";
            usernameTb.PlaceholderText = "Enter username";
            usernameTb.Size = new Size(361, 40);
            usernameTb.TabIndex = 3;
            // 
            // passwordLbl
            // 
            passwordLbl.AccessibleRole = AccessibleRole.OutlineButton;
            passwordLbl.AutoSize = true;
            passwordLbl.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLbl.ForeColor = Color.WhiteSmoke;
            passwordLbl.Location = new Point(58, 129);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(98, 30);
            passwordLbl.TabIndex = 1;
            passwordLbl.Text = "Password:";
            passwordLbl.Click += label3_Click;
            // 
            // usernameLbl
            // 
            usernameLbl.AccessibleRole = AccessibleRole.OutlineButton;
            usernameLbl.AutoSize = true;
            usernameLbl.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLbl.ForeColor = Color.WhiteSmoke;
            usernameLbl.Location = new Point(58, 33);
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(105, 30);
            usernameLbl.TabIndex = 0;
            usernameLbl.Text = "Username:";
            // 
            // logo
            // 
            logo.Image = Properties.Resources._464643879_122123191316493608_5108633697996930672_n_removebg_preview_removebg_preview;
            logo.Location = new Point(177, 12);
            logo.Name = "logo";
            logo.Size = new Size(270, 274);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 2;
            logo.TabStop = false;
            // 
            // crmLbl
            // 
            crmLbl.AutoSize = true;
            crmLbl.Font = new Font("Crimson Pro", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crmLbl.ForeColor = Color.FromArgb(40, 75, 83);
            crmLbl.Location = new Point(220, 277);
            crmLbl.Name = "crmLbl";
            crmLbl.Size = new Size(181, 30);
            crmLbl.TabIndex = 3;
            crmLbl.Text = "CRM SOFTWARE";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 717);
            Controls.Add(crmLbl);
            Controls.Add(logo);
            Controls.Add(loginPanel);
            Name = "LogIn";
            Text = "Log In";
            Load += LogIn_Load;
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel loginPanel;
        private PictureBox logo;
        private Label usernameLbl;
        private Label passwordLbl;
        private TextBox passwordTb;
        private TextBox usernameTb;
        private Button loginBtn;
        private LinkLabel linkLabel1;
        private Label crmLbl;
    }
}
