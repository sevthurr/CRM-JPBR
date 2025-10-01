using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Jara_s_Palm_Beach_Resort
{
    public partial class Marketing : Form
    {

        private AccountManager accountManager = new AccountManager();

        public Marketing()
        {
            InitializeComponent();
            topNavBar1.SetActive("Marketing");
            topNavBar1.Dock = DockStyle.Top;
            newCampaignBtn.Click += newCampaignBtn_Click;
            viewDetailsBtn.Click += ViewDetailsBtn_Click;

            // Clear the static campaign card
            campaignCardsPanel.Controls.Clear();

            // Load dynamic campaigns
            LoadCampaigns();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            var dashboardForm = new Dashboard();
            dashboardForm.WindowState = FormWindowState.Maximized;
            dashboardForm.Show();
            this.Hide();
        }

        private void bookingsBtn_Click(object sender, EventArgs e)
        {
            var bookingForm = new BookingManagement();
            bookingForm.WindowState = FormWindowState.Maximized;
            bookingForm.Show();
            this.Hide();
        }

        private void guestsBtn_Click(object sender, EventArgs e)
        {
            var guestsForm = new ContactManagement();
            guestsForm.WindowState = FormWindowState.Maximized;
            guestsForm.Show();
            this.Hide();
        }

        private void marketingBtn_Click(object sender, EventArgs e)
        {
            var marketingForm = new Marketing();
            marketingForm.WindowState = FormWindowState.Maximized;
            marketingForm.Show();
            this.Hide();
        }

        private void supportBtn_Click(object sender, EventArgs e)
        {
            var supportForm = new Support();
            supportForm.WindowState = FormWindowState.Maximized;
            supportForm.Show();
            this.Hide();
        }

        private void newCampaignBtn_Click(object sender, EventArgs e)
        {
            using (var modal = new NewCampaign())
            {
                modal.StartPosition = FormStartPosition.CenterParent;
                modal.FormBorderStyle = FormBorderStyle.FixedDialog;
                modal.ShowInTaskbar = false;
                modal.MaximizeBox = false;
                modal.MinimizeBox = true;
                var result = modal.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    LoadCampaigns(); // Refresh after successful creation
                }
            }
        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadCampaigns()
        {
            campaignCardsPanel.Controls.Clear();

            var campaigns = accountManager.GetCampaigns();

            // Update status counts
            activeVal.Text = $"({campaigns.Count(c => c.Status == "Active").ToString()})";
            completedVal.Text = $"({campaigns.Count(c => c.Status == "Completed").ToString()})";
            draftVal.Text = $"({campaigns.Count(c => c.Status == "Draft").ToString()})";

            int yPosition = 3; // Starting Y position
            int cardHeight = 210; // Card height + margin (204 height + 6 margin)

            foreach (var campaign in campaigns)
            {
                var card = CreateCampaignCard(campaign, yPosition);
                campaignCardsPanel.Controls.Add(card);
                yPosition += cardHeight; // Move down for next card
            }
        }

        private Panel CreateCampaignCard(CampaignData data, int yPosition)
        {
            // Main campaign card panel
            Panel campaignCard = new Panel();
            campaignCard.SuspendLayout();
            campaignCard.BackColor = Color.White;
            campaignCard.BorderStyle = BorderStyle.FixedSingle;
            campaignCard.Location = new Point(24, yPosition);
            campaignCard.Name = $"campaignCard_{data.CampaignID}";
            campaignCard.Size = new Size(1751, 204);
            campaignCard.TabIndex = 0;

            // fireIcon
            FontAwesome.Sharp.IconPictureBox fireIcon = new FontAwesome.Sharp.IconPictureBox();
            fireIcon.AccessibleRole = AccessibleRole.None;
            fireIcon.BackColor = Color.Transparent;
            fireIcon.ForeColor = Color.FromArgb(235, 197, 149);
            fireIcon.IconChar = FontAwesome.Sharp.IconChar.Fire;
            fireIcon.IconColor = Color.FromArgb(235, 197, 149);
            fireIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            fireIcon.IconSize = 47;
            fireIcon.Location = new Point(54, 35);
            fireIcon.Name = "fireIcon";
            fireIcon.Size = new Size(51, 47);
            fireIcon.TabIndex = 43;
            fireIcon.TabStop = false;
            campaignCard.Controls.Add(fireIcon);

            // promoHeadline
            Label promoHeadline = new Label();
            promoHeadline.AutoSize = true;
            promoHeadline.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            promoHeadline.Location = new Point(111, 35);
            promoHeadline.Name = "promoHeadline";
            promoHeadline.Size = new Size(187, 36);
            promoHeadline.TabIndex = 6;
            promoHeadline.Text = data.Headline;
            if (!string.IsNullOrEmpty(data.PromoCode))
            {
                promoHeadline.Text += $" ({data.PromoCode})";
            }
            campaignCard.Controls.Add(promoHeadline);

            // startCampaignDate
            Label startCampaignDate = new Label();
            startCampaignDate.AutoSize = true;
            startCampaignDate.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startCampaignDate.ForeColor = SystemColors.ControlDarkDark;
            startCampaignDate.Location = new Point(114, 12);
            startCampaignDate.Name = "startCampaignDate";
            startCampaignDate.Size = new Size(79, 23);
            startCampaignDate.TabIndex = 6;
            startCampaignDate.Text = data.StartDate.ToString("MM/dd/yyyy");
            campaignCard.Controls.Add(startCampaignDate);

            // campaignMessage
            Label campaignMessage = new Label();
            campaignMessage.AutoSize = true;
            campaignMessage.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            campaignMessage.ForeColor = SystemColors.ControlDarkDark;
            campaignMessage.Location = new Point(114, 68);
            campaignMessage.Name = "campaignMessage";
            campaignMessage.Size = new Size(948, 23);
            campaignMessage.TabIndex = 6;
            campaignMessage.Text = data.EmailMessage.Length > 120 ? data.EmailMessage.Substring(0, 120) + "..." : data.EmailMessage;
            campaignCard.Controls.Add(campaignMessage);

            // tagPanel
            Panel tagPanel = new Panel();
            tagPanel.BorderStyle = BorderStyle.FixedSingle;
            tagPanel.Location = new Point(523, 113);
            tagPanel.Name = "tagPanel";
            tagPanel.Size = new Size(355, 68);
            tagPanel.TabIndex = 44;
            campaignCard.Controls.Add(tagPanel);

            // peopleIcon
            FontAwesome.Sharp.IconPictureBox peopleIcon = new FontAwesome.Sharp.IconPictureBox();
            peopleIcon.AccessibleRole = AccessibleRole.None;
            peopleIcon.BackColor = Color.Transparent;
            peopleIcon.ForeColor = Color.Teal;
            peopleIcon.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            peopleIcon.IconColor = Color.Teal;
            peopleIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            peopleIcon.IconSize = 40;
            peopleIcon.Location = new Point(37, 13);
            peopleIcon.Name = "peopleIcon";
            peopleIcon.Size = new Size(40, 40);
            peopleIcon.TabIndex = 44;
            peopleIcon.TabStop = false;
            tagPanel.Controls.Add(peopleIcon);

            // tagVal
            Label tagVal = new Label();
            tagVal.AutoSize = true;
            tagVal.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tagVal.Location = new Point(86, 12);
            tagVal.Name = "tagVal";
            tagVal.Size = new Size(73, 30);
            tagVal.TabIndex = 6;
            tagVal.Text = data.Tag;
            tagPanel.Controls.Add(tagVal);

            // tagLbl
            Label tagLbl = new Label();
            tagLbl.AutoSize = true;
            tagLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tagLbl.ForeColor = SystemColors.ControlDarkDark;
            tagLbl.Location = new Point(177, 37);
            tagLbl.Name = "tagLbl";
            tagLbl.Size = new Size(35, 23);
            tagLbl.TabIndex = 47;
            tagLbl.Text = "Tag";
            tagPanel.Controls.Add(tagLbl);

            // campaignTypePanel
            Panel campaignTypePanel = new Panel();
            campaignTypePanel.BorderStyle = BorderStyle.FixedSingle;
            campaignTypePanel.Location = new Point(932, 113);
            campaignTypePanel.Name = "campaignTypePanel";
            campaignTypePanel.Size = new Size(355, 68);
            campaignTypePanel.TabIndex = 46;
            campaignCard.Controls.Add(campaignTypePanel);

            // handHeartIcon
            FontAwesome.Sharp.IconPictureBox handHeartIcon = new FontAwesome.Sharp.IconPictureBox();
            handHeartIcon.AccessibleRole = AccessibleRole.None;
            handHeartIcon.BackColor = Color.Transparent;
            handHeartIcon.ForeColor = Color.FromArgb(255, 173, 70);
            handHeartIcon.IconChar = FontAwesome.Sharp.IconChar.HandHoldingHeart;
            handHeartIcon.IconColor = Color.FromArgb(255, 173, 70);
            handHeartIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            handHeartIcon.IconSize = 40;
            handHeartIcon.Location = new Point(68, 14);
            handHeartIcon.Name = "handHeartIcon";
            handHeartIcon.Size = new Size(40, 40);
            handHeartIcon.TabIndex = 44;
            handHeartIcon.TabStop = false;
            campaignTypePanel.Controls.Add(handHeartIcon);

            // campaignTypeVal
            Label campaignTypeVal = new Label();
            campaignTypeVal.AutoSize = true;
            campaignTypeVal.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            campaignTypeVal.Location = new Point(134, 11);
            campaignTypeVal.Name = "campaignTypeVal";
            campaignTypeVal.Size = new Size(139, 30);
            campaignTypeVal.TabIndex = 48;
            campaignTypeVal.Text = data.Type;
            campaignTypeVal.TextAlign = ContentAlignment.TopCenter;
            campaignTypePanel.Controls.Add(campaignTypeVal);

            // campaignTypeLbl
            Label campaignTypeLbl = new Label();
            campaignTypeLbl.AutoSize = true;
            campaignTypeLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            campaignTypeLbl.ForeColor = SystemColors.ControlDarkDark;
            campaignTypeLbl.Location = new Point(142, 35);
            campaignTypeLbl.Name = "campaignTypeLbl";
            campaignTypeLbl.Size = new Size(114, 23);
            campaignTypeLbl.TabIndex = 48;
            campaignTypeLbl.Text = "Campaign Type";
            campaignTypePanel.Controls.Add(campaignTypeLbl);

            // deliveredPanel
            Panel deliveredPanel = new Panel();
            deliveredPanel.BorderStyle = BorderStyle.FixedSingle;
            deliveredPanel.Location = new Point(114, 113);
            deliveredPanel.Name = "deliveredPanel";
            deliveredPanel.Size = new Size(355, 68);
            deliveredPanel.TabIndex = 48;
            campaignCard.Controls.Add(deliveredPanel);

            // messageCheckIcon
            FontAwesome.Sharp.IconPictureBox messageCheckIcon = new FontAwesome.Sharp.IconPictureBox();
            messageCheckIcon.AccessibleRole = AccessibleRole.None;
            messageCheckIcon.BackColor = Color.Transparent;
            messageCheckIcon.ForeColor = Color.FromArgb(38, 176, 112);
            messageCheckIcon.IconChar = FontAwesome.Sharp.IconChar.EnvelopeCircleCheck;
            messageCheckIcon.IconColor = Color.FromArgb(38, 176, 112);
            messageCheckIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            messageCheckIcon.IconSize = 40;
            messageCheckIcon.Location = new Point(91, 13);
            messageCheckIcon.Name = "messageCheckIcon";
            messageCheckIcon.Size = new Size(40, 40);
            messageCheckIcon.TabIndex = 44;
            messageCheckIcon.TabStop = false;
            deliveredPanel.Controls.Add(messageCheckIcon);

            // deliveredVal
            Label deliveredVal = new Label();
            deliveredVal.AutoSize = true;
            deliveredVal.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliveredVal.Location = new Point(171, 12);
            deliveredVal.Name = "deliveredVal";
            deliveredVal.Size = new Size(23, 30);
            deliveredVal.TabIndex = 6;
            deliveredVal.Text = $"{data.Delivered}";
            deliveredPanel.Controls.Add(deliveredVal);

            // deliveredLbl
            Label deliveredLbl = new Label();
            deliveredLbl.AutoSize = true;
            deliveredLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveredLbl.ForeColor = SystemColors.ControlDarkDark;
            deliveredLbl.Location = new Point(150, 37);
            deliveredLbl.Name = "deliveredLbl";
            deliveredLbl.Size = new Size(70, 23);
            deliveredLbl.TabIndex = 47;
            deliveredLbl.Text = "Delivered";
            deliveredPanel.Controls.Add(deliveredLbl);

            // endCampaignPanel
            Panel endCampaignPanel = new Panel();
            endCampaignPanel.BorderStyle = BorderStyle.FixedSingle;
            endCampaignPanel.Location = new Point(1341, 113);
            endCampaignPanel.Name = "endCampaignPanel";
            endCampaignPanel.Size = new Size(355, 68);
            endCampaignPanel.TabIndex = 49;
            campaignCard.Controls.Add(endCampaignPanel);

            // calendarCheckIcon
            FontAwesome.Sharp.IconPictureBox calendarCheckIcon = new FontAwesome.Sharp.IconPictureBox();
            calendarCheckIcon.AccessibleRole = AccessibleRole.None;
            calendarCheckIcon.BackColor = Color.Transparent;
            calendarCheckIcon.ForeColor = Color.Red;
            calendarCheckIcon.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            calendarCheckIcon.IconColor = Color.Red;
            calendarCheckIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            calendarCheckIcon.IconSize = 40;
            calendarCheckIcon.Location = new Point(75, 14);
            calendarCheckIcon.Name = "calendarCheckIcon";
            calendarCheckIcon.Size = new Size(40, 40);
            calendarCheckIcon.TabIndex = 44;
            calendarCheckIcon.TabStop = false;
            endCampaignPanel.Controls.Add(calendarCheckIcon);

            // endCampaignVal
            Label endCampaignVal = new Label();
            endCampaignVal.AutoSize = true;
            endCampaignVal.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            endCampaignVal.Location = new Point(141, 11);
            endCampaignVal.Name = "endCampaignVal";
            endCampaignVal.Size = new Size(133, 30);
            endCampaignVal.TabIndex = 48;
            endCampaignVal.Text = data.EndDate.ToString("MM/dd/yyyy");
            endCampaignVal.TextAlign = ContentAlignment.TopCenter;
            endCampaignPanel.Controls.Add(endCampaignVal);

            // endCampaignLbl
            Label endCampaignLbl = new Label();
            endCampaignLbl.AutoSize = true;
            endCampaignLbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endCampaignLbl.ForeColor = SystemColors.ControlDarkDark;
            endCampaignLbl.Location = new Point(135, 35);
            endCampaignLbl.Name = "endCampaignLbl";
            endCampaignLbl.Size = new Size(122, 23);
            endCampaignLbl.TabIndex = 48;
            endCampaignLbl.Text = "End of Campaign";
            endCampaignPanel.Controls.Add(endCampaignLbl);

            // runningStatus
            Label runningStatus = new Label();
            runningStatus.AutoSize = true;
            runningStatus.Font = new Font("Poppins", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);

            // Set status color based on campaign status
            if (data.Status == "Active")
            {
                runningStatus.ForeColor = Color.FromArgb(38, 176, 112);
                runningStatus.Text = "⦿  Running";
            }
            else if (data.Status == "Completed")
            {
                runningStatus.ForeColor = Color.Gray;
                runningStatus.Text = "⦿  Completed";
            }
            else // Draft
            {
                runningStatus.ForeColor = Color.Orange;
                runningStatus.Text = "⦿  Draft";
            }

            runningStatus.Location = new Point(1507, 22);
            runningStatus.Name = "runningStatus";
            runningStatus.Size = new Size(86, 23);
            runningStatus.TabIndex = 49;
            campaignCard.Controls.Add(runningStatus);

            // viewDetailsBtn
            LinkLabel viewDetailsBtn = new LinkLabel();
            viewDetailsBtn.AutoSize = true;
            viewDetailsBtn.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewDetailsBtn.LinkColor = Color.FromArgb(40, 75, 83);
            viewDetailsBtn.Location = new Point(1604, 22);
            viewDetailsBtn.Name = "viewDetailsBtn";
            viewDetailsBtn.Size = new Size(88, 23);
            viewDetailsBtn.TabIndex = 50;
            viewDetailsBtn.TabStop = true;
            viewDetailsBtn.Text = "View Details";
            viewDetailsBtn.VisitedLinkColor = Color.FromArgb(40, 75, 83);
            viewDetailsBtn.Tag = data.CampaignID;
            viewDetailsBtn.Click += ViewDetailsBtn_Click;
            campaignCard.Controls.Add(viewDetailsBtn);

            campaignCard.ResumeLayout(false);
            campaignCard.PerformLayout();

            return campaignCard;
        }

        private void ViewDetailsBtn_Click(object sender, EventArgs e)
        {
            LinkLabel btn = sender as LinkLabel;
            int campaignID = (int)btn.Tag;
            using (var modal = new CampaignInfo(campaignID)) // Assume CampaignInfo has constructor taking int ID
            {
                modal.StartPosition = FormStartPosition.CenterParent;
                modal.FormBorderStyle = FormBorderStyle.FixedDialog;
                modal.ShowInTaskbar = false;
                modal.MaximizeBox = false;
                modal.MinimizeBox = true;
                modal.ShowDialog(this);
            }
        }
    }
}
