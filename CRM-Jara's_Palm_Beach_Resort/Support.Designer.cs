namespace CRM_Jara_s_Palm_Beach_Resort
{
    partial class Support
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
            marketingLbl = new Label();
            midPanel = new Panel();
            supportHistoryLbl = new Label();
            searchSortPanel = new Panel();
            priorityIcon = new FontAwesome.Sharp.IconPictureBox();
            sortComboBox = new ComboBox();
            ticketIcon = new FontAwesome.Sharp.IconPictureBox();
            searchBoxLbl = new TextBox();
            searchIcon = new FontAwesome.Sharp.IconPictureBox();
            prioritySearchCb = new ComboBox();
            ticketTypeCb = new ComboBox();
            sortIcon = new FontAwesome.Sharp.IconPictureBox();
            ticketsTable = new DataGridView();
            ticketID = new DataGridViewTextBoxColumn();
            subject = new DataGridViewTextBoxColumn();
            deliverTo = new DataGridViewTextBoxColumn();
            ticketType = new DataGridViewTextBoxColumn();
            guestName = new DataGridViewTextBoxColumn();
            priority = new DataGridViewTextBoxColumn();
            ticketInfoLbl = new Label();
            sentByLbl = new Label();
            ticketIDLbl = new Label();
            requestTypeInfoLbl = new Label();
            subjectLbl = new Label();
            remarksInfoLbl = new Label();
            deliverToInfoLbl = new Label();
            priorityLbl = new Label();
            timestampInfoLbl = new Label();
            assigneeLbl = new Label();
            ticketIDVal = new Label();
            sentByVal = new Label();
            requestTypeVal = new Label();
            subjectVal = new Label();
            remarksVal = new Label();
            deliverToVal = new Label();
            priorityVal = new Label();
            assigneeVal = new Label();
            timestampVal = new Label();
            resolveBtn = new Button();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            ticketInfoPanel = new Panel();
            createNewTicketLbl = new Label();
            infoLbl = new Label();
            ticketTypeLbl = new Label();
            guestIDLbl = new Label();
            guestIdTb = new TextBox();
            guestNameLbl = new Label();
            guestNameTb = new TextBox();
            ticketTypeCbox = new ComboBox();
            remarksLbl = new Label();
            remarksTb = new TextBox();
            requestSubjectLbl = new Label();
            requestSubjectTb = new TextBox();
            deliverToLbl = new Label();
            deliverToTb = new TextBox();
            priorityLevelLbl = new Label();
            priorityLevelCb = new ComboBox();
            timestampLbl = new Label();
            timestampDtp = new DateTimePicker();
            submitTicketBtn = new Button();
            ticketForm = new Panel();
            midPanel.SuspendLayout();
            searchSortPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priorityIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sortIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ticketInfoPanel.SuspendLayout();
            ticketForm.SuspendLayout();
            SuspendLayout();
            // 
            // topNavBar1
            // 
            topNavBar1.Location = new Point(0, 0);
            topNavBar1.Name = "topNavBar1";
            topNavBar1.Size = new Size(1915, 70);
            topNavBar1.TabIndex = 8;
            // 
            // marketingLbl
            // 
            marketingLbl.AutoSize = true;
            marketingLbl.Font = new Font("Poppins", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            marketingLbl.Location = new Point(55, 101);
            marketingLbl.Name = "marketingLbl";
            marketingLbl.Size = new Size(166, 60);
            marketingLbl.TabIndex = 9;
            marketingLbl.Text = "Support";
            // 
            // midPanel
            // 
            midPanel.BackColor = Color.White;
            midPanel.Controls.Add(supportHistoryLbl);
            midPanel.Controls.Add(searchSortPanel);
            midPanel.Location = new Point(67, 587);
            midPanel.Name = "midPanel";
            midPanel.Size = new Size(1792, 77);
            midPanel.TabIndex = 41;
            // 
            // supportHistoryLbl
            // 
            supportHistoryLbl.AutoSize = true;
            supportHistoryLbl.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            supportHistoryLbl.ForeColor = Color.Black;
            supportHistoryLbl.Location = new Point(36, 21);
            supportHistoryLbl.Name = "supportHistoryLbl";
            supportHistoryLbl.Size = new Size(203, 40);
            supportHistoryLbl.TabIndex = 41;
            supportHistoryLbl.Text = "Support History";
            // 
            // searchSortPanel
            // 
            searchSortPanel.BackColor = Color.FromArgb(83, 169, 181);
            searchSortPanel.Controls.Add(priorityIcon);
            searchSortPanel.Controls.Add(sortComboBox);
            searchSortPanel.Controls.Add(ticketIcon);
            searchSortPanel.Controls.Add(searchBoxLbl);
            searchSortPanel.Controls.Add(searchIcon);
            searchSortPanel.Controls.Add(prioritySearchCb);
            searchSortPanel.Controls.Add(ticketTypeCb);
            searchSortPanel.Controls.Add(sortIcon);
            searchSortPanel.Location = new Point(509, 12);
            searchSortPanel.Name = "searchSortPanel";
            searchSortPanel.Size = new Size(1179, 52);
            searchSortPanel.TabIndex = 39;
            // 
            // priorityIcon
            // 
            priorityIcon.AccessibleRole = AccessibleRole.None;
            priorityIcon.BackColor = Color.FromArgb(83, 169, 181);
            priorityIcon.IconChar = FontAwesome.Sharp.IconChar.ArrowUpShortWide;
            priorityIcon.IconColor = Color.White;
            priorityIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            priorityIcon.IconSize = 29;
            priorityIcon.Location = new Point(675, 11);
            priorityIcon.Name = "priorityIcon";
            priorityIcon.Size = new Size(30, 29);
            priorityIcon.TabIndex = 43;
            priorityIcon.TabStop = false;
            // 
            // sortComboBox
            // 
            sortComboBox.BackColor = Color.White;
            sortComboBox.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sortComboBox.ForeColor = SystemColors.WindowFrame;
            sortComboBox.FormattingEnabled = true;
            sortComboBox.ItemHeight = 26;
            sortComboBox.Items.AddRange(new object[] { "Name (Asc)", "Name (Dsc)", "Date (Asc)", "Date (Dsc)" });
            sortComboBox.Location = new Point(971, 8);
            sortComboBox.Name = "sortComboBox";
            sortComboBox.Size = new Size(178, 34);
            sortComboBox.TabIndex = 38;
            sortComboBox.Text = "Sort";
            // 
            // ticketIcon
            // 
            ticketIcon.AccessibleRole = AccessibleRole.None;
            ticketIcon.BackColor = Color.FromArgb(83, 169, 181);
            ticketIcon.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            ticketIcon.IconColor = Color.White;
            ticketIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ticketIcon.IconSize = 29;
            ticketIcon.Location = new Point(419, 11);
            ticketIcon.Name = "ticketIcon";
            ticketIcon.Size = new Size(30, 29);
            ticketIcon.TabIndex = 36;
            ticketIcon.TabStop = false;
            // 
            // searchBoxLbl
            // 
            searchBoxLbl.BackColor = Color.White;
            searchBoxLbl.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBoxLbl.ForeColor = SystemColors.WindowFrame;
            searchBoxLbl.Location = new Point(58, 10);
            searchBoxLbl.Multiline = true;
            searchBoxLbl.Name = "searchBoxLbl";
            searchBoxLbl.PlaceholderText = "Search ID, guest, type";
            searchBoxLbl.Size = new Size(307, 34);
            searchBoxLbl.TabIndex = 33;
            // 
            // searchIcon
            // 
            searchIcon.AccessibleRole = AccessibleRole.None;
            searchIcon.BackColor = Color.FromArgb(83, 169, 181);
            searchIcon.IconChar = FontAwesome.Sharp.IconChar.Search;
            searchIcon.IconColor = Color.White;
            searchIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            searchIcon.IconSize = 30;
            searchIcon.Location = new Point(22, 13);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(30, 31);
            searchIcon.TabIndex = 34;
            searchIcon.TabStop = false;
            // 
            // prioritySearchCb
            // 
            prioritySearchCb.BackColor = Color.White;
            prioritySearchCb.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prioritySearchCb.ForeColor = SystemColors.WindowFrame;
            prioritySearchCb.FormattingEnabled = true;
            prioritySearchCb.ItemHeight = 26;
            prioritySearchCb.Items.AddRange(new object[] { "Booked", "Staying", "Completed", "Cancelled", "", "Fully Paid", "Partial", "Downpayment" });
            prioritySearchCb.Location = new Point(711, 8);
            prioritySearchCb.Name = "prioritySearchCb";
            prioritySearchCb.Size = new Size(178, 34);
            prioritySearchCb.TabIndex = 42;
            prioritySearchCb.Text = "Prority";
            // 
            // ticketTypeCb
            // 
            ticketTypeCb.BackColor = Color.White;
            ticketTypeCb.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ticketTypeCb.ForeColor = SystemColors.WindowFrame;
            ticketTypeCb.FormattingEnabled = true;
            ticketTypeCb.ItemHeight = 26;
            ticketTypeCb.Items.AddRange(new object[] { "Booked", "Staying", "Completed", "Cancelled", "", "Fully Paid", "Partial", "Downpayment" });
            ticketTypeCb.Location = new Point(455, 8);
            ticketTypeCb.Name = "ticketTypeCb";
            ticketTypeCb.Size = new Size(178, 34);
            ticketTypeCb.TabIndex = 35;
            ticketTypeCb.Text = "Ticket Type";
            // 
            // sortIcon
            // 
            sortIcon.AccessibleRole = AccessibleRole.None;
            sortIcon.BackColor = Color.FromArgb(83, 169, 181);
            sortIcon.IconChar = FontAwesome.Sharp.IconChar.SortAlphaAsc;
            sortIcon.IconColor = Color.White;
            sortIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            sortIcon.IconSize = 30;
            sortIcon.Location = new Point(934, 8);
            sortIcon.Name = "sortIcon";
            sortIcon.Size = new Size(30, 31);
            sortIcon.TabIndex = 37;
            sortIcon.TabStop = false;
            // 
            // ticketsTable
            // 
            ticketsTable.AllowUserToAddRows = false;
            ticketsTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 197, 149);
            ticketsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ticketsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ticketsTable.BackgroundColor = Color.White;
            ticketsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ticketsTable.Columns.AddRange(new DataGridViewColumn[] { ticketID, subject, deliverTo, ticketType, guestName, priority });
            ticketsTable.GridColor = Color.White;
            ticketsTable.Location = new Point(77, 689);
            ticketsTable.Name = "ticketsTable";
            ticketsTable.ReadOnly = true;
            ticketsTable.RowHeadersWidth = 51;
            ticketsTable.Size = new Size(1159, 645);
            ticketsTable.TabIndex = 42;
            ticketsTable.CellContentClick += ticketsTable_CellContentClick;
            // 
            // ticketID
            // 
            ticketID.HeaderText = "Ticket ID";
            ticketID.MinimumWidth = 6;
            ticketID.Name = "ticketID";
            ticketID.ReadOnly = true;
            // 
            // subject
            // 
            subject.HeaderText = "Subject";
            subject.MinimumWidth = 6;
            subject.Name = "subject";
            subject.ReadOnly = true;
            // 
            // deliverTo
            // 
            deliverTo.HeaderText = "Deliver To";
            deliverTo.MinimumWidth = 6;
            deliverTo.Name = "deliverTo";
            deliverTo.ReadOnly = true;
            // 
            // ticketType
            // 
            ticketType.HeaderText = "Ticket Type";
            ticketType.MinimumWidth = 6;
            ticketType.Name = "ticketType";
            ticketType.ReadOnly = true;
            // 
            // guestName
            // 
            guestName.HeaderText = "Guest Name";
            guestName.MinimumWidth = 6;
            guestName.Name = "guestName";
            guestName.ReadOnly = true;
            // 
            // priority
            // 
            priority.HeaderText = "Priority";
            priority.MinimumWidth = 6;
            priority.Name = "priority";
            priority.ReadOnly = true;
            // 
            // ticketInfoLbl
            // 
            ticketInfoLbl.AutoSize = true;
            ticketInfoLbl.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ticketInfoLbl.Location = new Point(206, 23);
            ticketInfoLbl.Name = "ticketInfoLbl";
            ticketInfoLbl.Size = new Size(204, 36);
            ticketInfoLbl.TabIndex = 0;
            ticketInfoLbl.Text = "Ticket Information";
            // 
            // sentByLbl
            // 
            sentByLbl.AutoSize = true;
            sentByLbl.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sentByLbl.Location = new Point(87, 132);
            sentByLbl.Name = "sentByLbl";
            sentByLbl.Size = new Size(72, 26);
            sentByLbl.TabIndex = 1;
            sentByLbl.Text = "Sent By:";
            // 
            // ticketIDLbl
            // 
            ticketIDLbl.AutoSize = true;
            ticketIDLbl.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ticketIDLbl.Location = new Point(87, 76);
            ticketIDLbl.Name = "ticketIDLbl";
            ticketIDLbl.Size = new Size(80, 26);
            ticketIDLbl.TabIndex = 2;
            ticketIDLbl.Text = "Ticket ID:";
            // 
            // requestTypeInfoLbl
            // 
            requestTypeInfoLbl.AutoSize = true;
            requestTypeInfoLbl.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            requestTypeInfoLbl.Location = new Point(87, 188);
            requestTypeInfoLbl.Name = "requestTypeInfoLbl";
            requestTypeInfoLbl.Size = new Size(118, 26);
            requestTypeInfoLbl.TabIndex = 3;
            requestTypeInfoLbl.Text = "Request Type:";
            // 
            // subjectLbl
            // 
            subjectLbl.AutoSize = true;
            subjectLbl.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subjectLbl.Location = new Point(87, 244);
            subjectLbl.Name = "subjectLbl";
            subjectLbl.Size = new Size(73, 26);
            subjectLbl.TabIndex = 4;
            subjectLbl.Text = "Subject:";
            subjectLbl.Click += label12_Click;
            // 
            // remarksInfoLbl
            // 
            remarksInfoLbl.AutoSize = true;
            remarksInfoLbl.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remarksInfoLbl.Location = new Point(87, 300);
            remarksInfoLbl.Name = "remarksInfoLbl";
            remarksInfoLbl.Size = new Size(84, 26);
            remarksInfoLbl.TabIndex = 5;
            remarksInfoLbl.Text = "Remarks:";
            // 
            // deliverToInfoLbl
            // 
            deliverToInfoLbl.AutoSize = true;
            deliverToInfoLbl.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliverToInfoLbl.Location = new Point(88, 375);
            deliverToInfoLbl.Name = "deliverToInfoLbl";
            deliverToInfoLbl.Size = new Size(90, 26);
            deliverToInfoLbl.TabIndex = 6;
            deliverToInfoLbl.Text = "Deliver To:";
            // 
            // priorityLbl
            // 
            priorityLbl.AutoSize = true;
            priorityLbl.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            priorityLbl.Location = new Point(87, 431);
            priorityLbl.Name = "priorityLbl";
            priorityLbl.Size = new Size(70, 26);
            priorityLbl.TabIndex = 7;
            priorityLbl.Text = "Priority:";
            // 
            // timestampInfoLbl
            // 
            timestampInfoLbl.AutoSize = true;
            timestampInfoLbl.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timestampInfoLbl.Location = new Point(88, 543);
            timestampInfoLbl.Name = "timestampInfoLbl";
            timestampInfoLbl.Size = new Size(104, 26);
            timestampInfoLbl.TabIndex = 8;
            timestampInfoLbl.Text = "Timestamp:";
            // 
            // assigneeLbl
            // 
            assigneeLbl.AutoSize = true;
            assigneeLbl.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            assigneeLbl.Location = new Point(87, 487);
            assigneeLbl.Name = "assigneeLbl";
            assigneeLbl.Size = new Size(85, 26);
            assigneeLbl.TabIndex = 9;
            assigneeLbl.Text = "Assignee:";
            // 
            // ticketIDVal
            // 
            ticketIDVal.AutoSize = true;
            ticketIDVal.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ticketIDVal.Location = new Point(230, 76);
            ticketIDVal.Name = "ticketIDVal";
            ticketIDVal.Size = new Size(43, 26);
            ticketIDVal.TabIndex = 10;
            ticketIDVal.Text = "T001";
            // 
            // sentByVal
            // 
            sentByVal.AutoSize = true;
            sentByVal.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sentByVal.Location = new Point(229, 132);
            sentByVal.Name = "sentByVal";
            sentByVal.Size = new Size(105, 26);
            sentByVal.TabIndex = 11;
            sentByVal.Text = "Guest Name";
            // 
            // requestTypeVal
            // 
            requestTypeVal.AutoSize = true;
            requestTypeVal.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            requestTypeVal.Location = new Point(230, 188);
            requestTypeVal.Name = "requestTypeVal";
            requestTypeVal.Size = new Size(68, 26);
            requestTypeVal.TabIndex = 12;
            requestTypeVal.Text = "Repairs";
            // 
            // subjectVal
            // 
            subjectVal.AutoSize = true;
            subjectVal.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subjectVal.Location = new Point(230, 244);
            subjectVal.Name = "subjectVal";
            subjectVal.Size = new Size(117, 26);
            subjectVal.TabIndex = 13;
            subjectVal.Text = "Broken Aircon";
            // 
            // remarksVal
            // 
            remarksVal.AutoSize = true;
            remarksVal.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            remarksVal.Location = new Point(230, 300);
            remarksVal.Name = "remarksVal";
            remarksVal.Size = new Size(282, 52);
            remarksVal.TabIndex = 14;
            remarksVal.Text = "Aircon not working. Very hot in here.\r\nPlease fix it right away.\r\n";
            // 
            // deliverToVal
            // 
            deliverToVal.AutoSize = true;
            deliverToVal.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliverToVal.Location = new Point(229, 375);
            deliverToVal.Name = "deliverToVal";
            deliverToVal.Size = new Size(104, 26);
            deliverToVal.TabIndex = 15;
            deliverToVal.Text = "Casa Keona";
            // 
            // priorityVal
            // 
            priorityVal.AutoSize = true;
            priorityVal.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priorityVal.Location = new Point(229, 431);
            priorityVal.Name = "priorityVal";
            priorityVal.Size = new Size(46, 26);
            priorityVal.TabIndex = 16;
            priorityVal.Text = "High";
            // 
            // assigneeVal
            // 
            assigneeVal.AutoSize = true;
            assigneeVal.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            assigneeVal.Location = new Point(230, 487);
            assigneeVal.Name = "assigneeVal";
            assigneeVal.Size = new Size(61, 26);
            assigneeVal.TabIndex = 17;
            assigneeVal.Text = "Admin";
            // 
            // timestampVal
            // 
            timestampVal.AutoSize = true;
            timestampVal.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timestampVal.Location = new Point(237, 543);
            timestampVal.Name = "timestampVal";
            timestampVal.Size = new Size(173, 26);
            timestampVal.TabIndex = 18;
            timestampVal.Text = "mm/dd/yyy, 00:00 AM";
            // 
            // resolveBtn
            // 
            resolveBtn.BackColor = Color.FromArgb(38, 176, 112);
            resolveBtn.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resolveBtn.ForeColor = Color.White;
            resolveBtn.Location = new Point(206, 592);
            resolveBtn.Name = "resolveBtn";
            resolveBtn.Size = new Size(204, 37);
            resolveBtn.TabIndex = 19;
            resolveBtn.Text = "        Mark As Resolved";
            resolveBtn.UseVisualStyleBackColor = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.AccessibleRole = AccessibleRole.None;
            iconPictureBox2.BackColor = Color.FromArgb(38, 176, 112);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Check;
            iconPictureBox2.IconColor = Color.White;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 25;
            iconPictureBox2.Location = new Point(225, 600);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(25, 25);
            iconPictureBox2.TabIndex = 44;
            iconPictureBox2.TabStop = false;
            // 
            // ticketInfoPanel
            // 
            ticketInfoPanel.BackColor = Color.White;
            ticketInfoPanel.BorderStyle = BorderStyle.FixedSingle;
            ticketInfoPanel.Controls.Add(iconPictureBox2);
            ticketInfoPanel.Controls.Add(resolveBtn);
            ticketInfoPanel.Controls.Add(timestampVal);
            ticketInfoPanel.Controls.Add(assigneeVal);
            ticketInfoPanel.Controls.Add(priorityVal);
            ticketInfoPanel.Controls.Add(deliverToVal);
            ticketInfoPanel.Controls.Add(remarksVal);
            ticketInfoPanel.Controls.Add(subjectVal);
            ticketInfoPanel.Controls.Add(requestTypeVal);
            ticketInfoPanel.Controls.Add(sentByVal);
            ticketInfoPanel.Controls.Add(ticketIDVal);
            ticketInfoPanel.Controls.Add(assigneeLbl);
            ticketInfoPanel.Controls.Add(timestampInfoLbl);
            ticketInfoPanel.Controls.Add(priorityLbl);
            ticketInfoPanel.Controls.Add(deliverToInfoLbl);
            ticketInfoPanel.Controls.Add(remarksInfoLbl);
            ticketInfoPanel.Controls.Add(subjectLbl);
            ticketInfoPanel.Controls.Add(requestTypeInfoLbl);
            ticketInfoPanel.Controls.Add(ticketIDLbl);
            ticketInfoPanel.Controls.Add(sentByLbl);
            ticketInfoPanel.Controls.Add(ticketInfoLbl);
            ticketInfoPanel.Location = new Point(1264, 689);
            ticketInfoPanel.Name = "ticketInfoPanel";
            ticketInfoPanel.Size = new Size(581, 645);
            ticketInfoPanel.TabIndex = 45;
            // 
            // createNewTicketLbl
            // 
            createNewTicketLbl.AutoSize = true;
            createNewTicketLbl.Font = new Font("Poppins", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createNewTicketLbl.Location = new Point(26, 29);
            createNewTicketLbl.Name = "createNewTicketLbl";
            createNewTicketLbl.Size = new Size(182, 31);
            createNewTicketLbl.TabIndex = 11;
            createNewTicketLbl.Text = "Create New Ticket";
            // 
            // infoLbl
            // 
            infoLbl.AutoSize = true;
            infoLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            infoLbl.ForeColor = Color.DimGray;
            infoLbl.Location = new Point(32, 59);
            infoLbl.Name = "infoLbl";
            infoLbl.Size = new Size(364, 23);
            infoLbl.TabIndex = 12;
            infoLbl.Text = "Fill up the information here then click the submit button.";
            // 
            // ticketTypeLbl
            // 
            ticketTypeLbl.AutoSize = true;
            ticketTypeLbl.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ticketTypeLbl.ForeColor = Color.DimGray;
            ticketTypeLbl.Location = new Point(694, 115);
            ticketTypeLbl.Name = "ticketTypeLbl";
            ticketTypeLbl.Size = new Size(137, 26);
            ticketTypeLbl.TabIndex = 13;
            ticketTypeLbl.Text = "Select ticket type";
            // 
            // guestIDLbl
            // 
            guestIDLbl.AutoSize = true;
            guestIDLbl.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guestIDLbl.ForeColor = Color.DimGray;
            guestIDLbl.Location = new Point(58, 115);
            guestIDLbl.Name = "guestIDLbl";
            guestIDLbl.Size = new Size(78, 26);
            guestIDLbl.TabIndex = 14;
            guestIDLbl.Text = "Guest ID:";
            // 
            // guestIdTb
            // 
            guestIdTb.BackColor = Color.White;
            guestIdTb.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guestIdTb.ForeColor = Color.Black;
            guestIdTb.Location = new Point(60, 150);
            guestIdTb.Multiline = true;
            guestIdTb.Name = "guestIdTb";
            guestIdTb.PlaceholderText = "Enter Guest ID";
            guestIdTb.Size = new Size(217, 32);
            guestIdTb.TabIndex = 27;
            // 
            // guestNameLbl
            // 
            guestNameLbl.AutoSize = true;
            guestNameLbl.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guestNameLbl.ForeColor = Color.DimGray;
            guestNameLbl.Location = new Point(365, 115);
            guestNameLbl.Name = "guestNameLbl";
            guestNameLbl.Size = new Size(108, 26);
            guestNameLbl.TabIndex = 28;
            guestNameLbl.Text = "Guest Name:";
            // 
            // guestNameTb
            // 
            guestNameTb.BackColor = Color.White;
            guestNameTb.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guestNameTb.ForeColor = Color.Black;
            guestNameTb.Location = new Point(365, 150);
            guestNameTb.Multiline = true;
            guestNameTb.Name = "guestNameTb";
            guestNameTb.PlaceholderText = "Enter Guest Name";
            guestNameTb.Size = new Size(250, 32);
            guestNameTb.TabIndex = 29;
            // 
            // ticketTypeCbox
            // 
            ticketTypeCbox.BackColor = Color.White;
            ticketTypeCbox.FormattingEnabled = true;
            ticketTypeCbox.Items.AddRange(new object[] { "Equipment/Product Request", "Repairs", "Complaint" });
            ticketTypeCbox.Location = new Point(694, 149);
            ticketTypeCbox.Name = "ticketTypeCbox";
            ticketTypeCbox.Size = new Size(250, 28);
            ticketTypeCbox.TabIndex = 30;
            // 
            // remarksLbl
            // 
            remarksLbl.AutoSize = true;
            remarksLbl.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            remarksLbl.ForeColor = Color.DimGray;
            remarksLbl.Location = new Point(60, 213);
            remarksLbl.Name = "remarksLbl";
            remarksLbl.Size = new Size(77, 26);
            remarksLbl.TabIndex = 31;
            remarksLbl.Text = "Remarks";
            // 
            // remarksTb
            // 
            remarksTb.BackColor = Color.White;
            remarksTb.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            remarksTb.ForeColor = Color.Black;
            remarksTb.Location = new Point(60, 251);
            remarksTb.Multiline = true;
            remarksTb.Name = "remarksTb";
            remarksTb.PlaceholderText = "Enter Remarks";
            remarksTb.Size = new Size(522, 32);
            remarksTb.TabIndex = 32;
            // 
            // requestSubjectLbl
            // 
            requestSubjectLbl.AutoSize = true;
            requestSubjectLbl.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            requestSubjectLbl.ForeColor = Color.DimGray;
            requestSubjectLbl.Location = new Point(1023, 113);
            requestSubjectLbl.Name = "requestSubjectLbl";
            requestSubjectLbl.Size = new Size(132, 26);
            requestSubjectLbl.TabIndex = 33;
            requestSubjectLbl.Text = "Request Subject";
            requestSubjectLbl.Click += label6_Click;
            // 
            // requestSubjectTb
            // 
            requestSubjectTb.BackColor = Color.White;
            requestSubjectTb.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            requestSubjectTb.ForeColor = Color.Black;
            requestSubjectTb.Location = new Point(1023, 145);
            requestSubjectTb.Multiline = true;
            requestSubjectTb.Name = "requestSubjectTb";
            requestSubjectTb.PlaceholderText = "Write request subject";
            requestSubjectTb.Size = new Size(250, 32);
            requestSubjectTb.TabIndex = 34;
            // 
            // deliverToLbl
            // 
            deliverToLbl.AutoSize = true;
            deliverToLbl.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliverToLbl.ForeColor = Color.DimGray;
            deliverToLbl.Location = new Point(1352, 113);
            deliverToLbl.Name = "deliverToLbl";
            deliverToLbl.Size = new Size(85, 26);
            deliverToLbl.TabIndex = 35;
            deliverToLbl.Text = "Deliver To";
            // 
            // deliverToTb
            // 
            deliverToTb.BackColor = Color.White;
            deliverToTb.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliverToTb.ForeColor = Color.Black;
            deliverToTb.Location = new Point(1352, 142);
            deliverToTb.Multiline = true;
            deliverToTb.Name = "deliverToTb";
            deliverToTb.PlaceholderText = "Enter Room or Area";
            deliverToTb.Size = new Size(250, 32);
            deliverToTb.TabIndex = 36;
            // 
            // priorityLevelLbl
            // 
            priorityLevelLbl.AutoSize = true;
            priorityLevelLbl.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priorityLevelLbl.ForeColor = Color.DimGray;
            priorityLevelLbl.Location = new Point(694, 210);
            priorityLevelLbl.Name = "priorityLevelLbl";
            priorityLevelLbl.Size = new Size(104, 26);
            priorityLevelLbl.TabIndex = 37;
            priorityLevelLbl.Text = "Priority Level";
            // 
            // priorityLevelCb
            // 
            priorityLevelCb.BackColor = Color.White;
            priorityLevelCb.FormattingEnabled = true;
            priorityLevelCb.Items.AddRange(new object[] { "Low", "Medium", "High" });
            priorityLevelCb.Location = new Point(694, 250);
            priorityLevelCb.Name = "priorityLevelCb";
            priorityLevelCb.Size = new Size(250, 28);
            priorityLevelCb.TabIndex = 38;
            // 
            // timestampLbl
            // 
            timestampLbl.AutoSize = true;
            timestampLbl.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timestampLbl.ForeColor = Color.DimGray;
            timestampLbl.Location = new Point(1023, 212);
            timestampLbl.Name = "timestampLbl";
            timestampLbl.Size = new Size(202, 26);
            timestampLbl.TabIndex = 39;
            timestampLbl.Text = "Date and Time Submitted";
            // 
            // timestampDtp
            // 
            timestampDtp.CalendarForeColor = Color.FromArgb(40, 75, 83);
            timestampDtp.CalendarMonthBackground = SystemColors.ControlLight;
            timestampDtp.CalendarTitleForeColor = Color.FromArgb(40, 75, 83);
            timestampDtp.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timestampDtp.Location = new Point(1023, 250);
            timestampDtp.MinDate = new DateTime(2025, 9, 13, 0, 0, 0, 0);
            timestampDtp.Name = "timestampDtp";
            timestampDtp.Size = new Size(270, 30);
            timestampDtp.TabIndex = 40;
            // 
            // submitTicketBtn
            // 
            submitTicketBtn.BackColor = Color.FromArgb(82, 169, 181);
            submitTicketBtn.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submitTicketBtn.ForeColor = Color.Transparent;
            submitTicketBtn.Location = new Point(58, 311);
            submitTicketBtn.Name = "submitTicketBtn";
            submitTicketBtn.Size = new Size(170, 49);
            submitTicketBtn.TabIndex = 22;
            submitTicketBtn.Text = "Submit Ticket";
            submitTicketBtn.UseVisualStyleBackColor = false;
            // 
            // ticketForm
            // 
            ticketForm.BackColor = Color.White;
            ticketForm.BorderStyle = BorderStyle.FixedSingle;
            ticketForm.Controls.Add(submitTicketBtn);
            ticketForm.Controls.Add(timestampDtp);
            ticketForm.Controls.Add(timestampLbl);
            ticketForm.Controls.Add(priorityLevelCb);
            ticketForm.Controls.Add(priorityLevelLbl);
            ticketForm.Controls.Add(deliverToTb);
            ticketForm.Controls.Add(deliverToLbl);
            ticketForm.Controls.Add(requestSubjectTb);
            ticketForm.Controls.Add(requestSubjectLbl);
            ticketForm.Controls.Add(remarksTb);
            ticketForm.Controls.Add(remarksLbl);
            ticketForm.Controls.Add(ticketTypeCbox);
            ticketForm.Controls.Add(guestNameTb);
            ticketForm.Controls.Add(guestNameLbl);
            ticketForm.Controls.Add(guestIdTb);
            ticketForm.Controls.Add(guestIDLbl);
            ticketForm.Controls.Add(ticketTypeLbl);
            ticketForm.Controls.Add(infoLbl);
            ticketForm.Controls.Add(createNewTicketLbl);
            ticketForm.ForeColor = SystemColors.ControlText;
            ticketForm.Location = new Point(67, 170);
            ticketForm.Name = "ticketForm";
            ticketForm.Size = new Size(1792, 384);
            ticketForm.TabIndex = 10;
            ticketForm.Paint += s_Paint;
            // 
            // Support
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1924, 1053);
            Controls.Add(ticketInfoPanel);
            Controls.Add(ticketsTable);
            Controls.Add(midPanel);
            Controls.Add(ticketForm);
            Controls.Add(marketingLbl);
            Controls.Add(topNavBar1);
            Name = "Support";
            Text = "Support";
            Load += Support_Load;
            midPanel.ResumeLayout(false);
            midPanel.PerformLayout();
            searchSortPanel.ResumeLayout(false);
            searchSortPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)priorityIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)sortIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ticketInfoPanel.ResumeLayout(false);
            ticketInfoPanel.PerformLayout();
            ticketForm.ResumeLayout(false);
            ticketForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TopNavBar topNavBar1;
        private Label marketingLbl;
        private Panel midPanel;
        private Label supportHistoryLbl;
        private Panel searchSortPanel;
        private FontAwesome.Sharp.IconPictureBox priorityIcon;
        private ComboBox sortComboBox;
        private FontAwesome.Sharp.IconPictureBox ticketIcon;
        private TextBox searchBoxLbl;
        private FontAwesome.Sharp.IconPictureBox searchIcon;
        private ComboBox prioritySearchCb;
        private ComboBox ticketTypeCb;
        private FontAwesome.Sharp.IconPictureBox sortIcon;
        private DataGridView ticketsTable;
        private DataGridViewTextBoxColumn ticketID;
        private DataGridViewTextBoxColumn subject;
        private DataGridViewTextBoxColumn deliverTo;
        private DataGridViewTextBoxColumn ticketType;
        private DataGridViewTextBoxColumn guestName;
        private DataGridViewTextBoxColumn priority;
        private Label ticketInfoLbl;
        private Label sentByLbl;
        private Label ticketIDLbl;
        private Label requestTypeInfoLbl;
        private Label subjectLbl;
        private Label remarksInfoLbl;
        private Label deliverToInfoLbl;
        private Label priorityLbl;
        private Label timestampInfoLbl;
        private Label assigneeLbl;
        private Label ticketIDVal;
        private Label sentByVal;
        private Label requestTypeVal;
        private Label subjectVal;
        private Label remarksVal;
        private Label deliverToVal;
        private Label priorityVal;
        private Label assigneeVal;
        private Label timestampVal;
        private Button resolveBtn;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Panel ticketInfoPanel;
        private Label createNewTicketLbl;
        private Label infoLbl;
        private Label ticketTypeLbl;
        private Label guestIDLbl;
        private TextBox guestIdTb;
        private Label guestNameLbl;
        private TextBox guestNameTb;
        private ComboBox ticketTypeCbox;
        private Label remarksLbl;
        private TextBox remarksTb;
        private Label requestSubjectLbl;
        private TextBox requestSubjectTb;
        private Label deliverToLbl;
        private TextBox deliverToTb;
        private Label priorityLevelLbl;
        private ComboBox priorityLevelCb;
        private Label timestampLbl;
        private DateTimePicker timestampDtp;
        private Button submitTicketBtn;
        private Panel ticketForm;
    }
}