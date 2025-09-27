namespace CRM_Jara_s_Palm_Beach_Resort
{
    partial class NewBookingForm
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
            firstNameTb = new TextBox();
            newBookingLbl = new Label();
            guestInfoLbl = new Label();
            guestInfoPanel = new Panel();
            emailTb = new TextBox();
            emailLbl = new Label();
            contactTb = new TextBox();
            platformCb = new ComboBox();
            contactLbl = new Label();
            addressTb = new TextBox();
            addressLbl = new Label();
            suffixCb = new ComboBox();
            suffixLbl = new Label();
            middleNameTb = new TextBox();
            label4 = new Label();
            lastNameTb = new TextBox();
            lastNameLbl = new Label();
            firstNameLbl = new Label();
            bookingInfoPanel = new Panel();
            guestQty = new NumericUpDown();
            textBox1 = new TextBox();
            label1 = new Label();
            packageAPanel = new Panel();
            packageALbl = new Label();
            packageARBtn = new RadioButton();
            packageBPanel = new Panel();
            packageBLbl = new Label();
            packageBRbtn = new RadioButton();
            checkOutDp = new DateTimePicker();
            checkOutLbl = new Label();
            checkInDp = new DateTimePicker();
            bookingDateDp = new DateTimePicker();
            numberOfGuestLbl = new Label();
            checkInLbl = new Label();
            bookingDateLbl = new Label();
            BookingInfoLbl = new Label();
            newBookingPanel = new Panel();
            proceedPaymentBtn = new Button();
            platformLbl = new Label();
            guestInfoPanel.SuspendLayout();
            bookingInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guestQty).BeginInit();
            packageAPanel.SuspendLayout();
            packageBPanel.SuspendLayout();
            newBookingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // firstNameTb
            // 
            firstNameTb.BackColor = Color.White;
            firstNameTb.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameTb.ForeColor = Color.Black;
            firstNameTb.Location = new Point(28, 78);
            firstNameTb.Multiline = true;
            firstNameTb.Name = "firstNameTb";
            firstNameTb.PlaceholderText = "First Name";
            firstNameTb.Size = new Size(180, 32);
            firstNameTb.TabIndex = 0;
            // 
            // newBookingLbl
            // 
            newBookingLbl.AutoSize = true;
            newBookingLbl.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newBookingLbl.ForeColor = Color.White;
            newBookingLbl.Location = new Point(340, 9);
            newBookingLbl.Name = "newBookingLbl";
            newBookingLbl.Size = new Size(230, 39);
            newBookingLbl.TabIndex = 1;
            newBookingLbl.Text = "New Booking";
            // 
            // guestInfoLbl
            // 
            guestInfoLbl.AutoSize = true;
            guestInfoLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guestInfoLbl.ForeColor = Color.Black;
            guestInfoLbl.Location = new Point(19, 14);
            guestInfoLbl.Name = "guestInfoLbl";
            guestInfoLbl.Size = new Size(143, 18);
            guestInfoLbl.TabIndex = 2;
            guestInfoLbl.Text = "Guest Information";
            // 
            // guestInfoPanel
            // 
            guestInfoPanel.BackColor = Color.White;
            guestInfoPanel.Controls.Add(platformLbl);
            guestInfoPanel.Controls.Add(emailTb);
            guestInfoPanel.Controls.Add(emailLbl);
            guestInfoPanel.Controls.Add(contactTb);
            guestInfoPanel.Controls.Add(platformCb);
            guestInfoPanel.Controls.Add(contactLbl);
            guestInfoPanel.Controls.Add(addressTb);
            guestInfoPanel.Controls.Add(addressLbl);
            guestInfoPanel.Controls.Add(suffixCb);
            guestInfoPanel.Controls.Add(suffixLbl);
            guestInfoPanel.Controls.Add(middleNameTb);
            guestInfoPanel.Controls.Add(label4);
            guestInfoPanel.Controls.Add(lastNameTb);
            guestInfoPanel.Controls.Add(lastNameLbl);
            guestInfoPanel.Controls.Add(firstNameLbl);
            guestInfoPanel.Controls.Add(guestInfoLbl);
            guestInfoPanel.Controls.Add(firstNameTb);
            guestInfoPanel.Location = new Point(49, 89);
            guestInfoPanel.Name = "guestInfoPanel";
            guestInfoPanel.Size = new Size(790, 235);
            guestInfoPanel.TabIndex = 3;
            // 
            // emailTb
            // 
            emailTb.BackColor = Color.White;
            emailTb.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTb.ForeColor = Color.Black;
            emailTb.Location = new Point(232, 159);
            emailTb.Multiline = true;
            emailTb.Name = "emailTb";
            emailTb.PlaceholderText = "Email Address";
            emailTb.Size = new Size(180, 32);
            emailTb.TabIndex = 18;
            // 
            // emailLbl
            // 
            emailLbl.AutoSize = true;
            emailLbl.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLbl.ForeColor = Color.DimGray;
            emailLbl.Location = new Point(232, 133);
            emailLbl.Name = "emailLbl";
            emailLbl.Size = new Size(95, 16);
            emailLbl.TabIndex = 17;
            emailLbl.Text = "Email Address";
            // 
            // contactTb
            // 
            contactTb.BackColor = Color.White;
            contactTb.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contactTb.ForeColor = Color.Black;
            contactTb.Location = new Point(430, 159);
            contactTb.Multiline = true;
            contactTb.Name = "contactTb";
            contactTb.PlaceholderText = "Number or Username";
            contactTb.Size = new Size(171, 32);
            contactTb.TabIndex = 16;
            // 
            // platformCb
            // 
            platformCb.BackColor = Color.White;
            platformCb.FormattingEnabled = true;
            platformCb.Items.AddRange(new object[] { "Facebook", "Instagram", "Mobile" });
            platformCb.Location = new Point(629, 163);
            platformCb.Name = "platformCb";
            platformCb.Size = new Size(121, 28);
            platformCb.TabIndex = 15;
            // 
            // contactLbl
            // 
            contactLbl.AutoSize = true;
            contactLbl.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contactLbl.ForeColor = Color.DimGray;
            contactLbl.Location = new Point(430, 133);
            contactLbl.Name = "contactLbl";
            contactLbl.Size = new Size(76, 16);
            contactLbl.TabIndex = 14;
            contactLbl.Text = "Contact Info";
            // 
            // addressTb
            // 
            addressTb.BackColor = Color.White;
            addressTb.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressTb.ForeColor = Color.Black;
            addressTb.Location = new Point(28, 159);
            addressTb.Multiline = true;
            addressTb.Name = "addressTb";
            addressTb.PlaceholderText = "Address";
            addressTb.Size = new Size(180, 32);
            addressTb.TabIndex = 13;
            // 
            // addressLbl
            // 
            addressLbl.AutoSize = true;
            addressLbl.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressLbl.ForeColor = Color.DimGray;
            addressLbl.Location = new Point(28, 133);
            addressLbl.Name = "addressLbl";
            addressLbl.Size = new Size(58, 16);
            addressLbl.TabIndex = 12;
            addressLbl.Text = "Address";
            // 
            // suffixCb
            // 
            suffixCb.BackColor = Color.White;
            suffixCb.FormattingEnabled = true;
            suffixCb.Items.AddRange(new object[] { "Jr.", "Sr.", "II.", "III.", "IV.", "V." });
            suffixCb.Location = new Point(629, 82);
            suffixCb.Name = "suffixCb";
            suffixCb.Size = new Size(121, 28);
            suffixCb.TabIndex = 9;
            // 
            // suffixLbl
            // 
            suffixLbl.AutoSize = true;
            suffixLbl.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            suffixLbl.ForeColor = Color.DimGray;
            suffixLbl.Location = new Point(626, 52);
            suffixLbl.Name = "suffixLbl";
            suffixLbl.Size = new Size(97, 16);
            suffixLbl.TabIndex = 8;
            suffixLbl.Text = "Suffix (optional)";
            // 
            // middleNameTb
            // 
            middleNameTb.BackColor = Color.White;
            middleNameTb.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            middleNameTb.ForeColor = Color.Black;
            middleNameTb.Location = new Point(430, 78);
            middleNameTb.Multiline = true;
            middleNameTb.Name = "middleNameTb";
            middleNameTb.PlaceholderText = "Middle Name";
            middleNameTb.Size = new Size(171, 32);
            middleNameTb.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(430, 52);
            label4.Name = "label4";
            label4.Size = new Size(88, 16);
            label4.TabIndex = 6;
            label4.Text = "Middle Name";
            // 
            // lastNameTb
            // 
            lastNameTb.BackColor = Color.White;
            lastNameTb.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameTb.ForeColor = Color.Black;
            lastNameTb.Location = new Point(232, 78);
            lastNameTb.Multiline = true;
            lastNameTb.Name = "lastNameTb";
            lastNameTb.PlaceholderText = "Last Name";
            lastNameTb.Size = new Size(171, 32);
            lastNameTb.TabIndex = 5;
            // 
            // lastNameLbl
            // 
            lastNameLbl.AutoSize = true;
            lastNameLbl.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLbl.ForeColor = Color.DimGray;
            lastNameLbl.Location = new Point(232, 52);
            lastNameLbl.Name = "lastNameLbl";
            lastNameLbl.Size = new Size(72, 16);
            lastNameLbl.TabIndex = 4;
            lastNameLbl.Text = "Last Name";
            // 
            // firstNameLbl
            // 
            firstNameLbl.AutoSize = true;
            firstNameLbl.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameLbl.ForeColor = Color.DimGray;
            firstNameLbl.Location = new Point(28, 52);
            firstNameLbl.Name = "firstNameLbl";
            firstNameLbl.Size = new Size(72, 16);
            firstNameLbl.TabIndex = 3;
            firstNameLbl.Text = "First Name";
            // 
            // bookingInfoPanel
            // 
            bookingInfoPanel.BackColor = Color.White;
            bookingInfoPanel.Controls.Add(guestQty);
            bookingInfoPanel.Controls.Add(textBox1);
            bookingInfoPanel.Controls.Add(label1);
            bookingInfoPanel.Controls.Add(packageAPanel);
            bookingInfoPanel.Controls.Add(packageBPanel);
            bookingInfoPanel.Controls.Add(checkOutDp);
            bookingInfoPanel.Controls.Add(checkOutLbl);
            bookingInfoPanel.Controls.Add(checkInDp);
            bookingInfoPanel.Controls.Add(bookingDateDp);
            bookingInfoPanel.Controls.Add(numberOfGuestLbl);
            bookingInfoPanel.Controls.Add(checkInLbl);
            bookingInfoPanel.Controls.Add(bookingDateLbl);
            bookingInfoPanel.Controls.Add(BookingInfoLbl);
            bookingInfoPanel.Location = new Point(49, 349);
            bookingInfoPanel.Name = "bookingInfoPanel";
            bookingInfoPanel.Size = new Size(790, 512);
            bookingInfoPanel.TabIndex = 19;
            // 
            // guestQty
            // 
            guestQty.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guestQty.Location = new Point(349, 77);
            guestQty.Name = "guestQty";
            guestQty.Size = new Size(150, 24);
            guestQty.TabIndex = 27;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(558, 78);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter promo code";
            textBox1.Size = new Size(155, 32);
            textBox1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(558, 52);
            label1.Name = "label1";
            label1.Size = new Size(83, 16);
            label1.TabIndex = 25;
            label1.Text = "Promo Code";
            // 
            // packageAPanel
            // 
            packageAPanel.BackColor = Color.White;
            packageAPanel.BorderStyle = BorderStyle.FixedSingle;
            packageAPanel.Controls.Add(packageALbl);
            packageAPanel.Controls.Add(packageARBtn);
            packageAPanel.ForeColor = Color.White;
            packageAPanel.Location = new Point(30, 218);
            packageAPanel.Name = "packageAPanel";
            packageAPanel.Size = new Size(341, 261);
            packageAPanel.TabIndex = 23;
            packageAPanel.Click += packageAPanel_Click;
            // 
            // packageALbl
            // 
            packageALbl.AutoSize = true;
            packageALbl.BackColor = Color.Transparent;
            packageALbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            packageALbl.ForeColor = Color.Black;
            packageALbl.Location = new Point(60, 63);
            packageALbl.Name = "packageALbl";
            packageALbl.Size = new Size(193, 126);
            packageALbl.TabIndex = 1;
            packageALbl.Text = "• Full Resort Access\r\n• Up to 30 guests\r\n• Casa Keona (main house)\r\n• 2 Airconditioned rooms\r\n• Dining room with minibar\r\n• Spacious Cozy Porch\r\n• 4 Indian Rooms ( Non-AC)\r\n";
            // 
            // packageARBtn
            // 
            packageARBtn.AutoSize = true;
            packageARBtn.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            packageARBtn.ForeColor = Color.Black;
            packageARBtn.Location = new Point(30, 15);
            packageARBtn.Name = "packageARBtn";
            packageARBtn.Size = new Size(127, 26);
            packageARBtn.TabIndex = 0;
            packageARBtn.TabStop = true;
            packageARBtn.Text = "Package A";
            packageARBtn.UseVisualStyleBackColor = true;
            // 
            // packageBPanel
            // 
            packageBPanel.BackColor = SystemColors.ControlLightLight;
            packageBPanel.BorderStyle = BorderStyle.FixedSingle;
            packageBPanel.Controls.Add(packageBLbl);
            packageBPanel.Controls.Add(packageBRbtn);
            packageBPanel.Location = new Point(409, 218);
            packageBPanel.Name = "packageBPanel";
            packageBPanel.Size = new Size(341, 261);
            packageBPanel.TabIndex = 24;
            packageBPanel.Click += packageBPanel_Click;
            // 
            // packageBLbl
            // 
            packageBLbl.AutoSize = true;
            packageBLbl.BackColor = Color.Transparent;
            packageBLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            packageBLbl.ForeColor = Color.Black;
            packageBLbl.Location = new Point(60, 59);
            packageBLbl.Name = "packageBLbl";
            packageBLbl.Size = new Size(190, 126);
            packageBLbl.TabIndex = 3;
            packageBLbl.Text = "• Up to 20 persons\r\n• 4 Indian Rooms ( Non-Air)\r\n• Swing Garden\r\n• Dining Area\r\n• Receiving Area \r\n• 2 Cabana\r\n• 1 Dirty Kitchen";
            // 
            // packageBRbtn
            // 
            packageBRbtn.AutoSize = true;
            packageBRbtn.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            packageBRbtn.ForeColor = Color.Black;
            packageBRbtn.Location = new Point(28, 15);
            packageBRbtn.Name = "packageBRbtn";
            packageBRbtn.Size = new Size(127, 26);
            packageBRbtn.TabIndex = 2;
            packageBRbtn.TabStop = true;
            packageBRbtn.Text = "Package B";
            packageBRbtn.UseVisualStyleBackColor = true;
            // 
            // checkOutDp
            // 
            checkOutDp.CalendarForeColor = Color.FromArgb(40, 75, 83);
            checkOutDp.CalendarMonthBackground = SystemColors.ControlLight;
            checkOutDp.CalendarTitleForeColor = Color.FromArgb(40, 75, 83);
            checkOutDp.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkOutDp.Location = new Point(349, 156);
            checkOutDp.MinDate = new DateTime(2025, 9, 13, 0, 0, 0, 0);
            checkOutDp.Name = "checkOutDp";
            checkOutDp.Size = new Size(270, 22);
            checkOutDp.TabIndex = 20;
            // 
            // checkOutLbl
            // 
            checkOutLbl.AutoSize = true;
            checkOutLbl.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkOutLbl.ForeColor = Color.DimGray;
            checkOutLbl.Location = new Point(349, 131);
            checkOutLbl.Name = "checkOutLbl";
            checkOutLbl.Size = new Size(100, 16);
            checkOutLbl.TabIndex = 19;
            checkOutLbl.Text = "Check Out Date";
            // 
            // checkInDp
            // 
            checkInDp.CalendarForeColor = Color.FromArgb(40, 75, 83);
            checkInDp.CalendarMonthBackground = SystemColors.ControlLight;
            checkInDp.CalendarTitleForeColor = Color.FromArgb(40, 75, 83);
            checkInDp.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkInDp.Location = new Point(28, 156);
            checkInDp.MinDate = new DateTime(2025, 9, 13, 0, 0, 0, 0);
            checkInDp.Name = "checkInDp";
            checkInDp.Size = new Size(270, 22);
            checkInDp.TabIndex = 18;
            // 
            // bookingDateDp
            // 
            bookingDateDp.CalendarForeColor = Color.FromArgb(40, 75, 83);
            bookingDateDp.CalendarMonthBackground = SystemColors.ControlLight;
            bookingDateDp.CalendarTitleForeColor = Color.FromArgb(40, 75, 83);
            bookingDateDp.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookingDateDp.Location = new Point(28, 77);
            bookingDateDp.MinDate = new DateTime(2025, 9, 13, 0, 0, 0, 0);
            bookingDateDp.Name = "bookingDateDp";
            bookingDateDp.Size = new Size(270, 22);
            bookingDateDp.TabIndex = 17;
            // 
            // numberOfGuestLbl
            // 
            numberOfGuestLbl.AutoSize = true;
            numberOfGuestLbl.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numberOfGuestLbl.ForeColor = Color.DimGray;
            numberOfGuestLbl.Location = new Point(348, 52);
            numberOfGuestLbl.Name = "numberOfGuestLbl";
            numberOfGuestLbl.Size = new Size(80, 16);
            numberOfGuestLbl.TabIndex = 6;
            numberOfGuestLbl.Text = "No. of Guest";
            // 
            // checkInLbl
            // 
            checkInLbl.AutoSize = true;
            checkInLbl.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkInLbl.ForeColor = Color.DimGray;
            checkInLbl.Location = new Point(28, 131);
            checkInLbl.Name = "checkInLbl";
            checkInLbl.Size = new Size(90, 16);
            checkInLbl.TabIndex = 4;
            checkInLbl.Text = "Check In Date";
            // 
            // bookingDateLbl
            // 
            bookingDateLbl.AutoSize = true;
            bookingDateLbl.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookingDateLbl.ForeColor = Color.DimGray;
            bookingDateLbl.Location = new Point(28, 52);
            bookingDateLbl.Name = "bookingDateLbl";
            bookingDateLbl.Size = new Size(89, 16);
            bookingDateLbl.TabIndex = 3;
            bookingDateLbl.Text = "Booking Date";
            // 
            // BookingInfoLbl
            // 
            BookingInfoLbl.AutoSize = true;
            BookingInfoLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookingInfoLbl.ForeColor = Color.Black;
            BookingInfoLbl.Location = new Point(19, 14);
            BookingInfoLbl.Name = "BookingInfoLbl";
            BookingInfoLbl.Size = new Size(160, 18);
            BookingInfoLbl.TabIndex = 2;
            BookingInfoLbl.Text = "Booking Information";
            // 
            // newBookingPanel
            // 
            newBookingPanel.BackColor = Color.FromArgb(40, 75, 83);
            newBookingPanel.Controls.Add(newBookingLbl);
            newBookingPanel.Location = new Point(0, 0);
            newBookingPanel.Name = "newBookingPanel";
            newBookingPanel.Size = new Size(900, 65);
            newBookingPanel.TabIndex = 20;
            // 
            // proceedPaymentBtn
            // 
            proceedPaymentBtn.BackColor = Color.FromArgb(82, 169, 181);
            proceedPaymentBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            proceedPaymentBtn.ForeColor = Color.Transparent;
            proceedPaymentBtn.Location = new Point(641, 895);
            proceedPaymentBtn.Name = "proceedPaymentBtn";
            proceedPaymentBtn.Size = new Size(198, 40);
            proceedPaymentBtn.TabIndex = 21;
            proceedPaymentBtn.Text = "Proceed to Payment  >";
            proceedPaymentBtn.UseVisualStyleBackColor = false;
            proceedPaymentBtn.Click += proceedPaymentBtn_Click_1;
            // 
            // platformLbl
            // 
            platformLbl.AutoSize = true;
            platformLbl.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            platformLbl.ForeColor = Color.DimGray;
            platformLbl.Location = new Point(626, 133);
            platformLbl.Name = "platformLbl";
            platformLbl.Size = new Size(56, 16);
            platformLbl.TabIndex = 19;
            platformLbl.Text = "Platform";
            // 
            // NewBookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 976);
            Controls.Add(proceedPaymentBtn);
            Controls.Add(bookingInfoPanel);
            Controls.Add(guestInfoPanel);
            Controls.Add(newBookingPanel);
            Name = "NewBookingForm";
            Text = "New Booking";
            guestInfoPanel.ResumeLayout(false);
            guestInfoPanel.PerformLayout();
            bookingInfoPanel.ResumeLayout(false);
            bookingInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guestQty).EndInit();
            packageAPanel.ResumeLayout(false);
            packageAPanel.PerformLayout();
            packageBPanel.ResumeLayout(false);
            packageBPanel.PerformLayout();
            newBookingPanel.ResumeLayout(false);
            newBookingPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox firstNameTb;
        private Label newBookingLbl;
        private Label guestInfoLbl;
        private Panel guestInfoPanel;
        private Label firstNameLbl;
        private ComboBox suffixCb;
        private Label suffixLbl;
        private TextBox middleNameTb;
        private Label label4;
        private TextBox lastNameTb;
        private Label lastNameLbl;
        private TextBox contactTb;
        private ComboBox platformCb;
        private Label contactLbl;
        private TextBox addressTb;
        private Label addressLbl;
        private Panel bookingInfoPanel;
        private DateTimePicker checkInDp;
        private DateTimePicker bookingDateDp;
        private TextBox paxTb;
        private Label numberOfGuestLbl;
        private Label checkInLbl;
        private Label bookingDateLbl;
        private Label BookingInfoLbl;
        private DateTimePicker checkOutDp;
        private Label checkOutLbl;
        private Panel newBookingPanel;
        private Button proceedPaymentBtn;
        private Panel packageAPanel;
        private Panel packageBPanel;
        private RadioButton packageARBtn;
        private Label packageALbl;
        private Label label2;
        private RadioButton radioButton2;
        private RadioButton packageBRbtn;
        private Label packageBLbl;
        private NumericUpDown guestQty;
        private TextBox textBox1;
        private Label label1;
        private TextBox emailTb;
        private Label emailLbl;
        private Label platformLbl;
    }
}