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
            contactListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guestTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sortIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filterIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            guestInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)deleteButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editButton).BeginInit();
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
            contactListPanel.BorderStyle = BorderStyle.FixedSingle;
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
            guestTable.AllowUserToResizeColumns = false;
            guestTable.AllowUserToResizeRows = false;
            guestTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            guestTable.BackgroundColor = Color.White;
            guestTable.BorderStyle = BorderStyle.Fixed3D;
            guestTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            guestTable.GridColor = Color.White;
            guestTable.Location = new Point(39, 96);
            guestTable.Name = "guestTable";
            guestTable.ReadOnly = true;
            guestTable.RowHeadersVisible = false;
            guestTable.RowHeadersWidth = 51;
            guestTable.Size = new Size(1196, 633);
            guestTable.TabIndex = 17;
            guestTable.CellContentClick += guestTable_CellContentClick;
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
            // ContactManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 977);
            Controls.Add(contactListPanel);
            Controls.Add(contactManagementLbl);
            Controls.Add(topNavBar1);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label contactManagementLbl;
        private Panel contactListPanel;
        private Label contactListLbl;
        private Label label3;
        private DataGridView guestTable;
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
    }
}