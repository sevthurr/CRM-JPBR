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
            paymentInfoPanel = new Panel();
            paymentMethodCb = new ComboBox();
            accountNumberTb = new TextBox();
            accountNameTb = new TextBox();
            amountTb = new TextBox();
            amountLbl = new Label();
            purposeCb = new ComboBox();
            purposeLbl = new Label();
            paymentMethodLbl = new Label();
            accountNumberLbl = new Label();
            accountNameLbl = new Label();
            paymentInfoLbl = new Label();
            bookingInfoPanel = new Panel();
            checkOutDp = new DateTimePicker();
            checkOutLbl = new Label();
            checkInDp = new DateTimePicker();
            bookingDateDp = new DateTimePicker();
            packageCb = new ComboBox();
            packageLbl = new Label();
            paxTb = new TextBox();
            paxLbl = new Label();
            checkInLbl = new Label();
            bookingDateLbl = new Label();
            BookingInfoLbl = new Label();
            newBookingPanel = new Panel();
            addBookingBtn = new Button();
            plusIcon = new FontAwesome.Sharp.IconPictureBox();
            guestInfoPanel.SuspendLayout();
            paymentInfoPanel.SuspendLayout();
            bookingInfoPanel.SuspendLayout();
            newBookingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)plusIcon).BeginInit();
            SuspendLayout();
            // 
            // firstNameTb
            // 
            firstNameTb.BackColor = Color.White;
            firstNameTb.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameTb.ForeColor = Color.Black;
            firstNameTb.Location = new Point(28, 78);
            firstNameTb.Multiline = true;
            firstNameTb.Name = "firstNameTb";
            firstNameTb.PlaceholderText = "First Name";
            firstNameTb.Size = new Size(171, 32);
            firstNameTb.TabIndex = 0;
            // 
            // newBookingLbl
            // 
            newBookingLbl.AutoSize = true;
            newBookingLbl.Font = new Font("Crimson Pro", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newBookingLbl.ForeColor = Color.White;
            newBookingLbl.Location = new Point(340, 9);
            newBookingLbl.Name = "newBookingLbl";
            newBookingLbl.Size = new Size(213, 43);
            newBookingLbl.TabIndex = 1;
            newBookingLbl.Text = "New Booking";
            // 
            // guestInfoLbl
            // 
            guestInfoLbl.AutoSize = true;
            guestInfoLbl.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guestInfoLbl.ForeColor = Color.Black;
            guestInfoLbl.Location = new Point(19, 14);
            guestInfoLbl.Name = "guestInfoLbl";
            guestInfoLbl.Size = new Size(150, 26);
            guestInfoLbl.TabIndex = 2;
            guestInfoLbl.Text = "Guest Information";
            // 
            // guestInfoPanel
            // 
            guestInfoPanel.BackColor = Color.White;
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
            // contactTb
            // 
            contactTb.BackColor = Color.White;
            contactTb.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            platformCb.Items.AddRange(new object[] { "Facebook", "Instagram", "Email", "Mobile" });
            platformCb.Location = new Point(629, 163);
            platformCb.Name = "platformCb";
            platformCb.Size = new Size(121, 28);
            platformCb.TabIndex = 15;
            // 
            // contactLbl
            // 
            contactLbl.AutoSize = true;
            contactLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contactLbl.ForeColor = Color.DimGray;
            contactLbl.Location = new Point(430, 133);
            contactLbl.Name = "contactLbl";
            contactLbl.Size = new Size(89, 23);
            contactLbl.TabIndex = 14;
            contactLbl.Text = "Contact Info";
            // 
            // addressTb
            // 
            addressTb.BackColor = Color.White;
            addressTb.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressTb.ForeColor = Color.Black;
            addressTb.Location = new Point(28, 159);
            addressTb.Multiline = true;
            addressTb.Name = "addressTb";
            addressTb.PlaceholderText = "Address";
            addressTb.Size = new Size(375, 32);
            addressTb.TabIndex = 13;
            // 
            // addressLbl
            // 
            addressLbl.AutoSize = true;
            addressLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressLbl.ForeColor = Color.DimGray;
            addressLbl.Location = new Point(28, 133);
            addressLbl.Name = "addressLbl";
            addressLbl.Size = new Size(64, 23);
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
            suffixLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            suffixLbl.ForeColor = Color.DimGray;
            suffixLbl.Location = new Point(626, 52);
            suffixLbl.Name = "suffixLbl";
            suffixLbl.Size = new Size(111, 23);
            suffixLbl.TabIndex = 8;
            suffixLbl.Text = "Suffix (optional)";
            // 
            // middleNameTb
            // 
            middleNameTb.BackColor = Color.White;
            middleNameTb.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            label4.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(430, 52);
            label4.Name = "label4";
            label4.Size = new Size(95, 23);
            label4.TabIndex = 6;
            label4.Text = "Middle Name";
            // 
            // lastNameTb
            // 
            lastNameTb.BackColor = Color.White;
            lastNameTb.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            lastNameLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLbl.ForeColor = Color.DimGray;
            lastNameLbl.Location = new Point(232, 52);
            lastNameLbl.Name = "lastNameLbl";
            lastNameLbl.Size = new Size(79, 23);
            lastNameLbl.TabIndex = 4;
            lastNameLbl.Text = "Last Name";
            // 
            // firstNameLbl
            // 
            firstNameLbl.AutoSize = true;
            firstNameLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameLbl.ForeColor = Color.DimGray;
            firstNameLbl.Location = new Point(28, 52);
            firstNameLbl.Name = "firstNameLbl";
            firstNameLbl.Size = new Size(79, 23);
            firstNameLbl.TabIndex = 3;
            firstNameLbl.Text = "First Name";
            // 
            // paymentInfoPanel
            // 
            paymentInfoPanel.BackColor = Color.White;
            paymentInfoPanel.Controls.Add(paymentMethodCb);
            paymentInfoPanel.Controls.Add(accountNumberTb);
            paymentInfoPanel.Controls.Add(accountNameTb);
            paymentInfoPanel.Controls.Add(amountTb);
            paymentInfoPanel.Controls.Add(amountLbl);
            paymentInfoPanel.Controls.Add(purposeCb);
            paymentInfoPanel.Controls.Add(purposeLbl);
            paymentInfoPanel.Controls.Add(paymentMethodLbl);
            paymentInfoPanel.Controls.Add(accountNumberLbl);
            paymentInfoPanel.Controls.Add(accountNameLbl);
            paymentInfoPanel.Controls.Add(paymentInfoLbl);
            paymentInfoPanel.Location = new Point(49, 619);
            paymentInfoPanel.Name = "paymentInfoPanel";
            paymentInfoPanel.Size = new Size(790, 235);
            paymentInfoPanel.TabIndex = 17;
            // 
            // paymentMethodCb
            // 
            paymentMethodCb.BackColor = Color.White;
            paymentMethodCb.FormattingEnabled = true;
            paymentMethodCb.Items.AddRange(new object[] { "Cash", "GCash", "BPI - Bank Transfer", "BDO - Bank Transfer" });
            paymentMethodCb.Location = new Point(28, 82);
            paymentMethodCb.Name = "paymentMethodCb";
            paymentMethodCb.Size = new Size(231, 28);
            paymentMethodCb.TabIndex = 19;
            // 
            // accountNumberTb
            // 
            accountNumberTb.BackColor = Color.White;
            accountNumberTb.Enabled = false;
            accountNumberTb.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountNumberTb.ForeColor = Color.Black;
            accountNumberTb.Location = new Point(305, 161);
            accountNumberTb.Multiline = true;
            accountNumberTb.Name = "accountNumberTb";
            accountNumberTb.PlaceholderText = "Status";
            accountNumberTb.Size = new Size(198, 32);
            accountNumberTb.TabIndex = 18;
            // 
            // accountNameTb
            // 
            accountNameTb.BackColor = Color.White;
            accountNameTb.Enabled = false;
            accountNameTb.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountNameTb.ForeColor = Color.Black;
            accountNameTb.Location = new Point(30, 160);
            accountNameTb.Multiline = true;
            accountNameTb.Name = "accountNameTb";
            accountNameTb.PlaceholderText = "Status";
            accountNameTb.Size = new Size(198, 32);
            accountNameTb.TabIndex = 17;
            // 
            // amountTb
            // 
            amountTb.BackColor = Color.White;
            amountTb.Enabled = false;
            amountTb.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountTb.ForeColor = Color.Black;
            amountTb.Location = new Point(518, 82);
            amountTb.Multiline = true;
            amountTb.Name = "amountTb";
            amountTb.PlaceholderText = "Php. 0. 00";
            amountTb.Size = new Size(171, 32);
            amountTb.TabIndex = 16;
            // 
            // amountLbl
            // 
            amountLbl.AutoSize = true;
            amountLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountLbl.ForeColor = Color.DimGray;
            amountLbl.Location = new Point(518, 56);
            amountLbl.Name = "amountLbl";
            amountLbl.Size = new Size(61, 23);
            amountLbl.TabIndex = 14;
            amountLbl.Text = "Amount";
            amountLbl.Click += label6_Click;
            // 
            // purposeCb
            // 
            purposeCb.BackColor = Color.White;
            purposeCb.FormattingEnabled = true;
            purposeCb.Items.AddRange(new object[] { "Downpayment", "Full Payment" });
            purposeCb.Location = new Point(305, 82);
            purposeCb.Name = "purposeCb";
            purposeCb.Size = new Size(179, 28);
            purposeCb.TabIndex = 9;
            // 
            // purposeLbl
            // 
            purposeLbl.AutoSize = true;
            purposeLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            purposeLbl.ForeColor = Color.DimGray;
            purposeLbl.Location = new Point(305, 56);
            purposeLbl.Name = "purposeLbl";
            purposeLbl.Size = new Size(63, 23);
            purposeLbl.TabIndex = 8;
            purposeLbl.Text = "Purpose";
            // 
            // paymentMethodLbl
            // 
            paymentMethodLbl.AutoSize = true;
            paymentMethodLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            paymentMethodLbl.ForeColor = Color.DimGray;
            paymentMethodLbl.Location = new Point(28, 56);
            paymentMethodLbl.Name = "paymentMethodLbl";
            paymentMethodLbl.Size = new Size(120, 23);
            paymentMethodLbl.TabIndex = 6;
            paymentMethodLbl.Text = "Payment Method";
            // 
            // accountNumberLbl
            // 
            accountNumberLbl.AutoSize = true;
            accountNumberLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountNumberLbl.ForeColor = Color.DimGray;
            accountNumberLbl.Location = new Point(305, 135);
            accountNumberLbl.Name = "accountNumberLbl";
            accountNumberLbl.Size = new Size(119, 23);
            accountNumberLbl.TabIndex = 4;
            accountNumberLbl.Text = "Account Number";
            // 
            // accountNameLbl
            // 
            accountNameLbl.AutoSize = true;
            accountNameLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountNameLbl.ForeColor = Color.DimGray;
            accountNameLbl.Location = new Point(30, 135);
            accountNameLbl.Name = "accountNameLbl";
            accountNameLbl.Size = new Size(106, 23);
            accountNameLbl.TabIndex = 3;
            accountNameLbl.Text = "Account Name";
            // 
            // paymentInfoLbl
            // 
            paymentInfoLbl.AutoSize = true;
            paymentInfoLbl.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paymentInfoLbl.ForeColor = Color.Black;
            paymentInfoLbl.Location = new Point(19, 14);
            paymentInfoLbl.Name = "paymentInfoLbl";
            paymentInfoLbl.Size = new Size(175, 26);
            paymentInfoLbl.TabIndex = 2;
            paymentInfoLbl.Text = "Payment Information";
            // 
            // bookingInfoPanel
            // 
            bookingInfoPanel.BackColor = Color.White;
            bookingInfoPanel.Controls.Add(checkOutDp);
            bookingInfoPanel.Controls.Add(checkOutLbl);
            bookingInfoPanel.Controls.Add(checkInDp);
            bookingInfoPanel.Controls.Add(bookingDateDp);
            bookingInfoPanel.Controls.Add(packageCb);
            bookingInfoPanel.Controls.Add(packageLbl);
            bookingInfoPanel.Controls.Add(paxTb);
            bookingInfoPanel.Controls.Add(paxLbl);
            bookingInfoPanel.Controls.Add(checkInLbl);
            bookingInfoPanel.Controls.Add(bookingDateLbl);
            bookingInfoPanel.Controls.Add(BookingInfoLbl);
            bookingInfoPanel.Location = new Point(49, 349);
            bookingInfoPanel.Name = "bookingInfoPanel";
            bookingInfoPanel.Size = new Size(790, 235);
            bookingInfoPanel.TabIndex = 19;
            // 
            // checkOutDp
            // 
            checkOutDp.CalendarForeColor = Color.FromArgb(40, 75, 83);
            checkOutDp.CalendarMonthBackground = SystemColors.ControlLight;
            checkOutDp.CalendarTitleForeColor = Color.FromArgb(40, 75, 83);
            checkOutDp.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkOutDp.Location = new Point(349, 156);
            checkOutDp.MinDate = new DateTime(2025, 9, 13, 0, 0, 0, 0);
            checkOutDp.Name = "checkOutDp";
            checkOutDp.Size = new Size(270, 27);
            checkOutDp.TabIndex = 20;
            // 
            // checkOutLbl
            // 
            checkOutLbl.AutoSize = true;
            checkOutLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkOutLbl.ForeColor = Color.DimGray;
            checkOutLbl.Location = new Point(349, 131);
            checkOutLbl.Name = "checkOutLbl";
            checkOutLbl.Size = new Size(111, 23);
            checkOutLbl.TabIndex = 19;
            checkOutLbl.Text = "Check Out Date";
            // 
            // checkInDp
            // 
            checkInDp.CalendarForeColor = Color.FromArgb(40, 75, 83);
            checkInDp.CalendarMonthBackground = SystemColors.ControlLight;
            checkInDp.CalendarTitleForeColor = Color.FromArgb(40, 75, 83);
            checkInDp.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkInDp.Location = new Point(28, 156);
            checkInDp.MinDate = new DateTime(2025, 9, 13, 0, 0, 0, 0);
            checkInDp.Name = "checkInDp";
            checkInDp.Size = new Size(270, 27);
            checkInDp.TabIndex = 18;
            // 
            // bookingDateDp
            // 
            bookingDateDp.CalendarForeColor = Color.FromArgb(40, 75, 83);
            bookingDateDp.CalendarMonthBackground = SystemColors.ControlLight;
            bookingDateDp.CalendarTitleForeColor = Color.FromArgb(40, 75, 83);
            bookingDateDp.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookingDateDp.Location = new Point(28, 77);
            bookingDateDp.MinDate = new DateTime(2025, 9, 13, 0, 0, 0, 0);
            bookingDateDp.Name = "bookingDateDp";
            bookingDateDp.Size = new Size(270, 27);
            bookingDateDp.TabIndex = 17;
            // 
            // packageCb
            // 
            packageCb.BackColor = Color.White;
            packageCb.FormattingEnabled = true;
            packageCb.Items.AddRange(new object[] { "A", "B" });
            packageCb.Location = new Point(511, 82);
            packageCb.Name = "packageCb";
            packageCb.Size = new Size(107, 28);
            packageCb.TabIndex = 9;
            // 
            // packageLbl
            // 
            packageLbl.AutoSize = true;
            packageLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            packageLbl.ForeColor = Color.DimGray;
            packageLbl.Location = new Point(511, 52);
            packageLbl.Name = "packageLbl";
            packageLbl.Size = new Size(68, 23);
            packageLbl.TabIndex = 8;
            packageLbl.Text = "Package";
            // 
            // paxTb
            // 
            paxTb.BackColor = Color.White;
            paxTb.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            paxTb.ForeColor = Color.Black;
            paxTb.Location = new Point(348, 78);
            paxTb.Multiline = true;
            paxTb.Name = "paxTb";
            paxTb.PlaceholderText = "No. of Guest";
            paxTb.Size = new Size(108, 32);
            paxTb.TabIndex = 7;
            // 
            // paxLbl
            // 
            paxLbl.AutoSize = true;
            paxLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            paxLbl.ForeColor = Color.DimGray;
            paxLbl.Location = new Point(348, 52);
            paxLbl.Name = "paxLbl";
            paxLbl.Size = new Size(33, 23);
            paxLbl.TabIndex = 6;
            paxLbl.Text = "Pax";
            // 
            // checkInLbl
            // 
            checkInLbl.AutoSize = true;
            checkInLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkInLbl.ForeColor = Color.DimGray;
            checkInLbl.Location = new Point(28, 131);
            checkInLbl.Name = "checkInLbl";
            checkInLbl.Size = new Size(99, 23);
            checkInLbl.TabIndex = 4;
            checkInLbl.Text = "Check In Date";
            // 
            // bookingDateLbl
            // 
            bookingDateLbl.AutoSize = true;
            bookingDateLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookingDateLbl.ForeColor = Color.DimGray;
            bookingDateLbl.Location = new Point(28, 52);
            bookingDateLbl.Name = "bookingDateLbl";
            bookingDateLbl.Size = new Size(95, 23);
            bookingDateLbl.TabIndex = 3;
            bookingDateLbl.Text = "Booking Date";
            // 
            // BookingInfoLbl
            // 
            BookingInfoLbl.AutoSize = true;
            BookingInfoLbl.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookingInfoLbl.ForeColor = Color.Black;
            BookingInfoLbl.Location = new Point(19, 14);
            BookingInfoLbl.Name = "BookingInfoLbl";
            BookingInfoLbl.Size = new Size(169, 26);
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
            // addBookingBtn
            // 
            addBookingBtn.BackColor = Color.FromArgb(82, 169, 181);
            addBookingBtn.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBookingBtn.ForeColor = Color.Transparent;
            addBookingBtn.Location = new Point(336, 874);
            addBookingBtn.Name = "addBookingBtn";
            addBookingBtn.Size = new Size(198, 40);
            addBookingBtn.TabIndex = 21;
            addBookingBtn.Text = "    Add Booking";
            addBookingBtn.UseVisualStyleBackColor = false;
            // 
            // plusIcon
            // 
            plusIcon.BackColor = Color.FromArgb(82, 169, 181);
            plusIcon.IconChar = FontAwesome.Sharp.IconChar.Add;
            plusIcon.IconColor = Color.White;
            plusIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            plusIcon.IconSize = 29;
            plusIcon.Location = new Point(351, 880);
            plusIcon.Name = "plusIcon";
            plusIcon.Size = new Size(31, 29);
            plusIcon.TabIndex = 22;
            plusIcon.TabStop = false;
            // 
            // NewBookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 932);
            Controls.Add(plusIcon);
            Controls.Add(addBookingBtn);
            Controls.Add(bookingInfoPanel);
            Controls.Add(paymentInfoPanel);
            Controls.Add(guestInfoPanel);
            Controls.Add(newBookingPanel);
            Name = "NewBookingForm";
            Text = "New Booking";
            guestInfoPanel.ResumeLayout(false);
            guestInfoPanel.PerformLayout();
            paymentInfoPanel.ResumeLayout(false);
            paymentInfoPanel.PerformLayout();
            bookingInfoPanel.ResumeLayout(false);
            bookingInfoPanel.PerformLayout();
            newBookingPanel.ResumeLayout(false);
            newBookingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)plusIcon).EndInit();
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
        private Panel paymentInfoPanel;
        private TextBox amountTb;
        private Label amountLbl;
        private ComboBox purposeCb;
        private Label purposeLbl;
        private Label paymentMethodLbl;
        private Label accountNumberLbl;
        private Label accountNameLbl;
        private Label paymentInfoLbl;
        private TextBox accountNumberTb;
        private TextBox accountNameTb;
        private Panel bookingInfoPanel;
        private DateTimePicker checkInDp;
        private DateTimePicker bookingDateDp;
        private ComboBox packageCb;
        private Label packageLbl;
        private TextBox paxTb;
        private Label paxLbl;
        private Label checkInLbl;
        private Label bookingDateLbl;
        private Label BookingInfoLbl;
        private ComboBox paymentMethodCb;
        private DateTimePicker checkOutDp;
        private Label checkOutLbl;
        private Panel newBookingPanel;
        private Button addBookingBtn;
        private FontAwesome.Sharp.IconPictureBox plusIcon;
    }
}