namespace CRM_Jara_s_Palm_Beach_Resort
{
    partial class EditBooking
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
            newBookingPanel = new Panel();
            editBookingLbl = new Label();
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
            guestInfoLbl = new Label();
            firstNameTb = new TextBox();
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
            summaryPanel = new Panel();
            totalAmountLbl = new Label();
            totalAmountVal = new Label();
            discountAmount = new Label();
            discountPercentage = new Label();
            promoDiscountLbl = new Label();
            excessPersonAmount = new Label();
            excessPersonVal = new Label();
            excessPersonLbl = new Label();
            daysStayingAmount = new Label();
            daysStayingVal = new Label();
            daysStayingLbl = new Label();
            packageAmount = new Label();
            packageVal = new Label();
            packageLbl = new Label();
            summaryLbl = new Label();
            proceedPaymentBtn = new Button();
            newBookingPanel.SuspendLayout();
            guestInfoPanel.SuspendLayout();
            bookingInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guestQty).BeginInit();
            packageAPanel.SuspendLayout();
            packageBPanel.SuspendLayout();
            summaryPanel.SuspendLayout();
            SuspendLayout();
            // 
            // newBookingPanel
            // 
            newBookingPanel.BackColor = Color.FromArgb(40, 75, 83);
            newBookingPanel.Controls.Add(editBookingLbl);
            newBookingPanel.Location = new Point(0, 0);
            newBookingPanel.Name = "newBookingPanel";
            newBookingPanel.Size = new Size(900, 65);
            newBookingPanel.TabIndex = 21;
            // 
            // editBookingLbl
            // 
            editBookingLbl.AutoSize = true;
            editBookingLbl.Font = new Font("Crimson Pro", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editBookingLbl.ForeColor = Color.White;
            editBookingLbl.Location = new Point(340, 9);
            editBookingLbl.Name = "editBookingLbl";
            editBookingLbl.Size = new Size(207, 43);
            editBookingLbl.TabIndex = 1;
            editBookingLbl.Text = "Edit Booking";
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
            guestInfoPanel.Location = new Point(56, 106);
            guestInfoPanel.Name = "guestInfoPanel";
            guestInfoPanel.Size = new Size(790, 235);
            guestInfoPanel.TabIndex = 22;
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
            bookingInfoPanel.Location = new Point(56, 371);
            bookingInfoPanel.Name = "bookingInfoPanel";
            bookingInfoPanel.Size = new Size(790, 512);
            bookingInfoPanel.TabIndex = 23;
            // 
            // guestQty
            // 
            guestQty.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guestQty.Location = new Point(349, 77);
            guestQty.Name = "guestQty";
            guestQty.Size = new Size(150, 30);
            guestQty.TabIndex = 27;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            label1.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(558, 52);
            label1.Name = "label1";
            label1.Size = new Size(90, 23);
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
            // 
            // packageALbl
            // 
            packageALbl.AutoSize = true;
            packageALbl.BackColor = Color.Transparent;
            packageALbl.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            packageALbl.ForeColor = Color.Black;
            packageALbl.Location = new Point(60, 63);
            packageALbl.Name = "packageALbl";
            packageALbl.Size = new Size(222, 182);
            packageALbl.TabIndex = 1;
            packageALbl.Text = "• Full Resort Access\r\n• Up to 30 guests\r\n• Casa Keona (main house)\r\n• 2 Airconditioned rooms\r\n• Dining room with minibar\r\n• Spacious Cozy Porch\r\n• 4 Indian Rooms ( Non-AC)\r\n";
            // 
            // packageARBtn
            // 
            packageARBtn.AutoSize = true;
            packageARBtn.Font = new Font("Poppins", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            packageARBtn.ForeColor = Color.Black;
            packageARBtn.Location = new Point(30, 15);
            packageARBtn.Name = "packageARBtn";
            packageARBtn.Size = new Size(132, 35);
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
            // 
            // packageBLbl
            // 
            packageBLbl.AutoSize = true;
            packageBLbl.BackColor = Color.Transparent;
            packageBLbl.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            packageBLbl.ForeColor = Color.Black;
            packageBLbl.Location = new Point(60, 59);
            packageBLbl.Name = "packageBLbl";
            packageBLbl.Size = new Size(220, 182);
            packageBLbl.TabIndex = 3;
            packageBLbl.Text = "• Up to 20 persons\r\n• 4 Indian Rooms ( Non-Air)\r\n• Swing Garden\r\n• Dining Area\r\n• Receiving Area \r\n• 2 Cabana\r\n• 1 Dirty Kitchen";
            // 
            // packageBRbtn
            // 
            packageBRbtn.AutoSize = true;
            packageBRbtn.Font = new Font("Poppins", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            packageBRbtn.ForeColor = Color.Black;
            packageBRbtn.Location = new Point(28, 15);
            packageBRbtn.Name = "packageBRbtn";
            packageBRbtn.Size = new Size(131, 35);
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
            // numberOfGuestLbl
            // 
            numberOfGuestLbl.AutoSize = true;
            numberOfGuestLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numberOfGuestLbl.ForeColor = Color.DimGray;
            numberOfGuestLbl.Location = new Point(348, 52);
            numberOfGuestLbl.Name = "numberOfGuestLbl";
            numberOfGuestLbl.Size = new Size(86, 23);
            numberOfGuestLbl.TabIndex = 6;
            numberOfGuestLbl.Text = "No. of Guest";
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
            // summaryPanel
            // 
            summaryPanel.BackColor = Color.White;
            summaryPanel.Controls.Add(totalAmountLbl);
            summaryPanel.Controls.Add(totalAmountVal);
            summaryPanel.Controls.Add(discountAmount);
            summaryPanel.Controls.Add(discountPercentage);
            summaryPanel.Controls.Add(promoDiscountLbl);
            summaryPanel.Controls.Add(excessPersonAmount);
            summaryPanel.Controls.Add(excessPersonVal);
            summaryPanel.Controls.Add(excessPersonLbl);
            summaryPanel.Controls.Add(daysStayingAmount);
            summaryPanel.Controls.Add(daysStayingVal);
            summaryPanel.Controls.Add(daysStayingLbl);
            summaryPanel.Controls.Add(packageAmount);
            summaryPanel.Controls.Add(packageVal);
            summaryPanel.Controls.Add(packageLbl);
            summaryPanel.Controls.Add(summaryLbl);
            summaryPanel.Location = new Point(56, 917);
            summaryPanel.Name = "summaryPanel";
            summaryPanel.Size = new Size(790, 232);
            summaryPanel.TabIndex = 24;
            // 
            // totalAmountLbl
            // 
            totalAmountLbl.AutoSize = true;
            totalAmountLbl.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalAmountLbl.ForeColor = Color.Black;
            totalAmountLbl.Location = new Point(438, 122);
            totalAmountLbl.Name = "totalAmountLbl";
            totalAmountLbl.Size = new Size(138, 30);
            totalAmountLbl.TabIndex = 29;
            totalAmountLbl.Text = "Total Amount:";
            // 
            // totalAmountVal
            // 
            totalAmountVal.AutoSize = true;
            totalAmountVal.BorderStyle = BorderStyle.FixedSingle;
            totalAmountVal.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalAmountVal.ForeColor = Color.Black;
            totalAmountVal.Location = new Point(576, 122);
            totalAmountVal.Name = "totalAmountVal";
            totalAmountVal.Size = new Size(88, 32);
            totalAmountVal.TabIndex = 30;
            totalAmountVal.Text = "₱ 15,200";
            // 
            // discountAmount
            // 
            discountAmount.AutoSize = true;
            discountAmount.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discountAmount.ForeColor = Color.DimGray;
            discountAmount.Location = new Point(621, 79);
            discountAmount.Name = "discountAmount";
            discountAmount.Size = new Size(85, 26);
            discountAmount.TabIndex = 33;
            discountAmount.Text = "(₱ 15,000)";
            // 
            // discountPercentage
            // 
            discountPercentage.AutoSize = true;
            discountPercentage.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discountPercentage.ForeColor = Color.Black;
            discountPercentage.Location = new Point(576, 78);
            discountPercentage.Name = "discountPercentage";
            discountPercentage.Size = new Size(45, 26);
            discountPercentage.TabIndex = 32;
            discountPercentage.Text = "50%";
            // 
            // promoDiscountLbl
            // 
            promoDiscountLbl.AutoSize = true;
            promoDiscountLbl.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            promoDiscountLbl.ForeColor = Color.Black;
            promoDiscountLbl.Location = new Point(438, 78);
            promoDiscountLbl.Name = "promoDiscountLbl";
            promoDiscountLbl.Size = new Size(136, 26);
            promoDiscountLbl.TabIndex = 31;
            promoDiscountLbl.Text = "Promo Discount:";
            // 
            // excessPersonAmount
            // 
            excessPersonAmount.AutoSize = true;
            excessPersonAmount.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            excessPersonAmount.ForeColor = Color.DimGray;
            excessPersonAmount.Location = new Point(247, 171);
            excessPersonAmount.Name = "excessPersonAmount";
            excessPersonAmount.Size = new Size(88, 26);
            excessPersonAmount.TabIndex = 28;
            excessPersonAmount.Text = "(2 * ₱ 100)";
            // 
            // excessPersonVal
            // 
            excessPersonVal.AutoSize = true;
            excessPersonVal.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            excessPersonVal.ForeColor = Color.Black;
            excessPersonVal.Location = new Point(177, 171);
            excessPersonVal.Name = "excessPersonVal";
            excessPersonVal.Size = new Size(68, 26);
            excessPersonVal.TabIndex = 27;
            excessPersonVal.Text = "2 Guest";
            // 
            // excessPersonLbl
            // 
            excessPersonLbl.AutoSize = true;
            excessPersonLbl.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            excessPersonLbl.ForeColor = Color.Black;
            excessPersonLbl.Location = new Point(44, 171);
            excessPersonLbl.Name = "excessPersonLbl";
            excessPersonLbl.Size = new Size(120, 26);
            excessPersonLbl.TabIndex = 26;
            excessPersonLbl.Text = "Excess Person:";
            // 
            // daysStayingAmount
            // 
            daysStayingAmount.AutoSize = true;
            daysStayingAmount.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            daysStayingAmount.ForeColor = Color.DimGray;
            daysStayingAmount.Location = new Point(256, 124);
            daysStayingAmount.Name = "daysStayingAmount";
            daysStayingAmount.Size = new Size(109, 26);
            daysStayingAmount.TabIndex = 25;
            daysStayingAmount.Text = "(2 * ₱ 15,000)";
            // 
            // daysStayingVal
            // 
            daysStayingVal.AutoSize = true;
            daysStayingVal.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            daysStayingVal.ForeColor = Color.Black;
            daysStayingVal.Location = new Point(177, 124);
            daysStayingVal.Name = "daysStayingVal";
            daysStayingVal.Size = new Size(62, 26);
            daysStayingVal.TabIndex = 24;
            daysStayingVal.Text = "2 Days";
            // 
            // daysStayingLbl
            // 
            daysStayingLbl.AutoSize = true;
            daysStayingLbl.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            daysStayingLbl.ForeColor = Color.Black;
            daysStayingLbl.Location = new Point(44, 124);
            daysStayingLbl.Name = "daysStayingLbl";
            daysStayingLbl.Size = new Size(116, 26);
            daysStayingLbl.TabIndex = 23;
            daysStayingLbl.Text = "Days Staying: ";
            // 
            // packageAmount
            // 
            packageAmount.AutoSize = true;
            packageAmount.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            packageAmount.ForeColor = Color.DimGray;
            packageAmount.Location = new Point(275, 78);
            packageAmount.Name = "packageAmount";
            packageAmount.Size = new Size(85, 26);
            packageAmount.TabIndex = 22;
            packageAmount.Text = "(₱ 15,000)";
            // 
            // packageVal
            // 
            packageVal.AutoSize = true;
            packageVal.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            packageVal.ForeColor = Color.Black;
            packageVal.Location = new Point(177, 78);
            packageVal.Name = "packageVal";
            packageVal.Size = new Size(92, 26);
            packageVal.TabIndex = 21;
            packageVal.Text = "Package A";
            // 
            // packageLbl
            // 
            packageLbl.AutoSize = true;
            packageLbl.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            packageLbl.ForeColor = Color.Black;
            packageLbl.Location = new Point(44, 78);
            packageLbl.Name = "packageLbl";
            packageLbl.Size = new Size(80, 26);
            packageLbl.TabIndex = 20;
            packageLbl.Text = "Package:";
            // 
            // summaryLbl
            // 
            summaryLbl.AutoSize = true;
            summaryLbl.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            summaryLbl.ForeColor = Color.Black;
            summaryLbl.Location = new Point(19, 17);
            summaryLbl.Name = "summaryLbl";
            summaryLbl.Size = new Size(100, 30);
            summaryLbl.TabIndex = 20;
            summaryLbl.Text = "Summary";
            // 
            // proceedPaymentBtn
            // 
            proceedPaymentBtn.BackColor = Color.FromArgb(82, 169, 181);
            proceedPaymentBtn.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            proceedPaymentBtn.ForeColor = Color.White;
            // Place button below summary panel, outside it, positioned like NewBookingForm
            proceedPaymentBtn.Location = new Point(641, 1175);
            proceedPaymentBtn.Name = "proceedPaymentBtn";
            proceedPaymentBtn.Size = new Size(198, 40);
            proceedPaymentBtn.TabIndex = 25;
            proceedPaymentBtn.Text = "Save Edit";
            proceedPaymentBtn.UseVisualStyleBackColor = false;
            // 
            // EditBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            // Match NewBookingForm's ClientSize (898, 976) for consistent sizing
            ClientSize = new Size(898, 976);
            Controls.Add(proceedPaymentBtn);
            Controls.Add(summaryPanel);
            Controls.Add(bookingInfoPanel);
            Controls.Add(guestInfoPanel);
            Controls.Add(newBookingPanel);
            Name = "EditBooking";
            Text = "Edit Booking";
            newBookingPanel.ResumeLayout(false);
            newBookingPanel.PerformLayout();
            guestInfoPanel.ResumeLayout(false);
            guestInfoPanel.PerformLayout();
            bookingInfoPanel.ResumeLayout(false);
            bookingInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guestQty).EndInit();
            packageAPanel.ResumeLayout(false);
            packageAPanel.PerformLayout();
            packageBPanel.ResumeLayout(false);
            packageBPanel.PerformLayout();
            summaryPanel.ResumeLayout(false);
            summaryPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel newBookingPanel;
        private Label editBookingLbl;
        private Panel guestInfoPanel;
        private TextBox contactTb;
        private ComboBox platformCb;
        private Label contactLbl;
        private TextBox addressTb;
        private Label addressLbl;
        private ComboBox suffixCb;
        private Label suffixLbl;
        private TextBox middleNameTb;
        private Label label4;
        private TextBox lastNameTb;
        private Label lastNameLbl;
        private Label firstNameLbl;
        private Label guestInfoLbl;
        private TextBox firstNameTb;
        private Panel bookingInfoPanel;
        private NumericUpDown guestQty;
        private TextBox textBox1;
        private Label label1;
        private Panel packageAPanel;
        private Label packageALbl;
        private RadioButton packageARBtn;
        private Panel packageBPanel;
        private Label packageBLbl;
        private RadioButton packageBRbtn;
        private DateTimePicker checkOutDp;
        private Label checkOutLbl;
        private DateTimePicker checkInDp;
        private DateTimePicker bookingDateDp;
        private Label numberOfGuestLbl;
        private Label checkInLbl;
        private Label bookingDateLbl;
        private Label BookingInfoLbl;
        private Panel summaryPanel;
        private Label totalAmountLbl;
        private Label totalAmountVal;
        private Label discountAmount;
        private Label discountPercentage;
        private Label promoDiscountLbl;
        private Label excessPersonAmount;
        private Label excessPersonVal;
        private Label excessPersonLbl;
        private Label daysStayingAmount;
        private Label daysStayingVal;
        private Label daysStayingLbl;
        private Label packageAmount;
        private Label packageVal;
        private Label packageLbl;
        private Label summaryLbl;
        private Button proceedPaymentBtn;
    }
}