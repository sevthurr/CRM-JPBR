namespace CRM_Jara_s_Palm_Beach_Resort
{
    partial class EditGuest
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
            headerPanel = new Panel();
            editGuestLbl = new Label();
            guestDetailsPanel = new Panel();
            guestImagePanel = new Panel();
            uploadImageIcon = new FontAwesome.Sharp.IconPictureBox();
            uploadImageBtn = new Button();
            guestImagePictureBox = new PictureBox();
            middleNameTb = new TextBox();
            middleNameLbl = new Label();
            lastNameTb = new TextBox();
            lastNameLbl = new Label();
            firstNameTb = new TextBox();
            firstNameLbl = new Label();
            guestDetailsLbl = new Label();
            contactInfoPanel = new Panel();
            addSocialIcon = new FontAwesome.Sharp.IconPictureBox();
            addSocialBtn = new Button();
            socialsListBox = new ListBox();
            socialsLbl = new Label();
            contactNumberTb = new TextBox();
            contactNumberLbl = new Label();
            contactInfoLbl = new Label();
            preferencesPanel = new Panel();
            tagsGroupBox = new GroupBox();
            soloCheckBox = new CheckBox();
            coupleCheckBox = new CheckBox();
            groupCheckBox = new CheckBox();
            familyCheckBox = new CheckBox();
            marketingConsentPanel = new Panel();
            marketingOffRb = new RadioButton();
            marketingOnRb = new RadioButton();
            marketingConsentLbl = new Label();
            preferencesLbl = new Label();
            saveEditIcon = new FontAwesome.Sharp.IconPictureBox();
            saveEditBtn = new Button();
            headerPanel.SuspendLayout();
            guestDetailsPanel.SuspendLayout();
            guestImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uploadImageIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guestImagePictureBox).BeginInit();
            contactInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addSocialIcon).BeginInit();
            preferencesPanel.SuspendLayout();
            tagsGroupBox.SuspendLayout();
            marketingConsentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)saveEditIcon).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(40, 75, 83);
            headerPanel.Controls.Add(editGuestLbl);
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(800, 65);
            headerPanel.TabIndex = 0;
            // 
            // editGuestLbl
            // 
            editGuestLbl.AutoSize = true;
            editGuestLbl.Font = new Font("Crimson Pro", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editGuestLbl.ForeColor = Color.White;
            editGuestLbl.Location = new Point(310, 11);
            editGuestLbl.Name = "editGuestLbl";
            editGuestLbl.Size = new Size(180, 43);
            editGuestLbl.TabIndex = 0;
            editGuestLbl.Text = "Edit Guest";
            // 
            // guestDetailsPanel
            // 
            guestDetailsPanel.BackColor = Color.White;
            guestDetailsPanel.Controls.Add(guestImagePanel);
            guestDetailsPanel.Controls.Add(middleNameTb);
            guestDetailsPanel.Controls.Add(middleNameLbl);
            guestDetailsPanel.Controls.Add(lastNameTb);
            guestDetailsPanel.Controls.Add(lastNameLbl);
            guestDetailsPanel.Controls.Add(firstNameTb);
            guestDetailsPanel.Controls.Add(firstNameLbl);
            guestDetailsPanel.Controls.Add(guestDetailsLbl);
            guestDetailsPanel.Location = new Point(25, 85);
            guestDetailsPanel.Name = "guestDetailsPanel";
            guestDetailsPanel.Size = new Size(750, 240);
            guestDetailsPanel.TabIndex = 1;
            // 
            // guestImagePanel
            // 
            guestImagePanel.BorderStyle = BorderStyle.FixedSingle;
            guestImagePanel.Controls.Add(uploadImageIcon);
            guestImagePanel.Controls.Add(uploadImageBtn);
            guestImagePanel.Controls.Add(guestImagePictureBox);
            guestImagePanel.Location = new Point(500, 50);
            guestImagePanel.Name = "guestImagePanel";
            guestImagePanel.Size = new Size(230, 180);
            guestImagePanel.TabIndex = 7;
            // 
            // uploadImageIcon
            // 
            uploadImageIcon.BackColor = Color.FromArgb(82, 169, 181);
            uploadImageIcon.IconChar = FontAwesome.Sharp.IconChar.Upload;
            uploadImageIcon.IconColor = Color.White;
            uploadImageIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            uploadImageIcon.IconSize = 20;
            uploadImageIcon.Location = new Point(72, 152);
            uploadImageIcon.Name = "uploadImageIcon";
            uploadImageIcon.Size = new Size(20, 20);
            uploadImageIcon.TabIndex = 2;
            uploadImageIcon.TabStop = false;
            // 
            // uploadImageBtn
            // 
            uploadImageBtn.BackColor = Color.FromArgb(82, 169, 181);
            uploadImageBtn.Font = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uploadImageBtn.ForeColor = Color.White;
            uploadImageBtn.Location = new Point(65, 145);
            uploadImageBtn.Name = "uploadImageBtn";
            uploadImageBtn.Size = new Size(100, 30);
            uploadImageBtn.TabIndex = 1;
            uploadImageBtn.Text = "            Upload";
            uploadImageBtn.UseVisualStyleBackColor = false;
            // 
            // guestImagePictureBox
            // 
            guestImagePictureBox.BackColor = Color.LightGray;
            guestImagePictureBox.Location = new Point(10, 10);
            guestImagePictureBox.Name = "guestImagePictureBox";
            guestImagePictureBox.Size = new Size(210, 130);
            guestImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            guestImagePictureBox.TabIndex = 0;
            guestImagePictureBox.TabStop = false;
            // 
            // middleNameTb
            // 
            middleNameTb.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            middleNameTb.Location = new Point(25, 168);
            middleNameTb.Name = "middleNameTb";
            middleNameTb.PlaceholderText = "Middle Name";
            middleNameTb.Size = new Size(150, 27);
            middleNameTb.TabIndex = 6;
            // 
            // middleNameLbl
            // 
            middleNameLbl.AutoSize = true;
            middleNameLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            middleNameLbl.ForeColor = Color.DimGray;
            middleNameLbl.Location = new Point(25, 142);
            middleNameLbl.Name = "middleNameLbl";
            middleNameLbl.Size = new Size(95, 23);
            middleNameLbl.TabIndex = 5;
            middleNameLbl.Text = "Middle Name";
            // 
            // lastNameTb
            // 
            lastNameTb.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameTb.Location = new Point(200, 102);
            lastNameTb.Name = "lastNameTb";
            lastNameTb.PlaceholderText = "Last Name";
            lastNameTb.Size = new Size(150, 27);
            lastNameTb.TabIndex = 4;
            // 
            // lastNameLbl
            // 
            lastNameLbl.AutoSize = true;
            lastNameLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLbl.ForeColor = Color.DimGray;
            lastNameLbl.Location = new Point(200, 76);
            lastNameLbl.Name = "lastNameLbl";
            lastNameLbl.Size = new Size(79, 23);
            lastNameLbl.TabIndex = 3;
            lastNameLbl.Text = "Last Name";
            // 
            // firstNameTb
            // 
            firstNameTb.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameTb.Location = new Point(25, 102);
            firstNameTb.Name = "firstNameTb";
            firstNameTb.PlaceholderText = "First Name";
            firstNameTb.Size = new Size(150, 27);
            firstNameTb.TabIndex = 2;
            // 
            // firstNameLbl
            // 
            firstNameLbl.AutoSize = true;
            firstNameLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameLbl.ForeColor = Color.DimGray;
            firstNameLbl.Location = new Point(25, 76);
            firstNameLbl.Name = "firstNameLbl";
            firstNameLbl.Size = new Size(79, 23);
            firstNameLbl.TabIndex = 1;
            firstNameLbl.Text = "First Name";
            // 
            // guestDetailsLbl
            // 
            guestDetailsLbl.AutoSize = true;
            guestDetailsLbl.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guestDetailsLbl.ForeColor = Color.Black;
            guestDetailsLbl.Location = new Point(19, 14);
            guestDetailsLbl.Name = "guestDetailsLbl";
            guestDetailsLbl.Size = new Size(117, 26);
            guestDetailsLbl.TabIndex = 0;
            guestDetailsLbl.Text = "Guest Details";
            // 
            // contactInfoPanel
            // 
            contactInfoPanel.BackColor = Color.White;
            contactInfoPanel.Controls.Add(addSocialIcon);
            contactInfoPanel.Controls.Add(addSocialBtn);
            contactInfoPanel.Controls.Add(socialsListBox);
            contactInfoPanel.Controls.Add(socialsLbl);
            contactInfoPanel.Controls.Add(contactNumberTb);
            contactInfoPanel.Controls.Add(contactNumberLbl);
            contactInfoPanel.Controls.Add(contactInfoLbl);
            contactInfoPanel.Location = new Point(25, 345);
            contactInfoPanel.Name = "contactInfoPanel";
            contactInfoPanel.Size = new Size(750, 180);
            contactInfoPanel.TabIndex = 2;
            // 
            // addSocialIcon
            // 
            addSocialIcon.BackColor = Color.FromArgb(82, 169, 181);
            addSocialIcon.IconChar = FontAwesome.Sharp.IconChar.Plus;
            addSocialIcon.IconColor = Color.White;
            addSocialIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addSocialIcon.IconSize = 18;
            addSocialIcon.Location = new Point(407, 141);
            addSocialIcon.Name = "addSocialIcon";
            addSocialIcon.Size = new Size(18, 18);
            addSocialIcon.TabIndex = 6;
            addSocialIcon.TabStop = false;
            // 
            // addSocialBtn
            // 
            addSocialBtn.BackColor = Color.FromArgb(82, 169, 181);
            addSocialBtn.Font = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addSocialBtn.ForeColor = Color.White;
            addSocialBtn.Location = new Point(400, 135);
            addSocialBtn.Name = "addSocialBtn";
            addSocialBtn.Size = new Size(100, 30);
            addSocialBtn.TabIndex = 5;
            addSocialBtn.Text = "      Add";
            addSocialBtn.UseVisualStyleBackColor = false;
            // 
            // socialsListBox
            // 
            socialsListBox.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            socialsListBox.FormattingEnabled = true;
            socialsListBox.ItemHeight = 23;
            socialsListBox.Location = new Point(400, 75);
            socialsListBox.Name = "socialsListBox";
            socialsListBox.Size = new Size(300, 57);
            socialsListBox.TabIndex = 4;
            // 
            // socialsLbl
            // 
            socialsLbl.AutoSize = true;
            socialsLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            socialsLbl.ForeColor = Color.DimGray;
            socialsLbl.Location = new Point(400, 49);
            socialsLbl.Name = "socialsLbl";
            socialsLbl.Size = new Size(56, 23);
            socialsLbl.TabIndex = 3;
            socialsLbl.Text = "Socials";
            // 
            // contactNumberTb
            // 
            contactNumberTb.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contactNumberTb.Location = new Point(25, 75);
            contactNumberTb.Name = "contactNumberTb";
            contactNumberTb.PlaceholderText = "Contact Number";
            contactNumberTb.Size = new Size(200, 27);
            contactNumberTb.TabIndex = 2;
            // 
            // contactNumberLbl
            // 
            contactNumberLbl.AutoSize = true;
            contactNumberLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contactNumberLbl.ForeColor = Color.DimGray;
            contactNumberLbl.Location = new Point(25, 49);
            contactNumberLbl.Name = "contactNumberLbl";
            contactNumberLbl.Size = new Size(122, 23);
            contactNumberLbl.TabIndex = 1;
            contactNumberLbl.Text = "Contact Number";
            // 
            // contactInfoLbl
            // 
            contactInfoLbl.AutoSize = true;
            contactInfoLbl.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactInfoLbl.ForeColor = Color.Black;
            contactInfoLbl.Location = new Point(19, 14);
            contactInfoLbl.Name = "contactInfoLbl";
            contactInfoLbl.Size = new Size(161, 26);
            contactInfoLbl.TabIndex = 0;
            contactInfoLbl.Text = "Contact Information";
            // 
            // preferencesPanel
            // 
            preferencesPanel.BackColor = Color.White;
            preferencesPanel.Controls.Add(tagsGroupBox);
            preferencesPanel.Controls.Add(marketingConsentPanel);
            preferencesPanel.Controls.Add(preferencesLbl);
            preferencesPanel.Location = new Point(25, 545);
            preferencesPanel.Name = "preferencesPanel";
            preferencesPanel.Size = new Size(750, 160);
            preferencesPanel.TabIndex = 3;
            // 
            // tagsGroupBox
            // 
            tagsGroupBox.Controls.Add(soloCheckBox);
            tagsGroupBox.Controls.Add(coupleCheckBox);
            tagsGroupBox.Controls.Add(groupCheckBox);
            tagsGroupBox.Controls.Add(familyCheckBox);
            tagsGroupBox.Font = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tagsGroupBox.Location = new Point(400, 40);
            tagsGroupBox.Name = "tagsGroupBox";
            tagsGroupBox.Size = new Size(300, 100);
            tagsGroupBox.TabIndex = 2;
            tagsGroupBox.TabStop = false;
            tagsGroupBox.Text = "Tags";
            // 
            // soloCheckBox
            // 
            soloCheckBox.AutoSize = true;
            soloCheckBox.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            soloCheckBox.Location = new Point(150, 60);
            soloCheckBox.Name = "soloCheckBox";
            soloCheckBox.Size = new Size(59, 27);
            soloCheckBox.TabIndex = 3;
            soloCheckBox.Text = "Solo";
            soloCheckBox.UseVisualStyleBackColor = true;
            // 
            // coupleCheckBox
            // 
            coupleCheckBox.AutoSize = true;
            coupleCheckBox.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            coupleCheckBox.Location = new Point(20, 60);
            coupleCheckBox.Name = "coupleCheckBox";
            coupleCheckBox.Size = new Size(77, 27);
            coupleCheckBox.TabIndex = 2;
            coupleCheckBox.Text = "Couple";
            coupleCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupCheckBox
            // 
            groupCheckBox.AutoSize = true;
            groupCheckBox.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupCheckBox.Location = new Point(150, 30);
            groupCheckBox.Name = "groupCheckBox";
            groupCheckBox.Size = new Size(71, 27);
            groupCheckBox.TabIndex = 1;
            groupCheckBox.Text = "Group";
            groupCheckBox.UseVisualStyleBackColor = true;
            // 
            // familyCheckBox
            // 
            familyCheckBox.AutoSize = true;
            familyCheckBox.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            familyCheckBox.Location = new Point(20, 30);
            familyCheckBox.Name = "familyCheckBox";
            familyCheckBox.Size = new Size(73, 27);
            familyCheckBox.TabIndex = 0;
            familyCheckBox.Text = "Family";
            familyCheckBox.UseVisualStyleBackColor = true;
            // 
            // marketingConsentPanel
            // 
            marketingConsentPanel.Controls.Add(marketingOffRb);
            marketingConsentPanel.Controls.Add(marketingOnRb);
            marketingConsentPanel.Controls.Add(marketingConsentLbl);
            marketingConsentPanel.Location = new Point(25, 40);
            marketingConsentPanel.Name = "marketingConsentPanel";
            marketingConsentPanel.Size = new Size(300, 100);
            marketingConsentPanel.TabIndex = 1;
            // 
            // marketingOffRb
            // 
            marketingOffRb.AutoSize = true;
            marketingOffRb.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            marketingOffRb.Location = new Point(100, 50);
            marketingOffRb.Name = "marketingOffRb";
            marketingOffRb.Size = new Size(55, 27);
            marketingOffRb.TabIndex = 2;
            marketingOffRb.TabStop = true;
            marketingOffRb.Text = "Off";
            marketingOffRb.UseVisualStyleBackColor = true;
            // 
            // marketingOnRb
            // 
            marketingOnRb.AutoSize = true;
            marketingOnRb.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            marketingOnRb.Location = new Point(30, 50);
            marketingOnRb.Name = "marketingOnRb";
            marketingOnRb.Size = new Size(55, 27);
            marketingOnRb.TabIndex = 1;
            marketingOnRb.TabStop = true;
            marketingOnRb.Text = "On";
            marketingOnRb.UseVisualStyleBackColor = true;
            // 
            // marketingConsentLbl
            // 
            marketingConsentLbl.AutoSize = true;
            marketingConsentLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            marketingConsentLbl.ForeColor = Color.DimGray;
            marketingConsentLbl.Location = new Point(30, 20);
            marketingConsentLbl.Name = "marketingConsentLbl";
            marketingConsentLbl.Size = new Size(134, 23);
            marketingConsentLbl.TabIndex = 0;
            marketingConsentLbl.Text = "Marketing Consent";
            // 
            // preferencesLbl
            // 
            preferencesLbl.AutoSize = true;
            preferencesLbl.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            preferencesLbl.ForeColor = Color.Black;
            preferencesLbl.Location = new Point(19, 14);
            preferencesLbl.Name = "preferencesLbl";
            preferencesLbl.Size = new Size(104, 26);
            preferencesLbl.TabIndex = 0;
            preferencesLbl.Text = "Preferences";
            // 
            // saveEditIcon
            // 
            saveEditIcon.BackColor = Color.FromArgb(82, 169, 181);
            saveEditIcon.IconChar = FontAwesome.Sharp.IconChar.Save;
            saveEditIcon.IconColor = Color.White;
            saveEditIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            saveEditIcon.IconSize = 20;
            saveEditIcon.Location = new Point(584, 722);
            saveEditIcon.Name = "saveEditIcon";
            saveEditIcon.Size = new Size(20, 20);
            saveEditIcon.TabIndex = 5;
            saveEditIcon.TabStop = false;
            // 
            // saveEditBtn
            // 
            saveEditBtn.BackColor = Color.FromArgb(82, 169, 181);
            saveEditBtn.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveEditBtn.ForeColor = Color.White;
            saveEditBtn.Location = new Point(577, 715);
            saveEditBtn.Name = "saveEditBtn";
            saveEditBtn.Size = new Size(198, 40);
            saveEditBtn.TabIndex = 4;
            saveEditBtn.Text = "       Save Edit";
            saveEditBtn.UseVisualStyleBackColor = false;
            // 
            // EditGuest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 775);
            Controls.Add(saveEditIcon);
            Controls.Add(saveEditBtn);
            Controls.Add(preferencesPanel);
            Controls.Add(contactInfoPanel);
            Controls.Add(guestDetailsPanel);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditGuest";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Guest";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            guestDetailsPanel.ResumeLayout(false);
            guestDetailsPanel.PerformLayout();
            guestImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uploadImageIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)guestImagePictureBox).EndInit();
            contactInfoPanel.ResumeLayout(false);
            contactInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addSocialIcon).EndInit();
            preferencesPanel.ResumeLayout(false);
            preferencesPanel.PerformLayout();
            tagsGroupBox.ResumeLayout(false);
            tagsGroupBox.PerformLayout();
            marketingConsentPanel.ResumeLayout(false);
            marketingConsentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)saveEditIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private Label editGuestLbl;
        private Panel guestDetailsPanel;
        private Label guestDetailsLbl;
        private TextBox firstNameTb;
        private Label firstNameLbl;
        private TextBox lastNameTb;
        private Label lastNameLbl;
        private TextBox middleNameTb;
        private Label middleNameLbl;
        private Panel guestImagePanel;
        private PictureBox guestImagePictureBox;
        private Button uploadImageBtn;
        private FontAwesome.Sharp.IconPictureBox uploadImageIcon;
        private Panel contactInfoPanel;
        private Label contactInfoLbl;
        private TextBox contactNumberTb;
        private Label contactNumberLbl;
        private ListBox socialsListBox;
        private Label socialsLbl;
        private Button addSocialBtn;
        private FontAwesome.Sharp.IconPictureBox addSocialIcon;
        private Panel preferencesPanel;
        private Label preferencesLbl;
        private Panel marketingConsentPanel;
        private Label marketingConsentLbl;
        private RadioButton marketingOnRb;
        private RadioButton marketingOffRb;
        private GroupBox tagsGroupBox;
        private CheckBox familyCheckBox;
        private CheckBox groupCheckBox;
        private CheckBox coupleCheckBox;
        private CheckBox soloCheckBox;
        private Button saveEditBtn;
        private FontAwesome.Sharp.IconPictureBox saveEditIcon;
    }
}