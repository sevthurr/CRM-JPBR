namespace CRM_Jara_s_Palm_Beach_Resort
{
    partial class NewCampaign
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
            newCampaignLbl = new Label();
            newBookingPanel = new Panel();
            campaignHeadlineTb = new TextBox();
            campaignInfoLbl = new Label();
            campaignHeadlineLbl = new Label();
            campaignTypeLbl = new Label();
            campaignTypeCb = new ComboBox();
            campaignDescLbl = new Label();
            campaignDescTb = new TextBox();
            guestInfoPanel = new Panel();
            emailMessageTb = new TextBox();
            emailMessageLbl = new Label();
            promoCodeLbl = new Label();
            promoCodeTb = new TextBox();
            soloCb = new CheckBox();
            coupleCb = new CheckBox();
            groupCb = new CheckBox();
            familyCb = new CheckBox();
            endDateDtp = new DateTimePicker();
            endDateLbl = new Label();
            startDateDtp = new DateTimePicker();
            startDateLbl = new Label();
            tagsLbl = new Label();
            messagePanel = new Panel();
            infoIcon = new FontAwesome.Sharp.IconPictureBox();
            messageTxt = new Label();
            plusIcon = new FontAwesome.Sharp.IconPictureBox();
            addCampaignBtn = new Button();
            userLimitLbl = new Label();
            usageLimitTb = new TextBox();
            discountValueLbl = new Label();
            discountValueTb = new TextBox();
            newBookingPanel.SuspendLayout();
            guestInfoPanel.SuspendLayout();
            messagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)infoIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)plusIcon).BeginInit();
            SuspendLayout();
            // 
            // newCampaignLbl
            // 
            newCampaignLbl.AutoSize = true;
            newCampaignLbl.Font = new Font("Crimson Pro", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newCampaignLbl.ForeColor = Color.White;
            newCampaignLbl.Location = new Point(340, 9);
            newCampaignLbl.Name = "newCampaignLbl";
            newCampaignLbl.Size = new Size(242, 43);
            newCampaignLbl.TabIndex = 1;
            newCampaignLbl.Text = "New Campaign";
            // 
            // newBookingPanel
            // 
            newBookingPanel.BackColor = Color.FromArgb(40, 75, 83);
            newBookingPanel.Controls.Add(newCampaignLbl);
            newBookingPanel.Location = new Point(0, 0);
            newBookingPanel.Name = "newBookingPanel";
            newBookingPanel.Size = new Size(900, 65);
            newBookingPanel.TabIndex = 21;
            // 
            // campaignHeadlineTb
            // 
            campaignHeadlineTb.BackColor = Color.White;
            campaignHeadlineTb.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            campaignHeadlineTb.ForeColor = Color.Black;
            campaignHeadlineTb.Location = new Point(28, 78);
            campaignHeadlineTb.Multiline = true;
            campaignHeadlineTb.Name = "campaignHeadlineTb";
            campaignHeadlineTb.PlaceholderText = "Write campaign headline";
            campaignHeadlineTb.Size = new Size(344, 32);
            campaignHeadlineTb.TabIndex = 0;
            // 
            // campaignInfoLbl
            // 
            campaignInfoLbl.AutoSize = true;
            campaignInfoLbl.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            campaignInfoLbl.ForeColor = Color.Black;
            campaignInfoLbl.Location = new Point(19, 14);
            campaignInfoLbl.Name = "campaignInfoLbl";
            campaignInfoLbl.Size = new Size(187, 26);
            campaignInfoLbl.TabIndex = 2;
            campaignInfoLbl.Text = "Campaign Information";
            // 
            // campaignHeadlineLbl
            // 
            campaignHeadlineLbl.AutoSize = true;
            campaignHeadlineLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            campaignHeadlineLbl.ForeColor = Color.DimGray;
            campaignHeadlineLbl.Location = new Point(28, 52);
            campaignHeadlineLbl.Name = "campaignHeadlineLbl";
            campaignHeadlineLbl.Size = new Size(140, 23);
            campaignHeadlineLbl.TabIndex = 3;
            campaignHeadlineLbl.Text = "Campaign Headline";
            // 
            // campaignTypeLbl
            // 
            campaignTypeLbl.AutoSize = true;
            campaignTypeLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            campaignTypeLbl.ForeColor = Color.DimGray;
            campaignTypeLbl.Location = new Point(416, 52);
            campaignTypeLbl.Name = "campaignTypeLbl";
            campaignTypeLbl.Size = new Size(114, 23);
            campaignTypeLbl.TabIndex = 8;
            campaignTypeLbl.Text = "Campaign Type";
            // 
            // campaignTypeCb
            // 
            campaignTypeCb.BackColor = Color.White;
            campaignTypeCb.FormattingEnabled = true;
            campaignTypeCb.Items.AddRange(new object[] { "Seasonal Offer", "Limited-Time Discount", "Event" });
            campaignTypeCb.Location = new Point(419, 82);
            campaignTypeCb.Name = "campaignTypeCb";
            campaignTypeCb.Size = new Size(231, 28);
            campaignTypeCb.TabIndex = 9;
            // 
            // campaignDescLbl
            // 
            campaignDescLbl.AutoSize = true;
            campaignDescLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            campaignDescLbl.ForeColor = Color.DimGray;
            campaignDescLbl.Location = new Point(28, 133);
            campaignDescLbl.Name = "campaignDescLbl";
            campaignDescLbl.Size = new Size(156, 23);
            campaignDescLbl.TabIndex = 12;
            campaignDescLbl.Text = "Campaign Description";
            // 
            // campaignDescTb
            // 
            campaignDescTb.BackColor = Color.White;
            campaignDescTb.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            campaignDescTb.ForeColor = Color.Black;
            campaignDescTb.Location = new Point(28, 159);
            campaignDescTb.Multiline = true;
            campaignDescTb.Name = "campaignDescTb";
            campaignDescTb.PlaceholderText = "Write campaign description...";
            campaignDescTb.Size = new Size(730, 86);
            campaignDescTb.TabIndex = 13;
            // 
            // guestInfoPanel
            // 
            guestInfoPanel.BackColor = Color.White;
            guestInfoPanel.Controls.Add(discountValueLbl);
            guestInfoPanel.Controls.Add(discountValueTb);
            guestInfoPanel.Controls.Add(userLimitLbl);
            guestInfoPanel.Controls.Add(usageLimitTb);
            guestInfoPanel.Controls.Add(emailMessageTb);
            guestInfoPanel.Controls.Add(emailMessageLbl);
            guestInfoPanel.Controls.Add(promoCodeLbl);
            guestInfoPanel.Controls.Add(promoCodeTb);
            guestInfoPanel.Controls.Add(soloCb);
            guestInfoPanel.Controls.Add(coupleCb);
            guestInfoPanel.Controls.Add(groupCb);
            guestInfoPanel.Controls.Add(familyCb);
            guestInfoPanel.Controls.Add(endDateDtp);
            guestInfoPanel.Controls.Add(endDateLbl);
            guestInfoPanel.Controls.Add(startDateDtp);
            guestInfoPanel.Controls.Add(startDateLbl);
            guestInfoPanel.Controls.Add(tagsLbl);
            guestInfoPanel.Controls.Add(campaignDescTb);
            guestInfoPanel.Controls.Add(campaignDescLbl);
            guestInfoPanel.Controls.Add(campaignTypeCb);
            guestInfoPanel.Controls.Add(campaignTypeLbl);
            guestInfoPanel.Controls.Add(campaignHeadlineLbl);
            guestInfoPanel.Controls.Add(campaignInfoLbl);
            guestInfoPanel.Controls.Add(campaignHeadlineTb);
            guestInfoPanel.Location = new Point(54, 108);
            guestInfoPanel.Name = "guestInfoPanel";
            guestInfoPanel.Size = new Size(790, 683);
            guestInfoPanel.TabIndex = 22;
            // 
            // emailMessageTb
            // 
            emailMessageTb.BackColor = Color.White;
            emailMessageTb.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailMessageTb.ForeColor = Color.Black;
            emailMessageTb.Location = new Point(28, 301);
            emailMessageTb.Multiline = true;
            emailMessageTb.Name = "emailMessageTb";
            emailMessageTb.PlaceholderText = "Write email message...";
            emailMessageTb.Size = new Size(730, 86);
            emailMessageTb.TabIndex = 32;
            // 
            // emailMessageLbl
            // 
            emailMessageLbl.AutoSize = true;
            emailMessageLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailMessageLbl.ForeColor = Color.DimGray;
            emailMessageLbl.Location = new Point(28, 275);
            emailMessageLbl.Name = "emailMessageLbl";
            emailMessageLbl.Size = new Size(107, 23);
            emailMessageLbl.TabIndex = 31;
            emailMessageLbl.Text = "Email Message";
            // 
            // promoCodeLbl
            // 
            promoCodeLbl.AutoSize = true;
            promoCodeLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            promoCodeLbl.ForeColor = Color.DimGray;
            promoCodeLbl.Location = new Point(31, 421);
            promoCodeLbl.Name = "promoCodeLbl";
            promoCodeLbl.Size = new Size(160, 23);
            promoCodeLbl.TabIndex = 30;
            promoCodeLbl.Text = "Promo Code (Optional)";
            // 
            // promoCodeTb
            // 
            promoCodeTb.BackColor = Color.White;
            promoCodeTb.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            promoCodeTb.ForeColor = Color.Black;
            promoCodeTb.Location = new Point(31, 447);
            promoCodeTb.Multiline = true;
            promoCodeTb.Name = "promoCodeTb";
            promoCodeTb.PlaceholderText = "Write promo code";
            promoCodeTb.Size = new Size(239, 32);
            promoCodeTb.TabIndex = 29;
            // 
            // soloCb
            // 
            soloCb.AutoSize = true;
            soloCb.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            soloCb.Location = new Point(347, 541);
            soloCb.Name = "soloCb";
            soloCb.Size = new Size(67, 30);
            soloCb.TabIndex = 28;
            soloCb.Text = "Solo";
            soloCb.UseVisualStyleBackColor = true;
            // 
            // coupleCb
            // 
            coupleCb.AutoSize = true;
            coupleCb.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            coupleCb.Location = new Point(243, 541);
            coupleCb.Name = "coupleCb";
            coupleCb.Size = new Size(89, 30);
            coupleCb.TabIndex = 27;
            coupleCb.Text = "Couple";
            coupleCb.UseVisualStyleBackColor = true;
            // 
            // groupCb
            // 
            groupCb.AutoSize = true;
            groupCb.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupCb.Location = new Point(140, 541);
            groupCb.Name = "groupCb";
            groupCb.Size = new Size(82, 30);
            groupCb.TabIndex = 26;
            groupCb.Text = "Group";
            groupCb.UseVisualStyleBackColor = true;
            // 
            // familyCb
            // 
            familyCb.AutoSize = true;
            familyCb.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            familyCb.Location = new Point(35, 541);
            familyCb.Name = "familyCb";
            familyCb.Size = new Size(83, 30);
            familyCb.TabIndex = 25;
            familyCb.Text = "Family";
            familyCb.UseVisualStyleBackColor = true;
            // 
            // endDateDtp
            // 
            endDateDtp.CalendarForeColor = Color.FromArgb(40, 75, 83);
            endDateDtp.CalendarMonthBackground = SystemColors.ControlLight;
            endDateDtp.CalendarTitleForeColor = Color.FromArgb(40, 75, 83);
            endDateDtp.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endDateDtp.Location = new Point(356, 617);
            endDateDtp.MinDate = new DateTime(2025, 9, 13, 0, 0, 0, 0);
            endDateDtp.Name = "endDateDtp";
            endDateDtp.Size = new Size(270, 27);
            endDateDtp.TabIndex = 24;
            // 
            // endDateLbl
            // 
            endDateLbl.AutoSize = true;
            endDateLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endDateLbl.ForeColor = Color.DimGray;
            endDateLbl.Location = new Point(356, 592);
            endDateLbl.Name = "endDateLbl";
            endDateLbl.Size = new Size(68, 23);
            endDateLbl.TabIndex = 23;
            endDateLbl.Text = "End Date";
            // 
            // startDateDtp
            // 
            startDateDtp.CalendarForeColor = Color.FromArgb(40, 75, 83);
            startDateDtp.CalendarMonthBackground = SystemColors.ControlLight;
            startDateDtp.CalendarTitleForeColor = Color.FromArgb(40, 75, 83);
            startDateDtp.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startDateDtp.Location = new Point(35, 617);
            startDateDtp.MinDate = new DateTime(2025, 9, 13, 0, 0, 0, 0);
            startDateDtp.Name = "startDateDtp";
            startDateDtp.Size = new Size(270, 27);
            startDateDtp.TabIndex = 22;
            // 
            // startDateLbl
            // 
            startDateLbl.AutoSize = true;
            startDateLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startDateLbl.ForeColor = Color.DimGray;
            startDateLbl.Location = new Point(35, 592);
            startDateLbl.Name = "startDateLbl";
            startDateLbl.Size = new Size(76, 23);
            startDateLbl.TabIndex = 21;
            startDateLbl.Text = "Start Date";
            // 
            // tagsLbl
            // 
            tagsLbl.AutoSize = true;
            tagsLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tagsLbl.ForeColor = Color.DimGray;
            tagsLbl.Location = new Point(26, 512);
            tagsLbl.Name = "tagsLbl";
            tagsLbl.Size = new Size(54, 23);
            tagsLbl.TabIndex = 14;
            tagsLbl.Text = "Tag(s)";
            // 
            // messagePanel
            // 
            messagePanel.BackColor = Color.FromArgb(235, 197, 149);
            messagePanel.Controls.Add(infoIcon);
            messagePanel.Controls.Add(messageTxt);
            messagePanel.Location = new Point(54, 828);
            messagePanel.Name = "messagePanel";
            messagePanel.Size = new Size(790, 50);
            messagePanel.TabIndex = 23;
            // 
            // infoIcon
            // 
            infoIcon.AccessibleRole = AccessibleRole.None;
            infoIcon.BackColor = Color.Transparent;
            infoIcon.ForeColor = Color.FromArgb(40, 75, 83);
            infoIcon.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            infoIcon.IconColor = Color.FromArgb(40, 75, 83);
            infoIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            infoIcon.IconSize = 20;
            infoIcon.Location = new Point(31, 16);
            infoIcon.Name = "infoIcon";
            infoIcon.Size = new Size(20, 23);
            infoIcon.TabIndex = 38;
            infoIcon.TabStop = false;
            // 
            // messageTxt
            // 
            messageTxt.AutoSize = true;
            messageTxt.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            messageTxt.ForeColor = Color.FromArgb(40, 75, 83);
            messageTxt.Location = new Point(54, 13);
            messageTxt.Name = "messageTxt";
            messageTxt.Size = new Size(480, 23);
            messageTxt.TabIndex = 29;
            messageTxt.Text = "This campaign will be delivered directly to your selected guests via email.";
            // 
            // plusIcon
            // 
            plusIcon.BackColor = Color.FromArgb(82, 169, 181);
            plusIcon.IconChar = FontAwesome.Sharp.IconChar.Add;
            plusIcon.IconColor = Color.White;
            plusIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            plusIcon.IconSize = 25;
            plusIcon.Location = new Point(358, 906);
            plusIcon.Name = "plusIcon";
            plusIcon.Size = new Size(25, 25);
            plusIcon.TabIndex = 25;
            plusIcon.TabStop = false;
            // 
            // addCampaignBtn
            // 
            addCampaignBtn.BackColor = Color.FromArgb(82, 169, 181);
            addCampaignBtn.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addCampaignBtn.ForeColor = Color.Transparent;
            addCampaignBtn.Location = new Point(340, 900);
            addCampaignBtn.Name = "addCampaignBtn";
            addCampaignBtn.Size = new Size(198, 40);
            addCampaignBtn.TabIndex = 24;
            addCampaignBtn.Text = "    Add Campaign";
            addCampaignBtn.UseVisualStyleBackColor = false;
            // 
            // userLimitLbl
            // 
            userLimitLbl.AutoSize = true;
            userLimitLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userLimitLbl.ForeColor = Color.DimGray;
            userLimitLbl.Location = new Point(291, 421);
            userLimitLbl.Name = "userLimitLbl";
            userLimitLbl.Size = new Size(85, 23);
            userLimitLbl.TabIndex = 34;
            userLimitLbl.Text = "Usage Limit";
            // 
            // usageLimitTb
            // 
            usageLimitTb.BackColor = Color.White;
            usageLimitTb.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usageLimitTb.ForeColor = Color.Black;
            usageLimitTb.Location = new Point(291, 447);
            usageLimitTb.Multiline = true;
            usageLimitTb.Name = "usageLimitTb";
            usageLimitTb.PlaceholderText = "Enter usage limit";
            usageLimitTb.Size = new Size(177, 32);
            usageLimitTb.TabIndex = 33;
            // 
            // discountValueLbl
            // 
            discountValueLbl.AutoSize = true;
            discountValueLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discountValueLbl.ForeColor = Color.DimGray;
            discountValueLbl.Location = new Point(487, 421);
            discountValueLbl.Name = "discountValueLbl";
            discountValueLbl.Size = new Size(106, 23);
            discountValueLbl.TabIndex = 36;
            discountValueLbl.Text = "Discount Value";
            // 
            // discountValueTb
            // 
            discountValueTb.BackColor = Color.White;
            discountValueTb.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discountValueTb.ForeColor = Color.Black;
            discountValueTb.Location = new Point(487, 447);
            discountValueTb.Multiline = true;
            discountValueTb.Name = "discountValueTb";
            discountValueTb.PlaceholderText = "Enter discount value";
            discountValueTb.Size = new Size(177, 32);
            discountValueTb.TabIndex = 35;
            // 
            // NewCampaign
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 977);
            Controls.Add(plusIcon);
            Controls.Add(addCampaignBtn);
            Controls.Add(messagePanel);
            Controls.Add(guestInfoPanel);
            Controls.Add(newBookingPanel);
            Name = "NewCampaign";
            Text = "New Campaign";
            newBookingPanel.ResumeLayout(false);
            newBookingPanel.PerformLayout();
            guestInfoPanel.ResumeLayout(false);
            guestInfoPanel.PerformLayout();
            messagePanel.ResumeLayout(false);
            messagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)infoIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)plusIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label newCampaignLbl;
        private Panel newBookingPanel;
        private TextBox campaignHeadlineTb;
        private Label campaignInfoLbl;
        private Label campaignHeadlineLbl;
        private Label campaignTypeLbl;
        private ComboBox campaignTypeCb;
        private Label campaignDescLbl;
        private TextBox campaignDescTb;
        private Panel guestInfoPanel;
        private Label tagsLbl;
        private DateTimePicker endDateDtp;
        private Label endDateLbl;
        private DateTimePicker startDateDtp;
        private Label startDateLbl;
        private CheckBox soloCb;
        private CheckBox coupleCb;
        private CheckBox groupCb;
        private CheckBox familyCb;
        private Panel messagePanel;
        private Label messageTxt;
        private FontAwesome.Sharp.IconPictureBox infoIcon;
        private FontAwesome.Sharp.IconPictureBox plusIcon;
        private Button addCampaignBtn;
        private Label promoCodeLbl;
        private TextBox promoCodeTb;
        private TextBox emailMessageTb;
        private Label emailMessageLbl;
        private Label discountValueLbl;
        private TextBox discountValueTb;
        private Label userLimitLbl;
        private TextBox usageLimitTb;
    }
}