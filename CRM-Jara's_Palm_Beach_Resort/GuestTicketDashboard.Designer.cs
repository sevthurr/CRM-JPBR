namespace CRM_Jara_s_Palm_Beach_Resort
{
    partial class GuestTicketDashboard
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
            marketingLbl = new Label();
            ticketForm = new Panel();
            reviewTicketBtn = new Button();
            timestampDtp = new DateTimePicker();
            timestampLbl = new Label();
            deliverToTb = new TextBox();
            deliverToLbl = new Label();
            requestSubjectTb = new TextBox();
            requestSubjectLbl = new Label();
            remarksTb = new TextBox();
            remarksLbl = new Label();
            ticketTypeCbox = new ComboBox();
            guestNameTb = new TextBox();
            guestNameLbl = new Label();
            guestIdTb = new TextBox();
            guestIDLbl = new Label();
            ticketTypeLbl = new Label();
            infoLbl = new Label();
            createNewTicketLbl = new Label();
            panel1 = new Panel();
            label1 = new Label();
            crmLbl = new Label();
            pictureBox1 = new PictureBox();
            ticketForm.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // marketingLbl
            // 
            marketingLbl.AutoSize = true;
            marketingLbl.Font = new Font("Poppins", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            marketingLbl.Location = new Point(48, 113);
            marketingLbl.Name = "marketingLbl";
            marketingLbl.Size = new Size(326, 65);
            marketingLbl.TabIndex = 10;
            marketingLbl.Text = "Guest Helpdesk";
            // 
            // ticketForm
            // 
            ticketForm.BackColor = Color.White;
            ticketForm.BorderStyle = BorderStyle.FixedSingle;
            ticketForm.Controls.Add(reviewTicketBtn);
            ticketForm.Controls.Add(timestampDtp);
            ticketForm.Controls.Add(timestampLbl);
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
            ticketForm.Location = new Point(48, 218);
            ticketForm.Name = "ticketForm";
            ticketForm.Size = new Size(1792, 664);
            ticketForm.TabIndex = 11;
            // 
            // reviewTicketBtn
            // 
            reviewTicketBtn.BackColor = Color.FromArgb(82, 169, 181);
            reviewTicketBtn.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reviewTicketBtn.ForeColor = Color.Transparent;
            reviewTicketBtn.Location = new Point(57, 547);
            reviewTicketBtn.Name = "reviewTicketBtn";
            reviewTicketBtn.Size = new Size(214, 49);
            reviewTicketBtn.TabIndex = 22;
            reviewTicketBtn.Text = "Review Ticket";
            reviewTicketBtn.UseVisualStyleBackColor = false;
            // 
            // timestampDtp
            // 
            timestampDtp.CalendarForeColor = Color.FromArgb(40, 75, 83);
            timestampDtp.CalendarMonthBackground = SystemColors.ControlLight;
            timestampDtp.CalendarTitleForeColor = Color.FromArgb(40, 75, 83);
            timestampDtp.Font = new Font("Poppins", 10.8F);
            timestampDtp.Location = new Point(1121, 416);
            timestampDtp.MinDate = new DateTime(2025, 9, 13, 0, 0, 0, 0);
            timestampDtp.Name = "timestampDtp";
            timestampDtp.Size = new Size(354, 34);
            timestampDtp.TabIndex = 40;
            // 
            // timestampLbl
            // 
            timestampLbl.AutoSize = true;
            timestampLbl.Font = new Font("Poppins", 10.8F);
            timestampLbl.ForeColor = Color.DimGray;
            timestampLbl.Location = new Point(1121, 372);
            timestampLbl.Name = "timestampLbl";
            timestampLbl.Size = new Size(247, 31);
            timestampLbl.TabIndex = 39;
            timestampLbl.Text = "Date and Time Submitted";
            // 
            // deliverToTb
            // 
            deliverToTb.BackColor = Color.White;
            deliverToTb.Font = new Font("Poppins", 10.8F);
            deliverToTb.ForeColor = Color.Black;
            deliverToTb.Location = new Point(57, 418);
            deliverToTb.Multiline = true;
            deliverToTb.Name = "deliverToTb";
            deliverToTb.PlaceholderText = "Enter Room or Area";
            deliverToTb.Size = new Size(249, 43);
            deliverToTb.TabIndex = 36;
            // 
            // deliverToLbl
            // 
            deliverToLbl.AutoSize = true;
            deliverToLbl.Font = new Font("Poppins", 10.8F);
            deliverToLbl.ForeColor = Color.DimGray;
            deliverToLbl.Location = new Point(57, 372);
            deliverToLbl.Name = "deliverToLbl";
            deliverToLbl.Size = new Size(101, 31);
            deliverToLbl.TabIndex = 35;
            deliverToLbl.Text = "Deliver To";
            // 
            // requestSubjectTb
            // 
            requestSubjectTb.BackColor = Color.White;
            requestSubjectTb.Font = new Font("Poppins", 10.8F);
            requestSubjectTb.ForeColor = Color.Black;
            requestSubjectTb.Location = new Point(1130, 249);
            requestSubjectTb.Multiline = true;
            requestSubjectTb.Name = "requestSubjectTb";
            requestSubjectTb.PlaceholderText = "Write request subject";
            requestSubjectTb.Size = new Size(345, 43);
            requestSubjectTb.TabIndex = 34;
            // 
            // requestSubjectLbl
            // 
            requestSubjectLbl.AutoSize = true;
            requestSubjectLbl.Font = new Font("Poppins", 10.8F);
            requestSubjectLbl.ForeColor = Color.DimGray;
            requestSubjectLbl.Location = new Point(1121, 203);
            requestSubjectLbl.Name = "requestSubjectLbl";
            requestSubjectLbl.Size = new Size(160, 31);
            requestSubjectLbl.TabIndex = 33;
            requestSubjectLbl.Text = "Request Subject";
            // 
            // remarksTb
            // 
            remarksTb.BackColor = Color.White;
            remarksTb.Font = new Font("Poppins", 10.8F);
            remarksTb.ForeColor = Color.Black;
            remarksTb.Location = new Point(394, 418);
            remarksTb.Multiline = true;
            remarksTb.Name = "remarksTb";
            remarksTb.PlaceholderText = "Enter Remarks";
            remarksTb.Size = new Size(613, 43);
            remarksTb.TabIndex = 32;
            // 
            // remarksLbl
            // 
            remarksLbl.AutoSize = true;
            remarksLbl.Font = new Font("Poppins", 10.8F);
            remarksLbl.ForeColor = Color.DimGray;
            remarksLbl.Location = new Point(394, 372);
            remarksLbl.Name = "remarksLbl";
            remarksLbl.Size = new Size(92, 31);
            remarksLbl.TabIndex = 31;
            remarksLbl.Text = "Remarks";
            // 
            // ticketTypeCbox
            // 
            ticketTypeCbox.BackColor = Color.White;
            ticketTypeCbox.FormattingEnabled = true;
            ticketTypeCbox.Items.AddRange(new object[] { "Equipment/Product Request", "Repairs", "Complaint" });
            ticketTypeCbox.Location = new Point(757, 253);
            ticketTypeCbox.Name = "ticketTypeCbox";
            ticketTypeCbox.Size = new Size(250, 28);
            ticketTypeCbox.TabIndex = 30;
            // 
            // guestNameTb
            // 
            guestNameTb.BackColor = Color.White;
            guestNameTb.Font = new Font("Poppins", 10.8F);
            guestNameTb.ForeColor = Color.Black;
            guestNameTb.Location = new Point(394, 249);
            guestNameTb.Multiline = true;
            guestNameTb.Name = "guestNameTb";
            guestNameTb.PlaceholderText = "Enter Guest Name";
            guestNameTb.Size = new Size(250, 43);
            guestNameTb.TabIndex = 29;
            // 
            // guestNameLbl
            // 
            guestNameLbl.AutoSize = true;
            guestNameLbl.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guestNameLbl.ForeColor = Color.DimGray;
            guestNameLbl.Location = new Point(394, 203);
            guestNameLbl.Name = "guestNameLbl";
            guestNameLbl.Size = new Size(131, 31);
            guestNameLbl.TabIndex = 28;
            guestNameLbl.Text = "Guest Name:";
            // 
            // guestIdTb
            // 
            guestIdTb.BackColor = Color.White;
            guestIdTb.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guestIdTb.ForeColor = Color.Black;
            guestIdTb.Location = new Point(56, 249);
            guestIdTb.Multiline = true;
            guestIdTb.Name = "guestIdTb";
            guestIdTb.PlaceholderText = "Enter Room ID";
            guestIdTb.Size = new Size(250, 43);
            guestIdTb.TabIndex = 27;
            // 
            // guestIDLbl
            // 
            guestIDLbl.AutoSize = true;
            guestIDLbl.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guestIDLbl.ForeColor = Color.DimGray;
            guestIDLbl.Location = new Point(47, 203);
            guestIDLbl.Name = "guestIDLbl";
            guestIDLbl.Size = new Size(94, 31);
            guestIDLbl.TabIndex = 14;
            guestIDLbl.Text = "Room ID:";
            // 
            // ticketTypeLbl
            // 
            ticketTypeLbl.AutoSize = true;
            ticketTypeLbl.Font = new Font("Poppins", 10.8F);
            ticketTypeLbl.ForeColor = Color.DimGray;
            ticketTypeLbl.Location = new Point(757, 203);
            ticketTypeLbl.Name = "ticketTypeLbl";
            ticketTypeLbl.Size = new Size(168, 31);
            ticketTypeLbl.TabIndex = 13;
            ticketTypeLbl.Text = "Select ticket type";
            ticketTypeLbl.Click += ticketTypeLbl_Click;
            // 
            // infoLbl
            // 
            infoLbl.AutoSize = true;
            infoLbl.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            infoLbl.ForeColor = Color.DimGray;
            infoLbl.Location = new Point(34, 88);
            infoLbl.Name = "infoLbl";
            infoLbl.Size = new Size(578, 31);
            infoLbl.TabIndex = 12;
            infoLbl.Text = "Fill up the information here then click the Review Ticket button.";
            // 
            // createNewTicketLbl
            // 
            createNewTicketLbl.AutoSize = true;
            createNewTicketLbl.Font = new Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createNewTicketLbl.Location = new Point(26, 29);
            createNewTicketLbl.Name = "createNewTicketLbl";
            createNewTicketLbl.Size = new Size(280, 50);
            createNewTicketLbl.TabIndex = 11;
            createNewTicketLbl.Text = "Create New Ticket";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 75, 83);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(crmLbl);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1915, 70);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Crimson Pro", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(126, 40);
            label1.Name = "label1";
            label1.Size = new Size(134, 17);
            label1.TabIndex = 40;
            label1.Text = "PALM BEACH RESORT";
            // 
            // crmLbl
            // 
            crmLbl.AutoSize = true;
            crmLbl.Font = new Font("Crimson Pro", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crmLbl.ForeColor = Color.White;
            crmLbl.Location = new Point(137, 11);
            crmLbl.Name = "crmLbl";
            crmLbl.Size = new Size(70, 26);
            crmLbl.TabIndex = 39;
            crmLbl.Text = "JARA'S";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._464643879_122123191316493608_5108633697996930672_n_removebg_preview__1_;
            pictureBox1.Location = new Point(48, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // GuestTicketDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1924, 964);
            Controls.Add(panel1);
            Controls.Add(ticketForm);
            Controls.Add(marketingLbl);
            Name = "GuestTicketDashboard";
            Text = "Guest Helpdesk";
            ticketForm.ResumeLayout(false);
            ticketForm.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label marketingLbl;
        private Panel ticketForm;
        private Button reviewTicketBtn;
        private DateTimePicker timestampDtp;
        private Label timestampLbl;
        private TextBox deliverToTb;
        private Label deliverToLbl;
        private TextBox requestSubjectTb;
        private Label requestSubjectLbl;
        private TextBox remarksTb;
        private Label remarksLbl;
        private ComboBox ticketTypeCbox;
        private TextBox guestNameTb;
        private Label guestNameLbl;
        private TextBox guestIdTb;
        private Label guestIDLbl;
        private Label ticketTypeLbl;
        private Label infoLbl;
        private Label createNewTicketLbl;
        private Panel panel1;
        private Label label1;
        private Label crmLbl;
        private PictureBox pictureBox1;
    }
}