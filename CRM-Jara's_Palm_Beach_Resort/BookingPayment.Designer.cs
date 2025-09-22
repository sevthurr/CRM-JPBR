namespace CRM_Jara_s_Palm_Beach_Resort
{
    partial class BookingPayment
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
            newBookingLbl = new Label();
            newBookingPanel = new Panel();
            paymentInfoPanel = new Panel();
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
            confirmBookingBtn = new Button();
            backBtn = new LinkLabel();
            newBookingPanel.SuspendLayout();
            paymentInfoPanel.SuspendLayout();
            summaryPanel.SuspendLayout();
            SuspendLayout();
            // 
            // newBookingLbl
            // 
            newBookingLbl.AutoSize = true;
            newBookingLbl.Font = new Font("Crimson Pro", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newBookingLbl.ForeColor = Color.White;
            newBookingLbl.Location = new Point(281, 14);
            newBookingLbl.Name = "newBookingLbl";
            newBookingLbl.Size = new Size(342, 38);
            newBookingLbl.TabIndex = 1;
            newBookingLbl.Text = "New Booking  >  Payment";
            // 
            // newBookingPanel
            // 
            newBookingPanel.BackColor = Color.FromArgb(40, 75, 83);
            newBookingPanel.Controls.Add(newBookingLbl);
            newBookingPanel.Location = new Point(0, 0);
            newBookingPanel.Name = "newBookingPanel";
            newBookingPanel.Size = new Size(900, 65);
            newBookingPanel.TabIndex = 21;
            // 
            // paymentInfoPanel
            // 
            paymentInfoPanel.BackColor = Color.White;
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
            paymentInfoPanel.Location = new Point(51, 378);
            paymentInfoPanel.Name = "paymentInfoPanel";
            paymentInfoPanel.Size = new Size(790, 245);
            paymentInfoPanel.TabIndex = 22;
            // 
            // paymentMethodCb
            // 
            paymentMethodCb.BackColor = Color.White;
            paymentMethodCb.FormattingEnabled = true;
            paymentMethodCb.Items.AddRange(new object[] { "Cash", "GCash", "BPI - Bank Transfer", "BDO - Bank Transfer" });
            paymentMethodCb.Location = new Point(28, 89);
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
            accountNumberTb.Location = new Point(305, 168);
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
            accountNameTb.Location = new Point(30, 167);
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
            amountTb.Location = new Point(518, 89);
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
            amountLbl.Location = new Point(518, 63);
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
            purposeCb.Location = new Point(305, 89);
            purposeCb.Name = "purposeCb";
            purposeCb.Size = new Size(179, 28);
            purposeCb.TabIndex = 9;
            // 
            // purposeLbl
            // 
            purposeLbl.AutoSize = true;
            purposeLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            purposeLbl.ForeColor = Color.DimGray;
            purposeLbl.Location = new Point(308, 63);
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
            paymentMethodLbl.Location = new Point(28, 63);
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
            accountNumberLbl.Location = new Point(305, 142);
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
            accountNameLbl.Location = new Point(30, 142);
            accountNameLbl.Name = "accountNameLbl";
            accountNameLbl.Size = new Size(106, 23);
            accountNameLbl.TabIndex = 3;
            accountNameLbl.Text = "Account Name";
            // 
            // paymentInfoLbl
            // 
            paymentInfoLbl.AutoSize = true;
            paymentInfoLbl.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paymentInfoLbl.ForeColor = Color.Black;
            paymentInfoLbl.Location = new Point(19, 17);
            paymentInfoLbl.Name = "paymentInfoLbl";
            paymentInfoLbl.Size = new Size(201, 30);
            paymentInfoLbl.TabIndex = 2;
            paymentInfoLbl.Text = "Payment Information";
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
            summaryPanel.Location = new Point(51, 111);
            summaryPanel.Name = "summaryPanel";
            summaryPanel.Size = new Size(790, 232);
            summaryPanel.TabIndex = 23;
            summaryPanel.Paint += panel1_Paint;
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
            // confirmBookingBtn
            // 
            confirmBookingBtn.BackColor = Color.FromArgb(82, 169, 181);
            confirmBookingBtn.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmBookingBtn.ForeColor = Color.Transparent;
            confirmBookingBtn.Location = new Point(627, 663);
            confirmBookingBtn.Name = "confirmBookingBtn";
            confirmBookingBtn.Size = new Size(198, 40);
            confirmBookingBtn.TabIndex = 24;
            confirmBookingBtn.Text = "Confirm Booking";
            confirmBookingBtn.UseVisualStyleBackColor = false;
            // 
            // backBtn
            // 
            backBtn.ActiveLinkColor = Color.FromArgb(40, 75, 83);
            backBtn.AutoSize = true;
            backBtn.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backBtn.LinkColor = Color.FromArgb(40, 75, 83);
            backBtn.Location = new Point(70, 673);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(74, 30);
            backBtn.TabIndex = 51;
            backBtn.TabStop = true;
            backBtn.Text = "<  Back";
            backBtn.VisitedLinkColor = Color.FromArgb(40, 75, 83);
            // 
            // BookingPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 738);
            Controls.Add(backBtn);
            Controls.Add(confirmBookingBtn);
            Controls.Add(summaryPanel);
            Controls.Add(paymentInfoPanel);
            Controls.Add(newBookingPanel);
            Name = "BookingPayment";
            Text = "Booking Payment";
            newBookingPanel.ResumeLayout(false);
            newBookingPanel.PerformLayout();
            paymentInfoPanel.ResumeLayout(false);
            paymentInfoPanel.PerformLayout();
            summaryPanel.ResumeLayout(false);
            summaryPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label newBookingLbl;
        private Panel newBookingPanel;
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
        private Panel summaryPanel;
        private Label packageVal;
        private Label packageLbl;
        private Label summaryLbl;
        private Label daysStayingLbl;
        private Label packageAmount;
        private Label totalAmountLbl;
        private Label excessPersonAmount;
        private Label excessPersonVal;
        private Label excessPersonLbl;
        private Label daysStayingAmount;
        private Label daysStayingVal;
        private Label totalAmountVal;
        private Label discountAmount;
        private Label discountPercentage;
        private Label promoDiscountLbl;
        private Button confirmBookingBtn;
        private LinkLabel backBtn;
    }
}