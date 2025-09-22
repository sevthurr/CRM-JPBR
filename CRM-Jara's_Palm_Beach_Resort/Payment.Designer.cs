namespace CRM_Jara_s_Palm_Beach_Resort
{
    partial class Payment
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            paymentHisstoryLbl = new Label();
            paymentHistoryPanel = new Panel();
            paymentInfoPanel = new Panel();
            moneyIcon = new FontAwesome.Sharp.IconPictureBox();
            addPaymentBtn = new Button();
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
            paymentTable = new DataGridView();
            Amount = new DataGridViewTextBoxColumn();
            paymentID = new DataGridViewTextBoxColumn();
            Purpose = new DataGridViewTextBoxColumn();
            PaymentDate = new DataGridViewTextBoxColumn();
            paymentPanel = new Panel();
            paymentHistoryPanel.SuspendLayout();
            paymentInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)moneyIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paymentTable).BeginInit();
            paymentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // paymentHisstoryLbl
            // 
            paymentHisstoryLbl.AutoSize = true;
            paymentHisstoryLbl.Font = new Font("Crimson Pro", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paymentHisstoryLbl.ForeColor = Color.White;
            paymentHisstoryLbl.Location = new Point(282, 9);
            paymentHisstoryLbl.Name = "paymentHisstoryLbl";
            paymentHisstoryLbl.Size = new Size(215, 36);
            paymentHisstoryLbl.TabIndex = 1;
            paymentHisstoryLbl.Text = "Payment History";
            // 
            // paymentHistoryPanel
            // 
            paymentHistoryPanel.BackColor = Color.FromArgb(40, 75, 83);
            paymentHistoryPanel.Controls.Add(paymentHisstoryLbl);
            paymentHistoryPanel.Location = new Point(0, 0);
            paymentHistoryPanel.Name = "paymentHistoryPanel";
            paymentHistoryPanel.Size = new Size(811, 58);
            paymentHistoryPanel.TabIndex = 21;
            // 
            // paymentInfoPanel
            // 
            paymentInfoPanel.BackColor = Color.White;
            paymentInfoPanel.BorderStyle = BorderStyle.FixedSingle;
            paymentInfoPanel.Controls.Add(moneyIcon);
            paymentInfoPanel.Controls.Add(addPaymentBtn);
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
            paymentInfoPanel.Location = new Point(19, 418);
            paymentInfoPanel.Name = "paymentInfoPanel";
            paymentInfoPanel.Size = new Size(770, 238);
            paymentInfoPanel.TabIndex = 22;
            // 
            // moneyIcon
            // 
            moneyIcon.BackColor = Color.FromArgb(38, 176, 112);
            moneyIcon.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            moneyIcon.IconColor = Color.White;
            moneyIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            moneyIcon.IconSize = 22;
            moneyIcon.Location = new Point(557, 169);
            moneyIcon.Name = "moneyIcon";
            moneyIcon.Size = new Size(22, 23);
            moneyIcon.TabIndex = 36;
            moneyIcon.TabStop = false;
            // 
            // addPaymentBtn
            // 
            addPaymentBtn.BackColor = Color.FromArgb(38, 176, 112);
            addPaymentBtn.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addPaymentBtn.ForeColor = Color.Transparent;
            addPaymentBtn.Location = new Point(546, 161);
            addPaymentBtn.Name = "addPaymentBtn";
            addPaymentBtn.Size = new Size(157, 37);
            addPaymentBtn.TabIndex = 24;
            addPaymentBtn.Text = "    Add Payment";
            addPaymentBtn.UseVisualStyleBackColor = false;
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
            // paymentTable
            // 
            paymentTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 197, 149);
            paymentTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            paymentTable.BackgroundColor = Color.White;
            paymentTable.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            paymentTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            paymentTable.ColumnHeadersHeight = 29;
            paymentTable.Columns.AddRange(new DataGridViewColumn[] { Amount, paymentID, Purpose, PaymentDate });
            paymentTable.Location = new Point(0, 13);
            paymentTable.Name = "paymentTable";
            paymentTable.ReadOnly = true;
            paymentTable.RowHeadersWidth = 51;
            paymentTable.Size = new Size(770, 300);
            paymentTable.TabIndex = 0;
            paymentTable.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 125;
            // 
            // paymentID
            // 
            paymentID.HeaderText = "Payment ID";
            paymentID.MinimumWidth = 6;
            paymentID.Name = "paymentID";
            paymentID.ReadOnly = true;
            paymentID.Width = 125;
            // 
            // Purpose
            // 
            Purpose.HeaderText = "Purpose";
            Purpose.MinimumWidth = 6;
            Purpose.Name = "Purpose";
            Purpose.ReadOnly = true;
            Purpose.Width = 125;
            // 
            // PaymentDate
            // 
            PaymentDate.HeaderText = "Payment Date";
            PaymentDate.MinimumWidth = 6;
            PaymentDate.Name = "PaymentDate";
            PaymentDate.ReadOnly = true;
            PaymentDate.Width = 125;
            // 
            // paymentPanel
            // 
            paymentPanel.BackColor = Color.White;
            paymentPanel.Controls.Add(paymentTable);
            paymentPanel.Location = new Point(19, 79);
            paymentPanel.Name = "paymentPanel";
            paymentPanel.Size = new Size(770, 313);
            paymentPanel.TabIndex = 23;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(809, 692);
            Controls.Add(paymentPanel);
            Controls.Add(paymentInfoPanel);
            Controls.Add(paymentHistoryPanel);
            Name = "Payment";
            Text = "Payment History";
            Load += Payment_Load;
            paymentHistoryPanel.ResumeLayout(false);
            paymentHistoryPanel.PerformLayout();
            paymentInfoPanel.ResumeLayout(false);
            paymentInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)moneyIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)paymentTable).EndInit();
            paymentPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label paymentHisstoryLbl;
        private Panel paymentHistoryPanel;
        private Panel paymentInfoPanel;
        private ComboBox paymentMethodCb;
        private TextBox accountNumberTb;
        private TextBox accountNameTb;
        private TextBox amountTb;
        private Label amountLbl;
        private ComboBox purposeCb;
        private Label purposeLbl;
        private Label paymentMethodLbl;
        private Label accountNumberLbl;
        private Label accountNameLbl;
        private Label paymentInfoLbl;
        private Panel panel1;
        private Button addPaymentBtn;
        private DataGridView paymentTable;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn paymentID;
        private DataGridViewTextBoxColumn Purpose;
        private DataGridViewTextBoxColumn PaymentDate;
        private Panel paymentPanel;
        private FontAwesome.Sharp.IconPictureBox moneyIcon;
    }
}