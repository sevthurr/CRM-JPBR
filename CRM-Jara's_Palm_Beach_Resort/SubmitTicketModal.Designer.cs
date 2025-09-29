namespace CRM_Jara_s_Palm_Beach_Resort
{
    partial class SubmitTicketModal
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
            ticketInfoPanel = new Panel();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            submitTicketBtn = new Button();
            timestampVal = new Label();
            deliverToVal = new Label();
            remarksVal = new Label();
            subjectVal = new Label();
            requestTypeVal = new Label();
            sentByVal = new Label();
            ticketIDVal = new Label();
            timestampInfoLbl = new Label();
            deliverToInfoLbl = new Label();
            remarksInfoLbl = new Label();
            subjectLbl = new Label();
            requestTypeInfoLbl = new Label();
            ticketIDLbl = new Label();
            sentByLbl = new Label();
            ticketInfoLbl = new Label();
            ticketInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ticketInfoPanel
            // 
            ticketInfoPanel.BackColor = Color.White;
            ticketInfoPanel.Controls.Add(iconPictureBox2);
            ticketInfoPanel.Controls.Add(submitTicketBtn);
            ticketInfoPanel.Controls.Add(timestampVal);
            ticketInfoPanel.Controls.Add(deliverToVal);
            ticketInfoPanel.Controls.Add(remarksVal);
            ticketInfoPanel.Controls.Add(subjectVal);
            ticketInfoPanel.Controls.Add(requestTypeVal);
            ticketInfoPanel.Controls.Add(sentByVal);
            ticketInfoPanel.Controls.Add(ticketIDVal);
            ticketInfoPanel.Controls.Add(timestampInfoLbl);
            ticketInfoPanel.Controls.Add(deliverToInfoLbl);
            ticketInfoPanel.Controls.Add(remarksInfoLbl);
            ticketInfoPanel.Controls.Add(subjectLbl);
            ticketInfoPanel.Controls.Add(requestTypeInfoLbl);
            ticketInfoPanel.Controls.Add(ticketIDLbl);
            ticketInfoPanel.Controls.Add(sentByLbl);
            ticketInfoPanel.Controls.Add(ticketInfoLbl);
            ticketInfoPanel.Location = new Point(0, 0);
            ticketInfoPanel.Name = "ticketInfoPanel";
            ticketInfoPanel.Size = new Size(581, 645);
            ticketInfoPanel.TabIndex = 47;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.AccessibleRole = AccessibleRole.None;
            iconPictureBox2.BackColor = Color.FromArgb(38, 176, 112);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Check;
            iconPictureBox2.IconColor = Color.White;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 25;
            iconPictureBox2.Location = new Point(225, 571);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(25, 25);
            iconPictureBox2.TabIndex = 44;
            iconPictureBox2.TabStop = false;
            iconPictureBox2.Click += iconPictureBox2_Click;
            // 
            // submitTicketBtn
            // 
            submitTicketBtn.BackColor = Color.FromArgb(38, 176, 112);
            submitTicketBtn.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submitTicketBtn.ForeColor = Color.White;
            submitTicketBtn.Location = new Point(206, 565);
            submitTicketBtn.Name = "submitTicketBtn";
            submitTicketBtn.Size = new Size(204, 37);
            submitTicketBtn.TabIndex = 19;
            submitTicketBtn.Text = "       Submit Ticket";
            submitTicketBtn.UseVisualStyleBackColor = false;
            // 
            // timestampVal
            // 
            timestampVal.AutoSize = true;
            timestampVal.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timestampVal.Location = new Point(233, 473);
            timestampVal.Name = "timestampVal";
            timestampVal.Size = new Size(173, 26);
            timestampVal.TabIndex = 18;
            timestampVal.Text = "mm/dd/yyy, 00:00 AM";
            // 
            // deliverToVal
            // 
            deliverToVal.AutoSize = true;
            deliverToVal.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliverToVal.Location = new Point(225, 415);
            deliverToVal.Name = "deliverToVal";
            deliverToVal.Size = new Size(104, 26);
            deliverToVal.TabIndex = 15;
            deliverToVal.Text = "Casa Keona";
            // 
            // remarksVal
            // 
            remarksVal.AutoSize = true;
            remarksVal.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            remarksVal.Location = new Point(226, 340);
            remarksVal.Name = "remarksVal";
            remarksVal.Size = new Size(282, 52);
            remarksVal.TabIndex = 14;
            remarksVal.Text = "Aircon not working. Very hot in here.\r\nPlease fix it right away.\r\n";
            // 
            // subjectVal
            // 
            subjectVal.AutoSize = true;
            subjectVal.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subjectVal.Location = new Point(226, 284);
            subjectVal.Name = "subjectVal";
            subjectVal.Size = new Size(117, 26);
            subjectVal.TabIndex = 13;
            subjectVal.Text = "Broken Aircon";
            // 
            // requestTypeVal
            // 
            requestTypeVal.AutoSize = true;
            requestTypeVal.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            requestTypeVal.Location = new Point(226, 228);
            requestTypeVal.Name = "requestTypeVal";
            requestTypeVal.Size = new Size(68, 26);
            requestTypeVal.TabIndex = 12;
            requestTypeVal.Text = "Repairs";
            // 
            // sentByVal
            // 
            sentByVal.AutoSize = true;
            sentByVal.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sentByVal.Location = new Point(225, 172);
            sentByVal.Name = "sentByVal";
            sentByVal.Size = new Size(105, 26);
            sentByVal.TabIndex = 11;
            sentByVal.Text = "Guest Name";
            // 
            // ticketIDVal
            // 
            ticketIDVal.AutoSize = true;
            ticketIDVal.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ticketIDVal.Location = new Point(226, 116);
            ticketIDVal.Name = "ticketIDVal";
            ticketIDVal.Size = new Size(43, 26);
            ticketIDVal.TabIndex = 10;
            ticketIDVal.Text = "T001";
            // 
            // timestampInfoLbl
            // 
            timestampInfoLbl.AutoSize = true;
            timestampInfoLbl.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timestampInfoLbl.Location = new Point(84, 473);
            timestampInfoLbl.Name = "timestampInfoLbl";
            timestampInfoLbl.Size = new Size(104, 26);
            timestampInfoLbl.TabIndex = 8;
            timestampInfoLbl.Text = "Timestamp:";
            // 
            // deliverToInfoLbl
            // 
            deliverToInfoLbl.AutoSize = true;
            deliverToInfoLbl.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliverToInfoLbl.Location = new Point(84, 415);
            deliverToInfoLbl.Name = "deliverToInfoLbl";
            deliverToInfoLbl.Size = new Size(90, 26);
            deliverToInfoLbl.TabIndex = 6;
            deliverToInfoLbl.Text = "Deliver To:";
            // 
            // remarksInfoLbl
            // 
            remarksInfoLbl.AutoSize = true;
            remarksInfoLbl.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remarksInfoLbl.Location = new Point(83, 340);
            remarksInfoLbl.Name = "remarksInfoLbl";
            remarksInfoLbl.Size = new Size(84, 26);
            remarksInfoLbl.TabIndex = 5;
            remarksInfoLbl.Text = "Remarks:";
            // 
            // subjectLbl
            // 
            subjectLbl.AutoSize = true;
            subjectLbl.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subjectLbl.Location = new Point(83, 284);
            subjectLbl.Name = "subjectLbl";
            subjectLbl.Size = new Size(73, 26);
            subjectLbl.TabIndex = 4;
            subjectLbl.Text = "Subject:";
            // 
            // requestTypeInfoLbl
            // 
            requestTypeInfoLbl.AutoSize = true;
            requestTypeInfoLbl.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            requestTypeInfoLbl.Location = new Point(83, 228);
            requestTypeInfoLbl.Name = "requestTypeInfoLbl";
            requestTypeInfoLbl.Size = new Size(118, 26);
            requestTypeInfoLbl.TabIndex = 3;
            requestTypeInfoLbl.Text = "Request Type:";
            // 
            // ticketIDLbl
            // 
            ticketIDLbl.AutoSize = true;
            ticketIDLbl.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ticketIDLbl.Location = new Point(83, 116);
            ticketIDLbl.Name = "ticketIDLbl";
            ticketIDLbl.Size = new Size(80, 26);
            ticketIDLbl.TabIndex = 2;
            ticketIDLbl.Text = "Ticket ID:";
            // 
            // sentByLbl
            // 
            sentByLbl.AutoSize = true;
            sentByLbl.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sentByLbl.Location = new Point(83, 172);
            sentByLbl.Name = "sentByLbl";
            sentByLbl.Size = new Size(72, 26);
            sentByLbl.TabIndex = 1;
            sentByLbl.Text = "Sent By:";
            // 
            // ticketInfoLbl
            // 
            ticketInfoLbl.AutoSize = true;
            ticketInfoLbl.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ticketInfoLbl.Location = new Point(206, 40);
            ticketInfoLbl.Name = "ticketInfoLbl";
            ticketInfoLbl.Size = new Size(204, 36);
            ticketInfoLbl.TabIndex = 0;
            ticketInfoLbl.Text = "Ticket Information";
            // 
            // SubmitTicketModal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 643);
            Controls.Add(ticketInfoPanel);
            Name = "SubmitTicketModal";
            Text = "Submit Ticket";
            ticketInfoPanel.ResumeLayout(false);
            ticketInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ticketInfoPanel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Button submitTicketBtn;
        private Label timestampVal;
        private Label deliverToVal;
        private Label remarksVal;
        private Label subjectVal;
        private Label requestTypeVal;
        private Label sentByVal;
        private Label ticketIDVal;
        private Label timestampInfoLbl;
        private Label deliverToInfoLbl;
        private Label remarksInfoLbl;
        private Label subjectLbl;
        private Label requestTypeInfoLbl;
        private Label ticketIDLbl;
        private Label sentByLbl;
        private Label ticketInfoLbl;
    }
}