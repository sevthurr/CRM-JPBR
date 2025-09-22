namespace CRM_Jara_s_Palm_Beach_Resort
{
    partial class ContactManagement
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
            contactManagementLbl = new Label();
            topNavBar1 = new TopNavBar();
            contactListPanel = new Panel();
            guestTable = new DataGridView();
            sortComboBox = new ComboBox();
            contactListLbl = new Label();
            sortIcon = new FontAwesome.Sharp.IconPictureBox();
            label3 = new Label();
            filterIcon = new FontAwesome.Sharp.IconPictureBox();
            filterComboBox = new ComboBox();
            searchBoxLbl = new TextBox();
            searchIcon = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            contactLbl = new Label();
            bkHistoryLbl = new Label();
            marketingLbl = new Label();
            socialsLbl = new Label();
            guestNameLbl = new Label();
            guestInfoPanel = new Panel();
            deleteButton = new FontAwesome.Sharp.IconPictureBox();
            editButton = new FontAwesome.Sharp.IconPictureBox();
            deleteBtn = new Button();
            editBtn = new Button();
            imgPanel = new Panel();
            guestInfoLbl = new Label();
            bookingInformationPanel = new Panel();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label2 = new Label();
            label1 = new Label();
            guestName = new Label();
            paymentLbl = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            button1 = new Button();
            button2 = new Button();
            guestImage = new Panel();
            contactNumberLbl = new Label();
            rentalsLbl = new Label();
            paxLbl = new Label();
            nameLbl = new Label();
            guestInformationLbl = new Label();
            contactListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guestTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sortIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filterIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            guestInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)deleteButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editButton).BeginInit();
            bookingInformationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // contactManagementLbl
            // 
            contactManagementLbl.AutoSize = true;
            contactManagementLbl.Font = new Font("Poppins", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactManagementLbl.Location = new Point(55, 101);
            contactManagementLbl.Name = "contactManagementLbl";
            contactManagementLbl.Size = new Size(413, 60);
            contactManagementLbl.TabIndex = 4;
            contactManagementLbl.Text = "Contact Management";
            // 
            // topNavBar1
            // 
            topNavBar1.Location = new Point(0, 0);
            topNavBar1.Name = "topNavBar1";
            topNavBar1.Size = new Size(1915, 70);
            topNavBar1.TabIndex = 17;
            // 
            // contactListPanel
            // 
            contactListPanel.BackColor = Color.White;
            contactListPanel.Controls.Add(guestTable);
            contactListPanel.Controls.Add(sortComboBox);
            contactListPanel.Controls.Add(contactListLbl);
            contactListPanel.Controls.Add(sortIcon);
            contactListPanel.Controls.Add(label3);
            contactListPanel.Controls.Add(filterIcon);
            contactListPanel.Controls.Add(filterComboBox);
            contactListPanel.Controls.Add(searchBoxLbl);
            contactListPanel.Controls.Add(searchIcon);
            contactListPanel.Controls.Add(panel2);
            contactListPanel.ForeColor = Color.White;
            contactListPanel.Location = new Point(55, 172);
            contactListPanel.Name = "contactListPanel";
            contactListPanel.Size = new Size(1293, 775);
            contactListPanel.TabIndex = 6;
            // 
            // guestTable
            // 
            guestTable.AllowUserToAddRows = false;
            guestTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 197, 149);
            guestTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guestTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            guestTable.BackgroundColor = Color.White;
            guestTable.BorderStyle = BorderStyle.Fixed3D;
            guestTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            guestTable.GridColor = Color.White;
            guestTable.Location = new Point(39, 96);
            guestTable.Name = "guestTable";
            guestTable.ReadOnly = true;
            guestTable.RowHeadersWidth = 51;
            guestTable.Size = new Size(1196, 633);
            guestTable.TabIndex = 36;
            // 
            // sortComboBox
            // 
            sortComboBox.BackColor = Color.White;
            sortComboBox.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sortComboBox.ForeColor = SystemColors.WindowFrame;
            sortComboBox.FormattingEnabled = true;
            sortComboBox.ItemHeight = 26;
            sortComboBox.Items.AddRange(new object[] { "Name (Asc)", "Name (Dsc)", "Date (Asc)", "Date (Dsc)" });
            sortComboBox.Location = new Point(1086, 34);
            sortComboBox.Name = "sortComboBox";
            sortComboBox.Size = new Size(132, 34);
            sortComboBox.TabIndex = 31;
            sortComboBox.Text = "Sort";
            // 
            // contactListLbl
            // 
            contactListLbl.AutoSize = true;
            contactListLbl.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactListLbl.ForeColor = Color.Black;
            contactListLbl.Location = new Point(39, 29);
            contactListLbl.Name = "contactListLbl";
            contactListLbl.Size = new Size(158, 40);
            contactListLbl.TabIndex = 8;
            contactListLbl.Text = "Contact List";
            // 
            // sortIcon
            // 
            sortIcon.AccessibleRole = AccessibleRole.None;
            sortIcon.BackColor = Color.FromArgb(83, 169, 181);
            sortIcon.IconChar = FontAwesome.Sharp.IconChar.SortAlphaAsc;
            sortIcon.IconColor = Color.White;
            sortIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            sortIcon.IconSize = 30;
            sortIcon.Location = new Point(1049, 34);
            sortIcon.Name = "sortIcon";
            sortIcon.Size = new Size(30, 31);
            sortIcon.TabIndex = 30;
            sortIcon.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(31, 20);
            label3.Name = "label3";
            label3.Size = new Size(0, 40);
            label3.TabIndex = 12;
            // 
            // filterIcon
            // 
            filterIcon.AccessibleRole = AccessibleRole.None;
            filterIcon.BackColor = Color.FromArgb(83, 169, 181);
            filterIcon.IconChar = FontAwesome.Sharp.IconChar.Filter;
            filterIcon.IconColor = Color.White;
            filterIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            filterIcon.IconSize = 30;
            filterIcon.Location = new Point(852, 34);
            filterIcon.Name = "filterIcon";
            filterIcon.Size = new Size(30, 31);
            filterIcon.TabIndex = 29;
            filterIcon.TabStop = false;
            // 
            // filterComboBox
            // 
            filterComboBox.BackColor = Color.White;
            filterComboBox.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterComboBox.ForeColor = SystemColors.WindowFrame;
            filterComboBox.FormattingEnabled = true;
            filterComboBox.ItemHeight = 26;
            filterComboBox.Items.AddRange(new object[] { "Booked", "Staying", "Completed", "Cancelled", "", "Fully Paid", "Partial", "Downpayment" });
            filterComboBox.Location = new Point(888, 33);
            filterComboBox.Name = "filterComboBox";
            filterComboBox.Size = new Size(132, 34);
            filterComboBox.TabIndex = 28;
            filterComboBox.Text = "Filter";
            // 
            // searchBoxLbl
            // 
            searchBoxLbl.BackColor = Color.White;
            searchBoxLbl.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBoxLbl.ForeColor = SystemColors.WindowFrame;
            searchBoxLbl.Location = new Point(521, 34);
            searchBoxLbl.Multiline = true;
            searchBoxLbl.Name = "searchBoxLbl";
            searchBoxLbl.PlaceholderText = "Search ID, guests, tags, etc.";
            searchBoxLbl.Size = new Size(307, 34);
            searchBoxLbl.TabIndex = 26;
            // 
            // searchIcon
            // 
            searchIcon.AccessibleRole = AccessibleRole.None;
            searchIcon.BackColor = Color.FromArgb(83, 169, 181);
            searchIcon.IconChar = FontAwesome.Sharp.IconChar.Search;
            searchIcon.IconColor = Color.White;
            searchIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            searchIcon.IconSize = 30;
            searchIcon.Location = new Point(485, 37);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(30, 31);
            searchIcon.TabIndex = 27;
            searchIcon.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(83, 169, 181);
            panel2.Location = new Point(470, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(765, 52);
            panel2.TabIndex = 32;
            // 
            // contactLbl
            // 
            contactLbl.AutoSize = true;
            contactLbl.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactLbl.Location = new Point(97, 483);
            contactLbl.Name = "contactLbl";
            contactLbl.Size = new Size(117, 30);
            contactLbl.TabIndex = 15;
            contactLbl.Text = "Contact No.";
            // 
            // bkHistoryLbl
            // 
            bkHistoryLbl.AutoSize = true;
            bkHistoryLbl.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bkHistoryLbl.Location = new Point(97, 663);
            bkHistoryLbl.Name = "bkHistoryLbl";
            bkHistoryLbl.Size = new Size(156, 30);
            bkHistoryLbl.TabIndex = 14;
            bkHistoryLbl.Text = "Booking History:";
            // 
            // marketingLbl
            // 
            marketingLbl.AutoSize = true;
            marketingLbl.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            marketingLbl.Location = new Point(97, 603);
            marketingLbl.Name = "marketingLbl";
            marketingLbl.Size = new Size(189, 30);
            marketingLbl.TabIndex = 13;
            marketingLbl.Text = "Marketing Consent: ";
            // 
            // socialsLbl
            // 
            socialsLbl.AutoSize = true;
            socialsLbl.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            socialsLbl.Location = new Point(97, 543);
            socialsLbl.Name = "socialsLbl";
            socialsLbl.Size = new Size(80, 30);
            socialsLbl.TabIndex = 12;
            socialsLbl.Text = "Socials:";
            // 
            // guestNameLbl
            // 
            guestNameLbl.AutoSize = true;
            guestNameLbl.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guestNameLbl.Location = new Point(97, 423);
            guestNameLbl.Name = "guestNameLbl";
            guestNameLbl.Size = new Size(125, 30);
            guestNameLbl.TabIndex = 10;
            guestNameLbl.Text = "Guest Name:";
            // 
            // guestInfoPanel
            // 
            guestInfoPanel.BackColor = Color.White;
            guestInfoPanel.BorderStyle = BorderStyle.FixedSingle;
            guestInfoPanel.Controls.Add(deleteButton);
            guestInfoPanel.Controls.Add(contactLbl);
            guestInfoPanel.Controls.Add(editButton);
            guestInfoPanel.Controls.Add(deleteBtn);
            guestInfoPanel.Controls.Add(bkHistoryLbl);
            guestInfoPanel.Controls.Add(editBtn);
            guestInfoPanel.Controls.Add(imgPanel);
            guestInfoPanel.Controls.Add(marketingLbl);
            guestInfoPanel.Controls.Add(socialsLbl);
            guestInfoPanel.Controls.Add(guestNameLbl);
            guestInfoPanel.Controls.Add(guestInfoLbl);
            guestInfoPanel.ForeColor = Color.Black;
            guestInfoPanel.Location = new Point(1393, 173);
            guestInfoPanel.Name = "guestInfoPanel";
            guestInfoPanel.Size = new Size(470, 778);
            guestInfoPanel.TabIndex = 16;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Red;
            deleteButton.IconChar = FontAwesome.Sharp.IconChar.Trash;
            deleteButton.IconColor = Color.White;
            deleteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteButton.IconSize = 19;
            deleteButton.Location = new Point(259, 343);
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
            editButton.Location = new Point(156, 340);
            editButton.Name = "editButton";
            editButton.Size = new Size(24, 23);
            editButton.TabIndex = 18;
            editButton.TabStop = false;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Red;
            deleteBtn.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Location = new Point(247, 336);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(99, 31);
            deleteBtn.TabIndex = 20;
            deleteBtn.Text = "     Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.FromArgb(255, 173, 70);
            editBtn.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editBtn.ForeColor = Color.White;
            editBtn.Location = new Point(142, 336);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(99, 31);
            editBtn.TabIndex = 18;
            editBtn.Text = "      Edit";
            editBtn.UseVisualStyleBackColor = false;
            // 
            // imgPanel
            // 
            imgPanel.BackColor = Color.White;
            imgPanel.BorderStyle = BorderStyle.FixedSingle;
            imgPanel.Location = new Point(125, 89);
            imgPanel.Name = "imgPanel";
            imgPanel.Size = new Size(231, 232);
            imgPanel.TabIndex = 9;
            // 
            // guestInfoLbl
            // 
            guestInfoLbl.AutoSize = true;
            guestInfoLbl.Font = new Font("Poppins", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guestInfoLbl.ForeColor = Color.Black;
            guestInfoLbl.Location = new Point(115, 31);
            guestInfoLbl.Name = "guestInfoLbl";
            guestInfoLbl.Size = new Size(252, 44);
            guestInfoLbl.TabIndex = 8;
            guestInfoLbl.Text = "Guest Information";
            // 
            // bookingInformationPanel
            // 
            bookingInformationPanel.AutoScroll = true;
            bookingInformationPanel.BackColor = Color.White;
            bookingInformationPanel.BorderStyle = BorderStyle.FixedSingle;
            bookingInformationPanel.Controls.Add(linkLabel2);
            bookingInformationPanel.Controls.Add(linkLabel1);
            bookingInformationPanel.Controls.Add(radioButton2);
            bookingInformationPanel.Controls.Add(radioButton1);
            bookingInformationPanel.Controls.Add(label2);
            bookingInformationPanel.Controls.Add(label1);
            bookingInformationPanel.Controls.Add(guestName);
            bookingInformationPanel.Controls.Add(paymentLbl);
            bookingInformationPanel.Controls.Add(iconPictureBox1);
            bookingInformationPanel.Controls.Add(iconPictureBox2);
            bookingInformationPanel.Controls.Add(button1);
            bookingInformationPanel.Controls.Add(button2);
            bookingInformationPanel.Controls.Add(guestImage);
            bookingInformationPanel.Controls.Add(contactNumberLbl);
            bookingInformationPanel.Controls.Add(rentalsLbl);
            bookingInformationPanel.Controls.Add(paxLbl);
            bookingInformationPanel.Controls.Add(nameLbl);
            bookingInformationPanel.Controls.Add(guestInformationLbl);
            bookingInformationPanel.ForeColor = Color.Black;
            bookingInformationPanel.Location = new Point(1389, 172);
            bookingInformationPanel.Name = "bookingInformationPanel";
            bookingInformationPanel.Size = new Size(470, 775);
            bookingInformationPanel.TabIndex = 18;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.FromArgb(40, 75, 83);
            linkLabel2.Location = new Point(236, 600);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(19, 23);
            linkLabel2.TabIndex = 41;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "1";
            linkLabel2.VisitedLinkColor = Color.FromArgb(235, 197, 149);
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(40, 75, 83);
            linkLabel1.Location = new Point(216, 554);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(106, 20);
            linkLabel1.TabIndex = 40;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "+ Add Contact";
            linkLabel1.VisitedLinkColor = Color.FromArgb(235, 197, 149);
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(331, 657);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(55, 30);
            radioButton2.TabIndex = 39;
            radioButton2.TabStop = true;
            radioButton2.Text = "Off";
            radioButton2.TextAlign = ContentAlignment.MiddleCenter;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(270, 657);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(55, 30);
            radioButton1.TabIndex = 38;
            radioButton1.TabStop = true;
            radioButton1.Text = "On";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(204, 522);
            label2.Name = "label2";
            label2.Size = new Size(192, 30);
            label2.TabIndex = 37;
            label2.Text = "facebook.com/guest";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(204, 464);
            label1.Name = "label1";
            label1.Size = new Size(152, 30);
            label1.TabIndex = 36;
            label1.Text = "+639-000-0000";
            // 
            // guestName
            // 
            guestName.AutoSize = true;
            guestName.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guestName.Location = new Point(204, 402);
            guestName.Name = "guestName";
            guestName.Size = new Size(120, 30);
            guestName.TabIndex = 35;
            guestName.Text = "Guest Name";
            // 
            // paymentLbl
            // 
            paymentLbl.AutoSize = true;
            paymentLbl.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paymentLbl.Location = new Point(71, 658);
            paymentLbl.Name = "paymentLbl";
            paymentLbl.Size = new Size(185, 30);
            paymentLbl.TabIndex = 33;
            paymentLbl.Text = "Marketing Consent:";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Red;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 19;
            iconPictureBox1.Location = new Point(259, 332);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(19, 20);
            iconPictureBox1.TabIndex = 19;
            iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(255, 173, 70);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Edit;
            iconPictureBox2.IconColor = Color.White;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 23;
            iconPictureBox2.Location = new Point(152, 329);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(24, 23);
            iconPictureBox2.TabIndex = 18;
            iconPictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(247, 325);
            button1.Name = "button1";
            button1.Size = new Size(99, 31);
            button1.TabIndex = 20;
            button1.Text = "    Delete";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 173, 70);
            button2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(138, 325);
            button2.Name = "button2";
            button2.Size = new Size(99, 31);
            button2.TabIndex = 18;
            button2.Text = "     Edit";
            button2.UseVisualStyleBackColor = false;
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
            // contactNumberLbl
            // 
            contactNumberLbl.AutoSize = true;
            contactNumberLbl.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactNumberLbl.Location = new Point(71, 464);
            contactNumberLbl.Name = "contactNumberLbl";
            contactNumberLbl.Size = new Size(117, 30);
            contactNumberLbl.TabIndex = 15;
            contactNumberLbl.Text = "Contact No:";
            // 
            // rentalsLbl
            // 
            rentalsLbl.AutoSize = true;
            rentalsLbl.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rentalsLbl.Location = new Point(71, 522);
            rentalsLbl.Name = "rentalsLbl";
            rentalsLbl.Size = new Size(80, 30);
            rentalsLbl.TabIndex = 14;
            rentalsLbl.Text = "Socials:";
            // 
            // paxLbl
            // 
            paxLbl.AutoSize = true;
            paxLbl.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paxLbl.Location = new Point(71, 600);
            paxLbl.Name = "paxLbl";
            paxLbl.Size = new Size(156, 30);
            paxLbl.TabIndex = 13;
            paxLbl.Text = "Booking History:";
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLbl.Location = new Point(71, 406);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(71, 30);
            nameLbl.TabIndex = 10;
            nameLbl.Text = "Name:";
            // 
            // guestInformationLbl
            // 
            guestInformationLbl.AutoSize = true;
            guestInformationLbl.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guestInformationLbl.ForeColor = Color.Black;
            guestInformationLbl.Location = new Point(128, 24);
            guestInformationLbl.Name = "guestInformationLbl";
            guestInformationLbl.Size = new Size(232, 40);
            guestInformationLbl.TabIndex = 8;
            guestInformationLbl.Text = "Guest Information";
            guestInformationLbl.Click += bookingInformationLbl_Click;
            // 
            // ContactManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 977);
            Controls.Add(bookingInformationPanel);
            Controls.Add(contactManagementLbl);
            Controls.Add(topNavBar1);
            Controls.Add(contactListPanel);
            Location = new Point(55, 101);
            Name = "ContactManagement";
            Text = "ContactManagement";
            contactListPanel.ResumeLayout(false);
            contactListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guestTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)sortIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)filterIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchIcon).EndInit();
            guestInfoPanel.ResumeLayout(false);
            guestInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)deleteButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)editButton).EndInit();
            bookingInformationPanel.ResumeLayout(false);
            bookingInformationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label contactManagementLbl;
        private Panel contactListPanel;
        private Label contactListLbl;
        private Label label3;
        private Label contactLbl;
        private Label bkHistoryLbl;
        private Label marketingLbl;
        private Label socialsLbl;
        private Label guestNameLbl;
        private Panel guestInfoPanel;
        private FontAwesome.Sharp.IconPictureBox deleteButton;
        private FontAwesome.Sharp.IconPictureBox editButton;
        private Button deleteBtn;
        private Button editBtn;
        private Panel imgPanel;
        private Label guestInfoLbl;
        private ComboBox sortComboBox;
        private FontAwesome.Sharp.IconPictureBox sortIcon;
        private FontAwesome.Sharp.IconPictureBox filterIcon;
        private ComboBox filterComboBox;
        private TextBox searchBoxLbl;
        private FontAwesome.Sharp.IconPictureBox searchIcon;
        private Panel panel2;
        private TopNavBar topNavBar1;
        private Panel bookingInformationPanel;
        private Label paymentLbl;
        private Label checkOutDateVal;
        private Label checkOutDateLbl;
        private LinkLabel guestNameLnkLbl;
        private LinkLabel itemsLinkVal;
        private LinkLabel packageVal;
        private Label checkInDateVal;
        private Label paxVal;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Button button1;
        private Button button2;
        private Panel guestImage;
        private Label contactNumberLbl;
        private Label rentalsLbl;
        private Label paxLbl;
        private Label packageLbl;
        private Label nameLbl;
        private Label guestInformationLbl;
        private Label guestName;
        private Label label1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label2;
        private DataGridView guestTable;
    }
}