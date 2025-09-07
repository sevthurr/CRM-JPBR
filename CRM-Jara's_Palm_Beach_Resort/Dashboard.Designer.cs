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
            panel1 = new Panel();
            chevronDownBtn = new FontAwesome.Sharp.IconPictureBox();
            supportBtn = new Label();
            marketingBtn = new Label();
            guestsBtn = new Label();
            bookingsBtn = new Label();
            dashboardBtn = new Label();
            label1 = new Label();
            crmLbl = new Label();
            pictureBox1 = new PictureBox();
            bindingSource1 = new BindingSource(components);
            welcomeLbl = new Label();
            userLbl = new Label();
            bookingsPanel = new Panel();
            bookingsVal = new Label();
            monthLbl = new Label();
            TotalBookingsLbl = new Label();
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
            checkInsTable = new TableLayoutPanel();
            checkInsLbl = new Label();
            panel3 = new Panel();
            checkOutsTable = new TableLayoutPanel();
            checkOutsLbl = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chevronDownBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            bookingsPanel.SuspendLayout();
            repeatGuestsPanel.SuspendLayout();
            openTicketsPanel.SuspendLayout();
            activeCampaignsPanel.SuspendLayout();
            checkInsPanel.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 75, 83);
            panel1.Controls.Add(chevronDownBtn);
            panel1.Controls.Add(supportBtn);
            panel1.Controls.Add(marketingBtn);
            panel1.Controls.Add(guestsBtn);
            panel1.Controls.Add(bookingsBtn);
            panel1.Controls.Add(dashboardBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(crmLbl);
            panel1.Controls.Add(pictureBox1);
            panel1.ForeColor = Color.Coral;
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1908, 63);
            panel1.TabIndex = 0;
            // 
            // chevronDownBtn
            // 
            chevronDownBtn.BackColor = Color.FromArgb(40, 75, 83);
            chevronDownBtn.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            chevronDownBtn.IconColor = Color.White;
            chevronDownBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            chevronDownBtn.IconSize = 27;
            chevronDownBtn.Location = new Point(1805, 19);
            chevronDownBtn.Name = "chevronDownBtn";
            chevronDownBtn.Size = new Size(27, 33);
            chevronDownBtn.TabIndex = 2;
            chevronDownBtn.TabStop = false;
            chevronDownBtn.Click += iconPictureBox1_Click;
            // 
            // supportBtn
            // 
            supportBtn.AutoSize = true;
            supportBtn.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            supportBtn.ForeColor = Color.White;
            supportBtn.Location = new Point(1673, 19);
            supportBtn.Name = "supportBtn";
            supportBtn.Size = new Size(79, 30);
            supportBtn.TabIndex = 10;
            supportBtn.Text = "Support";
            // 
            // marketingBtn
            // 
            marketingBtn.AutoSize = true;
            marketingBtn.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            marketingBtn.ForeColor = Color.White;
            marketingBtn.Location = new Point(1524, 19);
            marketingBtn.Name = "marketingBtn";
            marketingBtn.Size = new Size(97, 30);
            marketingBtn.TabIndex = 9;
            marketingBtn.Text = "Marketing";
            // 
            // guestsBtn
            // 
            guestsBtn.AutoSize = true;
            guestsBtn.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guestsBtn.ForeColor = Color.White;
            guestsBtn.Location = new Point(1395, 19);
            guestsBtn.Name = "guestsBtn";
            guestsBtn.Size = new Size(72, 30);
            guestsBtn.TabIndex = 8;
            guestsBtn.Text = "Guests";
            // 
            // bookingsBtn
            // 
            bookingsBtn.AutoSize = true;
            bookingsBtn.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookingsBtn.ForeColor = Color.White;
            bookingsBtn.Location = new Point(1245, 20);
            bookingsBtn.Name = "bookingsBtn";
            bookingsBtn.Size = new Size(89, 30);
            bookingsBtn.TabIndex = 7;
            bookingsBtn.Text = "Bookings";
            // 
            // dashboardBtn
            // 
            dashboardBtn.AutoSize = true;
            dashboardBtn.Font = new Font("Poppins", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            dashboardBtn.ForeColor = Color.White;
            dashboardBtn.Location = new Point(1079, 22);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(111, 30);
            dashboardBtn.TabIndex = 6;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.Click += dashboardBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Crimson Pro", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(106, 35);
            label1.Name = "label1";
            label1.Size = new Size(134, 17);
            label1.TabIndex = 5;
            label1.Text = "PALM BEACH RESORT";
            // 
            // crmLbl
            // 
            crmLbl.AutoSize = true;
            crmLbl.Font = new Font("Crimson Pro", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crmLbl.ForeColor = Color.White;
            crmLbl.Location = new Point(116, 3);
            crmLbl.Name = "crmLbl";
            crmLbl.Size = new Size(70, 26);
            crmLbl.TabIndex = 4;
            crmLbl.Text = "JARA'S";
            crmLbl.Click += crmLbl_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._464643879_122123191316493608_5108633697996930672_n_removebg_preview__1_;
            pictureBox1.Location = new Point(31, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // welcomeLbl
            // 
            welcomeLbl.AutoSize = true;
            welcomeLbl.Font = new Font("Poppins", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLbl.Location = new Point(111, 88);
            welcomeLbl.Name = "welcomeLbl";
            welcomeLbl.Size = new Size(209, 60);
            welcomeLbl.TabIndex = 2;
            welcomeLbl.Text = "Welcome, ";
            // 
            // userLbl
            // 
            userLbl.AutoSize = true;
            userLbl.Font = new Font("Poppins", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userLbl.Location = new Point(301, 88);
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
            bookingsPanel.Controls.Add(TotalBookingsLbl);
            bookingsPanel.Location = new Point(111, 161);
            bookingsPanel.Name = "bookingsPanel";
            bookingsPanel.Size = new Size(395, 86);
            bookingsPanel.TabIndex = 4;
            // 
            // bookingsVal
            // 
            bookingsVal.AutoSize = true;
            bookingsVal.Font = new Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookingsVal.Location = new Point(20, 34);
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
            monthLbl.Location = new Point(129, 10);
            monthLbl.Name = "monthLbl";
            monthLbl.Size = new Size(96, 26);
            monthLbl.TabIndex = 9;
            monthLbl.Text = "September";
            monthLbl.Click += label8_Click;
            // 
            // TotalBookingsLbl
            // 
            TotalBookingsLbl.AutoSize = true;
            TotalBookingsLbl.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalBookingsLbl.ForeColor = SystemColors.ControlDarkDark;
            TotalBookingsLbl.Location = new Point(12, 11);
            TotalBookingsLbl.Name = "TotalBookingsLbl";
            TotalBookingsLbl.Size = new Size(147, 26);
            TotalBookingsLbl.TabIndex = 8;
            TotalBookingsLbl.Text = "Total Bookings for";
            // 
            // repeatGuestsPanel
            // 
            repeatGuestsPanel.BackColor = Color.White;
            repeatGuestsPanel.Controls.Add(repeatGuestsVal);
            repeatGuestsPanel.Controls.Add(repeatGuestsLbl);
            repeatGuestsPanel.Location = new Point(540, 161);
            repeatGuestsPanel.Name = "repeatGuestsPanel";
            repeatGuestsPanel.Size = new Size(395, 86);
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
            openTicketsPanel.Location = new Point(976, 161);
            openTicketsPanel.Name = "openTicketsPanel";
            openTicketsPanel.Size = new Size(395, 86);
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
            activeCampaignsPanel.Location = new Point(1411, 161);
            activeCampaignsPanel.Name = "activeCampaignsPanel";
            activeCampaignsPanel.Size = new Size(395, 86);
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
            checkInsPanel.Controls.Add(checkInsTable);
            checkInsPanel.Controls.Add(checkInsLbl);
            checkInsPanel.Location = new Point(111, 291);
            checkInsPanel.Name = "checkInsPanel";
            checkInsPanel.Size = new Size(824, 389);
            checkInsPanel.TabIndex = 8;
            checkInsPanel.Paint += panel2_Paint;
            // 
            // checkInsTable
            // 
            checkInsTable.AutoScroll = true;
            checkInsTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            checkInsTable.ColumnCount = 5;
            checkInsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.87454F));
            checkInsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.12546F));
            checkInsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 115F));
            checkInsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 116F));
            checkInsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            checkInsTable.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkInsTable.Location = new Point(29, 54);
            checkInsTable.Name = "checkInsTable";
            checkInsTable.RowCount = 6;
            checkInsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            checkInsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            checkInsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            checkInsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            checkInsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            checkInsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            checkInsTable.Size = new Size(756, 298);
            checkInsTable.TabIndex = 11;
            checkInsTable.Paint += tableLayoutPanel2_Paint;
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
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(checkOutsTable);
            panel3.Controls.Add(checkOutsLbl);
            panel3.Location = new Point(976, 291);
            panel3.Name = "panel3";
            panel3.Size = new Size(830, 389);
            panel3.TabIndex = 9;
            // 
            // checkOutsTable
            // 
            checkOutsTable.AutoScroll = true;
            checkOutsTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            checkOutsTable.ColumnCount = 5;
            checkOutsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.87454F));
            checkOutsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.12546F));
            checkOutsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 115F));
            checkOutsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 116F));
            checkOutsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            checkOutsTable.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkOutsTable.Location = new Point(33, 54);
            checkOutsTable.Name = "checkOutsTable";
            checkOutsTable.RowCount = 6;
            checkOutsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            checkOutsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            checkOutsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            checkOutsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            checkOutsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            checkOutsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            checkOutsTable.Size = new Size(762, 298);
            checkOutsTable.TabIndex = 12;
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
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(111, 723);
            panel2.Name = "panel2";
            panel2.Size = new Size(1678, 1000);
            panel2.TabIndex = 10;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(checkInsPanel);
            Controls.Add(activeCampaignsPanel);
            Controls.Add(openTicketsPanel);
            Controls.Add(repeatGuestsPanel);
            Controls.Add(bookingsPanel);
            Controls.Add(userLbl);
            Controls.Add(welcomeLbl);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chevronDownBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label crmLbl;
        private Label label1;
        private Label bookingsBtn;
        private Label dashboardBtn;
        private Label supportBtn;
        private Label marketingBtn;
        private Label guestsBtn;
        private BindingSource bindingSource1;
        private FontAwesome.Sharp.IconPictureBox chevronDownBtn;
        private Label welcomeLbl;
        private Label userLbl;
        private Panel bookingsPanel;
        private Label TotalBookingsLbl;
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
        private TableLayoutPanel checkInsTable;
        private Label checkInsLbl;
        private Panel panel3;
        private TableLayoutPanel checkOutsTable;
        private Label checkOutsLbl;
        private Panel panel2;
    }
}