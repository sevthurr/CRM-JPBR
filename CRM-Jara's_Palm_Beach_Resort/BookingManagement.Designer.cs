namespace CRM_Jara_s_Palm_Beach_Resort
{
    partial class BookingManagement
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            bookingListsPanel = new Panel();
            sortComboBox = new ComboBox();
            sortIcon = new FontAwesome.Sharp.IconPictureBox();
            filterIcon = new FontAwesome.Sharp.IconPictureBox();
            filterComboBox = new ComboBox();
            searchIcon = new FontAwesome.Sharp.IconPictureBox();
            searchBoxLbl = new TextBox();
            filterPanel = new Panel();
            bookingListLbl = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            label3 = new Label();
            newBookingBtn = new Button();
            bookingsTable = new DataGridView();
            bookingInformationPanel = new Panel();
            moneyIcon = new FontAwesome.Sharp.IconPictureBox();
            paymentHistoryBtn = new Button();
            paymentAmountVal = new Label();
            paymentLbl = new Label();
            checkOutDateVal = new Label();
            checkOutDateLbl = new Label();
            guestNameLnkLbl = new LinkLabel();
            packageVal = new LinkLabel();
            checkInDateVal = new Label();
            paxVal = new Label();
            deleteButton = new FontAwesome.Sharp.IconPictureBox();
            editButton = new FontAwesome.Sharp.IconPictureBox();
            deleteBtn = new Button();
            editBtn = new Button();
            guestImage = new Panel();
            checkInDateLbl = new Label();
            paxLbl = new Label();
            packageLbl = new Label();
            guestNameLbl = new Label();
            bookingInformationLbl = new Label();
            bookinglistsLbl = new Label();
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            topNavBar1 = new TopNavBar();
            bookingListsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sortIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filterIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookingsTable).BeginInit();
            bookingInformationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)moneyIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deleteButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editButton).BeginInit();
            SuspendLayout();
            // 
            // bookingListsPanel
            // 
            bookingListsPanel.BackColor = Color.White;
            bookingListsPanel.BorderStyle = BorderStyle.FixedSingle;
            bookingListsPanel.Controls.Add(sortComboBox);
            bookingListsPanel.Controls.Add(sortIcon);
            bookingListsPanel.Controls.Add(filterIcon);
            bookingListsPanel.Controls.Add(filterComboBox);
            bookingListsPanel.Controls.Add(searchIcon);
            bookingListsPanel.Controls.Add(searchBoxLbl);
            bookingListsPanel.Controls.Add(filterPanel);
            bookingListsPanel.Controls.Add(bookingListLbl);
            bookingListsPanel.Controls.Add(iconPictureBox2);
            bookingListsPanel.Controls.Add(label3);
            bookingListsPanel.Controls.Add(newBookingBtn);
            bookingListsPanel.Controls.Add(bookingsTable);
            bookingListsPanel.ForeColor = Color.White;
            bookingListsPanel.Location = new Point(55, 172);
            bookingListsPanel.Name = "bookingListsPanel";
            bookingListsPanel.Size = new Size(1293, 775);
            bookingListsPanel.TabIndex = 5;
            bookingListsPanel.Paint += panel3_Paint;
            // 
            // sortComboBox
            // 
            sortComboBox.BackColor = Color.White;
            sortComboBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sortComboBox.ForeColor = SystemColors.WindowFrame;
            sortComboBox.FormattingEnabled = true;
            sortComboBox.ItemHeight = 18;
            sortComboBox.Items.AddRange(new object[] { "Name (Asc)", "Name (Dsc)", "Date (Asc)", "Date (Dsc)" });
            sortComboBox.Location = new Point(892, 33);
            sortComboBox.Name = "sortComboBox";
            sortComboBox.Size = new Size(132, 26);
            sortComboBox.TabIndex = 24;
            sortComboBox.Text = "Sort";
            // 
            // sortIcon
            // 
            sortIcon.AccessibleRole = AccessibleRole.None;
            sortIcon.BackColor = Color.FromArgb(83, 169, 181);
            sortIcon.IconChar = FontAwesome.Sharp.IconChar.SortAlphaAsc;
            sortIcon.IconColor = Color.White;
            sortIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            sortIcon.IconSize = 30;
            sortIcon.Location = new Point(855, 33);
            sortIcon.Name = "sortIcon";
            sortIcon.Size = new Size(30, 31);
            sortIcon.TabIndex = 23;
            sortIcon.TabStop = false;
            // 
            // filterIcon
            // 
            filterIcon.AccessibleRole = AccessibleRole.None;
            filterIcon.BackColor = Color.FromArgb(83, 169, 181);
            filterIcon.IconChar = FontAwesome.Sharp.IconChar.Filter;
            filterIcon.IconColor = Color.White;
            filterIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            filterIcon.IconSize = 30;
            filterIcon.Location = new Point(658, 33);
            filterIcon.Name = "filterIcon";
            filterIcon.Size = new Size(30, 31);
            filterIcon.TabIndex = 22;
            filterIcon.TabStop = false;
            // 
            // filterComboBox
            // 
            filterComboBox.BackColor = Color.White;
            filterComboBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterComboBox.ForeColor = SystemColors.WindowFrame;
            filterComboBox.FormattingEnabled = true;
            filterComboBox.ItemHeight = 18;
            filterComboBox.Items.AddRange(new object[] { "Booked", "Staying", "Completed", "Cancelled", "", "Fully Paid", "Partial", "Downpayment" });
            filterComboBox.Location = new Point(694, 32);
            filterComboBox.Name = "filterComboBox";
            filterComboBox.Size = new Size(132, 26);
            filterComboBox.TabIndex = 21;
            filterComboBox.Text = "Filter";
            // 
            // searchIcon
            // 
            searchIcon.AccessibleRole = AccessibleRole.None;
            searchIcon.BackColor = Color.FromArgb(83, 169, 181);
            searchIcon.IconChar = FontAwesome.Sharp.IconChar.Search;
            searchIcon.IconColor = Color.White;
            searchIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            searchIcon.IconSize = 30;
            searchIcon.Location = new Point(291, 36);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(30, 31);
            searchIcon.TabIndex = 20;
            searchIcon.TabStop = false;
            // 
            // searchBoxLbl
            // 
            searchBoxLbl.BackColor = Color.White;
            searchBoxLbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBoxLbl.ForeColor = SystemColors.WindowFrame;
            searchBoxLbl.Location = new Point(327, 33);
            searchBoxLbl.Multiline = true;
            searchBoxLbl.Name = "searchBoxLbl";
            searchBoxLbl.PlaceholderText = "Search ID, guests, tags, etc.";
            searchBoxLbl.Size = new Size(307, 34);
            searchBoxLbl.TabIndex = 19;
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.FromArgb(83, 169, 181);
            filterPanel.Location = new Point(276, 23);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(765, 52);
            filterPanel.TabIndex = 25;
            // 
            // bookingListLbl
            // 
            bookingListLbl.AutoSize = true;
            bookingListLbl.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookingListLbl.ForeColor = Color.Black;
            bookingListLbl.Location = new Point(39, 29);
            bookingListLbl.Name = "bookingListLbl";
            bookingListLbl.Size = new Size(170, 29);
            bookingListLbl.TabIndex = 8;
            bookingListLbl.Text = "Booking Lists";
            bookingListLbl.Click += label4_Click;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(40, 75, 83);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconPictureBox2.IconColor = Color.White;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 29;
            iconPictureBox2.Location = new Point(1076, 35);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(29, 29);
            iconPictureBox2.TabIndex = 3;
            iconPictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(31, 20);
            label3.Name = "label3";
            label3.Size = new Size(0, 29);
            label3.TabIndex = 12;
            // 
            // newBookingBtn
            // 
            newBookingBtn.BackColor = Color.FromArgb(40, 75, 83);
            newBookingBtn.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newBookingBtn.ForeColor = Color.White;
            newBookingBtn.Location = new Point(1064, 23);
            newBookingBtn.Name = "newBookingBtn";
            newBookingBtn.Size = new Size(171, 52);
            newBookingBtn.TabIndex = 0;
            newBookingBtn.Text = "      New Booking";
            newBookingBtn.UseVisualStyleBackColor = false;
            newBookingBtn.Click += button1_Click;
            // 
            // bookingsTable
            // 
            bookingsTable.AllowUserToAddRows = false;
            bookingsTable.AllowUserToDeleteRows = false;
            bookingsTable.AllowUserToResizeColumns = false;
            bookingsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(235, 197, 149);
            bookingsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            bookingsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bookingsTable.BackgroundColor = Color.White;
            bookingsTable.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            bookingsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            bookingsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookingsTable.GridColor = Color.White;
            bookingsTable.Location = new Point(39, 96);
            bookingsTable.Name = "bookingsTable";
            bookingsTable.ReadOnly = true;
            bookingsTable.RowHeadersVisible = false;
            bookingsTable.RowHeadersWidth = 51;
            bookingsTable.Size = new Size(1196, 633);
            bookingsTable.TabIndex = 17;
            bookingsTable.CellContentClick += bookingsTable_CellContentClick;
            bookingsTable.Paint += tableLayoutPanel1_Paint;
            bookingsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bookingsTable.MultiSelect = false;
            // 
            // bookingInformationPanel
            // 
            bookingInformationPanel.BackColor = Color.White;
            bookingInformationPanel.BorderStyle = BorderStyle.FixedSingle;
            bookingInformationPanel.Controls.Add(moneyIcon);
            bookingInformationPanel.Controls.Add(paymentHistoryBtn);
            bookingInformationPanel.Controls.Add(paymentAmountVal);
            bookingInformationPanel.Controls.Add(paymentLbl);
            bookingInformationPanel.Controls.Add(checkOutDateVal);
            bookingInformationPanel.Controls.Add(checkOutDateLbl);
            bookingInformationPanel.Controls.Add(guestNameLnkLbl);
            bookingInformationPanel.Controls.Add(packageVal);
            bookingInformationPanel.Controls.Add(checkInDateVal);
            bookingInformationPanel.Controls.Add(paxVal);
            bookingInformationPanel.Controls.Add(deleteButton);
            bookingInformationPanel.Controls.Add(editButton);
            bookingInformationPanel.Controls.Add(deleteBtn);
            bookingInformationPanel.Controls.Add(editBtn);
            bookingInformationPanel.Controls.Add(guestImage);
            bookingInformationPanel.Controls.Add(checkInDateLbl);
            bookingInformationPanel.Controls.Add(paxLbl);
            bookingInformationPanel.Controls.Add(packageLbl);
            bookingInformationPanel.Controls.Add(guestNameLbl);
            bookingInformationPanel.Controls.Add(bookingInformationLbl);
            bookingInformationPanel.ForeColor = Color.Black;
            bookingInformationPanel.Location = new Point(1393, 172);
            bookingInformationPanel.Name = "bookingInformationPanel";
            bookingInformationPanel.Size = new Size(470, 775);
            bookingInformationPanel.TabIndex = 6;
            bookingInformationPanel.Paint += panel4_Paint;
            // 
            // moneyIcon
            // 
            moneyIcon.BackColor = Color.FromArgb(38, 176, 112);
            moneyIcon.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            moneyIcon.IconColor = Color.White;
            moneyIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            moneyIcon.IconSize = 19;
            moneyIcon.Location = new Point(299, 333);
            moneyIcon.Name = "moneyIcon";
            moneyIcon.Size = new Size(19, 20);
            moneyIcon.TabIndex = 35;
            moneyIcon.TabStop = false;
            // 
            // paymentHistoryBtn
            // 
            paymentHistoryBtn.BackColor = Color.FromArgb(38, 176, 112);
            paymentHistoryBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            paymentHistoryBtn.ForeColor = Color.White;
            paymentHistoryBtn.Location = new Point(287, 326);
            paymentHistoryBtn.Name = "paymentHistoryBtn";
            paymentHistoryBtn.Size = new Size(124, 31);
            paymentHistoryBtn.TabIndex = 36;
            paymentHistoryBtn.Text = "      Payments";
            paymentHistoryBtn.UseVisualStyleBackColor = false;
            // 
            // paymentAmountVal
            // 
            paymentAmountVal.AutoSize = true;
            paymentAmountVal.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            paymentAmountVal.Location = new Point(215, 646);
            paymentAmountVal.Name = "paymentAmountVal";
            paymentAmountVal.Size = new Size(78, 20);
            paymentAmountVal.TabIndex = 34;
            paymentAmountVal.Text = "Php. 0.00";
            // 
            // paymentLbl
            // 
            paymentLbl.AutoSize = true;
            paymentLbl.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paymentLbl.Location = new Point(78, 645);
            paymentLbl.Name = "paymentLbl";
            paymentLbl.Size = new Size(93, 20);
            paymentLbl.TabIndex = 33;
            paymentLbl.Text = "Payment: ";
            // 
            // checkOutDateVal
            // 
            checkOutDateVal.AutoSize = true;
            checkOutDateVal.Font = new Font("Microsoft Sans Serif", 9F);
            checkOutDateVal.Location = new Point(215, 498);
            checkOutDateVal.Name = "checkOutDateVal";
            checkOutDateVal.Size = new Size(86, 18);
            checkOutDateVal.TabIndex = 32;
            checkOutDateVal.Text = "mm/dd/yyyy";
            // 
            // checkOutDateLbl
            // 
            checkOutDateLbl.AutoSize = true;
            checkOutDateLbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkOutDateLbl.Location = new Point(78, 498);
            checkOutDateLbl.Name = "checkOutDateLbl";
            checkOutDateLbl.Size = new Size(103, 20);
            checkOutDateLbl.TabIndex = 31;
            checkOutDateLbl.Text = "Check Out:";
            // 
            // guestNameLnkLbl
            // 
            guestNameLnkLbl.AutoSize = true;
            guestNameLnkLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guestNameLnkLbl.LinkColor = Color.FromArgb(40, 75, 83);
            guestNameLnkLbl.Location = new Point(215, 400);
            guestNameLnkLbl.Name = "guestNameLnkLbl";
            guestNameLnkLbl.Size = new Size(92, 18);
            guestNameLnkLbl.TabIndex = 30;
            guestNameLnkLbl.TabStop = true;
            guestNameLnkLbl.Text = "Guest Name";
            guestNameLnkLbl.VisitedLinkColor = Color.FromArgb(83, 169, 181);
            // 
            // packageVal
            // 
            packageVal.AutoSize = true;
            packageVal.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            packageVal.LinkColor = Color.FromArgb(40, 75, 83);
            packageVal.Location = new Point(215, 548);
            packageVal.Name = "packageVal";
            packageVal.Size = new Size(20, 20);
            packageVal.TabIndex = 28;
            packageVal.TabStop = true;
            packageVal.Text = "A";
            packageVal.VisitedLinkColor = Color.FromArgb(83, 169, 181);
            // 
            // checkInDateVal
            // 
            checkInDateVal.AutoSize = true;
            checkInDateVal.Font = new Font("Microsoft Sans Serif", 9F);
            checkInDateVal.Location = new Point(215, 448);
            checkInDateVal.Name = "checkInDateVal";
            checkInDateVal.Size = new Size(86, 18);
            checkInDateVal.TabIndex = 26;
            checkInDateVal.Text = "mm/dd/yyyy";
            // 
            // paxVal
            // 
            paxVal.AutoSize = true;
            paxVal.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            paxVal.Location = new Point(215, 598);
            paxVal.Name = "paxVal";
            paxVal.Size = new Size(18, 20);
            paxVal.TabIndex = 24;
            paxVal.Text = "0";
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Red;
            deleteButton.IconChar = FontAwesome.Sharp.IconChar.Trash;
            deleteButton.IconColor = Color.White;
            deleteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteButton.IconSize = 19;
            deleteButton.Location = new Point(194, 333);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(19, 20);
            deleteButton.TabIndex = 19;
            deleteButton.TabStop = false;
            // 
            // editButton
            // 
            editButton.BackColor = Color.FromArgb(255, 173, 70);
            editButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            editButton.IconColor = Color.White;
            editButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editButton.IconSize = 23;
            editButton.Location = new Point(91, 330);
            editButton.Name = "editButton";
            editButton.Size = new Size(24, 23);
            editButton.TabIndex = 18;
            editButton.TabStop = false;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Red;
            deleteBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Location = new Point(182, 326);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(99, 31);
            deleteBtn.TabIndex = 20;
            deleteBtn.Text = "    Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.FromArgb(255, 173, 70);
            editBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editBtn.ForeColor = Color.White;
            editBtn.Location = new Point(77, 326);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(99, 31);
            editBtn.TabIndex = 18;
            editBtn.Text = "     Edit";
            editBtn.UseVisualStyleBackColor = false;
            // 
            // guestImage
            // 
            guestImage.BackColor = Color.White;
            guestImage.BorderStyle = BorderStyle.FixedSingle;
            guestImage.Location = new Point(127, 84);
            guestImage.Name = "guestImage";
            guestImage.Size = new Size(230, 221);
            guestImage.TabIndex = 9;
            // 
            // checkInDateLbl
            // 
            checkInDateLbl.AutoSize = true;
            checkInDateLbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkInDateLbl.Location = new Point(78, 448);
            checkInDateLbl.Name = "checkInDateLbl";
            checkInDateLbl.Size = new Size(88, 20);
            checkInDateLbl.TabIndex = 15;
            checkInDateLbl.Text = "Check In:";
            // 
            // paxLbl
            // 
            paxLbl.AutoSize = true;
            paxLbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paxLbl.Location = new Point(78, 598);
            paxLbl.Name = "paxLbl";
            paxLbl.Size = new Size(46, 20);
            paxLbl.TabIndex = 13;
            paxLbl.Text = "Pax:";
            // 
            // packageLbl
            // 
            packageLbl.AutoSize = true;
            packageLbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            packageLbl.Location = new Point(78, 548);
            packageLbl.Name = "packageLbl";
            packageLbl.Size = new Size(86, 20);
            packageLbl.TabIndex = 12;
            packageLbl.Text = "Package:";
            // 
            // guestNameLbl
            // 
            guestNameLbl.AutoSize = true;
            guestNameLbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guestNameLbl.Location = new Point(78, 398);
            guestNameLbl.Name = "guestNameLbl";
            guestNameLbl.Size = new Size(119, 20);
            guestNameLbl.TabIndex = 10;
            guestNameLbl.Text = "Guest Name:";
            // 
            // bookingInformationLbl
            // 
            bookingInformationLbl.AutoSize = true;
            bookingInformationLbl.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookingInformationLbl.ForeColor = Color.Black;
            bookingInformationLbl.Location = new Point(112, 24);
            bookingInformationLbl.Name = "bookingInformationLbl";
            bookingInformationLbl.Size = new Size(246, 29);
            bookingInformationLbl.TabIndex = 8;
            bookingInformationLbl.Text = "Booking Information";
            // 
            // bookinglistsLbl
            // 
            bookinglistsLbl.AutoSize = true;
            bookinglistsLbl.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookinglistsLbl.Location = new Point(55, 101);
            bookinglistsLbl.Name = "bookinglistsLbl";
            bookinglistsLbl.Size = new Size(366, 39);
            bookinglistsLbl.TabIndex = 3;
            bookinglistsLbl.Text = "Booking Management";
            bookinglistsLbl.Click += welcomeLbl_Click;
            // 
            // iconDropDownButton1
            // 
            iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconDropDownButton1.IconColor = Color.Black;
            iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDropDownButton1.Name = "iconDropDownButton1";
            iconDropDownButton1.Size = new Size(23, 23);
            iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // topNavBar1
            // 
            topNavBar1.Location = new Point(0, 0);
            topNavBar1.Name = "topNavBar1";
            topNavBar1.Size = new Size(1915, 70);
            topNavBar1.TabIndex = 7;
            // 
            // BookingManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 977);
            Controls.Add(topNavBar1);
            Controls.Add(bookingInformationPanel);
            Controls.Add(bookinglistsLbl);
            Controls.Add(bookingListsPanel);
            Name = "BookingManagement";
            Text = "Booking Management";
            Load += BookingManagement_Load;
            bookingListsPanel.ResumeLayout(false);
            bookingListsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sortIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)filterIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookingsTable).EndInit();
            bookingInformationPanel.ResumeLayout(false);
            bookingInformationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)moneyIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)deleteButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)editButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel bookingListsPanel;
        private Panel bookingInformationPanel;
        private Panel guestImage;
        private Label bookingInformationLbl;
        private Button newBookingBtn;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label label3;
        private Label bookinglistsLbl;
        private Label bookingListLbl;
        private DataGridView bookingsTable;
        private Label guestNameLbl;
        private Label checkInDateLbl;
        private Label paxLbl;
        private Label packageLbl;
        private FontAwesome.Sharp.IconPictureBox editButton;
        private FontAwesome.Sharp.IconPictureBox deleteButton;
        private Button deleteBtn;
        private Button editBtn;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private ComboBox sortComboBox;
        private FontAwesome.Sharp.IconPictureBox sortIcon;
        private FontAwesome.Sharp.IconPictureBox filterIcon;
        private ComboBox filterComboBox;
        private FontAwesome.Sharp.IconPictureBox searchIcon;
        private TextBox searchBoxLbl;
        private Panel filterPanel;
        private LinkLabel packageVal;
        private Label checkInDateVal;
        private Label paxVal;
        private TopNavBar topNavBar1;
        private LinkLabel guestNameLnkLbl;
        private Label checkOutDateVal;
        private Label checkOutDateLbl;
        private Label paymentAmountVal;
        private Label paymentLbl;
        private FontAwesome.Sharp.IconPictureBox moneyIcon;
        private Button paymentHistoryBtn;
    }
}    
