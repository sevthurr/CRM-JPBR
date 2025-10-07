namespace CRM_Jara_s_Palm_Beach_Resort
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            bindingSource1 = new BindingSource(components);
            welcomeLbl = new Label();
            userLbl = new Label();
            bookingsPanel = new Panel();
            bookingsVal = new Label();
            monthLbl = new Label();
            repeatGuestsPanel = new Panel();
            repeatGuestsVal = new Label();
            repeatGuestsLbl = new Label();
            openTicketsPanel = new Panel();
            openTicketsVal = new Label();
            openTicketsLbl = new Label();
            activeCampaignsPanel = new Panel();
            activeCampaignsVal = new Label();
            activeCampaignsLbl = new Label();
            checkInsPanel = new Panel();
            checkInTable = new DataGridView();
            guestName = new DataGridViewTextBoxColumn();
            package = new DataGridViewTextBoxColumn();
            pax = new DataGridViewTextBoxColumn();
            arrivalDate = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            checkInsLbl = new Label();
            checkOutPanel = new Panel();
            checkOutTable = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            checkOutDate = new DataGridViewTextBoxColumn();
            time = new DataGridViewTextBoxColumn();
            checkOutsLbl = new Label();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            calendarPanel = new Panel();
            topNavBar1 = new TopNavBar();
            pictureBox1 = new PictureBox();
            crmLbl = new Label();
            label1 = new Label();
            dashboardBtn = new Label();
            bookingsBtn = new Label();
            guestsBtn = new Label();
            marketingBtn = new Label();
            supportBtn = new Label();
            chevronDownBtn = new FontAwesome.Sharp.IconPictureBox();
            contentPanel = new Panel();
            analyticsPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            bookingsPanel.SuspendLayout();
            repeatGuestsPanel.SuspendLayout();
            openTicketsPanel.SuspendLayout();
            activeCampaignsPanel.SuspendLayout();
            checkInsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)checkInTable).BeginInit();
            checkOutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)checkOutTable).BeginInit();
            calendarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chevronDownBtn).BeginInit();
            contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // welcomeLbl
            // 
            welcomeLbl.AutoSize = true;
            welcomeLbl.Font = new Font("Poppins", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLbl.Location = new Point(75, 29);
            welcomeLbl.Name = "welcomeLbl";
            welcomeLbl.Size = new Size(209, 60);
            welcomeLbl.TabIndex = 2;
            welcomeLbl.Text = "Welcome, ";
            // 
            // userLbl
            // 
            userLbl.AutoSize = true;
            userLbl.Font = new Font("Poppins", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userLbl.Location = new Point(259, 29);
            userLbl.Name = "userLbl";
            userLbl.Size = new Size(155, 60);
            userLbl.TabIndex = 3;
            userLbl.Text = "Admin!";
            userLbl.Click += userLbl_Click;
            // 
            // bookingsPanel
            // 
            bookingsPanel.BackColor = Color.White;
            bookingsPanel.Controls.Add(bookingsVal);
            bookingsPanel.Controls.Add(monthLbl);
            bookingsPanel.Location = new Point(75, 107);
            bookingsPanel.Name = "bookingsPanel";
            bookingsPanel.Size = new Size(405, 101);
            bookingsPanel.TabIndex = 4;
            // 
            // bookingsVal
            // 
            bookingsVal.AutoSize = true;
            bookingsVal.Font = new Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookingsVal.Location = new Point(20, 36);
            bookingsVal.Name = "bookingsVal";
            bookingsVal.Size = new Size(40, 50);
            bookingsVal.TabIndex = 8;
            bookingsVal.Text = "0";
            // 
            // monthLbl
            // 
            monthLbl.AutoSize = true;
            monthLbl.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            monthLbl.ForeColor = SystemColors.ControlDarkDark;
            monthLbl.Location = new Point(154, 12);
            monthLbl.Name = "monthLbl";
            monthLbl.Size = new Size(96, 26);
            monthLbl.TabIndex = 9;
            monthLbl.Text = "September";
            monthLbl.Click += label8_Click;
            // 
            // repeatGuestsPanel
            // 
            repeatGuestsPanel.BackColor = Color.White;
            repeatGuestsPanel.Controls.Add(repeatGuestsVal);
            repeatGuestsPanel.Controls.Add(repeatGuestsLbl);
            repeatGuestsPanel.Location = new Point(540, 107);
            repeatGuestsPanel.Name = "repeatGuestsPanel";
            repeatGuestsPanel.Size = new Size(405, 101);
            repeatGuestsPanel.TabIndex = 5;
            // 
            // repeatGuestsVal
            // 
            repeatGuestsVal.AutoSize = true;
            repeatGuestsVal.Font = new Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            repeatGuestsVal.Location = new Point(21, 33);
            repeatGuestsVal.Name = "repeatGuestsVal";
            repeatGuestsVal.Size = new Size(40, 50);
            repeatGuestsVal.TabIndex = 10;
            repeatGuestsVal.Text = "0";
            // 
            // repeatGuestsLbl
            // 
            repeatGuestsLbl.AutoSize = true;
            repeatGuestsLbl.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            repeatGuestsLbl.ForeColor = SystemColors.ControlDarkDark;
            repeatGuestsLbl.Location = new Point(14, 10);
            repeatGuestsLbl.Name = "repeatGuestsLbl";
            repeatGuestsLbl.Size = new Size(120, 26);
            repeatGuestsLbl.TabIndex = 10;
            repeatGuestsLbl.Text = "Repeat Guests";
            // 
            // openTicketsPanel
            // 
            openTicketsPanel.BackColor = Color.White;
            openTicketsPanel.Controls.Add(openTicketsVal);
            openTicketsPanel.Controls.Add(openTicketsLbl);
            openTicketsPanel.Location = new Point(992, 107);
            openTicketsPanel.Name = "openTicketsPanel";
            openTicketsPanel.Size = new Size(405, 101);
            openTicketsPanel.TabIndex = 6;
            // 
            // openTicketsVal
            // 
            openTicketsVal.AutoSize = true;
            openTicketsVal.Font = new Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            openTicketsVal.ForeColor = Color.Red;
            openTicketsVal.Location = new Point(20, 34);
            openTicketsVal.Name = "openTicketsVal";
            openTicketsVal.Size = new Size(40, 50);
            openTicketsVal.TabIndex = 9;
            openTicketsVal.Text = "0";
            // 
            // openTicketsLbl
            // 
            openTicketsLbl.AutoSize = true;
            openTicketsLbl.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openTicketsLbl.ForeColor = SystemColors.ControlDarkDark;
            openTicketsLbl.Location = new Point(12, 11);
            openTicketsLbl.Name = "openTicketsLbl";
            openTicketsLbl.Size = new Size(108, 26);
            openTicketsLbl.TabIndex = 11;
            openTicketsLbl.Text = "Open Tickets";
            // 
            // activeCampaignsPanel
            // 
            activeCampaignsPanel.BackColor = Color.White;
            activeCampaignsPanel.Controls.Add(activeCampaignsVal);
            activeCampaignsPanel.Controls.Add(activeCampaignsLbl);
            activeCampaignsPanel.Location = new Point(1442, 107);
            activeCampaignsPanel.Name = "activeCampaignsPanel";
            activeCampaignsPanel.Size = new Size(405, 101);
            activeCampaignsPanel.TabIndex = 7;
            // 
            // activeCampaignsVal
            // 
            activeCampaignsVal.AutoSize = true;
            activeCampaignsVal.Font = new Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            activeCampaignsVal.ForeColor = Color.FromArgb(83, 169, 181);
            activeCampaignsVal.Location = new Point(25, 33);
            activeCampaignsVal.Name = "activeCampaignsVal";
            activeCampaignsVal.Size = new Size(40, 50);
            activeCampaignsVal.TabIndex = 12;
            activeCampaignsVal.Text = "0";
            // 
            // activeCampaignsLbl
            // 
            activeCampaignsLbl.AutoSize = true;
            activeCampaignsLbl.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            activeCampaignsLbl.ForeColor = SystemColors.ControlDarkDark;
            activeCampaignsLbl.Location = new Point(13, 11);
            activeCampaignsLbl.Name = "activeCampaignsLbl";
            activeCampaignsLbl.Size = new Size(150, 26);
            activeCampaignsLbl.TabIndex = 12;
            activeCampaignsLbl.Text = "Active Campaigns";
            // 
            // checkInsPanel
            // 
            checkInsPanel.BackColor = Color.White;
            checkInsPanel.Controls.Add(checkInTable);
            checkInsPanel.Controls.Add(checkInsLbl);
            checkInsPanel.Location = new Point(75, 241);
            checkInsPanel.Name = "checkInsPanel";
            checkInsPanel.Size = new Size(870, 412);
            checkInsPanel.TabIndex = 8;
            checkInsPanel.Paint += panel2_Paint;
            // 
            // checkInTable
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 197, 149);
            checkInTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            checkInTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            checkInTable.BackgroundColor = Color.White;
            checkInTable.BorderStyle = BorderStyle.Fixed3D;
            checkInTable.ColumnHeadersHeight = 29;
            checkInTable.Columns.AddRange(new DataGridViewColumn[] { guestName, package, pax, arrivalDate, status });
            checkInTable.GridColor = Color.FromArgb(40, 75, 83);
            checkInTable.Location = new Point(29, 54);
            checkInTable.Name = "checkInTable";
            checkInTable.RowHeadersWidth = 51;
            checkInTable.Size = new Size(812, 337);
            checkInTable.TabIndex = 11;
            // 
            // guestName
            // 
            guestName.HeaderText = "Guest Name";
            guestName.MinimumWidth = 6;
            guestName.Name = "guestName";
            guestName.ReadOnly = true;
            // 
            // package
            // 
            package.HeaderText = "Package";
            package.MinimumWidth = 6;
            package.Name = "package";
            package.ReadOnly = true;
            // 
            // pax
            // 
            pax.HeaderText = "Pax";
            pax.MinimumWidth = 6;
            pax.Name = "pax";
            pax.ReadOnly = true;
            // 
            // arrivalDate
            // 
            arrivalDate.HeaderText = "Arrival Date";
            arrivalDate.MinimumWidth = 6;
            arrivalDate.Name = "arrivalDate";
            arrivalDate.ReadOnly = true;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // checkInsLbl
            // 
            checkInsLbl.AutoSize = true;
            checkInsLbl.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkInsLbl.Location = new Point(29, 15);
            checkInsLbl.Name = "checkInsLbl";
            checkInsLbl.Size = new Size(121, 36);
            checkInsLbl.TabIndex = 10;
            checkInsLbl.Text = "Check-Ins";
            // 
            // checkOutPanel
            // 
            checkOutPanel.BackColor = Color.White;
            checkOutPanel.Controls.Add(checkOutTable);
            checkOutPanel.Controls.Add(checkOutsLbl);
            checkOutPanel.Location = new Point(992, 241);
            checkOutPanel.Name = "checkOutPanel";
            checkOutPanel.Size = new Size(855, 412);
            checkOutPanel.TabIndex = 9;
            // 
            // checkOutTable
            // 
            dataGridViewCellStyle2.BackColor = Color.FromArgb(235, 197, 149);
            checkOutTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            checkOutTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            checkOutTable.BackgroundColor = Color.White;
            checkOutTable.BorderStyle = BorderStyle.Fixed3D;
            checkOutTable.ColumnHeadersHeight = 29;
            checkOutTable.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, checkOutDate, time });
            checkOutTable.GridColor = Color.FromArgb(40, 75, 83);
            checkOutTable.Location = new Point(33, 54);
            checkOutTable.Name = "checkOutTable";
            checkOutTable.RowHeadersWidth = 51;
            checkOutTable.Size = new Size(790, 337);
            checkOutTable.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Guest Name";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Package";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Pax";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // checkOutDate
            // 
            checkOutDate.HeaderText = "Check Out Date";
            checkOutDate.MinimumWidth = 6;
            checkOutDate.Name = "checkOutDate";
            checkOutDate.ReadOnly = true;
            // 
            // time
            // 
            time.HeaderText = "Time";
            time.MinimumWidth = 6;
            time.Name = "time";
            time.ReadOnly = true;
            // 
            // checkOutsLbl
            // 
            checkOutsLbl.AutoSize = true;
            checkOutsLbl.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkOutsLbl.Location = new Point(33, 15);
            checkOutsLbl.Name = "checkOutsLbl";
            checkOutsLbl.Size = new Size(139, 36);
            checkOutsLbl.TabIndex = 12;
            checkOutsLbl.Text = "Check-Outs";
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.True;
            // 
            // calendarPanel
            // 
            calendarPanel.BackColor = SystemColors.ButtonHighlight;
            calendarPanel.Location = new Point(75, 705);
            calendarPanel.Name = "calendarPanel";
            calendarPanel.Size = new Size(1772, 605);
            calendarPanel.TabIndex = 11;
            // 
            // analyticsPanel
            // 
            analyticsPanel.BackColor = Color.White;
            analyticsPanel.Location = new Point(75, 1345);
            analyticsPanel.Name = "analyticsPanel";
            analyticsPanel.Size = new Size(1772, 700);
            analyticsPanel.TabIndex = 14;
            // 
            // topNavBar1
            // 
            topNavBar1.Location = new Point(0, 0);
            topNavBar1.Name = "topNavBar1";
            topNavBar1.Size = new Size(1922, 70);
            topNavBar1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._464643879_122123191316493608_5108633697996930672_n_removebg_preview__1_;
            pictureBox1.Location = new Point(36, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // crmLbl
            // 
            crmLbl.AutoSize = true;
            crmLbl.Font = new Font("Crimson Pro", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crmLbl.ForeColor = Color.White;
            crmLbl.Location = new Point(125, 10);
            crmLbl.Name = "crmLbl";
            crmLbl.Size = new Size(70, 26);
            crmLbl.TabIndex = 4;
            crmLbl.Text = "JARA'S";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Crimson Pro", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(114, 39);
            label1.Name = "label1";
            label1.Size = new Size(134, 17);
            label1.TabIndex = 5;
            label1.Text = "PALM BEACH RESORT";
            // 
            // dashboardBtn
            // 
            dashboardBtn.AutoSize = true;
            dashboardBtn.Font = new Font("Poppins", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            dashboardBtn.ForeColor = Color.White;
            dashboardBtn.Location = new Point(996, 19);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(132, 36);
            dashboardBtn.TabIndex = 6;
            dashboardBtn.Text = "Dashboard";
            // 
            // bookingsBtn
            // 
            bookingsBtn.AutoSize = true;
            bookingsBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookingsBtn.ForeColor = Color.White;
            bookingsBtn.Location = new Point(1188, 19);
            bookingsBtn.Name = "bookingsBtn";
            bookingsBtn.Size = new Size(105, 36);
            bookingsBtn.TabIndex = 7;
            bookingsBtn.Text = "Bookings";
            // 
            // guestsBtn
            // 
            guestsBtn.AutoSize = true;
            guestsBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guestsBtn.ForeColor = Color.White;
            guestsBtn.Location = new Point(1358, 19);
            guestsBtn.Name = "guestsBtn";
            guestsBtn.Size = new Size(83, 36);
            guestsBtn.TabIndex = 8;
            guestsBtn.Text = "Guests";
            // 
            // marketingBtn
            // 
            marketingBtn.AutoSize = true;
            marketingBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            marketingBtn.ForeColor = Color.White;
            marketingBtn.Location = new Point(1503, 19);
            marketingBtn.Name = "marketingBtn";
            marketingBtn.Size = new Size(114, 36);
            marketingBtn.TabIndex = 9;
            marketingBtn.Text = "Marketing";
            // 
            // supportBtn
            // 
            supportBtn.AutoSize = true;
            supportBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            supportBtn.ForeColor = Color.White;
            supportBtn.Location = new Point(1672, 20);
            supportBtn.Name = "supportBtn";
            supportBtn.Size = new Size(95, 36);
            supportBtn.TabIndex = 10;
            supportBtn.Text = "Support";
            // 
            // chevronDownBtn
            // 
            chevronDownBtn.BackColor = Color.FromArgb(40, 75, 83);
            chevronDownBtn.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            chevronDownBtn.IconColor = Color.White;
            chevronDownBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            chevronDownBtn.IconSize = 27;
            chevronDownBtn.Location = new Point(1825, 22);
            chevronDownBtn.Name = "chevronDownBtn";
            chevronDownBtn.Size = new Size(27, 33);
            chevronDownBtn.TabIndex = 2;
            chevronDownBtn.TabStop = false;
            // 
            // contentPanel
            // 
            contentPanel.AutoScroll = true;
            contentPanel.Controls.Add(userLbl);
            contentPanel.Controls.Add(bookingsPanel);
            contentPanel.Controls.Add(repeatGuestsPanel);
            contentPanel.Controls.Add(openTicketsPanel);
            contentPanel.Controls.Add(activeCampaignsPanel);
            contentPanel.Controls.Add(checkInsPanel);
            contentPanel.Controls.Add(checkOutPanel);
            contentPanel.Controls.Add(calendarPanel);
            contentPanel.Controls.Add(analyticsPanel);
            contentPanel.Controls.Add(welcomeLbl);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1924, 1049);
            contentPanel.TabIndex = 13;
            // 
            // analyticsPanel
            // 
            analyticsPanel.BackColor = Color.White;
            analyticsPanel.Location = new Point(75, 1345);
            analyticsPanel.Name = "analyticsPanel";
            analyticsPanel.Size = new Size(1772, 700);
            analyticsPanel.TabIndex = 14;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1924, 1049);
            Controls.Add(contentPanel);
            Controls.Add(topNavBar1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            bookingsPanel.ResumeLayout(false);
            bookingsPanel.PerformLayout();
            repeatGuestsPanel.ResumeLayout(false);
            repeatGuestsPanel.PerformLayout();
            openTicketsPanel.ResumeLayout(false);
            openTicketsPanel.PerformLayout();
            activeCampaignsPanel.ResumeLayout(false);
            activeCampaignsPanel.PerformLayout();
            checkInsPanel.ResumeLayout(false);
            checkInsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)checkInTable).EndInit();
            checkOutPanel.ResumeLayout(false);
            checkOutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)checkOutTable).EndInit();
            calendarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chevronDownBtn).EndInit();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource bindingSource1;
        private Label welcomeLbl;
        private Label userLbl;
        private Panel bookingsPanel;
        private Panel repeatGuestsPanel;
        private Panel openTicketsPanel;
        private Panel activeCampaignsPanel;
        private Label monthLbl;
        private Label repeatGuestsLbl;
        private Label openTicketsLbl;
        private Label activeCampaignsLbl;
        private Label bookingsVal;
        private Label repeatGuestsVal;
        private Label openTicketsVal;
        private Label activeCampaignsVal;
        private Panel checkInsPanel;
        private Label checkInsLbl;
        private Panel checkOutPanel;
        private Label checkOutsLbl;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Panel calendarPanel;
        private TopNavBar topNavBar1;
        private PictureBox pictureBox1;
        private Label crmLbl;
        private Label label1;
        private Label dashboardBtn;
        private Label bookingsBtn;
        private Label guestsBtn;
        private Label marketingBtn;
        private Label supportBtn;
        private FontAwesome.Sharp.IconPictureBox chevronDownBtn;
        private Panel contentPanel;
        private DataGridView checkInTable;
        private DataGridView checkOutTable;
        private DataGridViewTextBoxColumn guestName;
        private DataGridViewTextBoxColumn package;
        private DataGridViewTextBoxColumn pax;
        private DataGridViewTextBoxColumn arrivalDate;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn checkOutDate;
        private DataGridViewTextBoxColumn time;
        private Panel analyticsPanel;
    }
}