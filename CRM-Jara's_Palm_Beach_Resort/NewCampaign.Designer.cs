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
            tagsLbl = new Label();
            endDateDtp = new DateTimePicker();
            endDateLbl = new Label();
            startDateDtp = new DateTimePicker();
            startDateLbl = new Label();
            familyCb = new CheckBox();
            groupCb = new CheckBox();
            coupleCb = new CheckBox();
            soloCb = new CheckBox();
            messagePanel = new Panel();
            messageTxt = new Label();
            infoIcon = new FontAwesome.Sharp.IconPictureBox();
            plusIcon = new FontAwesome.Sharp.IconPictureBox();
            addCampaignBtn = new Button();
            promoCodeLbl = new Label();
            promoCodeTb = new TextBox();
            emailMessageTb = new TextBox();
            emailMessageLbl = new Label();
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
            // tagsLbl
            // 
            tagsLbl.AutoSize = true;
            tagsLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tagsLbl.ForeColor = Color.DimGray;
            tagsLbl.Location = new Point(26, 500);
            tagsLbl.Name = "tagsLbl";
            tagsLbl.Size = new Size(54, 23);
            tagsLbl.TabIndex = 14;
            tagsLbl.Text = "Tag(s)";
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
            promoCodeTb.Size = new Size(344, 32);
            promoCodeTb.TabIndex = 29;
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
    }
}